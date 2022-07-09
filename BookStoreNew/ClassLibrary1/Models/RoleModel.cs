using BookStoreNew.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreNew.Models.Models
{
    public class RoleModel
    {
        public RoleModel() { }
        public RoleModel(Role role)
        {
            Id = role.Id;
            Name = role.Name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
