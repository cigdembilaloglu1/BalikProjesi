using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BalikProjesi.Services
{
    public class RecordingsServices
    {
        public readonly IMongoCollection<Recordings> db;

        public RecordingsServices()
        {
            var Mongo = new DbContext();
            db = Mongo._records;
        }

        public void Create(int Fbone, int Defoo, int Knifee, int Reapingg)
        {
            Recordings EklenecekVeri = new Recordings();
            EklenecekVeri.FishBone= Fbone;
            EklenecekVeri.Defo = Defoo;
            EklenecekVeri.Knife = Knifee;
            EklenecekVeri.Reaping = Reapingg;
            db.InsertOne(EklenecekVeri);
      
        }
        public Recordings Get(string _id)
        {
            var result = db.Find(x => x.Id == _id).FirstOrDefault();
            return result;
        }
        public List<Recordings> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }


    }
}
