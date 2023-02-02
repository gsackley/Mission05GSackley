using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04GSackley.Models
{
    public class GradeCalculatorModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Assignments score must be between 0 and 100.")]
        public int ass { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Quizzes score must be between 0 and 100.")]
        public int qui { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Projects score must be between 0 and 100.")]
        public int pro { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Intex score must be between 0 and 100.")]
        public int inte { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Midterm score must be between 0 and 100.")]
        public int mid { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Final score must be between 0 and 100.")]
        public int fin { get; set; }
    }
}
