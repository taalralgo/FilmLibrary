using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(255)]
        public string Title { get; set; }

        [DataMember]
        [Column(TypeName = "TEXT")]
        public string Description { get; set; }

        [DataMember]
        public DateTime Release_year { get; set; }

        [DataMember]
        public int Rental_duration { get; set; }

        [DataMember]
        public int Rental_rate { get; set; }

        [DataMember]
        public int Lenght { get; set; }

        [DataMember]
        public int Rental { get; set; }

        [DataMember]
        public Language Language { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }
    }
}
