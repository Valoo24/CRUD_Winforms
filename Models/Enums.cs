using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    /// <summary>
    /// Définit le type de données que l'utilisateur va utiliser pour effectuer une recherche de fournisseur.
    /// </summary>
    public enum SearchType 
    { ID = 0, 
      Nom = 1,
      Pays = 2
    }
    /// <summary>
    /// Définit l'état d'attente de commande d'un fournisseur.
    /// </summary>
    public enum CommandStatus
    {
        Oui = 0,
        Non = 1
    }
    /// <summary>
    /// Définit le typé de données utilisée pour la sauvegarde ou le chargement de données.
    /// </summary>
    public enum TypeOfData
    {
        Fournisseur = 0,
        MailExtension = 1
    }
}
