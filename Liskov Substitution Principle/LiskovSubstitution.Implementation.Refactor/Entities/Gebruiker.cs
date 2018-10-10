using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Implementation.Refactor.Entities
{
    public class Gebruiker : GebruikerBase, IkHebEenNaam
    {
        public string Naam { get; set; }

        public string GetNaam()
        {
            return Naam;
        }
    }

}
