using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface ICartsServices1
    {
        bool CheckCard(string cardID);
        bool CheckUser(string Cname);
        void Create(Carts Data);
        bool Delete(string Cname);
        List<Carts> Get();
        bool Update(Carts card, string Cname = null);
    }
}