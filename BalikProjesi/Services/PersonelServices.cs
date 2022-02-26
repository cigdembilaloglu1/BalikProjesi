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

        public bool PCardCodeExist(string code)
        {
            var fResult = fdb.Find(x => x.CartCode == code).FirstOrDefault();
            var cResult = cdb.Find(x => x.CartCode == code).FirstOrDefault();

            if (fResult == null && cResult == null)
                return false;
            else
                return true;
        }

        public List<Personel> GetAll()
        {
            List<Personel> result;
            result = fdb.Find(x => true).ToList();
            result.AddRange(cdb.Find(x => true).ToList());

            return result;
        }
        public List<Personel> GetControl()
        {
            var result = cdb.Find(x => true).ToList();
            return result;
        }
        public List<Personel> GetFillet()
        {
            var result = fdb.Find(x => true).ToList();
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


    }
}
