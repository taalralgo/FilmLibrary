﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Actor
    {
        [DataMember]
        public int ActeurId { get; set; }

        [DataMember]
        public string ActeurNom { get; set; }

        [DataMember]
        public String ActeurPrenom { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}
