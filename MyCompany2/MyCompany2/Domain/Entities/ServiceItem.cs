using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyCompany2.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage ="Заполните название услуги")]
        [Display(Name = "Название услуги (заголовок)")]
        public override string Title { get; set; } = "Информационная страница";

        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; } = "Информационная страница";

        [Display(Name = "Полное описание страницы")]
        public override string Text { get; set; } = "Содержание страницы заполняется администратором";

    }
}
