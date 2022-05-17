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
    { ID, 
      Nom,
      Pays
    }
    /// <summary>
    /// Définit l'état d'attente de commande d'un fournisseur.
    /// </summary>
    public enum CommandStatus
    {
        Oui,
        Non
    }
    /// <summary>
    /// Définit le typé de données utilisée pour la sauvegarde ou le chargement de données.
    /// </summary>
    public enum TypeOfData
    {
        Fournisseur,
        MailExtension
    }
}
