using System.Text;
using Models;
namespace DAL
{
    public static class FileUtility
    {
        public static IList<Fournisseur> GetFurnisherData(string FilePath)
        {
            string[] Content = File.ReadAllLines(FilePath, Encoding.UTF7);
            IList<Fournisseur> List = new List<Fournisseur>();
            for (int i = 1; i < Content.GetLength(0) - 1; i++)
            {
                List.Add(new Fournisseur(Content[i]));
            }
            return List;
        }
        public static int GetLastID(string FilePath)
        {
            string[] Content = File.ReadAllLines(FilePath, Encoding.UTF7);
            string[] LastLine = Content[Content.GetLength(0) - 1].Split(";");
            return int.Parse(LastLine[1]);
        }
    }
}