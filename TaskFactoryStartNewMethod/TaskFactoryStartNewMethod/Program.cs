using System;
using System.Threading.Tasks;

namespace TaskFactoryStartNewMethod
{
     class TaskFactory
    {
         static void Main(string[] args)
        {
            Task t = Task.Factory.StartNew(() =>
                                              {
                                                  int ctr = 0;
                                                  for(ctr=0;ctr<10;ctr++)
                                                  {}
                                                  Console.WriteLine("Finised Loop iteration is: {0}", ctr);
                                              });
            t.Wait();
        }
    }
}
