using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Identity
{
    public class AppUser:IdentityUser<int>
    {

        public string Name { get; set; }
        public string SurName { get; set; }
        public string UserName { get; set; }
        public virtual int rolId { get; set; }
        
    }
}
