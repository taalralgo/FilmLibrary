using System;
using System.Collections.Generic;
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
        public int RentalId { get; set; }

        [DataMember]
        public DateTime RentalDate { get; set; }

        [DataMember]
        public DateTime RentalReturnDate { get; set; }

        [DataMember]
        public Inventory InventoryId { get; set; }

        [DataMember]
        public Customer CustomerId { get; set; }

        [DataMember]
        public Staff StaffId { get; set; }
    }
}
