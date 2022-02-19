using BalikProjesi.Entities;
using System.Collections.Generic;

namespace BalikProjesi.Services
{
    public interface ILoginServices
    {
        bool CheckLogin(string _UserName, string _Password);
        void Create(string _uname, string _pass);
        bool Delete(string _id);
        List<Login> Get();
        Login Get(string _id);
        Login GetByName(string name);
        bool Update(string _id, string _Username = null, string _Password = null);
    }
}