using System;
using System.Collections.Generic;
using System.Text;

namespace stategy_pattern
{
    public class PaymentContext
    {

        private IPaymentStrategy _paymentStrategy;

        public void setStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ExecuteStrategy()
        {
            _paymentStrategy.pay();
        }
    }
}
