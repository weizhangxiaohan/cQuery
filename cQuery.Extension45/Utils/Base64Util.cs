using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.Utils
{
    public class Base64Util
    {
        public static string GetBase64(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            return Convert.ToBase64String(bytes);
        }
    }
}
