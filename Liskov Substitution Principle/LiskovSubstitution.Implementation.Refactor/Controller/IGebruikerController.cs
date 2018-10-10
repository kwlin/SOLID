using LiskovSubstitution.Implementation.Refactor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitution.Implementation.Refactor.Controller
{
    public interface IGebruikerController
    {
        string GetGebruikerNaam(IkHebEenNaam gebruikerMetNaam);
    }
}
