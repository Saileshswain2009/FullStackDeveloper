using System;
using System.Linq;

namespace LinqToSqlExample1
{
    class LinqToSQLCRUD
    {
        static void Main(string[] args)
        {
            string connectString = System.Configuration.ConfigurationManager.ConnectionStrings["LinqToSQLDBConnectionString"].toString();
            LinqToSQLDataContext db = new LinqToSQLDataContext(connectString);

            Employee newEmployee = new Employee();
            newEmployee.Name = "Sailesh";
            newEmployee.Email = "saileshswain2009@gmail.com";
            newEmployee.ContantN.o = "8658821545";
            newEmployee.DepartmentId = "3";
            newEmployee.Address = "Sailesh-INDIA";

            db.Employees.InsertOnSubmit(newEmployee);

            db.SubmitChanges();

            Employee insertedEmployee = db.Employees.FirstOrDefault(e => e.Name.Equals("Sailesh"));

            Console.WriteLine("Employee Id = {0} , Name = {1}, Email = {2}, ContactNo = {3}, Address = {4}",
                          insertedEmployee.EmployeeId, insertedEmployee.Name, insertedEmployee.Email,
                          insertedEmployee.ContactNo, insertedEmployee.Address);

            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
