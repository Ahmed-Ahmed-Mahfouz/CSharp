using Day6_Contd;

namespace Day6_Contd
{
    #region NIC
    public enum NICType
    {
        Ethernet,
        TokenRing
    }

    public class NIC
    {
        private static bool instanceCreated = false;

        private NIC() { }  

        public static NIC CreateInstance(string manufacture, string macAddress, NICType type)
        {
            if (instanceCreated)
            {
                throw new InvalidOperationException("Only one NIC instance is allowed.");
            }

            instanceCreated = true;
            return new NIC
            {
                Manufacture = manufacture,
                MACAddress = macAddress,
                Type = type
            };
        }

        public string Manufacture { get; init; }
        public string MACAddress { get; init; }
        public NICType Type { get; init; }

        public override string ToString() => $"{Manufacture} NIC ({Type}) - MAC Address: {MACAddress}";
    }

    #endregion
    #region Task 1
    //public class Point3D : IComparable<Point3D>, ICloneable
    //{
    //   public int X { get; set; }
    //   public int Y { get; set; }
    //   public int Z { get; set; }
    //   public Point3D() : this(0, 0, 0) { }
    //   public Point3D(int x, int y) : this(x, y, 0) { }
    //   public Point3D(int x, int y, int z)
    //   {
    //       X = x;
    //       Y = y;
    //       Z = z;
    //   }

    //   public override string ToString()
    //   {
    //       return $"Point Coordinates:   ({X}, {Y}, {Z})";
    //   }

    //   public override bool Equals(object? obj)
    //   {
    //       return obj is Point3D p && X == p.X && Y == p.Y && Z == p.Z;
    //   }

    //    public int CompareTo(Point3D? other)
    //    {
    //        if (X.compareTo(X) != 0)
    //            return X.CompareTo(other.X);
    //        if (Y.compareTo(Y) != 0)
    //            return Y.CompareTo(other.Y);
    //        return Z.CompareTo(other.Z);
    //    }

    //    public int CompareTo(object? obj)
    //    {
    //Point3D p = obj as Point3D;

    //if (p == null)
    //{
    //    throw new ArgumentException("Object is not a Point3D");
    //}

    //if (X.CompareTo(p.X) != 0)
    //{
    //    return X.CompareTo(p.X);
    //}
    // if (Y.CompareTo(p.Y) != 0)
    //{
    //    return Y.CompareTo(p.Y);
    //}
    // return Z.CompareTo(p.Z);

}

//    public object Clone()
//    {
//        return new Point3D(X, Y, Z);
//    }

//    public static explicit operator string(Point3D p)
//   {
//       return p.ToString();
//   }

//}
#endregion

#region Task 2
//public class Math
//{
//    public static double Add(double a, double b)
//    {
//        return a + b;
//    }

//    public static double Subtract(double a, double b)
//    {
//        return a - b;
//    }

//    public static double Multiply(double a, double b)
//    {
//        return a * b;
//    }

//    public static double Divide(double a, double b)
//    {
//        if (b == 0)
//        {
//            throw new DivideByZeroException("Cannot divide by zero");
//        }
//        return a / b;
//    }
//}
#endregion

#region Task 3
//public class Duration
//{
//    public int Hours { get; set; }
//    public int Minutes { get; set; }
//    public int Seconds { get; set; }

//    public Duration(int hours, int minutes, int seconds)
//    {
//        Hours = hours;
//        Minutes = minutes;
//        Seconds = seconds;
//    }

//    public Duration(int totalSeconds)
//    {
//        Hours = totalSeconds / 3600;
//        totalSeconds %= 3600;
//        Minutes = totalSeconds / 60;
//        Seconds = totalSeconds % 60;
//    }

//    public override string ToString()
//    {
//        return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
//    }

//    public override bool Equals(object obj)
//    {
//        if (obj is Duration d)
//        {
//            return Hours == d.Hours && Minutes == d.Minutes && Seconds == d.Seconds;
//        }
//        return false;
//    }

//    public static bool operator ==(Duration d1, Duration d2)
//    {
//        return d1.Equals(d2);
//    }

//    public static bool operator !=(Duration d1, Duration d2)
//    {
//        return !d1.Equals(d2);
//    }

//    public static Duration operator +(Duration d1, Duration d2)
//    {
//        int totalSeconds = d1.ToSeconds() + d2.ToSeconds();
//        return new Duration(totalSeconds);
//    }

//    public static Duration operator +(Duration d, int seconds)
//    {
//        int totalSeconds = d.ToSeconds() + seconds;
//        return new Duration(totalSeconds);
//    }

