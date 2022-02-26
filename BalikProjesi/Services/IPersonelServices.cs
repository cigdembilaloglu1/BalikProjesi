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
        List<Personel> GetAll();
        List<Personel> GetControl();
        Personel GetControlPersonnelByCardId(string CardID);
        List<Personel> GetFillet();
        Personel GetFilletPersonnelByCardId(string CardID);
        List<Personel> GetFilteredController(FilterDefinition<Personel> filteredPersonel);
        List<Personel> GetFilteredFillet(FilterDefinition<Personel> filteredPersonel);
        Personel GetPersonalByCardCode(string cardCode);
        bool PCardCodeExist(string code);
        bool Update(Personel personel, string perstype);
        bool UpdateControllerCardInfo(Personel personel);
        bool UpdateFilletCardInfo(Personel personel);
    }
}