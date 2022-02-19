using BalikProjesi.Entities;
using System;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IFishBoxServices
    {
        bool CheckFBox(string Fbcode);
        void Create(string Fbcode, string Fbtype, DateTime Rdate);
        bool Delete(string Fcode);
        List<FishBox> Get();
        FishBox Get(string Fbcode);
        bool Update(string _id, string Ftype, DateTime Rdate, string FCode = null);
    }
}