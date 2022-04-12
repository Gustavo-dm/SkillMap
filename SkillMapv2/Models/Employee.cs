using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Skill_Map.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Skill { get; set; }

        public int Nível { get; set; }

        public bool WantToLearn { get; set; }
    }
}
