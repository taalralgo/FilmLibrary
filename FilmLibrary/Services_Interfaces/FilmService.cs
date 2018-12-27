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
                return db.Films.Where(film => film.ID.Equals(id)).FirstOrDefault();
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
                film = db.Films.Where(f => f.ID.Equals(id)).FirstOrDefault();
                if (film != null)
                {
                    film.Release_year = release_year;
                    film.Lenght = length;
                    if (titre != null)
                        film.Title = titre;
                    if (description != null)
                        film.Description = titre;
                    if (language != null)
                        film.Language = language;
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
