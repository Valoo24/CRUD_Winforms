using System.IO;
using System.Text;
using Models;
namespace DAL
{
    public static class FileUtility
    {
        #region Variables locales
        /// <summary>
        /// Nom du dossier dans lequel les fichiers seront sauvegardés.
        /// </summary>
        private static string SaveFolderName = "Saves";
        /// <summary>
        /// Chemin d'accès du fichier de sauvegarde des fournisseurs.
        /// </summary>
        private static string FurnisherSaveFilePath = $"{SaveFolderName}/Fsf.csv";
        /// <summary>
        /// Chemin d'accès du fichier de sauvegarde des extensions d'adresses mail.
        /// </summary>
        private static string MailExtensionSaveFilePath = $"{SaveFolderName}/MEsf.csv";
        #endregion
        /// <summary>
        /// Retourne la liste des fournisseurs depuis un chemin d'accès à un fichier.
        /// </summary>
        /// <param name="FilePath">Chemin d'accès au fichier fournisseur.</param>
        /// <returns>Liste des fournisseurs.</returns>
        public static IList<Fournisseur> GetFurnisherData(string FilePath)
        {
            IList<Fournisseur> List = new List<Fournisseur>();
            if (File.Exists(FilePath))
            {
                string[] Content = File.ReadAllLines(FilePath, Encoding.UTF8);
                for (int i = 0; i < Content.GetLength(0) - 1; i++)
                {
                    List.Add(new Fournisseur(Content[i]));
                }
            }
            return List;
        }
        /// <summary>
        /// Retourne la liste des fournisseurs depuis le chemin d'accès statndard au fichier des fournisseurs
        /// </summary>
        /// <returns>Liste des fournisseurs.</returns>
        public static IList<Fournisseur> GetFurnisherData()
        {
            IList<Fournisseur> List = new List<Fournisseur>();
            if (File.Exists(FurnisherSaveFilePath))
            {
                string[] Content = File.ReadAllLines(FurnisherSaveFilePath, Encoding.UTF8);
                for (int i = 0; i < Content.GetLength(0) - 1; i++)
                {
                    List.Add(new Fournisseur(Content[i]));
                }
            }
            return List;
        }
        /// <summary>
        /// Retourne le dernier ID utilisé pour créer un fournisseur. Si le chemin d'accès n'existe pas ou que le fichier est mal écrit, l'ID
        /// renvoyé sera 0.
        /// </summary>
        /// <param name="FilePath">Chemin d'accès au fichier fournisseur</param>
        /// <returns>Dernier ID utilisé pour créer un fournisseur</returns>
        public static int GetLastID(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string[] Content = File.ReadAllLines(FilePath, Encoding.UTF8);
                string[] LastLine = Content[Content.GetLength(0) - 1].Split(";");
                if (int.TryParse(LastLine[1], out int ID))
                {
                    return ID;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Retourne le dernier ID utilisé pour créer un fournisseur depuis le chemin d'accès standard au fichier de sauvegarde des fournisseurs.
        /// Si le chemin d'accès n'existe pas ou que le fichier est mal écrit, l'ID renvoyé sera 0.
        /// </summary>
        /// <returns></returns>
        public static int GetLastID()
        {
            if (File.Exists(FurnisherSaveFilePath))
            {
                string[] Content = File.ReadAllLines(FurnisherSaveFilePath, Encoding.UTF8);
                string[] LastLine = Content[Content.GetLength(0) - 1].Split(";");
                if (int.TryParse(LastLine[1], out int ID))
                {
                    return ID;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Sauvegarde la liste des fournisseurs.
        /// </summary>
        /// <param name="FurnisherList">Liste des fournisseurs à sauvegarder.</param>
        /// <param name="LastID">Dernier ID utilisé lors de la création d'un fournisseur.</param>
        public static void SaveFurnisherFile(IList<Fournisseur> FurnisherList, int LastID)
        {
            if(File.Exists(FurnisherSaveFilePath))
            {
                File.Delete(FurnisherSaveFilePath);
            }
            using (FileStream FurnisherFilePath = File.Create(FurnisherSaveFilePath))
            {
                foreach(Fournisseur fournisseur in FurnisherList)
                {
                    WriteInSaveFile(FurnisherFilePath, $"{fournisseur.FurnisherToSaveText()}\n");
                }
                WriteInSaveFile(FurnisherFilePath, $"LastID;{LastID}");
            }
        }
        /// <summary>
        /// Renvoie le chemin d'accès au fichier de sauvegarde des fournisseurs.
        /// </summary>
        /// <returns></returns>
        public static string GetFurnisherSaveFilePath()
        {
            return FurnisherSaveFilePath;
        }
        /// <summary>
        /// Sauvegarder la liste des extensions d'adresses mail.
        /// </summary>
        /// <param name="MailExtensionList">Liste d'extensions d'adresses mail à sauvegarder.</param>
        public static void SaveMailExtensionFile(IList<string> MailExtensionList)
        {
            if(File.Exists(MailExtensionSaveFilePath))
            {
                File.Delete(MailExtensionSaveFilePath);
            }
            using (FileStream MailExtensionFilePath = File.Create(MailExtensionSaveFilePath))
            {
                foreach(string MailExtension in MailExtensionList)
                {
                    WriteInSaveFile(MailExtensionFilePath, $"{MailExtension};");
                }
            }
        }
        /// <summary>
        /// Renvoie le chemin d'accès au fichier de sauvegarde des extensions d'adresses mail.
        /// </summary>
        /// <returns></returns>
        public static string GetMailExtensionSaveFilePath()
        {
            return MailExtensionSaveFilePath;
        }
        /// <summary>
        /// Renvoie la liste des extensions d'adesses mail depuis le fichier de sauvegarde standard.
        /// </summary>
        public static IList<string> GetMailExtensionData()
        {
            IList<string> List = new List<string>();

            if (File.Exists(MailExtensionSaveFilePath))
            {
                string[] Content = File.ReadAllLines(MailExtensionSaveFilePath, Encoding.UTF8);
                string[] MailExtensions = Content[0].Split(";");
                for (int i = 0; i < MailExtensions.GetLength(0); i++)
                {
                    if (MailExtensions[i] != "")
                    {
                        List.Add(MailExtensions[i]);
                    }
                }
                return List;
            }
            else
            {
                List.Add("com");
                List.Add("fr");
                List.Add("be");
                return List;
            }
        }
        /// <summary>
        /// Définit ce qui sera écrit dans un fichier de sauvegarde.
        /// </summary>
        /// <param name="Filestream">Accès au fichier de sauvegarde.</param>
        /// <param name="Text">Texte à sauvegarder.</param>
        private static void WriteInSaveFile(FileStream Filestream, string Text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(Text);
            Filestream.Write(info, 0, info.Length);
        }
    }
}