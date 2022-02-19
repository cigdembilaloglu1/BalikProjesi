using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Entities
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CartId { get; set; }
        public int PersonnelId { get; set; }
        public string CartCode { get; set; }
        public string CartType { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }

    }
}
