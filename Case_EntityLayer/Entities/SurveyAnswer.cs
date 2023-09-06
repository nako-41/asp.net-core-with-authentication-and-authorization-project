using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int Survey1 { get; set; }


        [DisplayName("Anket 2")]

        public int Survey2 { get; set; }

        [DisplayName("Anket 3")]
        public int Survey3 { get; set; }


        [DisplayName("Anket 4")]
        public int Survey4 { get; set; }


        [DisplayName("Anket 5")]
        public int Survey5 { get; set; }

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

        [ForeignKey("userId")]
        public int? userId { get; set; }

        public virtual User Users { get; set; }

        //public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
