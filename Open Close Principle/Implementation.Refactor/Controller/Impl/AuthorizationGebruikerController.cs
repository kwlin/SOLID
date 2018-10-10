using Common.Entities;
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace OpenClose.Implementation.Refactor.Controller.Impl
{
    public class AuthorizationGebruikerController : IGebruikerController
    {
        private IGebruikerController _inner;
        private string[] _roles;

        public AuthorizationGebruikerController(IGebruikerController inner, params string[] roles)
        {
            _inner = inner;
            _roles = roles;
        }

        public long AddGebruiker(Gebruiker gebruiker)
        {
            if (IsAuthorized("AddGebruikerRole"))
            {
                throw new SecurityException("Niet de juiste role");
            }

            return _inner.AddGebruiker(gebruiker);
        }

        private bool IsAuthorized(params string[] roles)
        {
            return true;
        }


    }
}
