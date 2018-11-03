using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.ExtendMethods
{
    public static class ListStringExtend
    {
        public static string ToString(this List<string> ls, string connector)
        {
            return string.Join(connector,ls.ToArray());
        }
    }
}
