using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gof_pattern_bridge_logger
{
    public class AsyncLogger : Logger
    {
        IList<Task> _tasks = new List<Task>();

        public AsyncLogger(IMessageStore messageStore)
            : base(messageStore)
        {
        }

        public AsyncLogger()
            : this(new MemoryStore())
        {
        }

        public override void Log(string message)
        {
            _tasks.Add(Task.Run(() => _messageStore.Add(message)));
        }

        public override void Flush()
        {
            Task.WaitAll(_tasks.ToArray());
        }

        public override IList<string> GetAllMessages()
        {
            return _messageStore.GetAllMessages();
        }
    }
}