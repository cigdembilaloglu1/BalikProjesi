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
            var Islem = CheckFBox(fishbox.CartId);
            if (Islem)
            {
                
                db.InsertOne(fishbox);
            }

        }

        public bool CheckFBox(string cardID)
        {
            var result = db.Find(x => x.CartId == cardID).FirstOrDefault();
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
        public bool Update(string _id, string Ftype, DateTime Rdate, string FCode = null)
        {


            if (!String.IsNullOrEmpty(FCode) && !String.IsNullOrEmpty(Ftype) && Rdate != DateTime.MinValue)
            {
                var Filter = Builders<FishBox>.Filter
                    .Eq(x => x.Id, _id);

                var Update = Builders<FishBox>.Update
                    .Set(x => x.FishBoxCode, FCode)
                    .Set(x => x.FishBoxType, Ftype)
                    .Set(x => x.UpdateDate, Rdate);
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
        public bool Delete(string Fcode)
        {
            try
            {
                var Filter = Builders<FishBox>.Filter.Eq(x => x.FishBoxCode, Fcode);
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
