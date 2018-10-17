using Common.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Threading;

namespace OpenClose.Implementation.Refactor.Controller.Impl
{
    public class AuthenticatedGebruikerController : IGebruikerController
    {
        private IGebruikerController _inner;

        public AuthenticatedGebruikerController(IGebruikerController inner)
        {
            _inner = inner;
        }

        public long AddGebruiker(Gebruiker gebruiker)
        {
            if (Thread.CurrentPrincipal.Identity.IsAuthenticated)
            {
                throw new SecurityException("Niet de juiste geauthenticeerd");
            }

            return _inner.AddGebruiker(gebruiker);
        }
    }
}
