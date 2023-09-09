
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Case_EntityLayer.Concrete
{
    public class SurveyAnswer
    {
        [Key]
        public int Id { get; set; }

        //public int SurveyQuestionId { get; set; }

        [DisplayName("Anket 1")]

        public bool Survey1 { get; set; }


        [DisplayName("Anket 2")]

        public bool Survey2 { get; set; }

        [DisplayName("Anket 3")]
        public bool Survey3 { get; set; }


        [DisplayName("Anket 4")]
        public bool Survey4 { get; set; }


        [DisplayName("Anket 5")]
        public bool Survey5 { get; set; }

        [DisplayName("Yas")]

        public byte Age { get; set; }
        [DisplayName("Cinsiyet")]
        public bool Gender { get; set; }
        [DisplayName("Egitim Bilgisi")]
        public EducationInformation educationInformations { get; set; }
        [DisplayName("Sehir")]
        public string City { get; set; }
        [DisplayName("Ilce")]
        public string District { get; set; }

        [ForeignKey("userId")]
        public int? userId { get; set; }

        public virtual User Users { get; set; }

        //public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
   public enum EducationInformation
    {
        ONLISANS,
        LISANS, 
        YüksekLisans
    }
}
