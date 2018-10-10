using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation.Implementation.Refactor.Controller
{
    public interface IGebruikerOpvragenRepository
    {
        string GetGebruiker(long gebruikerId);
    }
}
