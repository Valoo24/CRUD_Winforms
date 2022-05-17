using Models;
using DAL;
namespace BLL
{
    public static class DataAccess
    {
        /// <summary>
        /// Renvoie la liste des fournisseurs depuis le chemin d'accès à un fichier.
        /// </summary>
        /// <param name="FilePath">Chemin d'accès du fichier fournisseur à charger.</param>
        public static IList<Fournisseur> GetFurnisherListfromFile(string FilePath)
        {
            return FileUtility.GetFurnisherData(FilePath);
        }
        /// <summary>
        /// Renvoie la liste des fournisseurs depuis le chemin d'accès standard au fichier des fournisseurs.
        /// </summary>
        public static IList<Fournisseur> GetFurnisherListFromFile()
        {
            return FileUtility.GetFurnisherData();
        }
        /// <summary>
        /// Sauvegarde des données dans un fichier.
        /// </summary>
        /// <param name="TypeOfDataToSave">Type de données à sauvegarder.</param>
        public static void SaveFile(TypeOfData TypeOfDataToSave)
        {
            if(TypeOfDataToSave == TypeOfData.Fournisseur)
            {
                FileUtility.SaveFurnisherFile(SpecificData.GetFurnisherList(), SpecificData.GetLastID());
            }
            if(TypeOfDataToSave == TypeOfData.MailExtension)
            {
                FileUtility.SaveMailExtensionFile(MailExtension.GetEmailExtensionList());
            }
        }
        /// <summary>
        /// Renvoie le chemin d'accès au fichier de sauvegarde selon le type de données.
        /// </summary>
        /// <param name="TypeOfTheFile">Type de données dont on veut le chemin d'accès au fichier de sauvegarde.</param>
        public static string GetSavePath(TypeOfData TypeOfTheFile)
        {
            if(TypeOfTheFile == TypeOfData.Fournisseur)
            {
                return FileUtility.GetFurnisherSaveFilePath();
            }
            else if(TypeOfTheFile == TypeOfData.MailExtension)
            {
                return FileUtility.GetMailExtensionSaveFilePath();
            }
            else
            {
                return null;
            }
        }
    }
}