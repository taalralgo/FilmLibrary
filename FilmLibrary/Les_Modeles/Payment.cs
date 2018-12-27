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
        public int ID { get; set; }

        [DataMember]
        public int Amount { get; set; }

        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public Customer Customer { get; set; }

        [DataMember]
        public Staff Staff { get; set; }

        [DataMember]
        public Rental Rental { get; set; }

    }
}
