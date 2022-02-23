using BalikProjesi.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IPersonelServices
    {
        bool CheckPCode(Personel pers, string persType);
        bool Create(Personel personel, string persType);
        bool Delete(string _pid, string persType);
        Personel Get(string _pid);
        List<Personel> GetControl();
        List<Personel> GetFillet();
        List<Personel> GetFilteredController(FilterDefinition<Personel> filteredPersonel);
        List<Personel> GetFilteredFillet(FilterDefinition<Personel> filteredPersonel);
        bool Update(Personel personel, string perstype);
    }
}