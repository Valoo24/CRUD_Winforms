using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class DataCheck
    {
        /// <summary>
        /// Mémoire tampon du résultat de la confirmation. Doit toujours être initialisée à false.
        /// </summary>
        static bool Confirm = false;
        /// <summary>
        /// Vérifie si une TextBox contient du texte.
        /// </summary>
        /// <param name="TextBoxText">Texte de la TextBox</param>
        /// <returns>Un booléen. true si la TextBox contient du texte, false si la TextBox est vide.</returns>
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
        /// <summary>
        /// Renvoie le résultat de la confirmation du client.
        /// </summary>
        /// <returns></returns>
        public static bool GetConfirmation()
        {
            return Confirm;
        }
        /// <summary>
        /// Définit la variable de confirmation.
        /// </summary>
        /// <param name="Confirmation">État de la confirmation.</param>
        public static void SetConfirmTo(bool Confirmation)
        {
            Confirm = Confirmation;
        }
    }
}
