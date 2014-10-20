using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace icm.Framework
{
    public static class Extention
    {
        public static bool IsNullOrEmpty(this string value)
        {
            return string.IsNullOrEmpty(value);
        }
    }
}
