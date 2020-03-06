using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    public interface ILogger
    {
        public void Log(string message);
        public IList<string> GetAllMessages();
    }
}