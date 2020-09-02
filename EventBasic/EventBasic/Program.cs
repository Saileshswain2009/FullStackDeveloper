using System;

namespace EventBasic
{
    delegate void tDelegate();
    class SimpleEvent
    {
        public static event tDelegate add;//Declare
        static void Main(string[] args)
        {
            add += new tDelegate(USA);//raise
            add += new tDelegate(INDIA);//consume
            add += new tDelegate(RUSSIA);//register with the event
            add.Invoke();
        }
        static void USA()//Event handler
        {
            Console.WriteLine("Welcome to USA");
        }
        static void INDIA()
        {
            Console.WriteLine("Welcome to INDIA");
        }
        static void RUSSIA()
        {
            Console.WriteLine("Welcome to RUSSIA");
        }
    }
}
