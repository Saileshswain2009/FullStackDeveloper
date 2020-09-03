using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADODOTNET
{
    class Program
    {
        static void Main(string[] args)
        {
            DAL aL = new DAL();
            //aL.Save(5,"SAILESH", DateTime.Now);
            //aL.Update(5, "AUSOTOSH", DateTime.Now);
            aL.Delete(1);
            aL.ReadAndPrint();
            System.Console.ReadKey();
        }
    }
}
