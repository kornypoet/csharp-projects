using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Asg05
{
    class Program
    {
        public static void Main()
        {
            Schedule theSchedule = new Schedule();

            Patient[] patientGroup = Patient.Populate();

            Thread[] threadGroup = new Thread[20];

            int[] randomGroup = GenerateRandomArray(20, 20);

            for (int i = 0; i < threadGroup.Length; i++)
            {
                patientGroup[i].Times = theSchedule;
                threadGroup[i] = new Thread(patientGroup[i].MakeAppointment);               
            }

            for (int i = 0; i < threadGroup.Length; i++)
            {
                threadGroup[randomGroup[i]].Start();
                threadGroup[randomGroup[i]].Join();
            }

            Console.WriteLine("Press any key to end...");
            Console.ReadKey();
        }

        public static int[] GenerateRandomArray(int range, int quantity)
        {
            int[] a = new int[quantity];
            Random randomNumber = new Random();
            HashSet<int> used = new HashSet<int>();
            for (int n = 0; n < quantity; n++)
            {
                int r = randomNumber.Next(range);
                while (!used.Add(r))
                    r = randomNumber.Next(range);
                a[n] = r;
            }
            return a;
        }
    }
}

