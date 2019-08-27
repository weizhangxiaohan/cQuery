using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace cQuery.Extension.Utils
{
    public class SHA256Util
    {
        public static string GetSHA256(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            SHA256 sha256 = SHA256.Create();
            byte[] hashBytes = sha256.ComputeHash(bytes);
            StringBuilder hexStr = new StringBuilder();
            foreach (var item in hashBytes)
            {
                hexStr.Append(item.ToString("x2"));
            }
            return hexStr.ToString();
        }
    }
}
