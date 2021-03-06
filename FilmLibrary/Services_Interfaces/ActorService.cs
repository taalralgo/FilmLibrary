﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FilmLibrary.Les_Modeles;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "ActorService" à la fois dans le code et le fichier de configuration.
    public class ActorService : IActorService
    {
        DBContext db = new DBContext();
        public Actor Add(Actor acteur)
        {
            try
            {
                db.Actors.Add(acteur);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return acteur;
        }

        public Actor Find(int acteurId)
        {
            try
            {
                return db.Actors.Where(acteur => acteur.ID.Equals(acteurId)).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Actor FindByName(string nom,string prenom)
        {
            try
            {
                return db.Actors.Where(acteur => acteur.Nom.ToLower().Equals(nom.ToLower()) && acteur.Prenom.ToLower().Equals(prenom.ToLower())).FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Actor> FindAll()
        {
            //return db.Actors.Select(acteur => new { Id = acteur.ActeurId, Nom = acteur.ActeurNom, Prénom = acteur.ActeurPrenom }).ToList();
            return db.Actors.ToList();
        }

        public int Modifier(string anciennom, string ancienprenom, string nouveaunom, string nouveauprenom)
        {
            try
            {
                Actor tampon = new Actor();
                tampon = FindByName(anciennom, ancienprenom);
                tampon.Nom = nouveaunom.ToUpper();
                tampon.Prenom = nouveauprenom;
                return db.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
