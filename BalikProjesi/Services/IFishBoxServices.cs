using BalikProjesi.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IFishBoxServices
    {
        bool CheckFBox(string Fbcode);
        bool Create(FishBox fishBox);
        bool Delete(string Fcode);
        List<FishBox> Get(int page, int pageSize = 15);
        FishBox GetById(string ID);
        FishBox GetByCardCode(string ID);
        long GetDocumentCount();
        List<FishBox> GetFilteredFishBox(FilterDefinition<FishBox> filteredFishBox);
        bool Update(FishBox fishBox);
        bool UpdateCardInfo(FishBox fishbox);
        Recordings CheckRecordValidByFishboxID(string fishboxID);
        bool UpdateCartId(string OldCart, string NewCart);
        FishBox GetByBoxType(string fbType);
        List<FishBox> GetAllBoxes();
        FishBox Get(string ID);
    }
}