﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Store
    {
        [DataMember]
        public int StoreId { get; set; }

        [DataMember]
        public Adresse adresse { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }

    }
}