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
    public class Actor
    {
        [DataMember]
        
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public string ActeurNom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(15)]
        public String ActeurPrenom { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }
    }
}
