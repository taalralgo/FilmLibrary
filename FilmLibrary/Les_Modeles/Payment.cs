using System;
using System.Collections.Generic;
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
        public int PaymentId { get; set; }

        [DataMember]
        public int PaymentAmount { get; set; }

        [DataMember]
        public DateTime PaymentDate { get; set; }

        [DataMember]
        public virtual int CustomerId { get; set; }

        [DataMember]
        public virtual int StaffId { get; set; }

        [DataMember]
        public virtual int RentalId { get; set; }

    }
}
