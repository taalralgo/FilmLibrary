using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICustomerService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        int Add(Customer client);

        [OperationContract]
        int Modifier(int id, bool active, string nom = null, string prenom = null, string email = null, byte[] photo = null);

        //RETOURNER TOUTS LES CLIENTS
        [OperationContract]
        List<Customer> FindAll();

        //RETOURNER UN CLIENT
        [OperationContract]
        Customer Find(int clientId);

    }
}
