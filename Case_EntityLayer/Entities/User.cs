using Microsoft.AspNetCore.Identity;
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


    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required]
        [StringLength(40)]
        [DisplayName("Adiniz")]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("Soyadiz")]
        public string Surname { get; set; }
        [Required]
        [StringLength(30)]
        [DisplayName("Kullanici Adiniz")]
        public string UserName { get; set; }
        [Required]
        [StringLength(13)]
        [DisplayName("Telefon No")]
        public string Tel { get; set; }
        [Required]
        [StringLength(150)]
        [DisplayName("E-posta")]
        public string UserEmail { get; set; }
        [Required]
        [StringLength(20)]
        [DisplayName("Sifre")]
        public string UserPassword { get; set; }
         
        public int RoleId { get;set; }

        public List<SurveyAnswer> surveyAnswers { get; set; }

        public virtual Role Role { get; set; }
    }
  
}
