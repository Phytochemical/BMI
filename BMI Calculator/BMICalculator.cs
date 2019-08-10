using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class BMICalculator
    {
        // only stores input
        // getter method returns input value with no parameter
        // setter method void method with one parameter
        // uses methods to return output
        // should be usable by any object

        private string name = "No name";
        private double height = 0;
        private double weight = 0;
        private UnitTypes unit;

        // REFACTOR GETTER SETTER
        // returns value stored in filed name
        public string GetName()
        {
            return name;
        }

        public void SetName(string stringValue)
        {
            // value validation string.IsNullOrEmpty()
            if (!string.IsNullOrEmpty(stringValue))
            {
                name = stringValue;
            }
        }

        // setter method overwrites value save in instance variable name by new value
        public double GetHeight()
        {
            return height;
        }

        public void SetHeight(double doubleValue)
        {
            if (doubleValue >= 0)
            {
                height = doubleValue;
            }
        }

        public double GetHeightInches()
        {
            return height;
        }

        public void SetHeightInches(double doubleValue)
        {
            if (doubleValue >= 0)
            {
                height = doubleValue;
            }
        }

        public double GetWeight()
        {
            return weight;
        }

        public void SetWeight(double doubleValue)
        {
            if (doubleValue >= 0)
            {
                weight = doubleValue;
            }
        }

        public UnitTypes GetUnit()
        {
            return unit;
        }

        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }

        // metric BMI = (weight / height)²
        // imperial BMI = (weight / height)²*703
        public double CalculateBMI()
        {
            // imperial
            double bmiValue = 0.0;
            double conversionFactor = 0.0;

            if (unit == UnitTypes.Imperial)
            {
                conversionFactor = 703.0;
            }
            else
            {
                conversionFactor = 1.0;
            }

            bmiValue = conversionFactor * (weight / (height * height));
            Console.Out.WriteLine(height);

            return bmiValue;
        }
        // public string NormalWeight()

        /// <summary>
        /// outputs weight category based on BMI
        /// </summary>
        /// <returns>weight category based on BMI</returns>
        public string BmiWeightCategory()
        {
            double bmi = CalculateBMI();
            string stringOut = "";

            if (bmi > 40)
            {
                stringOut = "Overweight (Obesity class III)";
            }
            else if (bmi > 35)
            {
                stringOut = "Overweight (Obesity class II)";
            }
            else if (bmi > 30)
            {
                stringOut = "Overweight (Obesity class I)";
            }
            else if (bmi > 25)
            {
                stringOut = "Overweight (Pre-obesity)";
            }
            else if (bmi > 18.5)
            {
                stringOut = "Normal weight";
            }
            else
            {
                stringOut = "Undeweight";
            }

            return stringOut;
        }

        public string BmiWeightRange()
        {
            string stringOut = "";
            Console.Out.WriteLine("height " + height);

            if (height == 58)
            {
                stringOut = "Normal weight should be 91 to 115 lbs";
            }
            else if (height == 59)
            {
                stringOut = "Normal weight should be 94 to 119 lbs";
            }
            else if (height == 60)
            {
                stringOut = "Normal weight should be 97 to 123 lbs";
            }
            else if (height == 61)
            {
                stringOut = "Normal weight should be 100 to 127 lbs";
            }
            else if (height == 62)
            {
                stringOut = "Normal weight should be 104 to 131 lbs.";
            }
            else if (height == 63)
            {
                stringOut = "Normal weight should be 107 to 135 lbs";
            }
            else if (height == 64)
            {
                stringOut = "Normal weight should be 110 to 140 lbs";
            }
            else if (height == 65)
            {
                stringOut = "Normal weight should be 114 to 144 lbs";
            }
            else if (height == 66)
            {
                stringOut = "Normal weight should be 118 to 148 lbs";
            }
            else if (height == 67)
            {
                stringOut = "Normal weight should be 121 to 153 lbs";
            }
            else if (height == 68)
            {
                stringOut = "Normal weight should be 125 to 158 lbs";
            }
            else if (height == 69)
            {
                stringOut = "Normal weight should be 128 to 162 lbs";
            }
            else if (height == 70)
            {
                stringOut = "Normal weight should be 132 to 167 lbs";
            }
            else if (height == 71)
            {
                stringOut = "Normal weight should be 136 to 172 lbs";
            }
            else if (height == 72)
            {
                stringOut = "Normal weight should be 140 to 177 lbs";
            }
            else if (height == 73)
            {
                stringOut = "Normal weight should be 144 to 182 lbs";
            }
            else if (height == 74)
            {
                stringOut = "Normal weight should be 148 to 186 lbs";
            }
            else if (height == 75)
            {
                stringOut = "Normal weight should be 152 to 192 lbs";
            }
            else if (height == 76)
            {
                stringOut = "Normal weight should be 156 to 197 lbs";
            }
            else
            {
                stringOut = " ";
            }

            return stringOut;
        }
    }
}
