using System;

namespace PolymerMassCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the molecular formula of the polymer: ");
            string formula = Console.ReadLine();

            double molecularWeight = CalculateMolecularWeight(formula);

            Console.WriteLine("The molecular weight of the polymer is: " + molecularWeight + " g/mol");
        }

        static double CalculateMolecularWeight(string formula)
        {
            double molecularWeight = 0.0;

            for (int i = 0; i < formula.Length; i++)
            {
                char element = formula[i];
                int elementCount = 1;

                // Check if the next character is a number
                if (i < formula.Length - 1 && Char.IsDigit(formula[i + 1]))
                {
                    elementCount = Int32.Parse(formula[i + 1].ToString());
                    i++;
                }

                // Get the molecular weight of the element
                double elementWeight = GetElementWeight(element.ToString());

                // Add the weight of the element to the total molecular weight
                molecularWeight += elementWeight * elementCount;
            }

            return molecularWeight;
        }

        static double GetElementWeight(string element)
        {
            switch (element)
            {
                case "C":
                    return 12.01;
                case "H":
                    return 1.01;
                case "O":
                    return 16.00;
                case "N":
                    return 14.01;
                case "S":
                    return 32.06;
                case "Si":
                    return 28.09;
                case "F":
                    return 19.00;
                case "Cl":
                    return 35.45;
                case "Br":
                    return 80.00;
                case "I":
                    return 126.90;
                default:
                    return 0.0;
            }
        }
    }
}

