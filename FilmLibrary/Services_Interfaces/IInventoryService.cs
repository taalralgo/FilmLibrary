using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IInventoryService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IInventoryService
    {
        [OperationContract]
        Inventory Add(Inventory inventaire);

        [OperationContract]
        List<Inventory> FindAll();

        [OperationContract]
        Inventory Find(int id);
        //Trouver tous les nventaires d'un film
        [OperationContract]
        List<Inventory> FindInventaireFilm(Film film);

        //Trouver tous les inventaires d'un store
        [OperationContract]
        List<Inventory> FindInventaireStore(Store store);
    }
}
