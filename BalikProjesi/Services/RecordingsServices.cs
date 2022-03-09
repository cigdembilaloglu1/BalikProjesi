using BalikProjesi.Entities;
using MongoDB.Bson;
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

        public List<Recordings> TarihArama(DateTime Baslangic, DateTime Bitis, string Tip)
        {
            var records = new List<Recordings>();
            // TP : Kayit, Fileto, Kontrol
            if(Tip == "Kayit")
            {
                var Query = new BsonDocument
                {
                    {
                        "CreateDate" , new BsonDocument
                        {
                            {"$gte", Baslangic },
                            {"$lte", Bitis }
                        }
                    }
                };
                records = db.Find(Query).ToList();
            }
            else if ( Tip == "Fileto")
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Gte("FilletOpeningDate", Baslangic) &
                             filterBuilder.Lte("FilletClosingDate", Bitis);
                records = db.Find(filter).ToList();
            }
            else if(Tip == "Kontrol")
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Gte("ControllerOpeningDate", Baslangic) &
                             filterBuilder.Lte("ControllerClosingDate", Bitis);
                records = db.Find(filter).ToList();
            }

            return records;
        }
        public List<Recordings> FiletoArama(string Id)
        {
            var records = new List<Recordings>();
            if (true) 
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.FilletID, Id);
                             
                records = db.Find(filter).ToList();

            }
            return records;
        }
        public List<Recordings> FiletoTarihArama(string Id, DateTime Baslangic, DateTime Bitis)
        {
            var records = new List<Recordings>();
            if (true)
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.FilletID, Id) &
                             filterBuilder.Gte(x => x.FilletOpeningDate, Baslangic) &
                             filterBuilder.Lte(x => x.FilletClosingDate, Bitis);
                  
                records = db.Find(filter).ToList();

            }
            return records;
        }
        public List<Recordings> KontrolArama(string Id)
        {
            var records = new List<Recordings>();
            if (true)
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.ControllerID, Id);

                records = db.Find(filter).ToList();

            }
            return records;
        }
        public List<Recordings> KontrolTarihArama(string Id, DateTime Baslangic, DateTime Bitis)
        {
            var records = new List<Recordings>();
            if (true)
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.ControllerID, Id) &
                             filterBuilder.Gte(x => x.ControllerOpeningDate, Baslangic) &
                             filterBuilder.Lte(x => x.ControllerClosingDate, Bitis);

                records = db.Find(filter).ToList();

            }
            return records;
        }
        public List<Recordings> BoxArama(string Id)
        {
            var records = new List<Recordings>();
            if (true)
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.FishboxID, Id);
                records = db.Find(filter).ToList();

            }
            return records;
        }
        public List<Recordings> BoxTarihArama(string Id, DateTime Baslangic, DateTime Bitis)
        {
            var records = new List<Recordings>();
            if (true)
            {
                var filterBuilder = Builders<Recordings>.Filter;
                var filter = filterBuilder.Eq(x => x.FishboxID, Id) &
                             filterBuilder.Gte(x => x.FilletOpeningDate, Baslangic) &
                             filterBuilder.Lte(x => x.ControllerClosingDate, Bitis);

                records = db.Find(filter).ToList();

            }
            return records;
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
        public Recordings CheckRecordValidByFishboxID(string ID)
        {
            DateTime MinDate = DateTime.MinValue.AddYears(10);
            var result = db.Find(x => x.FishboxID == ID && x.ControllerClosingDate < MinDate).FirstOrDefault();
            return result;
        }
        public Recordings CheckPersonelValidByPeronelID(string ID) 
        {
            DateTime MinDate = DateTime.MinValue.AddYears(10);
            var result=db.Find(x => x.FilletID==ID && x.FilletOpeningDate < MinDate).FirstOrDefault();
            return result;
         
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

        public bool FiletoArama()
        {
            throw new NotImplementedException();
        }

        public bool FiletoArama(Recordings Record)
        {
            throw new NotImplementedException();
        }
    }
}
