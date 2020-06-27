using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace EzLearn.Core.Convertor
{
   public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value).ToString() + "/" + pc.GetMonth(value).ToString() +
                "/" + pc.GetDayOfMonth(value).ToString();
        }
    }
}
