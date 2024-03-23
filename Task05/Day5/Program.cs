using System.IO;
namespace Day5
{
    [Flags]
    enum Permissions : byte
    {
        read = 1, write = 2, update = 4, delete = 8
    }
    enum SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8
    }
    enum Gender
    {
        M, F
    }

    struct HiringDate
    {
        int day;
        int month;
        int year;

        public void setDay(int _day)
        {
            if (_day > 0)
                day = _day;
            else
                throw new Exception();
        }
        public void setMonth(int _month)
        {
            if (_month > 0)
                month = _month;
            else
                throw new Exception();
        }
        public void setYear(int _year)
        {
            if (_year > 1980 && _year < 2080)
                year = _year;
            else
                throw new Exception();
        }

        public int getDay()
        {
            if (day > 0)
                return day;
            else
                throw new Exception();
        }
        public int getMonth()
        {
            if (month > 0)
                return month;
            else
                throw new Exception();
        }
        public int getYear()
        {
            if (year > 1980 && year < 2080)
                return year;
            else
                throw new Exception();
        }
        public HiringDate(int _day, int _month, int _year)
        {
            day = _day;
            month = _month;
            year = _year;
        }
    }
    struct Employee
    {
        int id;
        double salary;
        HiringDate hireDate;
        Gender gender;
        Permissions securityPrivileges;
        public void setId(int _id)
        {
            if (_id >= 0)
                id = _id;
            else
                throw new Exception();
        }
        public void setSalary(double _salary)
        {
            if (_salary > 0)
                salary = _salary;
            else
                throw new Exception();
        }
        public void setHireDate(HiringDate _hireDate)
        {
            hireDate = _hireDate;
        }
        public int getId()
        {
            if (id >= 0)
                return id;
            else
                throw new Exception();
        }
        public double getSalary()
        {
            if (salary > 0)
                return salary;
            else
                throw new Exception();
        }
        public HiringDate getHireDate()
        {
            return hireDate;
        }
        public void setGender(string _gender)
        {
            try
            {
                gender = (Gender)Enum.Parse(typeof(Gender), _gender);
            }
            catch (Exception)
            {
                throw new Exception("Invalid gender. Please enter M or F.");
            }
        }

        public Gender getGender()
        {
            return gender;
        }
        public void SetSecurityPrivileges(SecurityLevel privileges)
        {
            try
            {
                switch (privileges)
                {
                    case SecurityLevel.Guest:
                        // Guest has only read permission
                        securityPrivileges = Permissions.read;
                        break;
                    case SecurityLevel.Developer:
                        // Developer has read, write, and update permissions
                        securityPrivileges = Permissions.read | Permissions.write | Permissions.update;
                        break;
                    case SecurityLevel.Secretary:
                        // Secretary has read and write permissions
                        securityPrivileges = Permissions.read | Permissions.write;
                        break;
                    case SecurityLevel.DBA:
                        // DBA has all permissions
                        securityPrivileges = Permissions.read | Permissions.write | Permissions.update | Permissions.delete;
                        break;
                    default:
                        throw new Exception("Invalid security privileges. Please enter Guest, Developer, Secretary, or DBA.");
                }
            }
            catch (Exception)
            {
                throw new Exception("Invalid security privileges. Please enter Guest, Developer, Secretary, or DBA.");
            }
        }
        public Permissions GetSecurityPrivileges()
        {
            return securityPrivileges;
        }

        public Employee(int _id, double _salary, HiringDate _hireDate, string _gender, SecurityLevel _securityPrivileges)
        {
            id = _id;
            salary = _salary;
            hireDate = _hireDate;
            setGender(_gender);
            SetSecurityPrivileges(_securityPrivileges);
        }
        public override string ToString()
        {
            return $"Id: {getId()}\n" +
                   $"Salary: {getSalary().ToString("C2")}\n" +
                   $"Hire Date: {getHireDate().getDay()}/{getHireDate().getMonth()}/{getHireDate().getYear()}\n" +
                   $"Gender: {getGender()}\n" +
                   $"Security Privileges: {(Permissions)securityPrivileges}";
        }

    }
    internal class Program
    {
        static void LogError(string errorMessage)
        {
            string logFilePath = @"error_log.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(logFilePath, true))
                {
                    writer.WriteLine($"[{DateTime.Now}] {errorMessage}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error while logging: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            Employee[] EmpArr = new Employee[3];
            for (int i = 0; i < EmpArr.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Enter details for employee {i + 1}: ");
                    Console.WriteLine("Enter Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Salary: ");
                    double salary = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Hire Date (DD MM YY): ");
                    string[] date = Console.ReadLine().Split(" ");
                    if (date.Length != 3)
                    {
                        Console.WriteLine("Invalid date format. Please enter the date in DD MM YY format.");
                        i--;
                        continue;
                    }

                    HiringDate hireDate = new HiringDate(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));

                    Console.WriteLine("Enter Gender (M or F): ");
                    string gender = Console.ReadLine();
                    if (gender.ToUpper() != "M" && gender.ToUpper() != "F")
                    {
                        Console.WriteLine("Invalid gender. Please enter M or F.");
                        i--;
                        continue;
                    }

                    Console.WriteLine("Enter Security Privileges (Guest, Developer, Secretary, DBA): ");
                    string privilege = Console.ReadLine();
                    if (!Enum.TryParse(privilege, out SecurityLevel securityPrivileges))
                    {
                        Console.WriteLine("Invalid security privileges. Please enter Guest, Developer, Secretary, or DBA.");
                        i--;
                        continue;
                    }

                    EmpArr[i] = new Employee(id, salary, hireDate, gender, securityPrivileges);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    LogError($"Error: {ex.Message}");
                    i--; 
                }
            }

            for (int i = 0; i < EmpArr.Length - 1; i++)
            {
                for (int j = 0; j < EmpArr.Length - 1 - i; j++)
                {
                    if (EmpArr[j].getHireDate().getYear() > EmpArr[j + 1].getHireDate().getYear()
                        || (EmpArr[j].getHireDate().getYear() == EmpArr[j + 1].getHireDate().getYear()
                            && EmpArr[j].getHireDate().getMonth() > EmpArr[j + 1].getHireDate().getMonth())
                        || (EmpArr[j].getHireDate().getYear() == EmpArr[j + 1].getHireDate().getYear()
                            && EmpArr[j].getHireDate().getMonth() == EmpArr[j + 1].getHireDate().getMonth()
                            && EmpArr[j].getHireDate().getDay() > EmpArr[j + 1].getHireDate().getDay()))
                    {
                        Employee temp = EmpArr[j];
                        EmpArr[j] = EmpArr[j + 1];
                        EmpArr[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < EmpArr.Length; i++)
            {
                Console.WriteLine($"\nEmployee {i + 1} Details:");
                string employeeDetails = EmpArr[i].ToString();
                Console.WriteLine(employeeDetails);
            }

        }

    }
}
