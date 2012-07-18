using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace MyTestPoject.Authorization.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter a firstname")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a lastname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please, enter a  mail!")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Please, enter a correct mail!")]
        public string EMail { get; set; }

        [Required(ErrorMessage = "Please, enter a  password!")]
        [StringLength(100, ErrorMessage = "The password must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please select a date")]
        public DateTime DayOfBirth { get; set; }

        [Required(ErrorMessage = "Please select a gander")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Please select a matrial status")]
        public string MatrialStatus { get; set; }

        public IEnumerable<SelectListItem> PossibleGenders { get; set; }

        public IEnumerable<SelectListItem> PossibleMatrialStatus { get; set; }
    }
}