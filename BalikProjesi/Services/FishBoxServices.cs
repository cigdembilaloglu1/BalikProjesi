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

        public bool Create(FishBox fishbox)
        {
            var Islem = CheckFBox(fishbox.FishBoxCode);
            if (Islem)
            {
                
                db.InsertOne(fishbox);
            }
            return Islem;
        }

        public bool CheckFBox(string Code)
        {
            var result = db.Find(x => x.FishBoxCode == Code).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public FishBox GetById(string ID)
        {
            var result = db.Find(x => x.Id == ID).FirstOrDefault();
            return result;
        }
        public List<FishBox> Get(int page, int pageSize = 15)
        {
            var result = db.Find(x => true).Skip((page - 1) * pageSize).Limit(pageSize).ToList();
            return result;
        }
        public FishBox GetByCardCode(string ID)
        {
            var result = db.Find(x => x.CartId == ID).FirstOrDefault();
            return result;
        }
        public List<FishBox> GetFilteredFishBox(FilterDefinition<FishBox> filteredFishBox)
        {
            var result = db.Find(filteredFishBox).ToList();
            return result;
        }
        public long GetDocumentCount()
        {
            long docCount = db.CountDocuments(FilterDefinition<FishBox>.Empty);
            return docCount;
        }

        public bool UpdateCardInfo(FishBox fishbox)
        {

            if (!String.IsNullOrEmpty(fishbox.Id) && !String.IsNullOrEmpty(fishbox.FishBoxType))
            {
                var Filter = Builders<FishBox>.Filter.Eq(x => x.Id, fishbox.Id);
                var Update = Builders<FishBox>.Update
                    .Set(x => x.CartId, fishbox.CartId)
                    .Set(x => x.CartCode, fishbox.CartCode);
                try
                {
                    db.UpdateOne(Filter, Update);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
            }
            else
            {
                return false;
            }
            
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
                    .Set(x => x.CartCode, fishbox.CartCode)
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
                var Filter = Builders<FishBox>.Filter.Eq(x => x.Id, fishboxID);
                db.DeleteOne(Filter);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public object CheckRecordValidByFishboxID(string fishboxID)
        {
            throw new NotImplementedException();
        }
    }
}
