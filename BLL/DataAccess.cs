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
        public static void SaveFile(TypeOfData TypeOfDataToSave)
        {
            if (TypeOfDataToSave == TypeOfData.Fournisseur)
            {
                FileUtility.SaveFurnisherFile(SpecificData.GetFurnisherList(), SpecificData.GetLastID());
            }
        }
        public static string GetSavePath(TypeOfData TypeOfTheFile)
        {
            //if(TypeOfTheFile == TypeOfData.Fournisseur)
            //{
                return FileUtility.GetSaveFurnicherFilePath();
            //}
        }
    }
}