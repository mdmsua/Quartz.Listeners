using System.Diagnostics;

namespace Quartz.Listeners
{
    public sealed class EventLogSchedulerListener : ISchedulerListener
    {
        private readonly EventLog eventLog;

        public EventLogSchedulerListener(EventLog eventLog)
        {
            this.eventLog = eventLog;
        }

        public void JobScheduled(ITrigger trigger)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobScheduled, trigger.JobKey.Name, trigger.JobKey.Group, trigger.Priority, trigger.Key.Name, trigger.Key.Group, trigger.Description, trigger.CalendarName, trigger.JobDataMap.AsString()));
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobUnscheduled, triggerKey.Name, triggerKey.Group));
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            this.eventLog.WriteEntry(string.Format(Resources.TriggerFinalized, trigger.Key.Name, trigger.Key.Group));
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.TriggerPaused, triggerKey.Name, triggerKey.Group));
        }

        public void TriggersPaused(string triggerGroup)
        {
            this.eventLog.WriteEntry(string.Format(Resources.TriggersPaused, triggerGroup));
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.TriggerResumed, triggerKey.Name, triggerKey.Group));   
        }

        public void TriggersResumed(string triggerGroup)
        {
            this.eventLog.WriteEntry(string.Format(Resources.TriggersResumed, triggerGroup));
        }

        public void JobAdded(IJobDetail jobDetail)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobAdded, jobDetail.Key.Name, jobDetail.Key.Group, jobDetail.Description, jobDetail.JobType.FullName, jobDetail.JobDataMap.AsString()));
        }

        public void JobDeleted(JobKey jobKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobDeleted, jobKey.Name, jobKey.Group));
        }

        public void JobPaused(JobKey jobKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobPaused, jobKey.Name, jobKey.Group));
        }

        public void JobsPaused(string jobGroup)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobsPaused, jobGroup));
        }

        public void JobResumed(JobKey jobKey)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobResumed, jobKey.Name, jobKey.Group));
        }

        public void JobsResumed(string jobGroup)
        {
            this.eventLog.WriteEntry(string.Format(Resources.JobsResumed, jobGroup));
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            this.eventLog.WriteEntry(string.Format(Resources.SchedulerError, msg, cause), EventLogEntryType.Error);
        }

        public void SchedulerInStandbyMode()
        {
            this.eventLog.WriteEntry(Resources.SchedulerInStandbyMode);
        }

        public void SchedulerStarted()
        {
            this.eventLog.WriteEntry(Resources.SchedulerStarted);
        }

        public void SchedulerStarting()
        {
            this.eventLog.WriteEntry(Resources.SchedulerStarting);
        }

        public void SchedulerShutdown()
        {
            this.eventLog.WriteEntry(Resources.SchedulerShutdown);
        }

        public void SchedulerShuttingdown()
        {
            this.eventLog.WriteEntry(Resources.SchedulerShuttingdown);
        }

        public void SchedulingDataCleared()
        {
            this.eventLog.WriteEntry(Resources.SchedulingDataCleared);
        }
    }
}
