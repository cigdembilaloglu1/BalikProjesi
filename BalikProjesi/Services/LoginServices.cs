using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Services
{
    public class LoginServices : ILoginServices
    {
        public readonly IMongoCollection<Login> db;

        public LoginServices()
        {
            var Mongo = new DbContext();
            db = Mongo._login;
        }


        public void Create(string _uname, string _pass)
        {
            var Islem = CheckUser(_uname);
            if (Islem)
            {
                Login EklenecekVeri = new Login();
                EklenecekVeri.UserName = _uname;
                
                EklenecekVeri.Password = _pass;
                if (_uname !=null && _pass !=null)
                {
                    db.InsertOne(EklenecekVeri);
                }
                
            }
            
        }

        public Login Get(string _id)
        {
            var result = db.Find(x => x.Id == _id).FirstOrDefault();
            return result;
        }
        public Login GetByName(string name)
        {
            var Filter = Builders<Login>.Filter.Regex(x => x.UserName, new MongoDB.Bson.BsonRegularExpression(name, "i"));
            var result = db.Find(Filter).FirstOrDefault();
            return result;
        }
        public List<Login> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }

        public bool Update(string _id, string _Username = null, string _Password = null)
        {
            if (!String.IsNullOrEmpty(_Username) && !String.IsNullOrEmpty(_Password))
            {
                var Filter = Builders<Login>.Filter
                    .Eq(x => x.Id, _id);

                var Update = Builders<Login>.Update
                    .Set(x => x.UserName, _Username)
                    .Set(x => x.Password, _Password);
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

        public bool Delete(string _id)
        {
            try
            {
                var Filter = Builders<Login>.Filter.Eq(x => x.Id, _id);
                db.DeleteOne(Filter);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool CheckLogin(string _UserName, string _Password)
        {
            try
            {
                var Filter = Builders<Login>.Filter.Regex(x => x.UserName, new MongoDB.Bson.BsonRegularExpression(_UserName, "i"));
                Filter &= Builders<Login>.Filter.Eq(x => x.Password, _Password);
                var result = db.Find(Filter).FirstOrDefault();
                if (result == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch

            {
                return false;
            }

        }
        public bool CheckUser(string _UserName)
        {

            var result = db.Find(x => x.UserName == _UserName).FirstOrDefault();
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
