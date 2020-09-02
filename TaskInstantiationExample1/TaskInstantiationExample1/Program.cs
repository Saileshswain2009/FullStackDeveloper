using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskInstantiationExample1
{
    class InitTask
    {
        static void Main(string[] args)
        {
            Action<object> action = (object obj) =>
                                        {
                                            Console.WriteLine("Task={0},obj={1},Thread={2}", Task.CurrentId, obj, Thread.CurrentThread.ManagedThreadId);//Fourth task executes a lambda expression (an Action delegate) that is defined inline in the call to the task creation method.
                                        };
            Task t1 = new Task(action, "alpha");//creating a task through task obj. through delegate but,do not start it.

            Task t2 = Task.Factory.StartNew(action, "Beta");//To create task for already started task we used Task.Factory with startNew().

            t2.Wait();//Here t2 task is waited.

            t1.Start();//start the task to get that object.

            String taskData = "delta";//Construct a started task using Task.Run
            Task t3 = Task.Run(() =>
                                    {
                                        Console.WriteLine("Task={0},obj={1},Thread={2}", Task.CurrentId, taskData, Thread.CurrentThread.ManagedThreadId);//Fourth task executes a lambda expression (an Action delegate) that is defined inline in the call to the task creation method.
                                    });
            t3.Wait();

            //Construct an unstarted task
            Task t4 = new Task(action, "gamma");
            //Runing Sychronously
            t4.RunSynchronously();
            t4.Wait();// Although the task was run synchronously, it is a good practice to wait for it in the event exceptions were thrown by the task.

        }
    }
}
