using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg05
{
    class Appointment
    {
        public string TimeSlot { get; set; }

        public Patient FilledWith;

        public Appointment(string time)
        {
            TimeSlot = time;
            FilledWith = null;
        }
    }
}
