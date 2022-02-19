using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi
{
    public class DbContext
    {
        private readonly IMongoClient _mongoDbClient;
        private readonly IMongoDatabase _mongoDb;
        public readonly IMongoCollection<Login> _login;
        public readonly IMongoCollection<Personel> _fpersonel;
        public readonly IMongoCollection<Personel> _cpersonel;
        public readonly IMongoCollection<FishBox> _fbox;
        public readonly IMongoCollection<Carts> _carts;
        public readonly IMongoCollection<Recordings> _records;
       
        public DbContext()
        {
            _mongoDbClient = new MongoClient("mongodb://localhost:27017");
            _mongoDb = _mongoDbClient.GetDatabase("LuckyFish");
            _login = _mongoDb.GetCollection<Login>("Login");
            _fpersonel = _mongoDb.GetCollection<Personel>("FilletPersonnel");
            _cpersonel = _mongoDb.GetCollection<Personel>("ControllerPersonnel");
            _fbox = _mongoDb.GetCollection<FishBox>("FishBox");
            _carts = _mongoDb.GetCollection<Carts>("Carts");
            _records= _mongoDb.GetCollection<Recordings>("Recordings");
        }
        

    }
}
