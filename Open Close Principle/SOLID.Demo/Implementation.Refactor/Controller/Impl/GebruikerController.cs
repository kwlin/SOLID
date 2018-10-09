using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;
using Implementation.Refactor.Crosscutting.Logging;
using Implementation.Refactor.Entities;

namespace Implementation.Refactor.Controller.Impl
{
    public class GebruikerController : IGebruikerController
    {
        public GebruikerController()
        {
        }

        public long AddGebruiker(Gebruiker gebruiker)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                throw new SecurityException("Niet de juiste geauthenticeerd");
            }

            #region awesome business code (uiteindelijke functionaliteit)
            return default(long);
            #endregion
        }
    }
}
