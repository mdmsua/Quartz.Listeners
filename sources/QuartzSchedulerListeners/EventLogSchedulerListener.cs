using System.Diagnostics;
using Quartz;

namespace QuartzSchedulerListeners
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
            
        }

        public void JobUnscheduled(TriggerKey triggerKey)
        {
            
        }

        public void TriggerFinalized(ITrigger trigger)
        {
            
        }

        public void TriggerPaused(TriggerKey triggerKey)
        {
            
        }

        public void TriggersPaused(string triggerGroup)
        {
            
        }

        public void TriggerResumed(TriggerKey triggerKey)
        {
            
        }

        public void TriggersResumed(string triggerGroup)
        {
            
        }

        public void JobAdded(IJobDetail jobDetail)
        {
            
        }

        public void JobDeleted(JobKey jobKey)
        {
            
        }

        public void JobPaused(JobKey jobKey)
        {
            
        }

        public void JobsPaused(string jobGroup)
        {
            
        }

        public void JobResumed(JobKey jobKey)
        {
            
        }

        public void JobsResumed(string jobGroup)
        {
            
        }

        public void SchedulerError(string msg, SchedulerException cause)
        {
            
        }

        public void SchedulerInStandbyMode()
        {
            
        }

        public void SchedulerStarted()
        {
            
        }

        public void SchedulerStarting()
        {
            
        }

        public void SchedulerShutdown()
        {
            
        }

        public void SchedulerShuttingdown()
        {
            
        }

        public void SchedulingDataCleared()
        {
            
        }
    }
}
