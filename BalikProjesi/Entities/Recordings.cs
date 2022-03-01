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
        public string FishboxID { get; set; }
        public string FilletID { get; set; }
        public string FilletCardId { get; set; }
        public DateTime FilletOpeningDate { get; set; }
        public DateTime FilletClosingDate { get; set; }
        public string ControllerID { get; set; }
        public string ControllerCardId { get; set; }
        public DateTime ControllerOpeningDate { get; set; }
        public DateTime ControllerClosingDate { get; set; }        
        public string FishBone { get; set; }
        public string Defo { get; set; }
        public string Knife { get; set; }
        public string OdLekesi { get; set; }
        
        

    }
}
