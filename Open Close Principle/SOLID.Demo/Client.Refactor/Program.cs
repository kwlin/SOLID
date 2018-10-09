using Implementation.Refactor.Controller.Impl;
using Implementation.Refactor.Crosscutting.Logging.Impl;
using Implementation.Refactor.Entities;
using System;

namespace Client.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Decorator pattern
            var gebruikerController = 
                new LoggingGebruikerController(new Logger(),
                    new GebruikerController());

            gebruikerController.AddGebruiker(new Gebruiker());

            Console.WriteLine("Hello World!");
        }
    }
}
