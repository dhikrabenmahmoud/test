// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
Flight  f1 = new ();

Plane plane3 = new Plane
{

    ManufactureDate = DateTime.Now,
    Capacity = 100,
    PlaneType = PlaneType.Boing,
    PlaneId = 2
};
FlightMethods sf = new FlightMethods();
sf.Flights = TestData.listFlights;