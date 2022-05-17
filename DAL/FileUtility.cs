using System.IO;
using System.Text;
using Models;
namespace DAL
{
    public static class FileUtility
    {
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
        public static string GetFurnisherSaveFilePath()
        {
            return FurnisherSaveFilePath;
        }
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
        public static string GetMailExtensionSaveFilePath()
        {
            return MailExtensionSaveFilePath;
        }
        public static IList<string> GetMailExtensionData()
        {
            IList<string> List = new List<string>();

            return List;
        }
        private static void WriteInSaveFile(FileStream Filestream, string Text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(Text);
            Filestream.Write(info, 0, info.Length);
        }
    }
}