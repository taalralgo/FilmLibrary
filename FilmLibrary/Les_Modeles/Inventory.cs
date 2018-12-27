using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Inventory
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public Film Film { get; set; }

        [DataMember]
        public Store Store { get; set; }
    }
}