using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Refactor.Crosscutting.Logging
{
    interface ILogger
    {
        void LogError(string message);
    }
}
