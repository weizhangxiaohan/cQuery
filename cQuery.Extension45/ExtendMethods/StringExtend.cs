using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class StringExtend
    {
        /// <summary>
        /// 将字符串转换为时间
        /// </summary>
        /// <param name="s">要转换的字符串</param>
        /// <param name="defaultValue">指定转换失败时返回的默认值</param>
        /// <returns>转换的结果</returns>
        public static DateTime ToDateTime(this string s,DateTime defaultValue = default(DateTime))
        {
            DateTime output;
            bool b = DateTime.TryParse(s,out output);
            if (b)
            {
                return output;
            }
            else
            {
                return defaultValue;
            }
        }
    }
}
