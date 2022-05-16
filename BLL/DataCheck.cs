using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DataCheck
    {
        public static bool TextBoxHasText(string TextBoxText)
        {
            Char[] TestArray = TextBoxText.ToCharArray();
            if (TestArray.GetLength(0) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
