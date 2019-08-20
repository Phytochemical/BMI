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
                weight1 = Math.Round(18.50 * (height * height));
                weight2 = Math.Round(24.90 * (height * height));

                stringOut = ($"Normal weight should be {weight1} to {weight2} kg");
            }
            else if (unit == UnitTypes.Imperial && (bmi >= 18.5 && bmi <= 24.9))
            {
                weight1 = Math.Round(18.50 * (height * height) / 703);
                weight2 = Math.Round(24.90 * (height * height) / 703);

                stringOut = ($"Normal weight should be {weight1} to {weight2} lbs");
            }
            else
            {
                stringOut = " ";
            }

                return stringOut;
            }
    }
}
