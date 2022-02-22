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
        public readonly IMongoCollection<Personel> pdb, fdb;

       // private readonly object _pid;

        public PersonelServices()
        {
            var Mongo = new DbContext();
            fdb = Mongo._fpersonel;
            pdb = Mongo._cpersonel;
        }
        public void Create(Personel personel,string persType)
        {
            var Islem = CheckPCode(personel, persType);
            if (Islem)
            {
                if (persType==InputEnums.Fileto)
                {
                    fdb.InsertOne(personel);
                }
                else
                {
                    pdb.InsertOne(personel);
                }      
            }

        }

        public bool CheckPCode(Personel pers,string persType)
        {
            

            if (persType==InputEnums.Fileto)
            {
                var result = fdb.Find(x => x.CartId == pers.CartId).FirstOrDefault();
                if (result == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (persType == InputEnums.Kontrol) { 
                var result = pdb.Find(x => x.CartId == pers.CartId).FirstOrDefault();
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

        public Personel Get(string _pid)
        {
            var result = pdb.Find(x => x.Id == _pid).FirstOrDefault();

            return result;
        }
        public List<Personel> GetControl()
        {
            var result = pdb.Find(x => true).ToList();
            return result;
        }
        public List<Personel> GetFillet()
        {
            var result = fdb.Find(x => true).ToList();
            return result;
        }

        public bool Update(string _id, string _pname = null, string _psurname = null, string _pcode = null, string _pgroup = null)
        {
            if (!String.IsNullOrEmpty(_pname) && !String.IsNullOrEmpty(_psurname) && !String.IsNullOrEmpty(_pcode) && !String.IsNullOrEmpty(_pgroup))
            {
                var Filter = Builders<Personel>.Filter
                    .Eq(x => x.Id, _id);

                var Update = Builders<Personel>.Update
                    .Set(x => x.PersonelName, _pname)
                    .Set(x => x.PersonelSurname, _psurname)
                    .Set(x => x.PersonelCode, _pcode)
                    .Set(x => x.PersonelGroup, _pgroup); ;

                try
                {
                    pdb.UpdateOne(Filter, Update);
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
        public bool Delete(string _pid)
        {
            try
            {
                var Filter = Builders<Personel>.Filter.Eq(x => x.Id, _pid);
                pdb.DeleteOne(Filter);
                return true;
            }
            catch
            {
                return false;
            }
        }


    }
}
