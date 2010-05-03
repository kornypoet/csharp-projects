using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Asg01
{
    interface IPayable
    {
        decimal AmountDue { get; set; }
        string PaymentAddress { get; }
        void AmountDueIncrease( decimal increaseBy );
    }
}
