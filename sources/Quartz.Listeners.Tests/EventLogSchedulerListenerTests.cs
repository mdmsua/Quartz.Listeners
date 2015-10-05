using System.Diagnostics;
using Moq;
using NUnit.Framework;

namespace Quartz.Listeners.Tests
{
    [TestFixture]
    public class EventLogSchedulerListenerTests
    {
        private EventLog eventLog;

        private readonly EventLogSchedulerListener schedulerListener;

        static EventLogSchedulerListenerTests()
        {
            EventLog.CreateEventSource("Quartz", "Quartz");
        }

        public EventLogSchedulerListenerTests()
        {
            //eventLog.Source = "Application";
            eventLog = new EventLog("Quartz", ".", "Quartz");
            schedulerListener = new EventLogSchedulerListener(eventLog);
        }

        [TestFixtureSetUp]
        public void TestFixtureSetUp()
        {
            EventLog.CreateEventSource("Quartz", "Quartz");
        }

        [TearDown]
        public void TearDown()
        {
            EventLog.DeleteEventSource("Quartz", ".");
        }

        [Test]
        public void JobScheduledShouldWriteEntry()
        {
            var triggerMock = new Mock<ITrigger>();
            triggerMock.SetupGet(x => x.Key).Returns(new TriggerKey("name", "group"));
            triggerMock.SetupGet(x => x.JobKey).Returns(new JobKey("name", "group"));
            triggerMock.SetupGet(x => x.Priority).Returns(0);
            triggerMock.SetupGet(x => x.Description).Returns("description");
            triggerMock.SetupGet(x => x.CalendarName).Returns("calendar");

            schedulerListener.JobScheduled(triggerMock.Object);

            const string expected = @"Job name (group) scheduled with priority 0.
Trigger: name (group)
Description: description
Calendar: calendar";
            Assert.IsTrue(eventLog.Entries[0].Message.Contains((expected)));
        }
        
        [Test]
        public void JobUnscheduledShouldWriteEntry()
        {
            var triggerKey = new TriggerKey("name", "group");

            schedulerListener.JobUnscheduled(triggerKey);

            const string expected = @"Job name (group) scheduled with priority 0.
Trigger: name (group)
Description: description
Calendar: calendar";
            Assert.IsTrue(eventLog.Entries[0].Message.Contains((expected)));
        }
    }
}