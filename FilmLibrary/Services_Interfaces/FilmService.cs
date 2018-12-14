using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "FilmService" à la fois dans le code et le fichier de configuration.
    public class FilmService : IFilmService
    {
        DBContext db = new DBContext();
        public Film Add(Film film)
        {
            try
            {
                db.Films.Add(film);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return film;
        }

        public Film Find(int id)
        {
            try
            {
                return db.Films.Where(film => film.FilmId.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Film> FindAll()
        {
            try
            {
                return db.Films.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, DateTime release_year, int length, string titre = null, string description = null, Language language = null)
        {
            try
            {
                Film film = new Film();
                film = db.Films.Where(f => f.FilmId.Equals(id)).FirstOrDefault();
                if (film != null)
                {
                    film.FilmRelease_year = release_year;
                    film.FilmLenght = length;
                    if (titre != null)
                        film.FilmTitle = titre;
                    if (description != null)
                        film.FilmDescription = titre;
                    if (language != null)
                        film.LanguageId = language;
                }
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
