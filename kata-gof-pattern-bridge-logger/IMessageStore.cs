using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    public interface IMessageStore
    {
        void Add(string message);
        IList<string> GetAllMessages();
    }
}