using System;
using System.Collections.Generic;

namespace APBD_ZAO_CW6
{
    class Program
    {

         static void show(IEnumerable<object> task)
        {
            foreach (var obj in task) Console.WriteLine(obj);
            Console.WriteLine("**************************************");
        }

        static void Main(string[] args)
        {
            show(LinqTasks.Task1());
            show(LinqTasks.Task2());
            Console.WriteLine(LinqTasks.Task3());
            Console.WriteLine("**************************************");
            show(LinqTasks.Task4());
            show(LinqTasks.Task5());
            show(LinqTasks.Task6());
            show(LinqTasks.Task7());
            Console.WriteLine(LinqTasks.Task8());
            Console.WriteLine("**************************************");
            Console.WriteLine(LinqTasks.Task9());
            Console.WriteLine("**************************************");
            show(LinqTasks.Task10());
            show(LinqTasks.Task11());
            show(LinqTasks.Task12());
            int[] array = { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 };            
            Console.WriteLine(LinqTasks.Task13(array));   
            Console.WriteLine("**************************************");
            show(LinqTasks.Task14());

        }
    }
}
