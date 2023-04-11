using System.ComponentModel.DataAnnotations;

namespace SaitForPPY.Models
{
    [Serializable]
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "Введите имя")]
        [MaxLength(50, ErrorMessage = "Длина символа не должна превышать бльше 50 символов")]
        public string Name { get; set; }
        [Range(1, 110, ErrorMessage = "Недопустимый возраст")]
        public int Age { get; set; }

        public string Adress { get; set; }
        [Required(ErrorMessage = "Введите номер телефона чтобы мы могли связаться с вами")]
        [MinLength(11, ErrorMessage = "Длина символа не должна быть меньше 11 символов")]
        public int Phone { get; set; }
        [CardLenchAtributes(19, ErrorMessage="Некорекктный номер карты")]
         public int NumberCard { get; set; }
    }
}