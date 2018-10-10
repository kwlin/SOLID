using Common.Crosscutting.Logging;
using Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClose.Implementation.Refactor.Controller.Impl
{
    public class LoggingGebruikerController : IGebruikerController
    {
        private readonly ILogger logger;
        private readonly IGebruikerController inner;

        public LoggingGebruikerController(ILogger logger, IGebruikerController inner)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.inner = inner ?? throw new ArgumentNullException(nameof(inner));
        }

        public long AddGebruiker(Gebruiker gebruiker)
        {
            try
            {
                return inner.AddGebruiker(gebruiker);
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
