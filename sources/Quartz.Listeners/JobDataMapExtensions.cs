using System;
using System.Linq;

namespace Quartz.Listeners
{
    internal static class JobDataMapExtensions
    {
        internal static string AsString(this JobDataMap jobDataMap)
        {
            return string.Join(Environment.NewLine, jobDataMap.Select(x => string.Format("{0}: {1}", x.Key, x.Value)));
        }
    }
}