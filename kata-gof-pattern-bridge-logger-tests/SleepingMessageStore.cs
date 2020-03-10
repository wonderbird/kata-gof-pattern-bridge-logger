using System;
using System.Collections.Generic;
using System.Threading;
using gof_pattern_bridge_logger;

namespace kata_gof_pattern_bridge_logger_tests
{
    public class SleepingMessageStore : IMessageStore
    {
        private readonly TimeSpan _delay;
        private List<string> _messages = new List<string>();

        public SleepingMessageStore(TimeSpan delay)
        {
            _delay = delay;
        }

        public void Add(string message)
        {
            Thread.Sleep(_delay);
            _messages.Add(message);
        }

        public IList<string> GetAllMessages()
        {
            return _messages;
        }
    }
}