using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace BookMvc.Core.Models
{
    public class UserRole : IdentityUser<int>
    { 
        public string Name { get; set; }
    }
}
