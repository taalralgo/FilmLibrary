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
        public int InventoryId { get; set; }

        [DataMember]
        public virtual int Film_Id { get; set; }

        [DataMember]
        public virtual int Store_Id { get; set; }
    }
}
