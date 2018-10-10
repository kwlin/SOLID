using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace LiskovSubstitution.Implementation.Entities
{
    public abstract class GebruikerBase
    {
        public long Id { get; set; }

        public SecureString Wachtwoord { get; set; }
        
        /// <summary>
        /// Refactorslag 1
        /// </summary>
        /// <returns></returns>
        public abstract string GetName();
    }
}

