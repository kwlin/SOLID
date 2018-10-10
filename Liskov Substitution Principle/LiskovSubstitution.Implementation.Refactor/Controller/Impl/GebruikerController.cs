using LiskovSubstitution.Implementation.Refactor.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace LiskovSubstitution.Implementation.Refactor.Controller.Impl
{
    public class GebruikerController : IGebruikerController
    {
        public string GetGebruikerNaam(IkHebEenNaam gebruiker)
        {
            return gebruiker.GetNaam();
        }
    }
}
