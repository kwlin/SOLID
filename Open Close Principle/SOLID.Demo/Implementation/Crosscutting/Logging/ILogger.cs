using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Crosscutting.Logging
{

    public interface ILogger
    {
        void LogError(string message);
    }
}
