using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZooPark
{
    class OpeningHours
    {
        // Needs to implement a timer 
        private bool zooOpenCloseHour;

        public OpeningHours(bool zooOpenCloseHour)
        {
            ZooOpenCloseHour = zooOpenCloseHour;
        }

        public bool ZooOpenCloseHour { get => zooOpenCloseHour; set => zooOpenCloseHour = value; }
        

        // Figure how much time until 10:00
        DateTime now = DateTime.Now;
        DateTime tenOClock = DateTime.Today.AddHours(10.0);

        public void OpenCloseHours()
        {
           Timer t = new Timer(TimerCallback); // def placed wrongly....

            // If it's already past 10:00, wait until 10:00 tomorrow
            // the if statement needs to work as such : as the time becomes 10 the zoo opens and visiters are welcome, and at 20 closed for visiters
            // this needs to use the timer with an simple bool if 10 am = true, if 20 am = false
            if (now > tenOClock)
            {

            ZooOpenCloseHour = true;
            Console.WriteLine("The zoo is open for visiters");

            tenOClock = tenOClock.AddDays(1.0);
            }
            else
            {
            ZooOpenCloseHour = false;
            Console.WriteLine("The zoo is Closed for visiters ");

            }

            int msUntilFour = (int)((tenOClock - now).TotalMilliseconds);

            // Set the timer to elapse only once, at 4:00.
            t.Change(msUntilFour, Timeout.Infinite);
        }

    }
}

// update?