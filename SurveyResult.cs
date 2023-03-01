using System;
using System.ComponentModel.DataAnnotations;

namespace SurveyValidation.Models
{
  public class SurveyResult
    {
        [Required(ErrorMessage = "Please enter your name.")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters in length.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select a location.")]
        public string Location { get; set; }

        [Required(ErrorMessage = "Please select a language.")]
        public string Language { get; set; }

        [MinLength(20, ErrorMessage = "If you enter a comment, it must be at least 20 characters in length.")]
        public string Comment { get; set; }
    }
}