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
    public class Country
    {
        [DataMember]
        public int CountryId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public string CountryNom { get; set; }

        [DataMember]
        public ICollection<City> Cities { get; set; }
    }
}
