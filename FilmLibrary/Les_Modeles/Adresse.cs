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
    public class Adresse
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Nom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public String Phone { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public String District { get; set; }

        [DataMember]
        [ForeignKey("City")]
        public int CityID { get; set; }
        [DataMember]
        public City City { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }

        [DataMember]
        public ICollection<Customer> Clients { get; set; }

        [DataMember]
        public ICollection<Staff> Staffs { get; set; }
    }
}
