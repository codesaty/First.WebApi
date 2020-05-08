using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First.WebApi.Entities;

namespace First.WebApi.Models
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
