using System.Diagnostics;

namespace Quartz.Listeners
{
    public sealed class EventLogJobListener: IJobListener
    {
        private readonly EventLog eventLog;

        public EventLogJobListener(EventLog eventLog)
        {
            Name = Resources.EventLogJobListener;
            this.eventLog = eventLog;
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobToBeExecuted, context.JobDetail.Key.Name, context.JobDetail.Key.Group, context.JobDetail.Description, context.JobDetail.JobType.FullName, context.MergedJobDataMap.AsString()));
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobExecutionVetoed, context.JobDetail.Key.Name, context.JobDetail.Key.Group), EventLogEntryType.Warning);
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            if (jobException == null)
            {
                this.eventLog.WriteEntry(string.Format(Resources.JobWasExecuted, context.JobDetail.Key.Name,
                    context.JobDetail.Key.Group));
            }
            else
            {
                this.eventLog.WriteEntry(string.Format(Resources.JobWasExecutedException, context.JobDetail.Key.Name,
                    context.JobDetail.Key.Group, jobException), EventLogEntryType.Error);
            }
        }

        public string Name { get; private set; }
    }
}