using Common.Crosscutting.Logging.Impl;
using Common.Entities;
using OpenClose.Implementation.Refactor.Controller.Impl;
using System;

namespace OpenClose.Client.Refactor
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
        }
    }
}
