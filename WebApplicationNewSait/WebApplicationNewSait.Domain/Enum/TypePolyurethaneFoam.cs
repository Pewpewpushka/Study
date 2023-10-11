
using System.ComponentModel.DataAnnotations;

namespace WebApplicationNewSait.Domain.Enum
{
    public enum TypePolyurethaneFoam
    {
        [Display(Name ="Эластичный пенополиуретан")]
        ElasticPolyurethaneFoam=0,
        [Display(Name = "Жесткий пенополиуретан")]
        RigidPolyurethaneFoam = 1,
        [Display(Name = "Напыляемый пенополиуретан")]
        SprayPolyurethaneFoam = 2,
        [Display(Name = "Интегральный пенополиуретан")]
        IntegralPolyurethaneFoam = 3,
        [Display(Name = "Полиуретановый эластомер для виброизоляции")]
        PolyurethaneElastomerVibrationIsolation = 4

       


    }
}
