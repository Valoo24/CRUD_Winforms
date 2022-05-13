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
    }
}