using System;

namespace NewRelic.Agent.Core.Time
{
    public static class TimeSpanMath
    {
        public static TimeSpan Min(TimeSpan timeSpan1, TimeSpan timeSpan2)
        {
            return timeSpan1 <= timeSpan2 ? timeSpan1 : timeSpan2;
        }

        public static TimeSpan Max(TimeSpan timeSpan1, TimeSpan timeSpan2)
        {
            return timeSpan1 >= timeSpan2 ? timeSpan1 : timeSpan2;
        }
    }
}