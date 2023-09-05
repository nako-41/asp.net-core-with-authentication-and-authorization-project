using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Concrete
{
    public class SurveyAnswer
    {
        [Key]
        public int Id { get; set; }

        //public int SurveyQuestionId { get; set; }

        [DisplayName("Anket 1")]
        [StringLength(5)]
        public char Survey1 { get; set; }

        [StringLength(5)]
        [DisplayName("Anket 2")]

        public char Survey2 { get; set; }
        [StringLength(5)]
        [DisplayName("Anket 3")]
        public char Survey3 { get; set; }

        [StringLength(5)]
        [DisplayName("Anket 4")]
        public char Survey4 { get; set; }

        [StringLength(5)]
        [DisplayName("Anket 5")]
        public char Survey5 { get; set; }

        [DisplayName("Yas")]
        public byte Age { get; set; }
        [DisplayName("Cinsiyet")]
        public char Gender { get; set; }
        [DisplayName("Egitim Bilgisi")]
        public string EducationInformation { get; set; }
        [DisplayName("Sehir")]
        public string City { get; set; }
        [DisplayName("Ilce")]
        public string District { get; set; }

        public int userID { get; set; }

        public User Users { get; set; }

        //public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
