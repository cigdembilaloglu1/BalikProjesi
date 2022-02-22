using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface IPersonelServices
    {
        bool CheckPCode(Personel pers, string persType);
        void Create(Personel personel,string persType);
        bool Delete(string _pid);
        List<Personel> GetControl();
        List<Personel> GetFillet();
        Personel Get(string _pid);
        bool Update(Personel personel);
       
    }
}