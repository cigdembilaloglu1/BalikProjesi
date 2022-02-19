using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Entities
{
    public class FishBox:BaseEntity
    {
        public string FishBoxCode { get; set; }
        public string FishBoxType { get; set; }
        public DateTime RecordDate { get; set; }
        
    }
}
