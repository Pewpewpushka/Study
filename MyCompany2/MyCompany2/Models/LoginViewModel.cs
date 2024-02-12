using System.ComponentModel.DataAnnotations;
namespace MyCompany2.Models
{
    public class LoginViewModel
    { // пользователь вводит на форме свои данные для авторатизации
        [Required]
        [Display(Name="Логин")]
        public string UserName { get; set; }

        [Required]
        [UIHint("password")]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }

    }
}
