using System;
using System.ComponentModel.DataAnnotations;

namespace AspChat.Models
{
    public class User
    {
        //User Id
        public Guid Id { get; set; }

        //User Login
        [Required(ErrorMessage = "Field can't be blank")]  
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "only alfanumeric symbols accepted")]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Number of symbols from 3 to 10")]
        [Display(Name = "Логин")]
        public string UserLogin { get; set; }

        //User Passsword
        [Required(ErrorMessage = "Field can't be blank")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "only alfanumeric symbols accepted")]
        [StringLength(14, MinimumLength = 6, ErrorMessage = "Number symbols from 6 to 14")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string UserPass { get; set; } 
    }
}