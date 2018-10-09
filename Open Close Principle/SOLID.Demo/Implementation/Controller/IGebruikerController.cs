using Implementation.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Controller
{
    public interface IGebruikerController
    {
        long AddGebruiker(Gebruiker gebruiker);
    }
}
