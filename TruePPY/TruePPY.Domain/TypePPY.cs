using System.ComponentModel.DataAnnotations;
namespace TruePPY.Domain
{
    public enum TypePPY
    {
        [Display(Name="Напыляемый пенополиуретан")]
        SprayingPPY=2,
            [Display(Name = "Эластичный пенополиуретан")]
        ElasticPPY = 0,
        [Display(Name = "Жесткий пенополиуретан")]
        RigidPPY = 2,
        [Display(Name = "Высокоэластичный пенополиуретан для виброизоляционных покрытий")]
        VibrationPPY = 0,

    }
}