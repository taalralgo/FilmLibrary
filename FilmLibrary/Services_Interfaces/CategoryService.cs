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
        public int Add(Category categorie)
        {
            try
            {
                db.Categories.Add(categorie);
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Category Find(int categoryId)
        {
            try
            {
                return db.Categories.Where(catego => catego.CategoryId.Equals(categoryId)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int Modifier(int categoryId, string categoryNom)
        {
            try
            {
                Category cat = new Category();
                cat = db.Categories.Find(categoryId);
                if(cat != null)
                    cat.CategoryNom = categoryNom;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
