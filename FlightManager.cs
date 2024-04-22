using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    public class FlightManager
    {
        private Flight[] flightList;
        private int numFlights;
        private int maxFlights;
        public FlightManager()
        {
            numFlights = 0;
            maxFlights = 100;
            flightList = new Flight[maxFlights];
        }
        public void addFlight(string origin, string destination, int seatNumber)
        {
            if (numFlights < maxFlights)
            {
                int flightNumber = numFlights + 1;
                flightList[numFlights] = new Flight(flightNumber, origin, destination, seatNumber);
                numFlights++;
                Console.WriteLine("Flight with flight Number: " + flightNumber + " added!");
            }
        }
        public void addFlight(string origin, string destination, int seatNumber, int flightNumber)
        {
            if (numFlights < maxFlights)
            {
                int flightNum = numFlights + 1;
                flightList[numFlights] = new Flight(flightNum, origin, destination, seatNumber);
                flightList[numFlights].setFlightNumber(flightNumber);
                numFlights++;
                Console.WriteLine("Flight with flight Number: " + flightNumber + " added!");
            }
        }
        public string viewFlight(int flightNumber)
        {
            string y = "-------- Flight --------";
            for(int i = 0; i < numFlights; i++)
            {
                int flight = flightList[i].getFlightNumber();
                if (flight == flightNumber)
                {
                    y = flightList[i].ToString();
                }
            }return y;
        }
        public Flight getFlight(int flightNumber)
        {
            Flight temp = null;
            for (int i = 0; i < numFlights; i++)
            {
                if (flightNumber <= numFlights && flightNumber > 0)
                {
                    int flight = flightList[i].getFlightNumber();
                    if (flight == flightNumber)
                    {
                        temp = flightList[i];
                    }
                }
            }return temp;
        }
        public int searchForSeat(int flightNumber)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flightNumber == flightList[i].getFlightNumber())
                {
                    return i;
                }
            }return -1;
        }
        public bool deleteFlight(int flightNumber)
        {
            int result = searchForSeat(flightNumber);
            if (result == -1)
            {
                return false;
            }else
            {
                Flight temp = flightList[numFlights - 1];
                flightList[numFlights - 1] = flightList[result];
                flightList[result] = temp;
                numFlights--;
                Console.WriteLine("Flight deleted!!!");
            }return true;
        }
        public Flight[] GetAllFlights()
        {
            Flight[] allFlights = new Flight[numFlights];
            for (int i = 0; i < numFlights; i++)
            {
                allFlights[i] = flightList[i];
            }
            return allFlights;
        }
        public string viewAllFlights()
        {
            string y = "\n";
            for(int i = 0; i < numFlights; i++)
            {
                y += flightList[i].toString() + "\n";
            }return y;
        }
    }
}
