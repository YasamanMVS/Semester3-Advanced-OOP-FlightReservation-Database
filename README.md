# Flight Reservation System

## Description:
The Flight Reservation System is a software application designed to manage flight bookings, customer details, and flight information. It allows users to add and manage customers and flights, make bookings, and handle related operations through a simple console interface.

## Features:
- **Customer Management**: Add, view, and delete customers.
- **Flight Management**: Add, view, delete, and retrieve specific flight details.
- **Booking Management**: Create and view bookings, integrating customer and flight information.

## Project Structure:
- **`Booking.cs`**: Defines the Booking class, encapsulating booking details.
- **`BookingManager.cs`**: Manages all booking operations.
- **`Customer.cs`**: Represents a customer with methods to manage customer details.
- **`CustomerManager.cs`**: Manages all customer-related operations.
- **`Flight.cs`**: Represents a flight and includes methods to manage flight details.
- **`FlightManager.cs`**: Manages all flight operations.
- **`Program.cs`**: The main entry point for the application, providing a user interface for interacting with the system.
- **`database.cs`**: Handles file operations for persisting and retrieving data.

## Installation and Setup:
1. **Prerequisites**: Ensure you have `.NET 5.0 SDK` installed on your system.
2. **Clone the repository**: Download the project files from the repository to your local machine.
3. **Open the project**: Open the `FlightReservation.sln` file in `Visual Studio`.
4. **Build the project**: Compile the project using Visual Studio to ensure all dependencies are correctly set up.
5. **Run the application**: Start the application through Visual Studio to access the functionality via the console interface.

## How to Use:
Navigate through the console menu to access different functionalities:

- Choose `1` for customer operations.
- Choose `2` for flight operations.
- Choose `3` for booking operations.   
Each section has its own submenu to perform specific tasks such as adding, viewing, or deleting records.
