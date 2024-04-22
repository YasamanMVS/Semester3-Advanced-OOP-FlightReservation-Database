using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    public class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int seatNumber;
        private Customer[] passenger;
        public Flight(int flightNumber, string origin, string destination, int seatNumber)
        {
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.seatNumber = seatNumber;
            passenger = new Customer[seatNumber];
        }
        public bool addCustomer(Customer customer)
        {
            for(int i = 0; i < passenger.Length; i++)
            {
                if (passenger[i] == null)
                {
                    passenger[i] = customer;
                    customer.setBookingNum();
                    return true;
                }
            }
            return false;
        }
        public virtual int getFlightNumber()
        {
            return flightNumber;
        }
        public void setFlightNumber(int flightNumber)
        {
            this.flightNumber = flightNumber;
        }
        public string getOrigin()
        {
            return origin;
        }
        public string getDestination()
        {
            return destination;
        }
        public int getSeatNumber()
        {
            return seatNumber;
        }
        public virtual string toString()
        {
            string y = "-------- Flights List --------";
            y += "\nFlight Number: " + flightNumber;
            y += "\nFrom: " + origin;
            y += "\nTo: " + destination;
            y += "\n" + seatNumber + " Seats\n";
            //for (int i = 0; i < passenger.Length; i++)
            //{
            //    if (passenger[i] != null)
            //    {
            //        y += "\n " + passenger[i].getFirstName() + " " + passenger[i].getLastName();
            //    }
            //}

            //y += "\n Passengers: " + y + "\n";
            return y;
        }
    }
}
