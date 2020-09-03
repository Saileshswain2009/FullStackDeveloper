/*using System;
using System.IO;
using System.Diagnostics;

namespace CompanyCSV_project
{
    class CompanyDetails
    {
        private static Random random = new Random();
        private static int employeeId = 143;
        public enum Department { HR, DEV, TESTING, QA, MANAGEMENT }
        public static void Main(string[] args)
        {
            string[] employeeName = { "sailesh", "gaurav", "vikash", "ranjit", "ausutosh" };
            string[] companyName = { "tcs", "wipro", "thinkactive", "bizruntime", "google" };
            string[] department = Enum.GetNames(typeof(Department));
            // readData("C:\\Users\\sonu\\Desktop\\CompanyDetails\\employe.csv");
            Console.WriteLine("number of company = " + companyName.Length);
            // addRecord("EmployeeId", "EmployeeName", "Department", "CompanyName", "CompanyID", "C:\\Users\\sonu\\Desktop\\CompanyDetails\\employe.csv");
            for (int j = 0; j < companyName.Length; j++)
            {
                int numberOfPerson = 0;
                Console.WriteLine("company name " + companyName[j]);
                for (int i = 0; i < 200; i++)
                {
                    numberOfPerson++;
                    string companyID = companyName[j] + 100;
                    employeeId += i;
                    string id = Convert.ToString(employeeId);//INT VALUE CONVERT TO STRING

                    if (i == 0)
                    {
                        addRecord("EmployeeId", "EmployeeName", "Department", "CompanyName", "CompanyID", "H:\\28-08-2020\\Employees_record\\" + companyName[j] + ".csv");
                    }
                    addRecord(id, employeeName[random.Next(0, 5)], department[random.Next(0, 5)], companyName[j], companyID, "H:\\28-08-2020\\Employees_record\\" + companyName[j] + ".csv");
                }
                Debug.WriteLine(numberOfPerson + " employee in = " + companyName[j]);
            }
        }

        public static void addRecord(string employeeId, string employeeName, string Department, String companyName, string companyId, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(filepath, true))
                {
                    file.WriteLine(employeeId + "," + employeeName + "," + Department + "," + companyName + "," + companyId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        /*public static void readData(string filepath)
        {
        try
        {
        using (StreamReader sr = new StreamReader(filepath))
        {
        string line;
        string[] row = new string[4];
        while ((line = sr.ReadLine()) != null)
        {
        row = line.Split(',');
        Console.WriteLine(row[0]);
        Console.WriteLine(row[1]);
        Console.WriteLine(row[2]);
        Console.WriteLine(row[3]);
        Console.WriteLine(row[4]);

        }
        }
        }
        catch (Exception ex)
        {
        Console.WriteLine(ex);
        }
        }
    }
}*/
