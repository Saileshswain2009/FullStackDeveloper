﻿using System;

namespace DelegateWithParameter
{
    public delegate void MyDelegate(string msg); //declaring a delegate

    class DelegateParam
    {
        static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            InvokeDelegate(del);

            del = ClassB.MethodB;
            InvokeDelegate(del);

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            InvokeDelegate(del);
        }

        static void InvokeDelegate(MyDelegate del) // MyDelegate type parameter
        {
            del("Hello World");
        }
    }

     class ClassA
    {

        public static void MethodA(string message)
        {
            Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
        }
    }

     class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
        }
    }
}
