using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICityService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICityService
    {
        [OperationContract]
        City Add(City city);

        [OperationContract]
        int Modifier(int cityId, string cityNom);

        [OperationContract]
        List<City> FindAll();

        [OperationContract]
        City Find(int cityId);
    }
}
