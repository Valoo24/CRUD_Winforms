using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class MailExtension
    {
        /// <summary>
        /// Liste des Extensions d'adresse e-mail acceptée.
        /// </summary>
        private static IList<string> MailExtensionList = new List<string>();
        /// <summary>
        /// Renvoie la liste des extensions d'adresses e-amil acceptée.
        /// </summary>
        public static IList<string> GetEmailExtensionList()
        {
            return MailExtensionList;
        }
        /// <summary>
        /// Enregistre le temps de l'exécution du programme la liste des extensions d'adresses mail.
        /// </summary>
        /// <param name="ExtensionListToSave">Liste d'extension à enregistrer</param>
        public static void SetMailExtensionList(IList<string> ExtensionListToSave)
        {
            MailExtensionList = ExtensionListToSave;
        }
        /// <summary>
        /// Ajoute une extension d'adresse e-amil à la liste d'extensions d'adresse e-mail.
        /// </summary>
        /// <param name="ExtensionToAdd">Extension à Ajouter.</param>
        public static void AddToMailExtensonList(string ExtensionToAdd)
        {
            MailExtensionList.Add(ExtensionToAdd);
        }
    }
}
