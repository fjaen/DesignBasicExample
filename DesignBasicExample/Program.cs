// See https://aka.ms/new-console-template for more information
using DesignBasicExample.Entities;

Console.WriteLine("Example creating objects!");
Person crew = new Person("C/Antonio Machado 3-13","12345678A","Javier Jaen");
Flight flight=new Flight(DateTime.Now,"32231",crew);
crew.Flights_Crew.Add(flight);
Person passenger = new Person("Av. Dionisio Guardiloa, 23-4", "23456789B", "Lara Croft");
Seat seat=new Seat("3A",flight,passenger);
passenger.SeatsasPassenger.Add(seat);
flight.Seats.Add(seat);

