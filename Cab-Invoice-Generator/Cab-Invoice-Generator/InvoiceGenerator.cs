using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class InvoiceGenerator
    {
        double Fare;
        public double calculateNormalFare(double distance, double time)
        {
            int COST_PER_KM = 10, COST_PER_MIN = 1, MIN_FARE = 5;
            try
            {
                Fare = (COST_PER_KM * distance) + (COST_PER_MIN * time);
            }
            catch(ExceptionHandler)
            {
                if (distance <= 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_DISTAANCE, "Invalid Distance");
                if (time < 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(Fare, MIN_FARE);
        }
        public double calculatePremiumFare(double distance, double time)
        {
            int COST_PER_KM = 15, COST_PER_MIN = 2, MIN_FARE = 20;
            try
            {
                Fare = (COST_PER_KM * distance) + (COST_PER_MIN * time);
            }
            catch (ExceptionHandler)
            {
                if (distance <= 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_DISTAANCE, "Invalid Distance");
                if (time < 0)
                    throw new ExceptionHandler(ExceptionHandler.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(Fare, MIN_FARE);
        }
    }
}
