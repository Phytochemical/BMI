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

            return bmiValue;
        }

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

            /// <summary>
            /// displays the weights that correspond to the normal BMI values
            /// </summary>
            /// <returns></returns>
            public string BmiWeightRange()
        {
            double bmi = CalculateBMI();
            double weight1;
            double weight2;
            string stringOut = "";

            if (unit == UnitTypes.Metric && (bmi >= 18.5 && bmi <= 24.9))
            {
                if (height >= 1.42 && height <= 1.45)
                {
                    stringOut = "Normal weight should be 38 to 50 kg";
                }
                else if (height >= 1.44 && height <= 1.46)
                {
                    stringOut = "Normal weight should be 40 to 52 kg";
                }
                else if (height >= 1.47 && height <= 1.48)
                {
                    stringOut = "Normal weight should be 40 to 52 kg";
                }
                else if (height >= 1.49 && height <= 1.51)
                {
                    stringOut = "Normal weight should be 41 to 54 kg";
                }
                else if (height >= 1.52 && height <= 1.53)
                {
                    stringOut = "Normal weight should be 41 to 54 kg";
                }
                else if (height >= 1.54 && height <= 1.56)
                {
                    stringOut = "Normal weight should be 45 to 59 kg";
                }
                else if (height >= 1.57 && height <= 1.59)
                {
                    stringOut = "Normal weight should be 47 to 61 kg";
                }
                else if (height >= 1.60 && height <= 1.61)
                {
                    stringOut = "Normal weight should be 47 to 63 kg";
                }
                else if (height >= 1.62 && height <= 1.64)
                {
                    stringOut = "Normal weight should be 50 to 65 kg";
                }
                else if (height >= 1.65 && height <= 1.66)
                {
                    stringOut = "Normal weight should be 52 to 65 kg";
                }
                else if (height >= 1.67 && height <= 1.69)
                {
                    stringOut = "Normal weight should be 52 to 68 kg";
                }
                else if (height >= 1.70 && height <= 1.71)
                {
                    stringOut = "Normal weight should be 52 to 68 kg";
                }
                else if (height >= 1.72 && height <= 1.74)
                {
                    stringOut = "Normal weight should be 56 to 72 kg";
                }
                else if (height >= 1.75 && height <= 1.76)
                {
                    stringOut = "Normal weight should be 59 to 75 kg";
                }
                else if (height >= 1.77 && height <= 1.79)
                {
                    stringOut = "Normal weight should be 59 to 74 kg";
                }
                else if (height >= 1.80 && height <= 1.81)
                {
                    stringOut = "Normal weight should be 61 to 79 kg";
                }
                else if (height >= 1.82 && height <= 1.84)
                {
                    stringOut = "Normal weight should be 63 to 81 kg";
                }
                else if (height >= 1.85 && height <= 1.86)
                {
                    stringOut = "Normal weight should be 63 to 84 kg";
                }
                else if (height >= 1.87 && height <= 1.89)
                {
                    stringOut = "Normal weight should be 65 to 86 kg";
                }
                else if (height >= 1.90 && height <= 1.92)
                {
                    stringOut = "Normal weight should be 68 to 152 kg";
                }
                else if (height >= 1.93)
                {
                    stringOut = "Normal weight should be 70 to 90 kg";
                }
                else
                {
                    stringOut = " ";
                }
            }
            else if (unit == UnitTypes.Imperial && (bmi >= 18.5 && bmi <= 24.9))
            {
                weight1 = Math.Round(18.50 * (height * height) / 703);
                weight2 = Math.Round(24.90 * (height * height) / 703);

                stringOut = ($"Normal weight should be {weight1} to {weight2} lbs");
            }

            return stringOut;
        }
    }
}
