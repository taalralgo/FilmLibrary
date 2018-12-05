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
        public int CityId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String CityNom { get; set; }

        [DataMember]
        public Country CountryId { get; set; }
    }
}
