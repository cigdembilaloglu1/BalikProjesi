﻿using BalikProjesi.Entities;
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
        Personel GetControlPersonnelByCardId(string CardID);
        List<Personel> GetFillet();
        Personel GetFilletPersonnelByCardId(string CardID);
        List<Personel> GetFilteredController(FilterDefinition<Personel> filteredPersonel);
        List<Personel> GetFilteredFillet(FilterDefinition<Personel> filteredPersonel);
        bool Update(Personel personel, string perstype);
        bool UpdateControllerCardInfo(Personel personel);
        bool UpdateFilletCardInfo(Personel personel);
    }
}