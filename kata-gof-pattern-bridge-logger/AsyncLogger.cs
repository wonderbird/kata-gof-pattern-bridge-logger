using System;
using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    internal class AsyncLogger : ILogger
    {
        public void Log(string message)
        {
            throw new NotImplementedException();
        }

        public IList<string> GetAllMessages()
        {
            throw new NotImplementedException();
        }
    }
}