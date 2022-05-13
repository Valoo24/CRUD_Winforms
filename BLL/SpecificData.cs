using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SpecificData
    {
        static int LastID = 0;
        static IList<Fournisseur> FurnisherList = new List<Fournisseur>();
        static IList<Fournisseur> FurnisherFoundList;
        public static int GetID(string FilePath)
        {
            return FileUtility.GetLastID(FilePath);
        }
        public static void SetLastID(int IDNumber)
        {
            LastID = IDNumber;
        }
        public static int GetLastID()
        {
            return LastID;
        }
        public static IList<Fournisseur> GetFurnisherList()
        {
            return FurnisherList;
        }
        public static void SetFurnisherList(IList<Fournisseur> List)
        {
            FurnisherList = List;
        }
        public static void AddFurnisher(Fournisseur NewFournisseur)
        {
            FurnisherList.Add(NewFournisseur);
        }
        public static IList<Fournisseur> GetSearchedList()
        {
            return FurnisherFoundList;
        }
        public static void SetSearchedList(IList<Fournisseur> SearchedList)
        {
            FurnisherFoundList = SearchedList;
        }
    }
}