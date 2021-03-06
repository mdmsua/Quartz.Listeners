﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quartz.Listeners {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Quartz.Listeners.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Event Log job listener.
        /// </summary>
        internal static string EventLogJobListener {
            get {
                return ResourceManager.GetString("EventLogJobListener", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) added.
        ///Description: {2}
        ///Type: {3}
        ///Data:
        ///{4}.
        /// </summary>
        internal static string JobAdded {
            get {
                return ResourceManager.GetString("JobAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) deleted..
        /// </summary>
        internal static string JobDeleted {
            get {
                return ResourceManager.GetString("JobDeleted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) vetoed..
        /// </summary>
        internal static string JobExecutionVetoed {
            get {
                return ResourceManager.GetString("JobExecutionVetoed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) paused..
        /// </summary>
        internal static string JobPaused {
            get {
                return ResourceManager.GetString("JobPaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) resumed..
        /// </summary>
        internal static string JobResumed {
            get {
                return ResourceManager.GetString("JobResumed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) scheduled.
        ///Priority: {2}
        ///Trigger: {3} ({4})
        ///Description: {5}
        ///Calendar: {6}
        ///Data:
        ///{7}.
        /// </summary>
        internal static string JobScheduled {
            get {
                return ResourceManager.GetString("JobScheduled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jobs in group {0} paused..
        /// </summary>
        internal static string JobsPaused {
            get {
                return ResourceManager.GetString("JobsPaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Jobs in group {0} resumed..
        /// </summary>
        internal static string JobsResumed {
            get {
                return ResourceManager.GetString("JobsResumed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) to be executed.
        ///Description: {2}
        ///Type: {3}
        ///Data:
        ///{4}.
        /// </summary>
        internal static string JobToBeExecuted {
            get {
                return ResourceManager.GetString("JobToBeExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job unscheduled.
        ///Trigger: {0} ({1}).
        /// </summary>
        internal static string JobUnscheduled {
            get {
                return ResourceManager.GetString("JobUnscheduled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) was executed..
        /// </summary>
        internal static string JobWasExecuted {
            get {
                return ResourceManager.GetString("JobWasExecuted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Job {0} ({1}) was executed with exception.
        ///Exception: {2}.
        /// </summary>
        internal static string JobWasExecutedException {
            get {
                return ResourceManager.GetString("JobWasExecutedException", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler error: {0}.
        ///Cause: {1}.
        /// </summary>
        internal static string SchedulerError {
            get {
                return ResourceManager.GetString("SchedulerError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler in standby mode..
        /// </summary>
        internal static string SchedulerInStandbyMode {
            get {
                return ResourceManager.GetString("SchedulerInStandbyMode", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler shutdown..
        /// </summary>
        internal static string SchedulerShutdown {
            get {
                return ResourceManager.GetString("SchedulerShutdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler shuttingdown..
        /// </summary>
        internal static string SchedulerShuttingdown {
            get {
                return ResourceManager.GetString("SchedulerShuttingdown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler started..
        /// </summary>
        internal static string SchedulerStarted {
            get {
                return ResourceManager.GetString("SchedulerStarted", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduler starting..
        /// </summary>
        internal static string SchedulerStarting {
            get {
                return ResourceManager.GetString("SchedulerStarting", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scheduling data cleared..
        /// </summary>
        internal static string SchedulingDataCleared {
            get {
                return ResourceManager.GetString("SchedulingDataCleared", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trigger {0} ({1}) finalized..
        /// </summary>
        internal static string TriggerFinalized {
            get {
                return ResourceManager.GetString("TriggerFinalized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trigger {0} ({1}) paused..
        /// </summary>
        internal static string TriggerPaused {
            get {
                return ResourceManager.GetString("TriggerPaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Trigger {0} ({1}) resumed..
        /// </summary>
        internal static string TriggerResumed {
            get {
                return ResourceManager.GetString("TriggerResumed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Triggers in group {0} paused..
        /// </summary>
        internal static string TriggersPaused {
            get {
                return ResourceManager.GetString("TriggersPaused", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Triggers in group {0} resumed..
        /// </summary>
        internal static string TriggersResumed {
            get {
                return ResourceManager.GetString("TriggersResumed", resourceCulture);
            }
        }
    }
}
