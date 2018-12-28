using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IStaffServce" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IStaffServce
    {
        [OperationContract]
        Staff Add(Staff staff);

        [OperationContract]
        List<Staff> FindAll();

        [OperationContract]
        Staff Find(int id);

        [OperationContract]
        Staff FindUser(string username);

        [OperationContract]
        int Modifier(int id, Adresse adresse,byte[] photo, Store store, bool etat, string nom, string prenom, string email, string username, string password, string role);
        
    }
}
