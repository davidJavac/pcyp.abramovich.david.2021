using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Clase9.Ejercicio1.WaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = Stopwatch.StartNew();

            sw.Start();
            
            Task<string> t1 = new Task<string>(() => { 
                Thread.Sleep(1000);
                string text = System.IO.File.ReadAllText($@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\resources\\ratings.txt");
                string readFileName = "ratings.txt";
                return readFileName;
            });

            Task<string> t2 = new Task<string>(() => {
                Thread.Sleep(1000);
                string text = System.IO.File.ReadAllText($@"{Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName}\\resources\\vial-test.csv");
                string readFileName = "vial-test.csv";
                return readFileName;
            });

            var taskList = new List<Task<string>>();
            taskList.Add(t1);
            taskList.Add(t2);

            taskList.ForEach(task => task.Start());

            Console.WriteLine("Progress...");
            
            //Utilizando WaitAllOneByOne  
            while (taskList.Count > 0) {
                var index = Task.WaitAny(taskList.ToArray());
                Console.WriteLine("Read " + taskList[index].Result + " file...");
                taskList.RemoveAt(index);
            }

            Console.WriteLine("Completed reading.");

            sw.Stop();

            Console.WriteLine("The used time was {0} seconds", (sw.ElapsedMilliseconds / 1000));
        }
    }
}
