using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class BoolExtend
    {
        public static string ToChineseString(this bool b)
        {
            return b ? "是" : "否";
        }
    }
}
