using Common.Crosscutting.Logging;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace OpenClose.Implementation.Controller.Impl
{
    public class GebruikerController : IGebruikerController
    {
        private readonly ILogger logger;

        public GebruikerController(ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public long AddGebruiker(Gebruiker gebruiker)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                throw new SecurityException("Niet de juiste geauthenticeerd");
            }

            if (IsAuthorized("AddGebruikerRole"))
            {
                throw new SecurityException("Niet de juiste role");
            }

            try
            {
                #region awesome business code (uiteindelijke functionaliteit)
                return default(long);
                #endregion
            }
            catch(Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
        }

        public bool IsAuthorized(params string[] roles)
        {
            return true;
        }

        public bool ValideerGebruiker(Gebruiker gebruiker)
        {
            return true;
        }
    }
}
