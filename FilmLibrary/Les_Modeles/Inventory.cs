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
        public virtual int FilmId { get; set; }

        [DataMember]
        public virtual int StoreId { get; set; }
    }
}
