using BalikProjesi.Entities;
using System;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IFishBoxServices
    {
        bool CheckFBox(string Fbcode);
        void Create(FishBox fishBox);
        bool Delete(string Fcode);
        List<FishBox> Get();
        FishBox Get(string Fbcode);
        bool Update(string _id, string Ftype, DateTime Rdate, string FCode = null);
    }
}