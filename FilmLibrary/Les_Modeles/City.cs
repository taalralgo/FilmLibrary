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
    public class City
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Nom { get; set; }

        [DataMember]
        [ForeignKey("Country")]
        public int CountryID { get; set; }
        [DataMember]
        public Country Country { get; set; }
    }
}
