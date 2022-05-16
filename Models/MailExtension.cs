using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class MailExtension
    {
        private static IList<string> MailExtensionList = new List<string>();
        public static IList<string> GetEmailExtensionList()
        {
            return MailExtensionList;
        }
        public static void SetMailExtensionList(IList<string> NewListOfExtension)
        {
            MailExtensionList = NewListOfExtension;
        }
        public static void AddToMailExtensonList(string ExtensionToAdd)
        {
            MailExtensionList.Add(ExtensionToAdd);
        }
    }
}
