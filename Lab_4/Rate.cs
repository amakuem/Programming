using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{

    class Rate
    {
        private double paymentPerMonth;
        public double PaymentPerMonth
        {
            get { return paymentPerMonth; }
            set { paymentPerMonth = value; }
        }
        public void IncreasePaymentPerMonth(double increasingValue)
        {
            paymentPerMonth += increasingValue;
        }
        public void DegreesPaymentPerMonth(double degreesingValue)
        {
            paymentPerMonth -= degreesingValue;
        }
    }
}
