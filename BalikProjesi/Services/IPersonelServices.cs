using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IPersonelServices
    {
        void Create(string _pname, string _psurname, string _pcode, string _pgroup);
        bool Delete(string _pid);
        List<Personel> Get();
        Personel Get(string _pid);
        bool Update(string _id, string _pname = null, string _psurname = null, string _pcode = null, string _pgroup = null);
    }
}