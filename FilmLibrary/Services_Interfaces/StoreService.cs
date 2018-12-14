using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "StoreService" à la fois dans le code et le fichier de configuration.
    public class StoreService : IStoreService
    {
        DBContext db = new DBContext();
        public Store Add(Store store)
        {
            try
            {
                db.Stores.Add(store);
                db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
            return store;
        }

        public Store Find(int id)
        {
            try
            {
                return db.Stores.Where(s => s.StoreId.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Store> FindAll()
        {
            try
            {
                return db.Stores.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, Staff manager)
        {
            try
            {
                Store store = new Store();
                store.StaffId = manager;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
