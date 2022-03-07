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
        List<Personel> GetAll(int page, int pageSize = 15);
        long GetAllPersonalDocumentCount();
        List<Personel> GetControl(int page, int pageSize = 15);
        long GetControllerDocumentCount();
        Personel GetControlPersonnelByCardId(string CardID);
        List<Personel> GetFillet(int page, int pageSize = 15);
        long GetFilletDocumentCount();
        Personel GetFilletPersonnelByCardId(string CardID);
        List<Personel> GetFilteredController(FilterDefinition<Personel> filteredPersonel);
        List<Personel> GetFilteredFillet(FilterDefinition<Personel> filteredPersonel);
        List<Personel> GetFilteredPersonal(FilterDefinition<Personel> filteredPersonel);
        Personel GetPersonalByCardCode(string cardCode);
        Personel GetPersonnelByCardId(Carts card);        
        bool PCardCodeExist(string code);
        bool Update(Personel personel, string perstype);
        bool UpdateControllerCardInfo(Personel personel);
        bool UpdateFilletCardInfo(Personel personel);
        object CheckPersonelValidByPeronelID(string filletID);
        bool ChangeCardId(string OldCard, string NewCard);
        List<Personel> GetFilletPersonels();
        List<Personel> GetControlPersonels();
    }
}