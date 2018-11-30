using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Les_Modeles
{
    [DataContract]
    public class Adresse
    {
        [DataMember]
        public int AdresseId { get; set; }

        [DataMember]
        public String AdresseNom { get; set; }

        [DataMember]
        public String Phone { get; set; }

        [DataMember]
        public String District { get; set; }

        [DataMember]
        public City CityId { get; set; }

        [DataMember]
        public ICollection<Store> Stores { get; set; }

        [DataMember]
        public ICollection<Customer> Clients { get; set; }

        [DataMember]
        public ICollection<Staff> Staffs { get; set; }
    }
}
