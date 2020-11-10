using System;

namespace OrchardSite.Helpers
{
    public static class DateExtensions
    {
        public static DateTime? UtcToLocal(this DateTime? dateTime)
        {
            if (dateTime == null)
            {
                return null;
            }
            return TimeZoneInfo.ConvertTimeFromUtc(dateTime.Value, TimeZoneInfo.Local);
        }
    }
}
