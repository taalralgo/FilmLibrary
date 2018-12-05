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
    public class Category
    {
        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(25)]
        public String CategoryNom { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}
