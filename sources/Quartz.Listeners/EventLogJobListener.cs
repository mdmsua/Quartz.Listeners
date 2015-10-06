using System.Diagnostics;

namespace Quartz.Listeners
{
    public sealed class EventLogJobListener: IJobListener
    {
        private readonly EventLog eventLog;

        public EventLogJobListener(EventLog eventLog)
        {
            Name = "EventLog";
            this.eventLog = eventLog;
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            
        }

        public string Name { get; private set; }
    }
}