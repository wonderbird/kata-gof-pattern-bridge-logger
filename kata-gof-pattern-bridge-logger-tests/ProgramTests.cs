using gof_pattern_bridge_logger;
using Xunit;

namespace kata_gof_pattern_bridge_logger_tests
{
    public class ProgramTests
    {
        [Fact]
        public void Main_HappyPath_LogsTwoMessages()
        {
            Program.Main(null);
            var allMessages = Program.Logger.GetAllMessages();
            Assert.Equal(2, allMessages.Count);
        }
    }
}