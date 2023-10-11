using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PPUmarket.Domain.Enum
{
    public enum TypeFoam
    {
        [Display(Name = "Эластичный пенополиуретан")]
        ElasticPolyurethaneFoam = 0,
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
