using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SaitForPPY.Models
{
    public class CardLenchAtributes : ValidationAttribute
    {
        private const int LengthCard = 19;
        private int lenghtValue;

        public CardLenchAtributes(int lenght)
        {

        }

        

        public override bool IsValid(object value)
        {
            var lengthValue = value.ToString().Length;
            if (value!= null && LengthCard==lenghtValue) 
                return true;
            return false;
        }
    }
}
