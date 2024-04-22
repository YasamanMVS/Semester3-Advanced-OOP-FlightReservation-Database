using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    public class Booking
    {
        private Customer customer;
        private Flight flight;
        private int bookingId;
        private string date;
        public Booking(Customer customer, Flight flight)
        {
            this.customer = customer;
            this.flight = flight;
            bookingId = bookingId+1;
            date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
        }
        public int getCustomerId() { return customer.getCustomerID(); }
        public int getFlightId() { return flight.getFlightNumber(); }
        public string getBookingDate() { return date; }
        public int getBookingId() { return bookingId; }
        public void setBookingDate(string date) { this.date = date; }
        public string getDate() { return date; }
        public string toString()
        {
            String y = "\n";
            y += "\nBooking ID: " + bookingId;
            y += "\nCustomer: " + customer.getFirstName();
            y += "\nFlight Number: " + flight.getFlightNumber();
            return y;
        }
    }
}
