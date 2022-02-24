using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Services
{
    public class CartsServices : ICartsServices1
    {
        public readonly IMongoCollection<Carts> db;

        public CartsServices()
        {
            var Mongo = new DbContext();
            db = Mongo._carts;
        }
        public bool Create(Carts Data)
        {
            var Islem = CheckCard(Data.CartCode);
            if (Islem)
            {

                db.InsertOne(Data);

            }
            return Islem;


        }

        public bool CheckCard(string cardID)
        {
            var result = db.Find(x => x.CartCode == cardID).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public List<Carts> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }
        public Carts GetByCardCode(string cardcode)
        {
            
            var result = db.Find(x => x.CartCode == cardcode).FirstOrDefault();
            return result;
        }
        public bool Update(Carts card, string Cname = null)
        {
            if (!String.IsNullOrEmpty(Cname))
            {
                var Filter = Builders<Carts>.Filter
                    .Eq(x => x.Id, card.Id);

                var Update = Builders<Carts>.Update
                    .Set(x => x.CartName, Cname)
                    .Set(x => x.UpdateDate, card.UpdateDate)
                    .Set(x => x.CartCode, card.CartCode)
                    .Set(x => x.CartType, card.CartType);

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

        public bool Delete(string cardID)
        {
            try
            {
                if (!string.IsNullOrEmpty(cardID))
                {
                    var Filter = Builders<Carts>.Filter.Eq(x => x.Id, cardID);
                    db.DeleteOne(Filter);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
        }
        public bool CheckUser(string Cname)
        {

            var result = db.Find(x => x.CartName == Cname).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

      
      
    }
}
