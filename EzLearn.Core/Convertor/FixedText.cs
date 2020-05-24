using System;
using System.Collections.Generic;
using System.Text;

namespace EzLearn.Core.Convertor
{
    public static class FixedText
    {
        public static string FixEmail(string email)
        {
            return email.Trim().ToLower();
        }
    }
}
