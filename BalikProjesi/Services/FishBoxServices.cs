using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Services
{
    public class FishBoxServices : IFishBoxServices
    {
        public readonly IMongoCollection<FishBox> db;
        public FishBoxServices()
        {
            var Mongo = new DbContext();
            db = Mongo._fbox;
        }

        public void Create(FishBox fishbox)
        {
            var Islem = CheckFBox(fishbox.Id);
            if (Islem)
            {
                
                db.InsertOne(fishbox);
            }

        }

        public bool CheckFBox(string BoxId)
        {
            var result = db.Find(x => x.Id == BoxId).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public FishBox Get(string Fbcode)
        {
            var result = db.Find(x => x.FishBoxCode == Fbcode).FirstOrDefault();
            return result;
        }
        public List<FishBox> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }
        public bool Update(FishBox fishbox)
        {


            if (!String.IsNullOrEmpty(fishbox.Id) && !String.IsNullOrEmpty(fishbox.FishBoxType) && fishbox.UpdateDate != DateTime.MinValue)
            {
                var Filter = Builders<FishBox>.Filter
                    .Eq(x => x.Id, fishbox.Id);

                var Update = Builders<FishBox>.Update
                    .Set(x => x.FishBoxCode, fishbox.FishBoxCode)
                    .Set(x => x.FishBoxType, fishbox.FishBoxType)
                    .Set(x => x.UpdateDate, fishbox.UpdateDate)
                    .Set(x => x.CartId, fishbox.CartId);
                try
                {
                    db.UpdateOne(Filter, Update);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public bool Delete(string fishboxID)
        {
            try
            {
                var Filter = Builders<FishBox>.Filter.Eq(x => x.FishBoxCode, fishboxID);
                db.DeleteOne(Filter);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
