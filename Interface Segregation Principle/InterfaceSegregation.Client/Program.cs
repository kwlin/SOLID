using InterfaceSegregation.Implementation.Controller;
using InterfaceSegregation.Implementation.Controller.Impl;
using System;

namespace InterfaceSegregation.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            IGebruikerRepository gebruikerRepository = new GebruikerRepository();

            var gebruiker = gebruikerRepository.GetGebruiker(1);
        }
    }
}
