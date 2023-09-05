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
        public string Survey1 { get; set; }
        [DisplayName("Anket 2")]
        public string Survey2 { get; set; }
        [DisplayName("Anket 3")]
        public string Survey3 { get; set; }
        [DisplayName("Anket 4")]
        public string Survey4 { get; set; }
        [DisplayName("Anket 5")]
        public string Survey5 { get; set; }

        public byte Age { get; set; }
        public char Gender { get; set; }
        public string EducationInformation { get; set; }
        public string City { get; set; }
        public string District { get; set; }

        //public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
