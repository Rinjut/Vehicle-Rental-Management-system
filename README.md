**Vehicle Rental Management system
Vehicle Rental Management System demonstrates the object-oriented principles in C#, mainly focusing on inheritance, abstraction, and encapsulation and developing classes to represent vehicles and a rental agency.

Project Structure

The vehicle Rental Management System contains several classes, each defined in separate files:
Vehicle.cs:  This file contains Vehicle class to represent a generic vehicle available for rental and includes properties such as Model, Manufacturer, Year, and RentalPrice. The DisplayDetails() method is used to display the vehicle's details.
Car.cs:  This file contains Car class that inherits from the Vehicle class and includes properties such as Seats, EngineType, Transmission, and Convertible. The DisplayDetails() method is used to display the vehicle's details including both common vehicle properties and car-specific properties.
Truck.cs: This file contains Truck class that inherits from the Vehicle class and includes properties such as Capacity, TruckType, and FourWheelDrive. The DisplayDetails() method is used to display the truck's details, including both common vehicle properties and truck-specific properties.
Motorcycle.cs: This file contains Motorcycle class that inherits from the Vehicle class and includes properties such as EngineCapacity, FuelType, and HasFairing. Also override the DisplayDetails() method to display the motorcycle’s details, including both common vehicle properties and motorcycle-specific properties.
RentalAgency.cs: This file contains RentalAgency class to manage the rental agency's fleet of vehicles and includes property, TotalRevenue to track the total revenue earned by the rental agency. Also added methods to add and remove vehicles from the fleet and rent vehicles. 
Program.cs: This file contains the functionality to create intsanves for vehicle and adding them to RentalAgency

Setup Instructions

Download and install.NET SDK
Create a repository named Vehicle Rental Management System
Build the project and run the project.
Verify the project is running as expected.
Create a git repository named Vehicle Rental Management System.
Commit the code with a valid message and push the code to GitHub.
