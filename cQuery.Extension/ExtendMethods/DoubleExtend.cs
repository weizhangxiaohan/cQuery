using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class DoubleExtend
    {
        /// <summary>
        /// 得到double类型变量的百分比表示
        /// </summary>
        /// <param name="d">要转换的double类型变量</param>
        /// <param name="digits">小数精度</param>
        /// <returns>double类型变量的百分比表示</returns>
        public static string ToPercentage(this double d,int digits)
        {
            return Math.Round(d * 100, digits) + "%";
        }
    }
}
