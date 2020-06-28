using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeMana.DTO
{
    public class Hash
    {
        public string MD5(string txt)
        {
            String st = "";
            Byte[] buf = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buf = md5.ComputeHash(buf);
            foreach (var item in buf)
            {
                st += item.ToString("X2");
            }
            return st;
        }
    }
}
