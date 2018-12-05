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
        public String StaffId { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(45)]
        public string StaffPrenom { get; set; }

        [DataMember]
        public byte[] StaffPicture { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(50)]
        public String StaffEmail { get; set; }

        [DataMember]
        public bool StaffActive { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(16)]
        public String StaffUserName { get; set; }

        [DataMember]
        [Column(TypeName = "VARCHAR")]
        [StringLength(40)]
        public String StaffPasswd { get; set; }

        [DataMember]
        public Adresse StaffAdresse { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
