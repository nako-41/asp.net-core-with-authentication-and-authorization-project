using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Concrete
{
    public class Role
    {
        [Key]

        public int Id { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
