using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace LiskovSubstitution.Implementation.Refactor.Entities
{

    public abstract class GebruikerBase
    {
        public long Id { get; set; }

        public SecureString Wachtwoord { get; set; }
    }
}

