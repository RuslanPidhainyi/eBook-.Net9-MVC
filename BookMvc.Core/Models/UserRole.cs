using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMvc.Core.Models
{
    public class UserRole : IdentityUser<int>
    {
        public UserRole() { }
        public UserRole(string roleName) : base(roleName) { }
    }
}
