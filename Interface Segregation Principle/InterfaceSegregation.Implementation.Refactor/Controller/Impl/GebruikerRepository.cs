using Common.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace InterfaceSegregation.Implementation.Refactor.Controller.Impl
{
    public class GebruikerRepository : IGebruikerOpvragenRepository, IGebruikerWijzigenRepository
    {
        public string AddGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public string DeleteGebruiker(long gebruikerId)
        {
            throw new NotImplementedException();
        }

        public string GetGebruiker(long gebruikerId)
        {
            throw new NotImplementedException();
        }

        public string UpdateGebruiker(long gebruikerId, Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }
    }
}
