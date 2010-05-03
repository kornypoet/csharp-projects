using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Asg05
{
    class Patient
    {
        public string Name { get; set; }
        
        public Appointment IsScheduledFor;

        public Schedule Times;

        public Patient(string name)
        {
            Name = name;
            IsScheduledFor = null;
        }

        public void MakeAppointment()
        {
            Monitor.Enter(Times);

            List<Appointment> timesLeft = Times.CheckForOpenAppointments();

            if (timesLeft.Count > 0)
            {
                timesLeft[0].FilledWith = this;
                this.IsScheduledFor = timesLeft[0];
                Console.Write("{0} is filled by...", this.IsScheduledFor.TimeSlot);
                Thread.Sleep(600);
                Console.WriteLine("{0}!", this.Name);
            }          
            
            Monitor.Exit(Times);
        }
                
        public static Patient[] Populate()
        {
            Patient[] people = new Patient[20];

            people[0] = new Patient("Anne");
            people[1] = new Patient("Bob");
            people[2] = new Patient("Claire");
            people[3] = new Patient("David");
            people[4] = new Patient("Erin");
            people[5] = new Patient("Frank");
            people[6] = new Patient("Gail"); 
            people[7] = new Patient("Harold");
            people[8] = new Patient("Irene");
            people[9] = new Patient("Joe");
            people[10] = new Patient("Karen"); 
            people[11] = new Patient("Lance");
            people[12] = new Patient("Mary");
            people[13] = new Patient("Nick");
            people[14] = new Patient("Olivia");
            people[15] = new Patient("Peter");
            people[16] = new Patient("Rachel");
            people[17] = new Patient("Steve");
            people[18] = new Patient("Tara");
            people[19] = new Patient("Uriah");

            return people;
        }
    }
}
