using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace LINQtoXML
{
    class ExampleOfXML
    {
        static void Main(string[] args)
        {

            string myXML = @"<Departments>
                       <Department>Account</Department>
                       <Department>Sales</Department>
                       <Department>Pre-Sales</Department>
                       <Department>Marketing</Department>
                       </Departments>";

            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add new Element
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add new Element at First
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            //Add new element at First
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Developer"));

            var result = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result)
            {
                Console.WriteLine("Department Name - " + item.Value);
            }

            Console.WriteLine("=====================================");

            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();
            var result1 = xdoc.Element("Departments").Descendants();
            foreach (var item in result1)
            {
                Console.WriteLine("Department Name -" + item.Value);
            }

            Console.WriteLine("======================================");

            xdoc.Descendants().Where(s => s.Value == "Marketing").Remove();
            var result2 = xdoc.Element("Departments").Descendants();
            foreach (var item in result2)
                Console.WriteLine("Department Name -" + item.Value);
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }
    }
}
