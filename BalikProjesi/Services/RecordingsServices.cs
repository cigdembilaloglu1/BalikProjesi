using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BalikProjesi.Services
{
    public class RecordingsServices : IRecordingsServices
    {
        public readonly IMongoCollection<Recordings> db;

        public RecordingsServices()
        {
            var Mongo = new DbContext();
            db = Mongo._records;
        }

        //public void Create(int Fbone, int Defoo, int Knifee, int Reapingg)
        //{
        //    Recordings EklenecekVeri = new Recordings();
        //    EklenecekVeri.FishBone= Fbone;
        //    EklenecekVeri.Defo = Defoo;
        //    EklenecekVeri.Knife = Knifee;
        //    EklenecekVeri.Reaping = Reapingg;
        //    db.InsertOne(EklenecekVeri);

        //}

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
        public bool Create(Recordings Record)
        {
            try
            {

                db.InsertOne(Record);

            }
            catch (Exception)
            {

                throw;
            }

            return true;
        }

        public bool FilletClosing(Recordings Record)
        {
            var Filter = Builders<Recordings>.Filter.Eq(x => x.Id, Record.Id);
            var Update = Builders<Recordings>.Update
                    .Set(x => x.FilletClosingDate, Record.FilletClosingDate);
            try
            {
                db.UpdateOne(Filter, Update);
                return true;

            }
            catch (Exception)
            {
                return false;
                throw;
            }
                    
        }
        
        public bool CheckFilletClosing(Recordings Record)
        {
            if (Record.FilletClosingDate!=DateTime.MinValue)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        public bool ControllerOpening(Recordings Record)
        {
            var result=CheckFilletClosing(Record);
            if (result)
            {
                var Filter = Builders<Recordings>.Filter.Eq(x => x.Id, Record.Id);
                var Update = Builders<Recordings>.Update
                        .Set(x => x.ControllerCardId, Record.ControllerCardId)
                        .Set(x => x.ControllerID, Record.ControllerID)
                        .Set(x => x.ControllerOpeningDate, Record.ControllerOpeningDate);
                try
                {
                    db.UpdateOne(Filter, Update);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            else
            {
                return false;
            }
        }
        
        public bool ControllerClosing(Recordings Record)
        {
            var result = CheckFilletClosing(Record);
            if (result)
            {
                var Filter = Builders<Recordings>.Filter.Eq(x => x.Id, Record.Id);
                var Update = Builders<Recordings>.Update                        
                        .Set(x => x.ControllerClosingDate, Record.ControllerClosingDate)
                        .Set(x=>x.FishBone,Record.FishBone)
                        .Set(x => x.Defo, Record.Defo)
                        .Set(x => x.Knife, Record.Knife)
                        .Set(x => x.OdLekesi, Record.OdLekesi);
                try
                {
                    db.UpdateOne(Filter, Update);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
            }
            else
            {
                return false;
            }
        }

        public bool ChangeCardId(string OldCardId, string NewCardId)
        {
            try
            {
                var filterfishbox = Builders<Recordings>.Filter.Eq(x => x.FishboxID, OldCardId);
                var Updatefixbod = Builders<Recordings>.Update.Set(x => x.FishboxID, NewCardId);
                db.UpdateOne(filterfishbox, Updatefixbod);

                var controlCartfilter = Builders<Recordings>.Filter.Eq(x => x.ControllerCardId, OldCardId);
                var controlCartUpdate = Builders<Recordings>.Update.Set(x => x.ControllerCardId, NewCardId);
                db.UpdateOne(controlCartfilter, controlCartUpdate);

                var FiletoFilter = Builders<Recordings>.Filter.Eq(x => x.FilletCardId, OldCardId);
                var FiletUpdated = Builders<Recordings>.Update.Set(x => x.FilletCardId, NewCardId);
                db.UpdateOne(FiletoFilter, FiletUpdated);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
