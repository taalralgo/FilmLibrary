using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Film
    {
        [DataMember]
        public int FilmId { get; set; }

        [DataMember]
        public string FilmTitle { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public int Release_year { get; set; }

        [DataMember]
        public int Rental_duration { get; set; }

        [DataMember]
        public int Rental_rate { get; set; }

        [DataMember]
        public int Lenght { get; set; }

        [DataMember]
        public int Rental { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }
    }
}
