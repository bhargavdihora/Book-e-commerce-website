using BookStoreNew.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreNew.Repository
{
    public class RoleRepository : BaseRepository
    {
        public List<RoleModel> GetRoles()
        {
            var roles = _context.Roles.Select(x=> new RoleModel() { 
               Id = x.Id,
               Name = x.Name,   
            }).ToList();

            return roles;
        }
    }
}
