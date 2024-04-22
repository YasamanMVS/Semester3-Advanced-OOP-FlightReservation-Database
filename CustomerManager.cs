using System;

namespace FlightReservation
{
    public class CustomerManager
    {
        private int numCustomers;
        private int maxCustomers;
        private Customer[] customerList;
        public CustomerManager()
        {
            numCustomers = 0;
            maxCustomers = 100;
            customerList = new Customer[maxCustomers];
        }
        public void addCustomer(string customerFirstName, string customerLastName, string customerPhoneNumber, string customerEmail, int bookingNumber)
        {
            if(numCustomers < maxCustomers)
            {
                int customerID = numCustomers + 1;
                Customer temp = new Customer(customerID, customerFirstName, customerLastName, customerPhoneNumber, customerEmail, bookingNumber);
                customerList[numCustomers] = temp;
                numCustomers++;
                Console.WriteLine("New customer with customer ID: " + customerID + "  added!");
            }
        }
        public void addCustomer(string customerFirstName, string customerLastName, string customerPhoneNumber, string customerEmail, int bookingNumber, int customerID)
        {
            if (numCustomers < maxCustomers)
            {
                Customer temp = new Customer(customerID, customerFirstName, customerLastName, customerPhoneNumber, customerEmail, bookingNumber);
                customerList[numCustomers] = temp;
                numCustomers++;
                Console.WriteLine("New customer with customer ID: " + customerID + "  added!");
            }
        }

        public int searchSeat(int customerID)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerID == customerList[i].getCustomerID())
                {
                    return i;
                }
            }
            return -1;
        }
        public bool deleteCustomer(int customerID)
        {
            int result = searchSeat(customerID);
            if (result == -1)
            {
                return false;
            }else
            {
                Customer temp = customerList[numCustomers - 1];
                customerList[numCustomers - 1] = customerList[result];
                customerList[result] = temp;
                numCustomers--;
                Console.WriteLine("Customer is deleted!");
            }
            return true;
        }
        public Customer GetCustomer(int customerID)
        {
            Customer temp = null;
            for (int i = 0; i < numCustomers; i++)
            {
                if (customerID <= numCustomers && customerID > 0)
                {
                    int customer = customerList[i].getCustomerID();
                    if (customer == customerID)
                    {
                        temp = customerList[i];
                    }
                }
            } return temp;
        }
        public Customer[] GetAllCustomers()
        {
            Customer[] allCustomers = new Customer[numCustomers];
            for (int i = 0; i < numCustomers; i++)
            {
                allCustomers[i] = customerList[i];
            }
            return allCustomers;
        }
        public string viewAllCustomers()
        {
            string y = "-------- Customers List --------";
            for (int i = 0; i < numCustomers; i++)
            {
                y += customerList[i].toString();
            }return y;
        }

        
    }
}
