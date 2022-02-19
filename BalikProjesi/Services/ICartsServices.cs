namespace BalikProjesi.Services
{
    public interface ICartsServices
    {
        bool CheckName(string Cname);
        bool CheckUser(string Cname);
        void Create(string Cname);
        bool Delete(string Cname);
        System.Collections.Generic.List<Entities.Carts> Get();
        bool Update(string _id, string Cname = null);
    }
}