using System;
using System.Collections.Generic;

namespace gof_pattern_bridge_logger
{
    interface IMessageStore
    {
        void Add(string message);
        IList<string> GetAllMessages();
    }

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

    interface ILogger
    {
        public void Log(string message);
        public IList<string> GetAllMessages();
    }

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

    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();
            logger.Log("Hello World!");
            logger.Log("Hello, Stefan");

            var messages = logger.GetAllMessages();
            foreach(var message in messages)
                Console.WriteLine(message);
        }
    }
}
