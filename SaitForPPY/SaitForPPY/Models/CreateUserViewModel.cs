using System.ComponentModel.DataAnnotations;

namespace SaitForPPY.Models
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина символа не должна превышать бльше 50 символов")]
        public string Name { get; set; }
        [Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }
        public string Adress { get; set; }
      
        public int Phone { get; set; }

    }
}