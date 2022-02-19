using System;

namespace BalikProjesi.Entities
{
    public class Login : BaseEntity 
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

    }
}
