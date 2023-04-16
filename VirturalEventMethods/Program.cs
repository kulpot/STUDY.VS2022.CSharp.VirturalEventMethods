using System;

namespace VirtualEventMethods
{
    class Program
    {
        private static void Main(string[] args)
        {
            MyClassSuper superClass = new MyClassSuper();
            //superClass.OnMyNumChanged();
            while (Console.ReadLine() == "")
                superClass.MyNum++;

        }
    }
}