using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SkillMapv4.Models
{
    public class Skills
    {
        public Skills()
        {
        }

        [Key]
        public int SkillID { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; private set; } //very important 

        public string SkillName { get; set; }
        
        [Required]
        [Range(0,5)]
        public int Nivel { get; set; }

        [Display(Name = "Quero Aprender!")]
        public bool WantToLearn { get; set; }
    }
}
