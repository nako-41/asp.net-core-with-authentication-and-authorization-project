using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_EntityLayer.Concrete
{
    public class SurveyQuestion
    {
        [Key]
        public int Id { get; set; }
        public int SurveyId { get; set; }

        [DisplayName("Soru Metni")]
        public string QuestionText { get; set; }
        [DisplayName("Soru Tipi")]
        public string QuestionType { get; set; }

        public virtual Survey Survey { get; set; }
    }
}
