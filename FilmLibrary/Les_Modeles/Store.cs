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
    public class Store
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        [ForeignKey("Adresse")]
        public int AdresseID { get; set; }
        [DataMember]
        public Adresse Adresse { get; set; }

        [DataMember]
        public ICollection<Film> Films { get; set; }

        [DataMember]
        public ICollection<Customer> Clients { get; set; }

        [DataMember]
        public ICollection<Staff> Staffs { get; set; }

    }
}
