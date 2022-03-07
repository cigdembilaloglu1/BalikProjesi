using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BalikProjesi.Enums;

namespace BalikProjesi.Services
{
    public class PersonelServices : IPersonelServices
    {
        public readonly IMongoCollection<Personel> cdb, fdb;

        // private readonly object _pid;

        public PersonelServices()
        {
            var Mongo = new DbContext();
            fdb = Mongo._fpersonel;
            cdb = Mongo._cpersonel;
        }
        public bool Create(Personel personel, string persType)
        {
            var Islem = CheckPCode(personel, persType);
            if (Islem)
            {
                if (persType == InputEnums.Fileto)
                {
                    fdb.InsertOne(personel);
                }
                else
                {
                    cdb.InsertOne(personel);
                }
            }
            return Islem;
        }

        public bool CheckPCode(Personel pers, string persType)
        {


            if (persType == InputEnums.Fileto)
            {
                var result = fdb.Find(x => x.PersonelCode == pers.PersonelCode).FirstOrDefault();
                if (result == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (persType == InputEnums.Kontrol)
            {
                var result = cdb.Find(x => x.PersonelCode == pers.PersonelCode).FirstOrDefault();
                if (result == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }



        }
        public List<Personel> GetFilletPersonels()
        {
            var result = fdb.Find(x => true).ToList();
            return result;
        }
        public List<Personel> GetControlPersonels()
        {
            var result = cdb.Find(x => true).ToList();
            return result;
        }
        public bool PCardCodeExist(string code)
        {
            var fResult = fdb.Find(x => x.CartCode == code).FirstOrDefault();
            var cResult = cdb.Find(x => x.CartCode == code).FirstOrDefault();

            if (fResult == null && cResult == null)
                return false;
            else
                return true;
        }

        public List<Personel> GetAll(int page, int pageSize = 15)
        {
            List<Personel> result;
            result = fdb.Find(x => true).Skip((page - 1) * pageSize).Limit(pageSize).ToList();
            result.AddRange(cdb.Find(x => true).Skip((page - 1) * pageSize).Limit(pageSize).ToList());

            return result;
        }
        public List<Personel> GetControl(int page, int pageSize = 15)
        {
            var result = cdb.Find(x => true).Skip((page - 1) * pageSize).Limit(pageSize).ToList();
            return result;
        }
        public List<Personel> GetFillet(int page, int pageSize = 15)
        {
            
            var result = fdb.Find(x => true).Skip((page - 1) * pageSize).Limit(pageSize).ToList();
            return result;
        }
        public Personel GetPersonalByCardCode(string cardCode)
        {
            Personel result;
            result = fdb.Find(x => x.CartCode == cardCode).FirstOrDefault();
            if(result != null)
            {
                return result;
            }
            else
            {
                result = cdb.Find(x => x.CartCode == cardCode).FirstOrDefault();
            }

            return result;
        }
        public Personel GetPersonnelByCardId(Carts card)
        {
            
            if (card.CartType==InputEnums.Fileto)
            {
                var result = fdb.Find(x => x.CartId == card.Id).FirstOrDefault();
                return result;
            }
            else if (card.CartType==InputEnums.Kontrol)
            {
                var result = cdb.Find(x => x.CartId == card.Id).FirstOrDefault();
                return result;
            }
            else
            {
                return null;//Kasa kartı veya kayıtlı olmayan bir kart okutulmuştur.
            }
            
            
        }
        public Personel GetFilletPersonnelByCardId(string CardID)
        {
            var result = fdb.Find(x => x.CartId == CardID).FirstOrDefault();
            return result;
        }
        public Personel GetControlPersonnelByCardId(string CardID)
        {
            var result = cdb.Find(x => x.CartId == CardID).FirstOrDefault();
            return result;
        }
        public List<Personel> GetFilteredFillet(FilterDefinition<Personel> filteredPersonel)
        {
            var result = fdb.Find(filteredPersonel).ToList();
            return result;
        }
        public List<Personel> GetFilteredController(FilterDefinition<Personel> filteredPersonel)
        {
            var result = cdb.Find(filteredPersonel).ToList();
            return result;
        }
        public List<Personel> GetFilteredPersonal(FilterDefinition<Personel> filteredPersonel)
        {
            var result = cdb.Find(filteredPersonel).ToList();
            result.AddRange(fdb.Find(filteredPersonel).ToList());
            return result;
        }

        public long GetFilletDocumentCount()
        {
            long docCount = fdb.CountDocuments(FilterDefinition<Personel>.Empty);
            return docCount;
        }
        public long GetControllerDocumentCount()
        {
            long docCount = cdb.CountDocuments(FilterDefinition<Personel>.Empty);
            return docCount;
        }
        public long GetAllPersonalDocumentCount()
        {
            long docCount = fdb.CountDocuments(FilterDefinition<Personel>.Empty);
            docCount += cdb.CountDocuments(FilterDefinition<Personel>.Empty);
            return docCount;
        }

        public bool UpdateControllerCardInfo(Personel personel)
        {
            if (!String.IsNullOrEmpty(personel.PersonelName) && !String.IsNullOrEmpty(personel.PersonelSurname) && !String.IsNullOrEmpty(personel.PersonelCode) && !String.IsNullOrEmpty(personel.PersonelGroup))
            {
                var Filter = Builders<Personel>.Filter.Eq(x => x.Id, personel.Id);
                var Update = Builders<Personel>.Update
                    .Set(x => x.CartId, personel.CartId)
                    .Set(x => x.CartCode, personel.CartCode);
                try
                {
                    cdb.UpdateOne(Filter, Update);
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
        public bool UpdateFilletCardInfo(Personel personel)
        {
            if (!String.IsNullOrEmpty(personel.PersonelName) && !String.IsNullOrEmpty(personel.PersonelSurname) && !String.IsNullOrEmpty(personel.PersonelCode) && !String.IsNullOrEmpty(personel.PersonelGroup))
            {
                var Filter = Builders<Personel>.Filter.Eq(x => x.Id, personel.Id);
                var Update = Builders<Personel>.Update
                    .Set(x => x.CartId, personel.CartId)
                    .Set(x => x.CartCode, personel.CartCode);
                try
                {
                    fdb.UpdateOne(Filter, Update);
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
        public bool Update(Personel personel, string perstype)
        {
            if (!String.IsNullOrEmpty(personel.PersonelName) && !String.IsNullOrEmpty(personel.PersonelSurname) && !String.IsNullOrEmpty(personel.PersonelCode) && !String.IsNullOrEmpty(personel.PersonelGroup))
            {
                var Filter = Builders<Personel>.Filter
                    .Eq(x => x.Id, personel.Id);

                var Update = Builders<Personel>.Update
                    .Set(x => x.PersonelName, personel.PersonelName)
                    .Set(x => x.PersonelSurname, personel.PersonelSurname)
                    .Set(x => x.PersonelCode, personel.PersonelCode)
                    .Set(x => x.PersonelGroup, personel.PersonelGroup)
                    .Set(x => x.CartId, personel.CartId)
                    .Set(x => x.CartCode, personel.CartCode);

                try
                {
                    if (perstype == InputEnums.Fileto)
                    {
                        fdb.UpdateOne(Filter, Update);
                    }
                    else
                    {
                        cdb.UpdateOne(Filter, Update);

                    }

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
        public bool Delete(string _pid, string persType)
        {
            try
            {
                var Filter = Builders<Personel>.Filter.Eq(x => x.Id, _pid);
                if (persType == InputEnums.Fileto)
                {
                    fdb.DeleteOne(Filter);
                }
                else
                {
                    cdb.DeleteOne(Filter);
                }


                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ChangeCardId(string OldCard, string NewCard)
        {
            try
            {
                var Filter = Builders<Personel>.Filter.Eq(x => x.CartCode, OldCard);
                var Update = Builders<Personel>.Update.Set(x => x.CartCode, NewCard);
                cdb.UpdateOne(Filter, Update);
                fdb.UpdateOne(Filter, Update);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public object CheckPersonelValidByPeronelID(string filletID)
        {
            throw new NotImplementedException();
        }
    }
}
