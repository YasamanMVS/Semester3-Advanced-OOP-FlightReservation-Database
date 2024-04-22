using System;

namespace FlightReservation
{
    public class Customer
    {
        private int customerID;
        private string customerFirstName;
        private string customerLastName;
        private string customerPhoneNumber;
        private string customerEmail;
        private int bookingNumber;
        public Customer(int customerID, string customerFirstName, string customerLastName, string customerPhoneNumber, string customerEmail, int bookingNumber)
        {
            this.customerID = customerID;
            this.customerFirstName = customerFirstName;
            this.customerLastName = customerLastName;
            this.customerPhoneNumber = customerPhoneNumber;
            this.customerEmail = customerEmail;
            this.bookingNumber = bookingNumber;
        }
        public int getCustomerID() { return customerID; }
        public virtual string getFirstName() { return customerFirstName; }
        public virtual string getLastName() { return customerLastName; }
        public virtual string getPhoneNum() { return customerPhoneNumber; }
        public virtual string getEmail() { return customerEmail; }
        public virtual int getBookingNum() { return bookingNumber; }
        public virtual int setBookingNum() { bookingNumber = bookingNumber + 1; return bookingNumber; }
        public virtual string toString()
        {
            String y = "\n";
            y += "\nID: " + customerID;
            y += "\nName: " + customerFirstName + " " + customerLastName;
            y += "\nPhone Number: " + customerPhoneNumber;
            y += "\nEmail: " + customerEmail;
            y += "\nBooking Number: " + bookingNumber;
            return y;
        }
    }
   
}
