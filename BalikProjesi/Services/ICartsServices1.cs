using BalikProjesi.Entities;
using MongoDB.Driver;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface ICartsServices1
    {
        bool CheckCard(string cardID);
        int CheckCardTypeResult(string cardCode);
        bool CheckUser(string Cname);
        bool Create(Carts Data);
        bool Delete(string cardID);
        List<Carts> Get();
        Carts GetByCardCode(string cardcode);
        Carts GetByCardID(string CardId);
        List<Carts> GetFilteredCards(FilterDefinition<Carts> filteredCards);
        bool Update(Carts card, string Cname = null);
    }
}