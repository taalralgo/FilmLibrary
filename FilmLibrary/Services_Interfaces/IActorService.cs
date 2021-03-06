﻿using FilmLibrary.Les_Modeles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FilmLibrary.Services_Interfaces
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IActorService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IActorService
    {
        //AJOUTER UN ACTEUR
        [OperationContract]
        Actor Add(Actor acteur);

        //MODIFIER UN ACTEUR
        [OperationContract]
        int Modifier(string anciennom, string ancienprenom,string nouveaunom, string nouveauprenom);

        //RETOURNER TOUS LES ACTEURS SANS EXCEPTION SOUS FORME DE LISTE
        [OperationContract]
        List<Actor> FindAll();

        //TROUVER UN ACTEUR PAR ID
        [OperationContract]
        Actor Find(int acteurId);

        [OperationContract]
        Actor FindByName(string nom, string prenom);



    }
}
