using Implementation.Controller;
using Implementation.Controller.Impl;
using Implementation.Crosscutting.Logging.Impl;
using Implementation.Entities;
using System;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            new GebruikerController(new Logger())
                .AddGebruiker(new Gebruiker());
        }
    }
}
