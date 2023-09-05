using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Concrete
{
    public class Survey
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Baslik")]
        public string Title { get; set; }
        [DisplayName("Tanim")]
        public string Description { get; set; }
        [DisplayName("Olusturma Tarihi")]
        public DateTime CreatedDate { get; set; }
        [DisplayName("Bitis Tarihi")]
        public DateTime EndDate { get; set; }

        public int userid { get; set; }

        public int CreatedById { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}
