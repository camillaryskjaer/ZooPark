using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooPark
{
    class Worker
    {
        // 2 ansatte til at fjerne lort

        //Fields and properties
        public string WorkerName;

        public Worker(string WorkerName)
        {
            this.WorkerName = WorkerName;
        }

        //method that will clean up the poop from the cages

        static int[] shit = new int[5];
        static byte shitCount = 0;
        static int shitPointer = 0;
        static int cleaningPointer = 0;
        static object locker = new object();

        public void RemovePoop()
        {

            Thread producerThread = new Thread(Shitter);
            producerThread.Start();
            Thread consumerThread = new Thread(Cleaner);
            consumerThread.Start();

            Console.Read();
        }

        static void Shitter()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (shit)
                {
                    if (shit[shitPointer].Equals(0) && shitCount < 10)
                    {
                        shit[shitPointer] = 1;
                        shitCount++;
                        Console.WriteLine($"Animal has produced. Antal: {shitCount}. Producer: {shitPointer}. Cleaner: {cleaningPointer}");
                        if (shitPointer == shit.Length - 1)
                        {
                            shitPointer = 0;
                        }
                        else
                        {
                            shitPointer++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Animal hasn't shat.");
                    }
                }
                Thread.Sleep(500);
            }
            Console.WriteLine($"Producer stoppet");
        }

        static void Cleaner()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (shit)
                {
                    if (shit[cleaningPointer].Equals(1) && shitCount >= 0)
                    {
                        shit[cleaningPointer] = 0;
                        shitCount--;

                        // this will return as a cage has been cleaned, it will be printed in program with the "cages" name
                        Console.WriteLine($"Worker has cleaned. Number: {shitCount}. In cage: {shitPointer}. ..: {cleaningPointer}");
                        if (cleaningPointer == shit.Length - 1)
                        {
                            cleaningPointer = 0;
                        }
                        else
                        {
                            cleaningPointer++;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Worker couldn't clean: {shitCount} number of shits. from cage: {shitPointer}. ..: {cleaningPointer}");
                    }
                }
                Thread.Sleep(1000);
            }
            Console.WriteLine($"Worker stopped");
        }
    }
}
