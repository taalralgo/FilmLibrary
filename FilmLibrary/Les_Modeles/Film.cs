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
        public string FilmDescription { get; set; }

        [DataMember]
        public DateTime FilmRelease_year { get; set; }

        [DataMember]
        public int FilmRental_duration { get; set; }

        [DataMember]
        public int FilmRental_rate { get; set; }

        [DataMember]
        public int FilmLenght { get; set; }

        [DataMember]
        public int FilmRental { get; set; }

        [DataMember]
        public Language FilmLanguage { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }
    }
}
