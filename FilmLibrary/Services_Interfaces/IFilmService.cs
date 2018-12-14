using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IFilmService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IFilmService
    {
        [OperationContract]
        Film Add(Film film);

        [OperationContract]
        int Modifier(int id, DateTime release_year, int length, string titre = null, string description = null, Language language = null);

        [OperationContract]
        List<Film> FindAll();

        [OperationContract]
        Film Find(int id);
    }
}
