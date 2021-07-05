using System;
using System.Collections.Generic;
using System.Text;

namespace stategy_pattern
{
    public class NagadPaymentStrategy : IPaymentStrategy
    {
        public void pay()
        {
            Console.WriteLine("Successfully paid with nagad");
        }
    }
}
