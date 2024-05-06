using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_1
{
    /*
     * Нужно сделать так чтобы все классы были в разных файлах.
     * В главных классах не должно быть WriteLine и ReadLine!!!!!
     */
    public class HousingService
    {
        private static HousingService instance = null;
        private string infoRegion;
        private int numberOfHousingService;
        private int numberOfResidents;
        private int numberOfPaid;
        private Rate rate;

        public static HousingService getInstance()
        {
            if (instance == null)
            {
                instance = new HousingService();
            }
            return instance;
        }
        public string InfoRegion
        { 
            get { return infoRegion; }
            set { infoRegion = value; }
        }
        public int NumberOfHousingService
        { 
            get { return numberOfHousingService; }
            set { numberOfHousingService = value; }
        }
        public int NumberOfResidents
        {
            get { return numberOfResidents; }
            set { numberOfResidents = value; }
        }
        public int NumberOfPaid
        {
            get { return numberOfPaid; }
            set { numberOfPaid = value; }

        }
        public double RateGet()
        {
            return rate.PaymentPerMonth;
        }
        public void RateSet(double paymentPerMonth) 
        {
            rate = new Rate();
            rate.PaymentPerMonth = paymentPerMonth;
        }
        public void RateIncr(double increasingValue)
        {
            rate.IncreasePaymentPerMonth(increasingValue) ;
        }
        public void RateDegr(double degreesingValue)
        {
            rate.DegreesPaymentPerMonth(degreesingValue);
        }
        public double TotalDebtOfResidents()
        {
            int notPaid;
            notPaid = NumberOfResidents - NumberOfPaid;
            return notPaid * rate.PaymentPerMonth;
        }
    }
}
