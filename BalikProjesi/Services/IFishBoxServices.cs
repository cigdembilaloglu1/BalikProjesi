using BalikProjesi.Entities;
using System;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IFishBoxServices
    {
        bool CheckFBox(string Fbcode);
        bool Create(FishBox fishBox);
        bool Delete(string Fcode);
        List<FishBox> Get();
        FishBox Get(string ID);
        FishBox GetByCardID(string ID);
        bool Update(FishBox fishBox);
        bool UpdateCardInfo(FishBox fishbox);
    }
}