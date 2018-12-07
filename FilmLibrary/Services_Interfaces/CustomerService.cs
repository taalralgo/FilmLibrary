using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CustomerService" à la fois dans le code et le fichier de configuration.
    public class CustomerService : ICustomerService
    {
        DBContext db = new DBContext();
        public int Add(Customer client)
        {
            try
            {
                db.Customers.Add(client);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Customer Find(int clientId)
        {
            try
            {
                return db.Customers.Where(client => client.CustomerId.Equals(client)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Customer> FindAll()
        {
            try
            {
                return db.Customers.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, bool active, string nom = null, string prenom = null, string email = null, byte[] photo = null)
        {
            try
            {
                Customer client = new Customer();
                client = db.Customers.Where(c => c.CustomerId.Equals(id)).FirstOrDefault();
                if (client != null)
                {
                    client.CustomerActive = active;
                    if (nom != null)
                        client.CustomerNom = nom;
                    if (prenom != null)
                        client.CustomerPrenom = prenom;
                    if (email != null)
                        client.CustomerEmail = email;
                    if (photo != null)
                        client.CustomerPicture = photo;
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
