using System;
using System.Collections.Generic;
using System.IO;

namespace Day9
{
    public enum ExamMode
    {
        Starting,
        Queued,
        Finished
    }

    class Question : ICloneable, IComparable<Question>
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }

        public Question(string header, string body, int marks)
            : this(header, body, marks, false) { }

        public Question(string header, string body, int marks, bool isTrue)
        {
            Header = header;
            Body = body;
            Marks = marks;
        }

        public object Clone() => new Question(this.Header, this.Body, this.Marks);

        public int CompareTo(Question other) => this.Header.CompareTo(other.Header);

        public override string ToString() => $"Header: {Header}, Body: {Body}, Marks: {Marks}";

        public override bool Equals(object obj)
        {
            if (obj is Question other)
            {
                return this.Header == other.Header &&
                       this.Body == other.Body &&
                       this.Marks == other.Marks;
            }

            return false;
        }

        public override int GetHashCode() => HashCode.Combine(Header, Body, Marks);
    }

    class TrueFalseQuestion : Question
    {
        public bool IsTrue { get; set; }

        public TrueFalseQuestion(string header, string body, int marks, bool isTrue)
            : base(header, body, marks)
        {
            IsTrue = isTrue;
        }
    }

    class ChooseOneQuestion : Question
    {
        public List<string> Options { get; set; }

        public ChooseOneQuestion(string header, string body, int marks, List<string> options)
            : base(header, body, marks)
        {
            Options = options;
        }
    }

    class ChooseAllQuestion : Question
    {
        public List<string> Options { get; set; }

        public ChooseAllQuestion(string header, string body, int marks, List<string> options)
            : base(header, body, marks)
        {
            Options = options;
        }
    }

    class Exam
    {
        public DateTime ExamTime { get; set; }
        public int NumberOfQuestions { get; set; }
        public Dictionary<Question, string> QuestionAnswerDictionary { get; set; }
        public ExamMode Mode { get; set; }

        public event EventHandler<string> ExamStarting;

        public Exam(DateTime examTime, int numberOfQuestions)
        {
            ExamTime = examTime;
            NumberOfQuestions = numberOfQuestions;
            QuestionAnswerDictionary = new Dictionary<Question, string>();
            Mode = ExamMode.Starting;
        }

        public virtual void ShowExam()
        {
            Console.WriteLine($"Exam Time: {ExamTime}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine($"Exam Mode: {Mode}");
        }

        public void SaveToFile(string filePath)
        {
            try
            {
                using (TextWriter tw = new StreamWriter(filePath))
                {
                    tw.WriteLine($"Exam Time: {ExamTime}");
                    tw.WriteLine($"Number of Questions: {NumberOfQuestions}");

                    foreach (var kvp in QuestionAnswerDictionary)
                    {
                        tw.WriteLine($"Question: {kvp.Key.Header}");
                        tw.WriteLine($"Body: {kvp.Key.Body}");
                        tw.WriteLine($"Marks: {kvp.Key.Marks}");
                        tw.WriteLine($"Answer: {kvp.Value}");
                        tw.WriteLine();
                    }
                }

                Console.WriteLine($"Exam details saved to {filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving exam details: {ex.Message}");
            }
        }

        public void SetExamMode(ExamMode newMode)
        {
            Mode = newMode;
            if (newMode == ExamMode.Starting)
            {
                NotifyStudents();
            }
        }

        protected virtual void NotifyStudents()
        {
            ExamStarting?.Invoke(this, $"The exam is starting. Get ready!");
        }
    }

    class PracticeExam : Exam
    {
        public PracticeExam(DateTime examTime, int numberOfQuestions)
            : base(examTime, numberOfQuestions)
        {
            ExamStarting += (sender, message) =>
            {
                Console.WriteLine($"Practice Exam Notification: {message}");
            };
        }

        public override void ShowExam()
        {
            base.ShowExam();

            Console.WriteLine("Practice Exam - Showing Correct Answers:");
            foreach (var kvp in QuestionAnswerDictionary)
            {
                Console.WriteLine($"Question: {kvp.Key.Header}");
                Console.WriteLine($"Body: {kvp.Key.Body}");
                Console.WriteLine($"Marks: {kvp.Key.Marks}");
                Console.WriteLine($"Correct Answer: {kvp.Value}");
                Console.WriteLine();
            }
        }
    }

    class FinalExam : Exam
    {
        public FinalExam(DateTime examTime, int numberOfQuestions)
            : base(examTime, numberOfQuestions)
        {
            ExamStarting += (sender, message) =>
            {
                Console.WriteLine($"Final Exam Notification: {message}");
            };
        }

        public override void ShowExam()
        {
            base.ShowExam();

            Console.WriteLine("Final Exam - Only Showing Questions and Answers:");
            foreach (var kvp in QuestionAnswerDictionary)
            {
                Console.WriteLine($"Question: {kvp.Key.Header}");
                Console.WriteLine($"Body: {kvp.Key.Body}");
                Console.WriteLine($"Marks: {kvp.Key.Marks}");
                Console.WriteLine($"Answer: {kvp.Value}");
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to select the exam type
            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1. Practice Exam");
            Console.WriteLine("2. Final Exam");

            // Get user input
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
            {
                Console.WriteLine("Invalid choice. Please enter 1 for Practice Exam or 2 for Final Exam.");
            }

            // Create the selected exam type
            Exam selectedExam = (choice == 1)
                ? (Exam)new PracticeExam(DateTime.Now, 5)
                : (Exam)new FinalExam(DateTime.Now, 5);

            // Set the exam mode
            selectedExam.SetExamMode(ExamMode.Starting);

            // Sample questions
            TrueFalseQuestion tfQuestion = new TrueFalseQuestion("True of False", "True or false question", 2, true);
            ChooseOneQuestion coQuestion = new ChooseOneQuestion("Choose One", "Choose one question", 5, new List<string> { "Option1", "Option2" });
            ChooseAllQuestion caQuestion = new ChooseAllQuestion("Choose All", "Choose All question", 5, new List<string> { "OptionA", "OptionB", "OptionC" });

            // Add questions to the selected exam
            selectedExam.QuestionAnswerDictionary.Add(tfQuestion, "True");
            selectedExam.QuestionAnswerDictionary.Add(coQuestion, "Option1");
            selectedExam.QuestionAnswerDictionary.Add(caQuestion, "OptionA,OptionB");

            // Show the selected exam
            selectedExam.ShowExam();

            // Save exam details to a file
            string logFilePath = @"exam_details.txt";
            selectedExam.SaveToFile(logFilePath);

            // Test cloning
            Question clonedQuestion = (Question)tfQuestion.Clone();
            Console.WriteLine("\nCloned Question:");
            Console.WriteLine(clonedQuestion);

            // Test comparison
            Console.WriteLine("\nComparison Result:");
            Console.WriteLine(tfQuestion.CompareTo(coQuestion));
        }
    }
}
