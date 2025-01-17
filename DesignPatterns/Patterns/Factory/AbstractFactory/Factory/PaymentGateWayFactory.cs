using DesignPatterns.Patterns.Factory.AbstractFactory.Classes;
using DesignPatterns.Patterns.Factory.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Factory.AbstractFactory.Factory
{
    public static class PaymentGateWayFactory
    {
        public static IPaymentGateway CreatePaymentGateway(string gatewayName)
        {
            switch (gatewayName.ToLower()) 
            {
                case "paypal":
                    return new PayPalGateway();

                case "stripe":
                    return new StripeGateway();

                case "creditcard":
                    return new CreditCardGateway();
                default:
                    throw new ArgumentException("Invalid payment request");
            }
        }
    }
}
