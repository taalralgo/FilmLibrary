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
    public class Staff
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public string Prenom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public string Nom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public string Role { get; set; }

        [DataMember]
        public byte[] Picture { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Email { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(16)]
        public String UserName { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public String Passwd { get; set; }

        [DataMember]

        [ForeignKey("Adresse")]
        public int AdresseID { get; set; }
        [DataMember]
        public Adresse Adresse { get; set; }

        [DataMember]

        [ForeignKey("Store")]
        public int StoreID { get; set; }
        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
