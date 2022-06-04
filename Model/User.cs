using System;
using TestandoRepositoryPattern.Model.Base;

namespace TestandoRepositoryPattern.Model
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
     
        public User(Guid id, string name, string email) : base(id)
        {
            Name = name;
            Email = email;
        }   
    }
}