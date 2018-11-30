using System;
using System.Collections.Generic;
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
        public string StaffPrenom { get; set; }

        [DataMember]
        public byte[] StaffPicture { get; set; }

        [DataMember]
        public String StaffEmail { get; set; }

        [DataMember]
        public bool StaffActive { get; set; }

        [DataMember]
        public String StaffUserName { get; set; }

        [DataMember]
        public String StaffPasswd { get; set; }

        [DataMember]
        public Adresse StaffAdresse { get; set; }

        [DataMember]
        public ICollection<Payment> Payments { get; set; }

        [DataMember]
        public ICollection<Rental> Rentals { get; set; }
    }
}
