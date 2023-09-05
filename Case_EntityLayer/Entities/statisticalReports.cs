using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Concrete
{
    public class statisticalReports
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Alan")]
        public string Area { get; set; }
        [DisplayName("Yas")]
        public byte Age { get; set; }
        [DisplayName("Cinsiyet")]
        public char Gender { get; set; }
        [DisplayName("Egitim Bilgisi")]
        public string EducationInformation { get; set; }
    }
}
