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

        // initiazlie GUI with the curent options, set defualt radioButton values
        // encapsulate within a container component groupBox
        // when one button is checked, rest should be unchecked
        private void InitializeGUI()
        {
            // current instance of the class
            // access members 
            this.Text = "BMI calculator";

            // input
            radioButtonImperial.Checked = true;
            labelHeight.Text = "Height (ft)";
            labelWeight.Text = "Weight (lbs)";

            // output
            textBoxHightFeet.Text = "";
            textBoxWeight.Text = "";
        }

        private void ReadName()
        {
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
        /// if txtName.Text == empty, bmiCalc.SetName (NoName);
        /// else bmiCalc.SetName (txtName);
        /// read hight value (txtHeight.Text) convert to double.TryParse ();
        /// read weight value, validate double.TryParse
        /// if weight == double, save it to bmiCalc
        /// else bmiCalc.CalculateBMI ()
        /// </summary>

        // read the input provided on the user name textbox textUserName.Text
        private void DisplayResults()
        {
            labelTextCalculateBMI.Text = myBMICalculator.CalculateBMI().ToString("f2");
            // lblResultYourBmi.Text = bmiCalc.CalculateBMI ( ).ToString ("0.00"); 
            // BMIWEIGHTCATEGORY
            labelTextWeightCategory.Text = myBMICalculator.BmiWeightCategory().ToString();
            groupBoxUnit.Text = myBMICalculator.GetName();
            //labelDisclaimer.Text = myBMICalculator.NormalWeight;
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
            }
            else
            {
                myBMICalculator.SetUnit(UnitTypes.Imperial);
            }
        }

        private bool ReadHeight()
        {
            double outValue = 0;
            bool inputValid = double.TryParse(textBoxHightFeet.Text, out outValue);

            if (inputValid)
            {
                if (outValue > 0)
                {
                    if (myBMICalculator.GetUnit() == UnitTypes.Imperial)
                    {
                        // convert ft to in
                        myBMICalculator.SetHeight(outValue * 12.00);
                    }
                    else
                    {
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
                        myBMICalculator.SetWeight(outValue * 12.00);
                    }
                    else
                    {
                        myBMICalculator.SetWeight(outValue / 100.0);
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
    }
}
