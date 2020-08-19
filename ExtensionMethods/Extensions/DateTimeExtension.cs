using System.Globalization;

//namespace ExtensionMethods.Extensions
// macete para herdar do System e não ter que dar using no Program
namespace System
{
    static class DateTimeExtension
    {
        public static string ElapsedTime(this DateTime obj)
        {
            var duration = DateTime.Now.Subtract(obj);

            if (duration.TotalHours < 24.0)
            {
                return $"{duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture)} hours";
            }
            else
            {
                return $"{duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture)} days";
            }
        }
    }
}
