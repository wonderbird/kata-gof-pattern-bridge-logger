using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    class MemoryStore : IMessageStore
    {
        private IList<string> _messages = new List<string>();

        public void Add(string message)
        {
            _messages.Add(message);
        }

        public IList<string> GetAllMessages()
        {
            return _messages;
        }
    }
}