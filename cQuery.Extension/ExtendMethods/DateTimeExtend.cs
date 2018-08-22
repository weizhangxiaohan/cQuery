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
    }
}
