using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface ICartsServices1
    {
        bool CheckCard(string cardID);
        bool CheckUser(string Cname);
        bool Create(Carts Data);
        bool Delete(string cardID);
        List<Carts> Get();
        Carts GetByCardCode(string cardcode);
        bool Update(Carts card, string Cname = null);
    }
}