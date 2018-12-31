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
    public class Inventory
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [ForeignKey("Film")]
        public int FilmID { get; set; }
        [DataMember]
        public Film Film { get; set; }

        [DataMember]
        [ForeignKey("Store")]
        public int StoreID { get; set; }
        [DataMember]
        public Store Store { get; set; }
    }
}