﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazingExtensions
{
    public static class HumanExtensions    //定義擴充方法，類別必須使用static
    {
        public static bool IsDistressCall(this string s)
        {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}
