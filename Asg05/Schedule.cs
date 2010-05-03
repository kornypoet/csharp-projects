using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Asg05
{
    class Schedule
    {
        public Appointment TimeSlot { get; set; }

        public Appointment[] Available = new Appointment[7];

        public Schedule()
        {
            Available[0] = new Appointment("9:00  a.m.");
            Available[1] = new Appointment("10:00 a.m.");
            Available[2] = new Appointment("11:00 a.m.");
            Available[3] = new Appointment("1:00  p.m.");
            Available[4] = new Appointment("2:00  p.m.");
            Available[5] = new Appointment("3:00  p.m.");
            Available[6] = new Appointment("4:00  p.m.");
        }

        public List<Appointment> CheckForOpenAppointments()
        {
            List<Appointment> timesLeft = new List<Appointment>();

            foreach (Appointment a in this.Available)
            {
                if (a.FilledWith == null)
                {
                    timesLeft.Add(a);
                }
            }

            return timesLeft;
        }
    }
}
