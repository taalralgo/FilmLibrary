using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CountryService" à la fois dans le code et le fichier de configuration.
    public class CountryService : ICountryService
    {
        DBContext db = new DBContext();
        public Country Add(Country country)
        {
            try
            {
                db.Countries.Add(country);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return country;
        }

        public List<Country> FindAll()
        {
            try
            {
                return db.Countries.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int countryId, string countryNom)
        {
            Country count = new Country();
            count = db.Countries.Where(country => country.ID.Equals(countryId)).FirstOrDefault();
            if (count != null)
                count.Nom = countryNom;
            return db.SaveChanges();

        }
    }
}
