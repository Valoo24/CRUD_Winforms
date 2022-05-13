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
        static IList<Fournisseur>? FurnisherFoundList;
        static Fournisseur SelectedFournisseur;
        #region Méthodes ID
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
        #endregion
        #region Méthodes FurnisherList
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
        #endregion
        #region Méthodes SearchedList
        public static IList<Fournisseur> GetSearchedList()
        {
            return FurnisherFoundList;
        }
        public static void SetSearchedList(IList<Fournisseur> SearchedList)
        {
            FurnisherFoundList = SearchedList;
        }
        public static bool SearchListIsNull()
        {
            if (FurnisherFoundList.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Méthodes SelectedFournisseur
        public static Fournisseur GetSelectedFournisseur()
        {
            return SelectedFournisseur;
        }
        public static void SetSelectedFournisseur(Fournisseur Furnisher)
        {
            SelectedFournisseur = Furnisher;
        }
        #endregion
    }
}