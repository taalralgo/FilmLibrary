using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "ICountryService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface ICountryService
    {
        [OperationContract]
        int Add(Country country);

        [OperationContract]
        int Modifier(int countryId, string countryNom);

        [OperationContract]
        List<Country> FindAll();


    }
}
