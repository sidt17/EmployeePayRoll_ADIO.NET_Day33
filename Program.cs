using System;

namespace EmployeePayRollService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to program");
            EmployeeRepo repo = new EmployeeRepo();
            EmployeeModel employee = new EmployeeModel();

            employee.EmployeeName = "Sameer Mark";
            employee.PhoneNumber = "6575774758";
            employee.Address = "ABC";
            employee.Department = "HR";
            employee.Gender = 'M';
            employee.BasicPay = 2200.00;
            employee.Deductions = 1500.00;
            employee.TaxablePay = 200;
            employee.Tax = 2500;
            employee.NetPay = 250;
           
            employee.City = "Mumbai";
            employee.Country = "India";
            repo.AddEmployee(employee);
          
        }
    }
}
