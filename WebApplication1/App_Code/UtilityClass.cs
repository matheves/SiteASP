using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code
{
    public class UtilityClass
    {

        public static string Hash_Me(string str_in)
        {
            string str_out = "";

            for (int i = 0; i < str_in.Length; i++)
            {
                str_out += Convert.ToInt16(str_in[i]).ToString();
            }

            return str_out;
        }
    }
}