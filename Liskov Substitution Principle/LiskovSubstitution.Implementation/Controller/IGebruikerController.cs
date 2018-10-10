using LiskovSubstitution.Implementation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Implementation.Controller
{
    public interface IGebruikerController
    {
        string GetGebruikerNaam(GebruikerBase gebruiker);

        string GetGebruikerNaam2(GebruikerBase gebruiker);
    }
}
