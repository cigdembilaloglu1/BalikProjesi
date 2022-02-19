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
        public void Create(string Cname)
        {
            var Islem = CheckName(Cname);
            if (Islem)
            {
                Carts EklenecekVeri = new Carts();
                EklenecekVeri.CartName = Cname;

                if (Cname != null)
                {
                    db.InsertOne(EklenecekVeri);
                }

            }


        }

        public bool CheckName(string Cname)
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

        public List<Carts> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }
        public bool Update(string _id, string Cname = null)
        {
            if (!String.IsNullOrEmpty(Cname))
            {
                var Filter = Builders<Carts>.Filter
                    .Eq(x => x.Id, _id);

                var Update = Builders<Carts>.Update
                    .Set(x => x.CartName, Cname);

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

        public bool Delete(string Cname)
        {
            try
            {
                var Filter = Builders<Carts>.Filter.Eq(x => x.CartName, Cname);
                db.DeleteOne(Filter);
                return true;
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
