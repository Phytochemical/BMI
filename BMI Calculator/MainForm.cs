using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class MainForm : Form
    {
        private BMICalculator myBMICalculator = new BMICalculator();

        // constructor
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// initiazlie GUI with the preset option, set defualt radioButton values
        /// encapsulate within a container component groupBox
        /// when one button is checked, rest should be unchecked
        /// </summary>
        private void InitializeGUI()
        {
            // current instance of the class
            // access members 
            this.Text = "BMI calculator";

            // input
            radioButtonImperial.Checked = true;
            labelHeight.Text = "Height (ft)";
            labelWeight.Text = "Weight (lb)";

            // output
            textBoxHeightFeet.Text = "";
            labelFeet.Text = "ft";
            labelInch.Text = "in";
            textBoxWeight.Text = "";
        }

        private void ReadName()
        {
            // delete spaces at the beginning and end of text input
            textUerName.Text.Trim();
            if (!string.IsNullOrEmpty(textUerName.Text))
            {
                myBMICalculator.SetName(textUerName.Text);
            }
            else
            {
                myBMICalculator.SetName("Unknown");
            }
        }

        /// <summary>
        /// calculates BMI based on user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCalculateBMI_Click(object sender, EventArgs e)
        {
            // read/validate input
            bool inputValid = ReadInputBMI();

            if (inputValid == true)
            {
                DisplayResults();
            }
        }

        /// <summary>
        /// get user input and save data in bmiCalc object
        /// if textName.Text == empty, bmiCalc.SetName (NoName);
        /// else bmiCalc.SetName (textName);
        /// read hight value (textHeight.Text) convert to double.TryParse ();
        /// read weight value, validate double.TryParse
        /// if weight == double, save it to bmiCalc
        /// else bmiCalc.CalculateBMI()
        /// </summary>
        // read the input provided on the user name textbox textUserName.Text
        private void DisplayResults()
        {
            labelCalculatedBMIOutput.Text = myBMICalculator.CalculateBMI().ToString("f2");
            // BMIWEIGHTCATEGORY
            labelWeightCategory.Text = myBMICalculator.BmiWeightCategory().ToString();
            labelBmiWeightRange.Text = myBMICalculator.BmiWeightRange().ToString();
            groupBoxResult.Text = "Results for " + myBMICalculator.GetName();
        }

        /// <summary>
        /// reads user input and validate if it's true
        /// </summary>
        /// <returns></returns>
        private bool ReadInputBMI()
        {
            bool isInputValid = false;

            ReadName();
            ReadUnitType();
            isInputValid = ReadHeight();
            isInputValid = isInputValid && ReadWeight();

            return isInputValid;
        }

        private void ReadUnitType()
        {
            if (radioButtonMetric.Checked)
            {
                myBMICalculator.SetUnit(UnitTypes.Metric);
                labelInch.Visible = false;
                labelBmiWeightRange.Visible = true;
            }
            else
            {
                myBMICalculator.SetUnit(UnitTypes.Imperial);
                labelInch.Visible = true;
            }
        }

        private bool ReadHeight()
        {
            double outValue = 0;
            double outValueInch = 0;
            double outValueTotal = 0;
            bool inputValid = double.TryParse(textBoxHeightFeet.Text, out outValue);
            bool inputValidInch = double.TryParse(textBoxHeightInches.Text, out outValueInch);

            if (inputValid)
            {
                if (outValue > 0 || outValueInch > 0)
                {
                    if (myBMICalculator.GetUnit() == UnitTypes.Imperial)
                    {
                        // convert ft to in
                        //myBMICalculator.SetHeight(outValue * 12.00);

                        outValueTotal = outValue * 12 + outValueInch;
                        myBMICalculator.SetHeight(outValueTotal);
                    }
                    else
                    {
                        // convert cm to m
                        myBMICalculator.SetHeight(outValue / 100.0);
                    }
                }
                else
                {
                    inputValid = false;
                }
            }

            if (inputValid == false)
            {
                MessageBox.Show("Invalid heigh value", "Error");
            }

            return inputValid;
        }

        /// <summary>
        /// Read height input and validates it and parse the data to BMI
        /// </summary>
        /// <returns></returns>
        private bool ReadWeight()
        {
            // output
            double outValue = 0;
            bool inputValid = double.TryParse(textBoxWeight.Text, out outValue);

            if (inputValid)
            {
                if (outValue > 0)
                {
                    if (myBMICalculator.GetUnit() == UnitTypes.Imperial)
                    {
                        myBMICalculator.SetWeight(outValue);
                    }
                    else
                    {
                        myBMICalculator.SetWeight(outValue);
                    }
                }
                else
                {
                    inputValid = false;
                }
            }

            if (inputValid == false)
            {
                MessageBox.Show("Invalid heigh value", "Error");
            }

            return inputValid;
        }

        private void labelTextCalculateBMI_Click(object sender, EventArgs e)
        {

        }

        private void labelUserName_Click(object sender, EventArgs e)
        {

        }

        private void labelDisclaimer_Click(object sender, EventArgs e)
        {

        }

        private void textBoxHeightInches_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCalculatedBMIOutput_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// check radioButtonMetric check status and revise the text to oindicate unit of measurement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMetric_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMetric.Checked)
            {
                labelHeight.Text = "Height (cm)";
                labelWeight.Text = "Weight (kg)";
                textBoxHeightInches.Visible = false;
                labelInch.Visible = false;
                labelFeet.Visible = false;
                myBMICalculator.SetUnit(UnitTypes.Metric);
            }
        }

        /// <summary>
        /// check radioButtonImperial check status and revise the text to oindicate unit of measurement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonImperial_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonImperial.Checked)
            {
                textBoxHeightInches.Visible = true;
                labelFeet.Visible = true;
                labelInch.Visible = true;
                labelHeight.Text = "Height (ft)";
                labelFeet.Text = "ft";
                labelInch.Text = "in";
                labelWeight.Text = "Weight (lb)";
                myBMICalculator.SetUnit(UnitTypes.Imperial);
            }
        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {
        }
    }
}
