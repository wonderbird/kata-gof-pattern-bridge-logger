using System;
using System.Diagnostics;
using gof_pattern_bridge_logger;
using Xunit;

namespace kata_gof_pattern_bridge_logger_tests
{
    public class AsyncLoggerTests
    {
        [Fact]
        public void Log_MessageStoreAddWithDelay_ReturnsAfterDelay()
        {
            var messageStoreDelay = 10;
            var fakeMessageStore =
                new SleepingMessageStore(TimeSpan.FromMilliseconds(messageStoreDelay));
            var logger = new AsyncLogger();

            var stopwatch = new Stopwatch();
            stopwatch.Start();
            logger.Log("anything");
            stopwatch.Stop();

            var actualCallDurationMillis = stopwatch.Elapsed.TotalMilliseconds;
            Assert.True(actualCallDurationMillis < messageStoreDelay);
        }
    }
}