using System;
using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    public class AsyncLogger : Logger
    {
        public override void Log(string message)
        {
            throw new NotImplementedException();
        }

        public override IList<string> GetAllMessages()
        {
            throw new NotImplementedException();
        }
    }
}