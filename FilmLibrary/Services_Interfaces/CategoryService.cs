using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "CategoryService" à la fois dans le code et le fichier de configuration.
    public class CategoryService : ICategoryService
    {
        DBContext db = new DBContext();
        public Category Add(Category categorie)
        {
            try
            {
                db.Categories.Add(categorie);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return categorie;
        }

        public Category Find(string nom)
        {
            try
            {
                return db.Categories.Where(catego => catego.Nom.Equals(nom)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Category> FindAll()
        {
            try
            {
                return db.Categories.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category FindByName(string name)
        {
            try
            {
                return db.Categories.Where(catego => catego.Nom.ToLower().Equals(name.ToLower())).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(string Aciennom, string NouveauNom)
        {
            try
            {
                Category cat = new Category();
                cat = Find(Aciennom);
                if(cat != null)
                    cat.Nom = NouveauNom.ToUpper();
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