//    public static Duration operator +(int seconds, Duration d)
//    {
//        int totalSeconds = seconds + d.ToSeconds();
//        return new Duration(totalSeconds);
//    }

//    public static Duration operator ++(Duration d)
//    {
//        int totalSeconds = d.ToSeconds() + 60;
//        return new Duration(totalSeconds);
//    }

//    public static Duration operator --(Duration d)
//    {
//        int totalSeconds = d.ToSeconds() - 60;
//        return new Duration(totalSeconds);
//    }

//    public static Duration operator -(Duration d)
//    {
//        return new Duration(-d.ToSeconds());
//    }

//    public static bool operator >(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() > d2.ToSeconds();
//    }

//    public static bool operator <(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() < d2.ToSeconds();
//    }

//    public static bool operator >=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() >= d2.ToSeconds();
//    }

//    public static bool operator <=(Duration d1, Duration d2)
//    {
//        return d1.ToSeconds() <= d2.ToSeconds();
//    }

//    public static explicit operator DateTime(Duration d)
//    {
//        return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
//    }

//    private int ToSeconds()
//    {
//        return Hours * 3600 + Minutes * 60 + Seconds;
//    }
//}
#endregion
internal class Program
    {
    static void Main(string[] args)
    {
        #region NIC
        try
        {
            NIC nicInstance = NIC.CreateInstance("ManufacturerX", "00:1A:2B:3C:4D:5E", NICType.Ethernet);
            Console.WriteLine(nicInstance);
            //NIC nicEnstance = NIC.CreateInstance("ManufacturerX", "00:1A:2B:3C:4D:5E", NICType.Ethernet);
            //Console.WriteLine(nicEnstance);
        }

        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        #endregion
        #region Task 1

        //try
        //{
        //   Console.Write("Enter the X coordinate for P1: ");
        //   int x1 = int.Parse(Console.ReadLine());

        //   Console.Write("Enter the Y coordinate for P1: ");
        //   int y1 = int.Parse(Console.ReadLine());

        //   Console.Write("Enter the Z coordinate for P1: ");
        //   int z1 = int.Parse(Console.ReadLine());

        //   Point3D P1 = new Point3D(x1, y1, z1);

        //   // Repeat the process for P2
        //   Console.Write("Enter the X coordinate for P2: ");
        //   int x2 = int.Parse(Console.ReadLine());

        //   Console.Write("Enter the Y coordinate for P2: ");
        //   int y2 = int.Parse(Console.ReadLine());

        //   Console.Write("Enter the Z coordinate for P2: ");
        //   int z2 = int.Parse(Console.ReadLine());

        //   Point3D P2 = new Point3D(x2, y2, z2);

        //   // Define an array of points
        //   Point3D[] points = new Point3D[]
        //   {
        //     P1, P2
        //   };

        //    Array.Sort(points);

        //    Point3D p1Clone = (Point3D)P1.Clone();
        //    Point3D p2Clone = (Point3D)P2.Clone();

        //    Console.WriteLine("Original points:");
        //    foreach (Point3D point in points)
        //       {
        //            Console.WriteLine(point);
        //       }
        //    Console.WriteLine("\nCloned point:");
        //    Console.WriteLine(p1Clone);
        //    Console.WriteLine(p2Clone);

        //}
        //catch (FormatException)
        //{
        //   Console.WriteLine("Invalid input. Please enter a valid number.");
        //}

        /// TryParse
        //// For P1
        //Console.Write("Enter the X coordinate for P1: ");
        //string inputX1 = Console.ReadLine();
        //int x1;

        //if (int.TryParse(inputX1, out x1))
        //{
        //    Console.Write("Enter the Y coordinate for P1: ");
        //    string inputY1 = Console.ReadLine();
        //    int y1;

        //    if (int.TryParse(inputY1, out y1))
        //    {
        //        Console.Write("Enter the Z coordinate for P1: ");
        //        string inputZ1 = Console.ReadLine();
        //        int z1;

        //        if (int.TryParse(inputZ1, out z1))
        //        {
        //            Point3D P1 = new Point3D(x1, y1, z1);
        //            Console.WriteLine("Point P1 created successfully.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input for Z coordinate of P1. Please enter a valid integer.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input for Y coordinate of P1. Please enter a valid integer.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input for X coordinate of P1. Please enter a valid integer.");
        //}

        //// For P2
        //Console.Write("Enter the X coordinate for P2: ");
        //string inputX2 = Console.ReadLine();
        //int x2;

        //if (int.TryParse(inputX2, out x2))
        //{
        //    Console.Write("Enter the Y coordinate for P2: ");
        //    string inputY2 = Console.ReadLine();
        //    int y2;

        //    if (int.TryParse(inputY2, out y2))
        //    {
        //        Console.Write("Enter the Z coordinate for P2: ");
        //        string inputZ2 = Console.ReadLine();
        //        int z2;

        //        if (int.TryParse(inputZ2, out z2))
        //        {
        //            Point3D P2 = new Point3D(x2, y2, z2);
        //            Console.WriteLine("Point P2 created successfully.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Invalid input for Z coordinate of P2. Please enter a valid integer.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input for Y coordinate of P2. Please enter a valid integer.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input for X coordinate of P2. Please enter a valid integer.");
        //}

        /// Convert
        // For P1
        //Console.Write("Enter the X coordinate for P1: ");
        //string inputX1 = Console.ReadLine();

        //try
        //{
        //    int x1 = Convert.ToInt32(inputX1);

        //    Console.Write("Enter the Y coordinate for P1: ");
        //    string inputY1 = Console.ReadLine();

        //    try
        //    {
        //        int y1 = Convert.ToInt32(inputY1);

        //        Console.Write("Enter the Z coordinate for P1: ");
        //        string inputZ1 = Console.ReadLine();

        //        try
        //        {
        //            int z1 = Convert.ToInt32(inputZ1);

        //            Point3D P1 = new Point3D(x1, y1, z1);
        //            Console.WriteLine("Point P1 created successfully.");
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Invalid input for Z coordinate of P1. Please enter a valid integer.");
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Invalid input for Y coordinate of P1. Please enter a valid integer.");
        //    }
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Invalid input for X coordinate of P1. Please enter a valid integer.");
        //}

        //// For P2
        //Console.Write("Enter the X coordinate for P2: ");
        //string inputX2 = Console.ReadLine();

        //try
        //{
        //    int x2 = Convert.ToInt32(inputX2);

        //    Console.Write("Enter the Y coordinate for P2: ");
        //    string inputY2 = Console.ReadLine();

        //    try
        //    {
        //        int y2 = Convert.ToInt32(inputY2);

        //        Console.Write("Enter the Z coordinate for P2: ");
        //        string inputZ2 = Console.ReadLine();

        //        try
        //        {
        //            int z2 = Convert.ToInt32(inputZ2);

        //            Point3D P2 = new Point3D(x2, y2, z2);
        //            Console.WriteLine("Point P2 created successfully.");
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Invalid input for Z coordinate of P2. Please enter a valid integer.");
        //        }
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Invalid input for Y coordinate of P2. Please enter a valid integer.");
        //    }
        //}
        //catch (FormatException)
        //{
        //    Console.WriteLine("Invalid input for X coordinate of P2. Please enter a valid integer.");
        //}


        #endregion

        #region Task 2
        //double a = 10.0;
        //double b = 2.0;

        //Console.WriteLine($"Add: {Math.Add(a, b)}");
        //Console.WriteLine($"Subtract: {Math.Subtract(a, b)}");
        //Console.WriteLine($"Multiply: {Math.Multiply(a, b)}");
        //Console.WriteLine($"Divide: {Math.Divide(a, b)}");
        #endregion

        #region Task 3
        //Duration D1 = new Duration(1, 10, 15);
        //Console.WriteLine(D1.ToString());

        //Duration D2 = new Duration(3600);
        //Console.WriteLine(D2.ToString());

        //Duration D3 = new Duration(7800);
        //Console.WriteLine(D3.ToString());

        //Duration D4 = new Duration(666);
        //Console.WriteLine(D4.ToString());

        //D3 = D1 + D2;
        //Console.WriteLine(D3.ToString());
        //D3 = D1 + 7800;
        //Console.WriteLine(D3.ToString());
        //D3 = 666 + D3;
        //Console.WriteLine(D3.ToString());
        //D3 = D1++;
        //Console.WriteLine(D3.ToString());
        //D3 = --D2;
        //Console.WriteLine(D3.ToString());
        //Duration D5 = -D2;
        //Console.WriteLine(D5.ToString());

        //if (D1 > D2)
        //{
        //    Console.WriteLine("D1 is greater than D2");
        //}

        //if (D1 <= D2)
        //{
        //    Console.WriteLine("D1 is less than or equal to D2");
        //}

        //DateTime Obj = (DateTime)D1;
        //Console.WriteLine(Obj.ToString());

        #endregion

    }
}
