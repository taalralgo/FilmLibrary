using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CityService" à la fois dans le code et le fichier de configuration.
    public class CityService : ICityService
    {
        DBContext db = new DBContext();
        public int Add(City city)
        {
            try
            {
                db.Cities.Add(city);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public City Find(int cityId)
        {
            try
            {
                return db.Cities.Where(city => city.CityId.Equals(cityId)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<City> FindAll()
        {
            try
            {
                return db.Cities.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int cityId, string cityNom)
        {
            try
            {
                City city = new City();
                city = db.Cities.Find(cityId);
                if(city != null)
                    city.CityNom = cityNom;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
