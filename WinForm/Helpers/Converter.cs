using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Helpers
{
    public static class Converter
    {
        public static string TimeToString( DateTime date)=> date.ToString("HH:mm");
        public static string DateToString(DateTime date) => date.ToString("yyyy-MM-dd");    }
}
