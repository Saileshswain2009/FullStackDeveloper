using System;
using System.Threading;
using System.Threading.Tasks;

namespace CreateExecuteTask
{
    class ExecuteTask
    {
        public static  async Task Main(string[] args)
        {
            await Task.Run(() =>
                        {
                            int count = 0;
                            for (count = 0; count <= 10; count++)
                            { }
                            Console.WriteLine("Finished {0} loop iterations", count);
                        });
        }
    }
}
