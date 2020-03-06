using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    class Logger : ILogger
    {
        private IMessageStore _messageStore;

        public Logger()
            : this(new MemoryStore())
        {
        }

        public Logger(IMessageStore messageStore)
        {
            _messageStore = messageStore;
        }

        public void Log(string message)
        {
            _messageStore.Add(message);
        }

        public IList<string> GetAllMessages()
        {
            return _messageStore.GetAllMessages();
        }
    }
}