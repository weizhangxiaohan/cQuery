using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.Utils
{
    public class MD5Util
    {
        public static string GetMD5(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);

            MD5 md5 = MD5.Create();
            byte[] hashBytes = md5.ComputeHash(bytes);
            StringBuilder hexStr = new StringBuilder();
            foreach(var item in hashBytes)
            {
                hexStr.Append(item.ToString("x2"));
            }
            return hexStr.ToString();
        }
    }
}
