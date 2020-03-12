using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
using gof_pattern_bridge_logger;
using Moq;
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

        [Fact]
        public void Main_HappyPathFileLogging_LogIsStoredInAFile()
        {
            var fileStore = new FileStore("c:\\temp\\temp.txt");
            Program.Logger = new SyncLogger(fileStore);
            Program.Main(null);

            var allMessagesCount = fileStore.GetAllMessages().Count;
            Assert.Equal(2, allMessagesCount);
        }
    }
}