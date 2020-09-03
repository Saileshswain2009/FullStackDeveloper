using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;

namespace WebApi_project.ApiControllers
{
    public class StudentDataController : ApiController
    {
        [HttpGet]
        public int GetData1()
        {
            return 10;
        }

        [HttpGet]
        public int GetData2(int a,int b)//Get data from Query String
        {
            return a + b;
        }

        [HttpPost]
        public string Save(StudentDTO dto)//Get data from body.Parameter always going through query string.
        {
            return dto.name + "-testing";
        }
    }
    public class StudentDTO
    {
        public int id { get; set; }
        public string name { get; set; }
    }
}