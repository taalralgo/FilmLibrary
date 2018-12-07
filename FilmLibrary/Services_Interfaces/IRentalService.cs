using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IRentalService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IRentalService
    {
        [OperationContract]
        int Add(Rental rental);

        [OperationContract]
        int Modifier(int id, DateTime dateRetour);

        [OperationContract]
        List<Rental> FindAll();

        [OperationContract]
        Rental Find(int id);
    }
}
