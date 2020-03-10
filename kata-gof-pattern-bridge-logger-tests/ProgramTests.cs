using gof_pattern_bridge_logger;
using Xunit;

namespace kata_gof_pattern_bridge_logger_tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_HappyPathSyncLogger_LogsTwoMessages()
        {
            Program.Logger = new SyncLogger();
            Program.Main(null);
            
            var allMessagesCount = Program.Logger.GetAllMessages().Count;
            Assert.Equal(2, allMessagesCount);
        }
        
        [Fact]
        public void Main_HappyPathAsyncLogger_LogsTwoMessages()
        {
            Program.Logger = new AsyncLogger();

            Program.Main(null);
            var allMessagesCount = Program.Logger.GetAllMessages().Count;
            Assert.Equal(2, allMessagesCount);
        }
    }
}