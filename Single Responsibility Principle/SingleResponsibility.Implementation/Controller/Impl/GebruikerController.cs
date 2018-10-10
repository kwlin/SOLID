using Common.Crosscutting.Logging;
using Common.Entities;
using SingleResponsibility.Implementation.Controller;
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

        public void AddBestellingToGebruikerShoppingCart(Bestelling bestelling, Gebruiker gebruiker, ShoppingCart shoppingCart)
        {
            throw new NotImplementedException();
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

        public bool GebruikerExistsWithId(long id)
        {
            throw new NotImplementedException();
        }

        public ShoppingCart GetGebruikerShoppingCart(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool IsAuthorized(params string[] roles)
        {
            return true;
        }

        public void RemoveGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool ValideerGebruiker(Gebruiker gebruiker)
        {
            return true;
        }
    }
}
