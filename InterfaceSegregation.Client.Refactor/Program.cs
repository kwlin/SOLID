using InterfaceSegregation.Implementation.Refactor.Controller;
using InterfaceSegregation.Implementation.Refactor.Controller.Impl;
using System;

namespace InterfaceSegregation.Client.Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            IGebruikerOpvragenRepository gebruikerOpvragenRepository = new GebruikerRepository();

            gebruikerOpvragenRepository.GetGebruiker(1);
        }
    }
}
