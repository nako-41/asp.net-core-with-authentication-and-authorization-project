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

        public int SurveyQuestionId { get; set; }

        [DisplayName("Yanit Metni")]
        public string AnswerText { get; set; }

        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
