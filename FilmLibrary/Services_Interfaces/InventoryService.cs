using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "InventoryService" à la fois dans le code et le fichier de configuration.
    public class InventoryService : IInventoryService
    {
        DBContext db = new DBContext();
        public Inventory Add(Inventory inventaire)
        {
            try
            {
                db.Inventories.Add(inventaire);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return inventaire;
        }

        public Inventory Find(int id)
        {
            try
            {
                return db.Inventories.Where(i => i.ID.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Inventory> FindInventaireFilm(Film film)
        {
            try
            {
                return db.Inventories.Where(i => i.Film.Equals(film)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Inventory> FindInventaireStore(Store store)
        {
            try
            {
                return db.Inventories.Where(s => s.Store.Equals(store)).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Inventory> FindAll()
        {
            try
            {
                return db.Inventories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
