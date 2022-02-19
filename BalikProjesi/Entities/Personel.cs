using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Entities
{
    public class Personel:BaseEntity
    {
        public string PersonelName { get; set; }
        public string PersonelSurname { get; set; }
        public string PersonelCode { get; set; }
        public string PersonelGroup { get; set; }
      
    }
}
