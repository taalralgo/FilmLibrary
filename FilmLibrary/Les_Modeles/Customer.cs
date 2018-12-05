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
        public int ClientId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String ClientNom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public String ClientPrenom { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String ClientEmail { get; set; }

        [DataMember]
        public byte[] ClientPicture { get; set; }

        [DataMember]
        public bool ClientActive { get; set; }

        [DataMember]
        public Store StoreId { get; set; }

        [DataMember]
        public Adresse AdresseClient { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
