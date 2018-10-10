using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Implementation.Controller
{
    public interface IGebruikerRepository
    {
        string AddGebruiker(Gebruiker gebruiker);

        string DeleteGebruiker(long gebruikerId);

        string UpdateGebruiker(long gebruikerId, Gebruiker gebruiker);

        string GetGebruiker(long gebruikerId);
    }
}
