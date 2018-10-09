using Implementation.Refactor.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Refactor.Controller
{
    public interface IGebruikerController
    {
        long AddGebruiker(Gebruiker gebruiker);
    }
}
