using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Adresse
    {
        [DataMember]
        public int AdresseId { get; set; }

        [DataMember]
        public String adresse { get; set; }

        [DataMember]
        public String phone { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }
    }
}
