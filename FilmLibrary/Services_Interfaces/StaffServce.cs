using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "StaffServce" à la fois dans le code et le fichier de configuration.
    public class StaffServce : IStaffServce
    {
        DBContext db = new DBContext();
        public Staff Add(Staff staff)
        {
            try
            {
                db.Staffs.Add(staff);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return staff;
        }

        public Staff Find(int id)
        {
            try
            {
                return db.Staffs.Where(s => s.ID.Equals(id)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Staff> FindAll()
        {
            try
            {
                return db.Staffs.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int id, Adresse adresse, byte[] photo, Store store, bool etat, string nom, string prenom, string email, string username, string password, string role)
        {
            try
            {
                Staff staff = new Staff();
                staff.Adresse = adresse;
                staff.Picture = photo;
                staff.Store = store;
                staff.Active = etat;
                staff.Nom = nom;
                staff.Prenom = prenom;
                staff.Email = email;
                staff.UserName = username;
                staff.Passwd = password;
                staff.Role = role;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
