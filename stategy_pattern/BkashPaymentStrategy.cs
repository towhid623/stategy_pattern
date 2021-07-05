using System;
using System.Collections.Generic;
using System.Text;

namespace stategy_pattern
{
    public class BkashPaymentStrategy : IPaymentStrategy
    {
        public void pay()
        {
            Console.WriteLine("Successfully paid with bkash");
        }
    }
}
