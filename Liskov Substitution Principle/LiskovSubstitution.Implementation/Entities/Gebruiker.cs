using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Implementation.Entities
{
    public class Gebruiker : GebruikerBase
    {
        public string Naam { get; set; }

        /// <summary>
        /// Refactorslag 1
        /// </summary>
        /// <returns></returns>
        public override string GetName()
        {
            return Naam;
        }
    }
}
