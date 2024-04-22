using System;

namespace FlightReservation
{
    public class BookingManager
    {
        private Booking[] bookingList;
        private int numBookings;
        private int maxBookings;
        public BookingManager()
        {
            maxBookings = 100;
            numBookings = 0;
            bookingList = new Booking[maxBookings];
        }
        public void makeBooking(Customer customer, Flight flight)
        {
            if (flight.addCustomer(customer))
            {
                int bookingNum = numBookings + 1;
                bookingList[numBookings] = new Booking(customer, flight);
                numBookings++;
                Console.WriteLine("\nFlight is booked now!!! \nBooking number is: " +bookingNum);
            }else
            {
                Console.WriteLine("The flight is full!!!\n");
            }
        }
        public void makeBooking(Customer customer, Flight flight, string bookingDate)
        {
            if (flight.addCustomer(customer))
            {
                int bookingNum = numBookings + 1;
                bookingList[numBookings] = new Booking(customer, flight);
                bookingList[numBookings].setBookingDate(bookingDate);
                numBookings++;
                Console.WriteLine("\nFlight is booked now!!! \nBooking number is: " + bookingNum);
            }
            else
            {
                Console.WriteLine("The flight is full!!!\n");
            }
        }
        public Booking GetBooking(int bookingId)
        {
            Booking temp = null;
            for (int i = 0; i < numBookings; i++)
            {
                if (bookingId <= numBookings && bookingId > 0)
                {
                    int booking = bookingList[i].getBookingId();
                    if (booking == bookingId)
                    {
                        temp = bookingList[i];
                    }
                }
            } return temp;
        }
        public Booking[] GetAllBookings()
        {
            Booking[] allBookings = new Booking[numBookings];
            for (int i = 0; i < numBookings; i++)
            {
                allBookings[i] = bookingList[i];
            }
            return allBookings;
        }
        public string viewAllBookings()
        {
            string y = "\n------ Bookings List ------";
            for (int i = 0; i < numBookings; i++)
            {
                y += bookingList[i].toString();
            }
            return y;
        }
    }
}
