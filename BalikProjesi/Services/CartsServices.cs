using BalikProjesi.Entities;
using BalikProjesi.Enums;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalikProjesi.Services
{
    public class CartsServices : ICartsServices1
    {
        public readonly IMongoCollection<Carts> db;

        public CartsServices()
        {
            var Mongo = new DbContext();
            db = Mongo._carts;
        }
        public bool Create(Carts Data)
        {
            var Islem = CheckCard(Data.CartCode);
            if (Islem)
            {
                Data.CartName = GetNewCardName();
                db.InsertOne(Data);
            }
            return Islem;


        }

        public List<Carts> Get()
        {
            var result = db.Find(x => true).ToList();
            return result;
        }
        public Carts GetByCardID(string CardId)
        {

            var result = db.Find(x => x.Id == CardId).FirstOrDefault();
            return result;
        }
        public Carts GetByCardCode(string cardcode)
        {
            
            var result = db.Find(x => x.CartCode == cardcode).FirstOrDefault();
            return result;
        }

        public List<Carts> GetFilteredCards(FilterDefinition<Carts> filteredCards)
        {
            var result = db.Find(filteredCards).ToList();
            return result;
        }

        public string GetNewCardName()
        {
            int cardName;
            Carts lastCard = db.AsQueryable().OrderByDescending(c => c.Id).FirstOrDefault();
            if(lastCard != null)
            {
                cardName = int.Parse(lastCard.CartName);
                cardName++;
            }
            else
            {
                cardName = 10000;
            }

            return cardName.ToString();
        }
        public bool Update(Carts card)
        {
            var Filter = Builders<Carts>.Filter
                     .Eq(x => x.Id, card.Id);

            var Update = Builders<Carts>.Update
                .Set(x => x.UpdateDate, card.UpdateDate)
                .Set(x => x.CartCode, card.CartCode)
                .Set(x => x.CartType, card.CartType);

            try
            {
                db.UpdateOne(Filter, Update);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(string cardID)
        {
            try
            {
                if (!string.IsNullOrEmpty(cardID))
                {
                    var Filter = Builders<Carts>.Filter.Eq(x => x.Id, cardID);
                    db.DeleteOne(Filter);
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
        }
        public bool CheckUser(string Cname)
        {

            var result = db.Find(x => x.CartName == Cname).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool CheckCard(string cardCode)
        {
            var result = db.Find(x => x.CartCode == cardCode).FirstOrDefault();
            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int CheckCardTypeResult(string cardCode)
        {
            Carts card = GetByCardCode(cardCode);

            if(card != null)
            {
                string cardType = card.CartType;
                if (cardType == InputEnums.Fileto)
                    return 0;//CartType Filetocu
                else if (cardType == InputEnums.Kontrol)
                    return 1;//CartType Kontrolcu
                else
                    return 2;//CartType Kasa
            }
            else
            {
                return -1;//Kart Carts Collectionda Yok
            }

        }



    }
}
