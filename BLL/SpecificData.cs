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
        #region Variables locales
        /// <summary>
        /// Dernier ID utilisée pour créer un fournisseur.
        /// </summary>
        static int LastID = 0;
        /// <summary>
        /// Liste des fournisseurs.
        /// </summary>
        static IList<Fournisseur> FurnisherList = new List<Fournisseur>();
        /// <summary>
        /// Liste des fournisseurs correspondant aux paramètres de recherche lors d'une recherche de fournsiseurs.
        /// </summary>
        static IList<Fournisseur> FurnisherFoundList = new List<Fournisseur>();
        /// <summary>
        /// Mémoire tampon du fournisseur sélectionné dans la liste des fournisseurs dans le winform.
        /// </summary>
        static Fournisseur SelectedFournisseur;
        #endregion
        #region Méthodes ID
        /// <summary>
        /// Renvoie le dernier ID utilisé depuis le chemin d'accès au fichier de sauvegarde des fournisseurs.
        /// </summary>
        /// <param name="FilePath">Chemin d'accès au fichier de sauvegarde des fournisseurs.</param>
        /// <returns></returns>
        public static int GetIDFromFile(string FilePath)
        {
            return FileUtility.GetLastID(FilePath);
        }
        /// <summary>
        /// Renvoie le dernier ID utilisé depuis le chemin d'accès standard au fichier de sauvegarde des fournisseurs.
        /// </summary>
        /// <returns></returns>
        public static int GetIDFromFile()
        {
            return FileUtility.GetLastID();
        }
        /// <summary>
        /// sauvegarde le temps de l'exécution du programme le dernier ID utilisé.
        /// </summary>
        /// <param name="IDNumber">Nombre à sauvegardé comme dernier ID</param>
        public static void SetLastID(int IDNumber)
        {
            LastID = IDNumber;
        }
        /// <summary>
        /// Renvoie le dernier ID utilisé pour la création de nouveaux fournisseurs.
        /// </summary>
        /// <returns></returns>
        public static int GetLastID()
        {
            return LastID;
        }
        #endregion
        #region Méthodes FurnisherList
        /// <summary>
        /// Renvoie la liste de fournisseurs
        /// </summary>
        /// <returns></returns>
        public static IList<Fournisseur> GetFurnisherList()
        {
            return FurnisherList;
        }
        /// <summary>
        /// Sauvegarde le temps de l'éxécution du programme la liste des fournisseurs
        /// </summary>
        /// <param name="List">Liste de fournisseurs à sauvegarder</param>
        public static void SetFurnisherList(IList<Fournisseur> List)
        {
            FurnisherList = List;
        }
        /// <summary>
        /// Rajoute un fournisseur à la liste des fournisseurs
        /// </summary>
        /// <param name="NewFournisseur">Fournisseur à rajouter à la liste des fournisseurs</param>
        public static void AddFurnisher(Fournisseur NewFournisseur)
        {
            FurnisherList.Add(NewFournisseur);
        }
        /// <summary>
        /// Modifie les informations d'un fournisseur dans la liste des fournisseurs
        /// </summary>
        /// <param name="NewFurnisherInfo">Fournisseur mis à jour</param>
        public static void ModifyFurnisherList(Fournisseur NewFurnisherInfo)
        {
            NewFurnisherInfo.SetNewUpdateDate();
            for(int i = 0; i < FurnisherList.Count; i++)
            {
                if(FurnisherList[i].Id == NewFurnisherInfo.Id)
                {
                    FurnisherList[i] = NewFurnisherInfo;
                }
            }
        }
        /// <summary>
        /// Supprime un fournisseur dans la liste de fournisseur.
        /// </summary>
        /// <param name="IndexToDelete">Index dans la liste du fournisseur à supprimer.</param>
        public static void DeleteInFurnisherList(int IndexToDelete)
        {
            FurnisherList.RemoveAt(IndexToDelete);
        }
        #endregion
        #region Méthodes SearchedList
        /// <summary>
        /// Renvoie la liste des fournisseur trouvés lors d'une recherche d'un fournisseur.
        /// </summary>
        /// <returns></returns>
        public static IList<Fournisseur> GetSearchedList()
        {
            return FurnisherFoundList;
        }
        /// <summary>
        /// Sauvegarde le temps de l'exécution du programme la liste des fournisseurs trouvés lors de la recherche des fournisseurs.
        /// </summary>
        /// <param name="SearchedList">Liste de fournisseurs trouvés lors de la recherche.</param>
        public static void SetSearchedList(IList<Fournisseur> SearchedList)
        {
            FurnisherFoundList = SearchedList;
        }
        /// <summary>
        /// Vérifie si la liste de recherche est vide.
        /// </summary>
        /// <returns>true si la liste est vide, false si la liste est complétée.</returns>
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
        /// <summary>
        /// Renvoie le fournisseur sélectionné dans la liste des fournisseurs.
        /// </summary>
        /// <returns></returns>
        public static Fournisseur GetSelectedFournisseur()
        {
            return SelectedFournisseur;
        }
        /// <summary>
        /// Sauvegarde dans la mémoire tampon le temps de l'exécution du programme le fournisseur sélectionné dans la liste de fournisseurs.
        /// </summary>
        /// <param name="Furnisher">Fournisseurs à sauvegarder dans la mémoire tampon.</param>
        public static void SetSelectedFournisseur(Fournisseur Furnisher)
        {
            SelectedFournisseur = Furnisher;
        }
        #endregion
    }
}