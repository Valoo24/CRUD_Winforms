using System.IO;
using System.Text;
using Models;
namespace DAL
{
    public static class FileUtility
    {
        private static string FurnisherFileSavePath = "Saves/Save_File.csv";
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
        public static int GetLastID(string FilePath)
        {
            if (File.Exists(FilePath))
            {
                string[] Content = File.ReadAllLines(FilePath, Encoding.UTF8);
                string[] LastLine = Content[Content.GetLength(0) - 1].Split(";");
                return int.Parse(LastLine[1]);
            }
            else
            {
                return 0;
            }
        }
        public static void SaveFurnisherFile(IList<Fournisseur> FurnisherList, int LastID)
        {
            if(File.Exists(FurnisherFileSavePath))
            {
                File.Delete(FurnisherFileSavePath);
            }
            using (FileStream FileSystem = File.Create(FurnisherFileSavePath))
            {
                foreach(Fournisseur fournisseur in FurnisherList)
                {
                    WriteInSaveFile(FileSystem, $"{fournisseur.FurnisherToSaveText()}\n");
                }
                WriteInSaveFile(FileSystem, $"LastID;{LastID}");
            }
        }
        public static string GetSaveFurnicherFilePath()
        {
            return FurnisherFileSavePath;
        }
        private static void WriteInSaveFile(FileStream Filestream, string Text)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(Text);
            Filestream.Write(info, 0, info.Length);
        }
    }
}