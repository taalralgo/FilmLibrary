using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "LanguageService" à la fois dans le code et le fichier de configuration.
    public class LanguageService : ILanguageService
    {
        DBContext db = new DBContext();
        public int Add(Language language)
        {
            try
            {
                db.Languages.Add(language);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, string nom)
        {
            try
            {
                Language language = new Language();
                language = db.Languages.Where(l => l.LanguageId.Equals(id)).FirstOrDefault();
                language.LanguageName = nom;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
