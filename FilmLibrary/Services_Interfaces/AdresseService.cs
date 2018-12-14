using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "AdresseService" à la fois dans le code et le fichier de configuration.
    public class AdresseService : IAdresseService
    {
        DBContext db = new DBContext();
        public Adresse Add(Adresse adresse)
        {
            try
            {
                db.Adresses.Add(adresse);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return adresse;
        }

        public Adresse Find(int adresseId)
        {
            return db.Adresses.Where(adr => adr.AdresseId.Equals(adresseId)).FirstOrDefault();
        }

        public List<Adresse> FindAll()
        {
            try
            {
                return db.Adresses.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int adresseId, string adresseNom)
        {
            try
            {
                Adresse adr = new Adresse();
                adr = db.Adresses.Find(adresseId);
                if (adr != null)
                    adr.AdresseNom = adresseNom;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
