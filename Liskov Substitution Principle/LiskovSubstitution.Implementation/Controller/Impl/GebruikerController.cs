using LiskovSubstitution.Implementation.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace LiskovSubstitution.Implementation.Controller.Impl
{
    public class GebruikerController : IGebruikerController
    {
        public string GetGebruikerNaam(GebruikerBase gebruiker)
        {
            switch (gebruiker)
            {
                case SysteemGebruiker sg:
                    throw new NotSupportedException();
                case Gebruiker g:
                    return g.Naam;
                default:
                    throw new NotImplementedException();
            }
        }
        
        /// <summary>
        /// Refactorslag 1
        /// </summary>
        /// <param name="gebruiker"></param>
        /// <returns></returns>
        public string GetGebruikerNaam2(GebruikerBase gebruiker)
        {
            return gebruiker.GetName();
        }
    }
}
