using System;
using System.Collections.Generic;

class Employee
{
    public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;

    protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
    {
        EmployeeLayOff?.Invoke(this, e);
    }

    public int EmployeeID { get; set; }
    public DateTime BirthDate { get; set; }
    public int VacationStock { get; set; }

    public bool RequestVacation(DateTime from, DateTime to)
    {
        if (from >= to)
        {
            throw new ArgumentException("Invalid vacation dates. 'From' date must be before 'To' date.");
        }

        int requestedDays = (int)(to - from).TotalDays;

        if (requestedDays <= VacationStock)
        {
            VacationStock -= requestedDays;
            Console.WriteLine($"Vacation approved for {requestedDays} days. Remaining vacation days: {VacationStock} days.");
            return true;
        }
        else
        {
            Console.WriteLine($"Vacation request denied. Insufficient vacation days. Remaining vacation days: {VacationStock} days.");
            return false;
        }
    }

    public void EndOfYearOperation()
    {
        DateTime currentDate = DateTime.Now;
        int age = currentDate.Year - BirthDate.Year;

        if (age > 60)
        {
            LayOff(LayOffCause.AgeGreaterThan60);
        }
        else if (VacationStock < 0)
        {
            LayOff(LayOffCause.VacationStockNegative);
        }
        else
        {
            Console.WriteLine($"Employee {EmployeeID} continues for the next year.");
        }
    }

    public void LayOff(LayOffCause cause)
    {
        OnEmployeeLayOff(new EmployeeLayOffEventArgs { Cause = cause });
    }

    public enum LayOffCause
    {
        AgeGreaterThan60,
        VacationStockNegative
    }

    public class EmployeeLayOffEventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}

class Department
{
    public int DeptID { get; set; }
    public string Deptname { get; set; }

    List<Employee> Staff = new List<Employee>();

    public void AddStaff(Employee E)
    {
        Staff.Add(E);
        E.EmployeeLayOff += RemoveStaff;
    }

    public void RemoveStaff(object sender, Employee.EmployeeLayOffEventArgs e)
    {
        Employee employee = (Employee)sender;
        if (e.Cause == Employee.LayOffCause.AgeGreaterThan60 || e.Cause == Employee.LayOffCause.VacationStockNegative)
        {
            Staff.Remove(employee);
            Console.WriteLine($"Employee {employee.EmployeeID} removed from department {Deptname} staff.");
        }
    }
}

class Club
{
    public int ClubID { get; set; }
    public string ClubName { get; set; }
    List<Employee> Members = new List<Employee>();

    public void AddMember(Employee E)
    {
        Members.Add(E);
        E.EmployeeLayOff += RemoveMember;
    }

    public void RemoveMember(object sender, Employee.EmployeeLayOffEventArgs e)
    {
        Employee employee = (Employee)sender;
        if (e.Cause == Employee.LayOffCause.VacationStockNegative && employee.VacationStock < 0)
        {
            Members.Remove(employee);
            Console.WriteLine($"Employee {employee.EmployeeID} removed from club {ClubName} due to negative vacation stock.");
        }
    }
}

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee { EmployeeID = 1, BirthDate = new DateTime(1960, 1, 1), VacationStock = 10 };
        Employee employee2 = new Employee { EmployeeID = 2, BirthDate = new DateTime(1980, 1, 1), VacationStock = 5 };

        Department department = new Department { DeptID = 1, Deptname = "IT" };
        Club club = new Club { ClubID = 1, ClubName = "Sports" };

        department.AddStaff(employee1);
        department.AddStaff(employee2);

        club.AddMember(employee1);
        club.AddMember(employee2);

        employee2.EndOfYearOperation();

        Console.WriteLine("\nVacation Requests:");
        bool request1Approved = employee1.RequestVacation(new DateTime(2023, 6, 1), new DateTime(2023, 6, 5));
        bool request2Approved = employee2.RequestVacation(new DateTime(2023, 7, 1), new DateTime(2023, 7, 10));

        Console.WriteLine($"Vacation Request 1 Approved: {request1Approved}");
        Console.WriteLine($"Vacation Request 2 Approved: {request2Approved}");
    }
}
