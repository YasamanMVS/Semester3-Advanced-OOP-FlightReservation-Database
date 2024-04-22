using System;

namespace FlightReservation
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int option = 0;
            CustomerManager cm = new CustomerManager();
            FlightManager fm = new FlightManager();
            BookingManager bm = new BookingManager();
            database.checkFile();
            database.loadAllData(cm, fm, bm);


            while (option != 4)
            {
                Console.WriteLine("XYZ AirLines Limited.");
                Console.WriteLine("Please select a choice from the menu below: \n");
                Console.WriteLine("1: Customers");
                Console.WriteLine("2: Flights");
                Console.WriteLine("3: Bookings");
                Console.WriteLine("4: Exit");
                option = Convert.ToInt32(Console.ReadLine());


                switch (option)
                {
                    case 1:
                        int customerOption = 0;
                        while (customerOption != 4)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("XYZ AirLines Limited.");
                            Console.WriteLine(" Customer Menu");
                            Console.WriteLine("Please select a choice from the menu below: \n");
                            Console.WriteLine("1: Add Customer");
                            Console.WriteLine("2: View Customers");
                            Console.WriteLine("3: Delete Customer");
                            Console.WriteLine("4: Back to main menu");

                            customerOption = Convert.ToInt32(Console.ReadLine());
                            if (customerOption == 1) // Add a new Customer
                            {
                                Console.Write("Enter customer first name: ");
                                string firstName = Console.ReadLine();

                                Console.Write("Enter customer last name: ");
                                string lastName = Console.ReadLine();

                                Console.Write("Enter customer phone number: ");
                                string phone = Console.ReadLine();

                                Console.Write("Enter customer email address: ");
                                string email = Console.ReadLine();

                                cm.addCustomer(firstName, lastName, phone, email, 0);
                            }
                            if (customerOption == 2) // View all Customers
                            {
                                Console.Write(cm.viewAllCustomers());
                            }
                            if (customerOption == 3) // Delete a Customer
                            {
                                Console.Write("Enter ID of customer to be deleted: ");
                                int cDelete = Convert.ToInt32(Console.ReadLine());
                                cm.deleteCustomer(cDelete);
                            }
                        }
                        break;
                    case 2:
                        int flightOption = 0;
                        while (flightOption != 5)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("XYZ AirLines Limited.");
                            Console.WriteLine(" Flight Menu");
                            Console.WriteLine("Please select a choice from the menu below: \n");
                            Console.WriteLine("1: Add Flight");
                            Console.WriteLine("2: View Flights");
                            Console.WriteLine("3: View a particular Flight");
                            Console.WriteLine("4: Delete Flight");
                            Console.WriteLine("5: Back to main menu");

                            flightOption = Convert.ToInt32(Console.ReadLine());
                            if (flightOption == 1) // Add a new Flight
                            {
                                Console.Write("Enter the origin: ");
                                string origin = Console.ReadLine();

                                Console.Write("Enter the destination: ");
                                string destination = Console.ReadLine();

                                Console.Write("Enter the number of seats: ");
                                int seats = Convert.ToInt32(Console.ReadLine());

                                fm.addFlight(origin, destination, seats);
                            }
                            else if (flightOption == 2) // View all Flights
                            {
                                Console.WriteLine(fm.viewAllFlights());
                            }
                            else if (flightOption == 3) // View a particular Flight
                            {
                                Console.WriteLine("Enter the Flight Number you are looking for: ");
                                int flightNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine(fm.viewFlight(flightNumber));
                            }
                            else if (flightOption == 4) // Delete a Flight
                            {
                                Console.WriteLine("Enter the flight number to be deleted: ");
                                int fDelete = Convert.ToInt32(Console.ReadLine());
                                fm.deleteFlight(fDelete);
                            }
                        }
                        break;

                    case 3:
                        int bookingOption = 0;
                        while (bookingOption != 3)
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("XYZ AirLines Limited.");
                            Console.WriteLine(" Booking Menu");
                            Console.WriteLine("Please select a choice from the menu below: \n");
                            Console.WriteLine("1: Make Booking");
                            Console.WriteLine("2: View Bookings");
                            Console.WriteLine("3: Back to main menu");
                            bookingOption = Convert.ToInt32(Console.ReadLine());

                            if (bookingOption == 1)
                            {
                                Console.WriteLine(cm.viewAllCustomers());
                                Console.WriteLine(fm.viewAllFlights());
                                Console.Write("\nEnter Customer ID: ");
                                int customerID = Convert.ToInt32(Console.ReadLine());

                                Console.Write("\nEnter Flight Number: ");
                                int flightNumber = Convert.ToInt32(Console.ReadLine());

                                Customer c = cm.GetCustomer(customerID);
                                Flight f = fm.getFlight(flightNumber);
                                string date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");

                                if (c != null && f != null)
                                {
                                    bm.makeBooking(c, f);
                                }
                                else
                                {
                                    if (c == null)
                                    {
                                        Console.WriteLine("Customer does NOT exist!!!");
                                    }
                                    if (f == null)
                                    {
                                        Console.WriteLine("Flight does NOT exist!!!");
                                    }
                                }
                            }
                            if (bookingOption == 2)
                            {
                                Console.WriteLine(bm.viewAllBookings());
                            }
                        }
                        break;
                }
                database.saveAllData(cm.GetAllCustomers(), fm.GetAllFlights(), bm.GetAllBookings());
            }
            
            
        }
    }
}
