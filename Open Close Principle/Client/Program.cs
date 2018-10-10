using Common.Crosscutting.Logging.Impl;
using Common.Entities;
using OpenClose.Implementation.Controller;
using OpenClose.Implementation.Controller.Impl;
using System;

namespace OpenClose.Client
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
