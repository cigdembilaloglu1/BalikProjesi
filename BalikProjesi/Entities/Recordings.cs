using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Entities
{
    public class Recordings
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool FilletStatus { get; set; }
        public bool ControlStatus { get; set; }
        public bool FishboxStatus { get; set; }
        public string FishboxID { get; set; }
        public string FilletID { get; set; }
        public string FilletCardId { get; set; }
        public DateTime FilletOpeningDate { get; set; }
        public DateTime FilletClosingDate { get; set; }
        public string ControllerID { get; set; }
        public string ControllerCardId { get; set; }
        public DateTime ControllerOpeningDate { get; set; }
        public DateTime ControllerClosingDate { get; set; }        
        public int FishBone { get; set; }
        public int Defo { get; set; }
        public int Knife { get; set; }
        public int OdLekesi { get; set; }
        
        

    }
}
