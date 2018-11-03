using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class LongExtend
    {
        /// <summary>
        /// Convert timestamp to local datetime
        /// </summary>
        /// <param name="timestamp">timestamp</param>
        /// <returns>the corresponding datetime</returns>
        public static DateTime ToDateTime(this long timestamp)
        {
            DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            DateTime  date = start.AddSeconds(timestamp).ToLocalTime();
            return date;
        }
    }
}
