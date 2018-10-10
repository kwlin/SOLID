using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsibility.Implementation.Controller
{
    public interface IGebruikerController
    {
        long AddGebruiker(Gebruiker gebruiker);

        void RemoveGebruiker(Gebruiker gebruiker);

        bool GebruikerExistsWithId(long id);

        ShoppingCart GetGebruikerShoppingCart(Gebruiker gebruiker);

        void AddBestellingToGebruikerShoppingCart(Bestelling bestelling, Gebruiker gebruiker, ShoppingCart shoppingCart);
    }
}
