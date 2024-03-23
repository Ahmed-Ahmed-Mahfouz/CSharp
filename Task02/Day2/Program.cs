using System.Threading.Channels;

namespace Day2
{
    class Complex
    {
        public int real;
        public int img;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Try Code
            //Complex c1 = new Complex();
            //c1.real = 1;
            //c1.img = 2;
            //Complex c2 = c1;
            //Console.WriteLine(c2.real);
            //Console.WriteLine($"{c2.img}");
            //c2.real = 10;
            //Console.WriteLine($"{c1.real}");

            //float f = 123.45f;
            //int? x = null;
            //Console.WriteLine("Enter a num: ");
            //int yourNum = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Your number = {yourNum}");

            //int[] arr1 = [1, 2, 3];
            //int[] arr2 = [.. arr1, 4, 5, 6];
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    Console.WriteLine($"{arr2[i]}");
            //}
            #endregion

            #region Task1
            Console.WriteLine("Enter the array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter the array Array Element {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int longestDistance = 0;
            int[] resultIndices = new int[2];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = arr.Length-1; j > 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        int currentDistance = j - i - 1;

                        if (currentDistance > longestDistance)
                        {
                            longestDistance = currentDistance;
                            resultIndices[0] = i;
                            resultIndices[1] = j;
                        }
                    }
                    break;
                }
            }

            Console.WriteLine("Longest distance: " + longestDistance);
            Console.WriteLine($"Values at indices {resultIndices[0]} and {resultIndices[1]}: {arr[resultIndices[0]]}");


            #endregion

            #region Task2
            // Console.WriteLine("Enter a list of space-separated words:");
            // string input = Console.ReadLine();

            // string[] words = input.Split(' ');

            // Array.Reverse(words);

            // string reversedWords = string.Join(" ", words);

            // Console.WriteLine(reversedWords);

            // WITHOUT SPLIT------>

            Console.WriteLine("Enter a list of space-separated words:");
            string input = Console.ReadLine();

            string reversedWords = "";
            string word = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    reversedWords = word + " " + reversedWords;
                    word = "";
                }
                else
                {
                    word += input[i];
                }
            }

            reversedWords = word + " " + reversedWords;

            Console.WriteLine(reversedWords);


            #endregion

            #region Task3
            //int totalCount = 0;
            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();

            //for (int i = 1; i < 100000000; i++)
            //{
            //    string numberString = i.ToString();

            //    for (int j = 0; j < numberString.Length; j++)
            //    {
            //        if (numberString[j] == '1')
            //        {
            //            totalCount++;
            //        }
            //    }
            //}

            //Console.WriteLine($"Total Count: {totalCount}");
            //watch.Stop();
            //Console.WriteLine($"Execution Time: {watch.Elapsed.ToString()} ms");

            //var watch = new System.Diagnostics.Stopwatch();
            //watch.Start();

            //int digits = Console.ReadLine().Length;
            //int totalCount = digits * (int)Math.Pow(10, digits - 1);

            //Console.WriteLine($"Total Count: {totalCount}");
            //watch.Stop();
            //Console.WriteLine($"Execution Time: {watch.Elapsed.ToString()} ms");

            #endregion
        }

    }
}