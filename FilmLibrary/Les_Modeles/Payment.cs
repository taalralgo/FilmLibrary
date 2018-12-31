using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Payment
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public int Amount { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        [ForeignKey("Staff")]
        public int StaffID { get; set; }
        [DataMember]
        public Staff Staff { get; set; }

        [DataMember]
        [ForeignKey("Rental")]
        public int RentalID { get; set; }
        [DataMember]
        public Rental Rental { get; set; }

    }
}
