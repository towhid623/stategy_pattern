using System;

namespace stategy_pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter payment method: ");
                PaymentContext paymentContext = new PaymentContext();
                switch (Console.ReadLine())
                {
                    case "bkash":
                        paymentContext.setStrategy(new BkashPaymentStrategy());
                        break;
                    case "nagad":
                        paymentContext.setStrategy(new NagadPaymentStrategy());
                        break;
                    default:
                        break;
                }
                paymentContext.ExecuteStrategy();
            }
            catch (Exception e)
            {
                Console.WriteLine("Payment failed!");
            }

        }
    }
}
