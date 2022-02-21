using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface ICartsServices1
    {
        bool CheckName(string Cname);
        bool CheckUser(string Cname);
        void Create(Carts Data);
        bool Delete(string Cname);
        List<Carts> Get();
        bool Update(string _id, string Cname = null);
    }
}