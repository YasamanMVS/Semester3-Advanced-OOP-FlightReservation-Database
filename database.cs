using System;
using System.IO;

namespace FlightReservation
{
    public static class database
    {
        private const string FileName = "database.txt";
        //check if the database file exists, if  not create it
        public static void checkFile()
        {
            if (!File.Exists(FileName))
            {
                File.Create(FileName);
            }
        }

        public static void saveAllData(Customer[] customer, Flight[] flights, Booking[] bookings)
        {
            // save data from customer manager, flight manager and booking manager to database
            StreamWriter sw = new StreamWriter(FileName);
            for (int i = 0; i < customer.Length; i++)
            {
                sw.WriteLine(customer[i].getCustomerID() + "," + customer[i].getFirstName() + "," + customer[i].getLastName() + "," + customer[i].getPhoneNum() + "," + customer[i].getEmail() + "," + customer[i].getBookingNum());
            }
            for (int i = 0; i < flights.Length; i++)
            {
                sw.WriteLine(flights[i].getFlightNumber() + "," + flights[i].getOrigin() + "," + flights[i].getDestination() + "," + flights[i].getSeatNumber());
            }
            for (int i = 0; i < bookings.Length; i++)
            {
                sw.WriteLine(bookings[i].getBookingDate() + "," + bookings[i].getCustomerId() + "," + bookings[i].getFlightId());
            }
            sw.Close();
        }

        // take data from database and store it in customer manager, flight manager and booking manager
        public static void loadAllData(CustomerManager customerManager, FlightManager flightManager, BookingManager bookingManager)
        {
            StreamReader sr = new StreamReader(FileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] data = line.Split(',');

                if (data.Length == 6)
                {
                    int customerID = int.Parse(data[0]);
                    string customerFirstName = data[1];
                    string customerLastName = data[2];
                    string customerPhoneNumber = data[3];
                    string customerEmail = data[4];
                    int bookingNumber = int.Parse(data[5]);
                    customerManager.addCustomer(customerFirstName, customerLastName, customerPhoneNumber, customerEmail, bookingNumber, customerID);
                }
                else if (data.Length == 4)
                {
                    int flightNumber = int.Parse(data[0]);
                    string origin = data[1];
                    string destination = data[2];
                    int seatNumber = int.Parse(data[3]);
                    flightManager.addFlight(origin, destination, seatNumber, flightNumber);
                }
                else if (data.Length == 3)
                {
                    string bookingDate = data[0];
                    int customerId = int.Parse(data[1]);
                    int flightId = int.Parse(data[2]);
                    Customer customer = customerManager.GetCustomer(customerId);
                    Flight flight = flightManager.getFlight(flightId);
                    bookingManager.makeBooking(customer, flight, bookingDate);
                }
            }
            sr.Close();
        }

    }
}