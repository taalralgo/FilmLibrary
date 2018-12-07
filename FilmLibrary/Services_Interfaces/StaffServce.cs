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
        public int Add(Staff staff)
        {
            try
            {
                db.Staffs.Add(staff);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Staff Find(int id)
        {
            try
            {
                return db.Staffs.Where(s => s.StaffId.Equals(id)).FirstOrDefault();
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
                staff.StaffAdresse = adresse;
                staff.StaffPicture = photo;
                staff.StaffStore = store;
                staff.StaffActive = etat;
                staff.StaffNom = nom;
                staff.StaffPrenom = prenom;
                staff.StaffEmail = email;
                staff.StaffUserName = username;
                staff.StaffPasswd = password;
                staff.StaffRole = role;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
