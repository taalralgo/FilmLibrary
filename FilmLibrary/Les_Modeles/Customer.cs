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
    public class Customer
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String Nom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String Prenom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String Email { get; set; }

        [DataMember]
        public byte[] Picture { get; set; }

        [DataMember]
        public bool Active { get; set; }

        [DataMember]
        public Store Store { get; set; }

        [DataMember]
        public Adresse Adresse { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
