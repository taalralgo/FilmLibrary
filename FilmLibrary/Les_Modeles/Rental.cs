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
    public class Rental
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public DateTime ReturnDate { get; set; }

        [DataMember]
        [ForeignKey("Inventory")]
        public int InventoryID { get; set; }
        [DataMember]
        public Inventory Inventory { get; set; }

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
    }
}
