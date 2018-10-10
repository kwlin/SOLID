using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Implementation.Controller
{
    public interface IGebruikerController
    {
        long AddGebruiker(Gebruiker gebruiker);
    }
}
