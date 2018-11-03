using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class DateTimeExtend
    {
        /// <summary>
        /// 将时间转换为字符串
        /// </summary>
        /// <param name="d">要转换的时间</param>
        /// <param name="format">表示时间的格式</param>
        /// <returns>表示时间的字符串</returns>
        public static string ToStringIfNullThenEmpty(this DateTime? d,string format)
        {
            if (d.HasValue)
            {
                return d.Value.ToString(format);
            }
            else
            {
                return string.Empty;
            }
        }

        /// <summary> 
        /// 计算某时间对应礼拜一的时间
        /// </summary> 
        public static DateTime GetMondayDate(this DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Monday;
            if (i == -1) i = 6;// i值 > = 0 ，因为枚举原因，Sunday排在最前，此时Sunday-Monday=-1，必须+7=6。 
            return someDate.AddDays(-1 * i).Date;
        }
        /// <summary> 
        /// 计算时间对应礼拜日的时间
        /// </summary> 
        public static DateTime GetSundayDate(this DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Sunday;
            if (i != 0) i = 7 - i;// 因为枚举原因，Sunday排在最前，相减间隔要被7减。
            return someDate.AddDays(i).Date;
        }

        /// <summary> 
        /// 计算某时间对应当月1号的时间
        /// </summary> 
        public static DateTime GetFirstDayOfCurrentMonth(this DateTime someDate)
        {
            return someDate.AddDays(-1 * someDate.Day + 1).Date;
        }
        /// <summary> 
        /// 计算某时间对应当月最后一天的时间
        /// </summary> 
        public static DateTime GetLastDayOfCurrentMonth(this DateTime someDate)
        {
            return someDate.AddDays(-1 * someDate.Day + 1).AddMonths(1).AddDays(-1).Date;
        }
    }
}
