using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "RentalService" à la fois dans le code et le fichier de configuration.
    public class RentalService : IRentalService
    {
        DBContext db = new DBContext();
        public Rental Add(Rental rental)
        {
            try
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return rental;
        }

        public Rental Find(int id)
        {
            try
            {
                return db.Rentals.Where(r => r.ID.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Rental> FindAll()
        {
            try
            {
                return db.Rentals.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, DateTime dateRetour)
        {
            try
            {
                Rental rental = new Rental();
                rental.Date = dateRetour;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
