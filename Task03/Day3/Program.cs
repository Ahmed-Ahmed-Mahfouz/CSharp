namespace Day3
{
    #region Task 2
    //struct HiringDate
    //{
    //    int day;
    //    int month;
    //    int year;

    //    public void setDay(int _day)
    //    {
    //        if (_day > 0)
    //            day = _day;
    //        else
    //            throw new Exception();
    //    }
    //    public void setMonth(int _month)
    //    {
    //        if (_month > 0)
    //            month = _month;
    //        else
    //            throw new Exception();
    //    }
    //    public void setYear(int _year)
    //    {
    //        if (_year > 1980 && _year < 2080)
    //            year = _year;
    //        else
    //            throw new Exception();
    //    }

    //    public int getDay()
    //    {
    //        if (day > 0)
    //            return day;
    //        else
    //            throw new Exception();
    //    }
    //    public int getMonth()
    //    {
    //        if (month > 0)
    //            return month;
    //        else
    //            throw new Exception();
    //    }
    //    public int getYear()
    //    {
    //        if (year > 1980 && year < 2080)
    //            return year;
    //        else
    //            throw new Exception();
    //    }
    //    public HiringDate(int _day, int _month, int _year)
    //    {
    //        day = _day;
    //        month = _month;
    //        year = _year;
    //    }
    //}

    //struct Employee
    //{
    //    int id;
    //    double salary;
    //    HiringDate hireDate;

    //    public void setId(int _id)
    //    {
    //        if (_id >= 0)
    //            id = _id;
    //        else
    //            throw new Exception();
    //    }
    //    public void setSalary(double _salary)
    //    {
    //        if (_salary > 0)
    //            salary = _salary;
    //        else
    //            throw new Exception();
    //    }
    //    public void setHireDate(HiringDate _hireDate)
    //    {
    //        hireDate = _hireDate;
    //    }
    //    public int getId()
    //    {
    //        if (id >= 0)
    //            return id;
    //        else
    //            throw new Exception();
    //    }
    //    public double getSalary()
    //    {
    //        if (salary > 0)
    //            return salary;
    //        else
    //            throw new Exception();
    //    }
    //    public HiringDate getHireDate()
    //    {
    //        return hireDate;
    //    }
    //    public Employee(int _id, double _salary, HiringDate _hireDate)
    //    {
    //        id = _id;
    //        salary = _salary;
    //        hireDate = _hireDate;
    //    }

    //}

        #endregion
        internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1 Static

            //Console.WriteLine("enter number of students: ");
            //int numOfStudetns = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter number of courses: ");
            //int numOfCourses = int.Parse(Console.ReadLine());

            //double[,] studentMarks = new double[numOfStudetns, numOfCourses];
            //for (int i = 0; i < numOfStudetns; i++)
            //{
            //    for (int j = 0; j < numOfCourses; j++)
            //    {
            //        Console.WriteLine($"enter marks of student {i + 1} in course {j + 1}");
            //        studentMarks[i, j] = double.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("Student Grades are: ");
            //for (int i = 0; i < numOfStudetns; i++)
            //{
            //    double sum = 0;
            //    for (int j = 0; j < numOfCourses; j++)
            //    {
            //        Console.WriteLine("Student " + (i + 1) + " marks in course " + (j + 1) + " is: " + studentMarks[i, j]);
            //        sum += studentMarks[i, j];
            //    }
            //    Console.WriteLine("Student " + (i + 1) + " total marks is: " + sum);
            //}

            //Console.WriteLine("Average of Grades for Each Course:");
            //for (int j = 0; j < numOfCourses; j++)
            //{
            //    double sum = 0;

            //    for (int i = 0; i < numOfStudetns; i++)
            //    {
            //        sum += studentMarks[i, j];
            //    }

            //    double average = sum / numOfStudetns;
            //    Console.WriteLine("Average grade for course " + (j + 1) + " is: " + average);
            //}
            #endregion

            #region Task 1 Dynamic
            Console.WriteLine("Enter number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            double[][] studentMarks = new double[numOfStudents][];
            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine($"Enter number of courses for student {i + 1}: ");
                int numOfCourses = int.Parse(Console.ReadLine());

                studentMarks[i] = new double[numOfCourses];
                for (int j = 0; j < numOfCourses; j++)
                {
                    Console.WriteLine($"Enter marks of student {i + 1} in course {j + 1}");
                    studentMarks[i][j] = double.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Student Grades are: ");
            for (int i = 0; i < numOfStudents; i++)
            {
                double sum = 0;

                for (int j = 0; j < studentMarks[i].Length; j++)
                {
                    Console.WriteLine("Student " + (i + 1) + " marks in course " + (j + 1) + " is: " + studentMarks[i][j]);
                    sum += studentMarks[i][j];
                }

                Console.WriteLine("Student " + (i + 1) + " total marks is: " + sum);
            }

            Console.WriteLine("Average of Grades for Each Course:");
            int maxNumOfCourses = 0;
            for (int i = 0; i < numOfStudents; i++)
            {
                if (studentMarks[i].Length > maxNumOfCourses)
                {
                    maxNumOfCourses = studentMarks[i].Length;
                }
            }

            for (int j = 0; j < maxNumOfCourses; j++)
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < numOfStudents; i++)
                {
                    if (j < studentMarks[i].Length)
                    {
                        sum += studentMarks[i][j];
                        count++;
                    }
                }

                double average = sum / count;
                Console.WriteLine("Average grade for course " + (j + 1) + " is: " + average);
            }
            #endregion

            #region Task 2
            //Employee[] EmpArr = new Employee[3];
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for employee {i + 1}: ");
            //    Console.WriteLine("Enter Id: ");
            //    int id = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Salary: ");
            //    double salary = double.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Hire Date (DD MM YY): ");
            //    string[] date = Console.ReadLine().Split(" ");
            //    HiringDate hireDate = new HiringDate(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
            //    EmpArr[i] = new Employee(id, salary, hireDate);
            //}
            //Console.WriteLine("\nEmployee Details:");
            //for (int i = 0; i < EmpArr.Length; i++)
            //{
            //    Console.WriteLine($"Employee {i + 1} Details: ");
            //    Console.WriteLine($"Id: {EmpArr[i].getId()}");
            //    Console.WriteLine($"Salary: {EmpArr[i].getSalary()}");
            //    Console.WriteLine($"Hire Date: {EmpArr[i].getHireDate().getDay()}/{EmpArr[i].getHireDate().getMonth()}/{EmpArr[i].getHireDate().getYear()}");
            //}
            #endregion

            #region Try Code
            //implicit
            //int x = 123;

            //long y = x;


            //exciplicit
            //checked
            //{
            //    long z = int.MaxValue;
            //    z += 20;
            //    int a = (int)z;
            //    Console.WriteLine(int.MinValue);

            //    Console.WriteLine(a);
            //}

            //helper class

            //any datatype => string    ... tostring();

            //int x = 123;
            //string txt = x.ToString();
            //string txt2 = txt + "45";
            //Console.WriteLine( txt2);

            // from string => anydatatype ... parse

            //string txt = "123w";

            //int x = int.Parse(txt);
            //int z = x + 45;
            //Console.WriteLine(z);


            //int x = 123;
            //string txt = Convert.ToString(x);


            // string txt2 = null;
            //// int x2 = int.Parse(txt2);
            // int x2 = Convert.ToInt32(txt2);
            // x2++;
            // Console.WriteLine(x2);

            //char c = 'A';
            //int x = c;
            //Console.WriteLine(x);

            //int x = 97;
            //char y = (char)x;
            //Console.WriteLine(y);


            #endregion

        }
    }
}
