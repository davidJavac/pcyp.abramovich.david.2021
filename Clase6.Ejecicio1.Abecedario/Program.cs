using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Clase6.Ejecicio1.Abecedario
{

    class Program
    {
        static void Main(string[] args)
        {
            TestTask test = new TestTask();
            test.testTasks();
        }


        public class TestTask {

            private List<char> alphabet;
            private ConcurrentDictionary<char, bool> addedLetters;
            private Task taskA;
            private Task taskB;
            private int taskAID;
            private int taskBID;
            public void testTasks() {

                alphabet = new List<char>();
                addedLetters = new ConcurrentDictionary<char, bool>();
                addLetterToAlphabet();
                //Task taskA = Task.Factory.StartNew(() => printAlphabetTaskA(alphabet));

                //Task taskB = Task.Factory.StartNew(() => printAlphabetTaskB(alphabet));

                taskA = new Task(printAlphabetTaskA);
                taskB = new Task(printAlphabetTaskB);
                taskAID = taskA.Id;
                taskBID = taskB.Id;

                testTask2();

                //taskA.Start();
                //taskB.Start();

                /*Task.WaitAll();

                //printAlphabetTaskB();
                foreach (KeyValuePair<char, bool> entry in addedLetters) {

                    Console.WriteLine("key " + entry.Key);
                }*/
                Console.ReadKey();
            }

            private void testTask2() {

                char letter = 'a';

                while (letter <= 'z') {

                    Task taskA = Task.Factory.StartNew(() => Console.Write(letter + " | "));
                    taskA.Wait();
                    letter++;

                    Task taskB = Task.Factory.StartNew(() => Console.WriteLine(letter));
                    taskB.Wait();
                    letter++;
                }
            }

            private void addLetterToAlphabet()
            {
                for (char letter = 'a'; letter <= 'z'; letter++)
                {
                    alphabet.Add(letter);
             
                }
                
            }

            private void printAlphabetTaskA()
            {
                foreach (char a in alphabet)
                {
                    if (!addedLetters.ContainsKey(a)) {
                        if (addedLetters.TryAdd(a, true)) { 
                        
                            Console.Write(a + " | ");
                            
                        }
                        
                    }

                }
            }

            private void printAlphabetTaskB()
            {
                foreach (char a in alphabet)
                {
                    if (!addedLetters.ContainsKey(a))
                    {
                        if (addedLetters.TryAdd(a, true)) { 
                        
                            Console.WriteLine(a);
                            
                        }
                       
                    }

                }
            }

            private void printAlphabetTask()
            {
                foreach (char a in alphabet)
                {
                    /*if (Task.CurrentId == taskAID)
                    {
                        Console.Write("taskAId " + taskAID + " " + a + " | ");
                    }
                    else { 
                    
                        Console.WriteLine("taskBId " + taskBID + " " + a);
                    }
                    //taskB.Wait();*/

                    Task taskA = Task.Factory.StartNew(() => Console.Write(a + " | "));

                    taskA.Wait();
                    
                    Task taskB = Task.Factory.StartNew(() => Console.WriteLine(a));
                }
            }
        }
    }
}
