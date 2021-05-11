using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ZooPark.Species;

namespace ZooPark
{
    class Program
    {
        static void Main(string[] args)
        {


            // zoo = lukket fra kl 20pm til 10pm hvor ingen besøgende er (14 timer lukket - 10 timer åbent)

            Console.WriteLine("Welcome to ZooPark!");

            // arrays and list over the many animals and the capacity of visiters
            Giraf[] girafs = new Giraf[12];
            Elephant[] elephants = new Elephant[6];
            FoxAndWolf[] foxAndWolf = new FoxAndWolf[40];
            List<Bunny> bunnyList = new List<Bunny>();
            Worker[] workers = new Worker[2];
            List<Visiter> visiters = new List<Visiter>(3200);

            
            // Creating the threads

            Thread threadGiraf = new Thread(() => GirafMethod(girafs));
            Thread threadElephant = new Thread(() => ElephantMethod(elephants));
            Thread threadFoxAndWolf = new Thread(() => FoxAndWolfMethod(foxAndWolf));
            Thread threadBunny = new Thread(() => BunnyStuffMethod(bunnyList));

            Thread threadWorker = new Thread(() => WorkerStuff(workers));
            Thread threadvisiters = new Thread(() => VisiterStuff(workers));

            // creating the priority of the threads as some cages are in higher need than others
            threadGiraf.Priority = ThreadPriority.Highest;
            threadElephant.Priority = ThreadPriority.AboveNormal;
            threadFoxAndWolf.Priority = ThreadPriority.BelowNormal;
            threadBunny.Priority = ThreadPriority.Lowest;

            threadWorker.Priority = ThreadPriority.Normal;
            threadWorker.Priority = ThreadPriority.Normal;

            // Starting the threads
            threadWorker.Start();
            threadGiraf.Start();
            threadElephant.Start();
            threadFoxAndWolf.Start();
            threadBunny.Start();

            Console.ReadLine();


        }

            static void GirafMethod(Object obj)
            {
                // i wanted to use the one in the giraf class but i paniced last mins 
            }
    
    }
}
