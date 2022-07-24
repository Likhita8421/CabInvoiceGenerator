using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice_Generator
{
    public class MultipleRides
    {
        public Dictionary<string, List<Ride>> repo = new Dictionary<string, List<Ride>>();
        public List<Ride> list = new List<Ride>();
        InvoiceGenerator generate = new InvoiceGenerator();
        double fare = 0;
        public void getDetails()
        {
            Ride ride = new Ride();
            list = new List<Ride>();
            Console.WriteLine("Which ride you want to take:\n1.Noramal Ride\n2.Premium Ride");
            int rideType = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Distance(KM):");
            ride.distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time(Min):");
            ride.time = Convert.ToDouble(Console.ReadLine());
            switch (rideType)
            {
                case 1:
                    ride.Fare = generate.calculateNormalFare(ride.distance, ride.time);
                    break;
                case 2:
                    ride.Fare = generate.calculatePremiumFare(ride.distance, ride.time);
                    break;
            }
            list.Add(ride);
        }
        public void MultipleFare()
        {
            Console.WriteLine("How many rides you want to take:");
            int noOfRides = Convert.ToInt32(Console.ReadLine());
            while (noOfRides != 0)
            {
                Console.WriteLine("Enter User ID:");
                string userID = Console.ReadLine();
                getDetails();
                repo.Add(userID, list.ToList());

                noOfRides--;
            }
        }
        public void showInvoice()
        {
            Console.WriteLine("Enter user ID to view invoice:");
            string userID = Console.ReadLine();
            List<Ride> newList = repo[userID];
            foreach (var item in newList)
            {
                Console.WriteLine("--------------Invoice-------------\nDistance of Journey:" + item.distance + " KM\nTime of Journey:" + item.time + " Min\nTotal Fare of Ride:" + item.Fare + " Rs");
            }
        }
    }
}
