using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Models
{
    public class RaporListviewModel
    {
        public string FiletoPersonel { get; set; }
        public string KontrolPersonel { get; set; }
        public string KasaAd { get; set; }
        public int BicakDefo { get; set; }
        public int KilcikDefo { get; set; }
        public int HasatDefo { get; set; }
        public int OdLekesi { get; set; }
        public DateTime FBasTar { get; set; }
        public DateTime FBitTar { get; set; }
        public DateTime FİsSure { get; set; }
        public DateTime KBasTar { get; set; }
        public DateTime KBitTar { get; set; }
        public DateTime KİsSure { get; set; }

    }
}
