using Models;
using DAL;
namespace BLL
{
    public static class DataAccess
    {
        public static IList<Fournisseur> GetListfromFile(string FilePath)
        {
            return FileUtility.GetFurnisherData(FilePath);
        }
        public static void SaveFurnisherFile(string FilePath, IList<Fournisseur> FurnisherList, int LastID)
        {
            FileUtility.SaveFile(FilePath, FurnisherList, LastID);
        }
    }
}