﻿namespace Assignment3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.textUerName = new System.Windows.Forms.TextBox();
            this.textBoxHeightFeet = new System.Windows.Forms.TextBox();
            this.textBoxHeightInches = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelCalculatedBMIOutput = new System.Windows.Forms.Label();
            this.labelTextCalculateBMI = new System.Windows.Forms.Label();
            this.labelTextWeightCategory = new System.Windows.Forms.Label();
            this.labelWeightCategory = new System.Windows.Forms.Label();
            this.labelDisclaimer = new System.Windows.Forms.Label();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelBmiWeightRange = new System.Windows.Forms.Label();
            this.labelFeet = new System.Windows.Forms.Label();
            this.labelInch = new System.Windows.Forms.Label();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(97, 94);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(132, 34);
            this.buttonCalculateBMI.TabIndex = 0;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.ButtonCalculateBMI_Click);
            // 
            // textUerName
            // 
            this.textUerName.Location = new System.Drawing.Point(73, 12);
            this.textUerName.Name = "textUerName";
            this.textUerName.Size = new System.Drawing.Size(315, 20);
            this.textUerName.TabIndex = 1;
            // 
            // textBoxHeightFeet
            // 
            this.textBoxHeightFeet.Location = new System.Drawing.Point(92, 42);
            this.textBoxHeightFeet.Name = "textBoxHeightFeet";
            this.textBoxHeightFeet.Size = new System.Drawing.Size(47, 20);
            this.textBoxHeightFeet.TabIndex = 2;
            // 
            // textBoxHeightInches
            // 
            this.textBoxHeightInches.Location = new System.Drawing.Point(163, 42);
            this.textBoxHeightInches.Name = "textBoxHeightInches";
            this.textBoxHeightInches.Size = new System.Drawing.Size(47, 20);
            this.textBoxHeightInches.TabIndex = 3;
            this.textBoxHeightInches.TextChanged += new System.EventHandler(this.textBoxHeightInches_TextChanged);
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(92, 68);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(47, 20);
            this.textBoxWeight.TabIndex = 4;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(26, 49);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 5;
            this.labelHeight.Text = "Height";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(26, 19);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(35, 13);
            this.labelUserName.TabIndex = 6;
            this.labelUserName.Text = "Name";
            this.labelUserName.Click += new System.EventHandler(this.labelUserName_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(26, 74);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(41, 13);
            this.labelWeight.TabIndex = 7;
            this.labelWeight.Text = "Weight";
            // 
            // labelCalculatedBMIOutput
            // 
            this.labelCalculatedBMIOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCalculatedBMIOutput.Location = new System.Drawing.Point(116, 22);
            this.labelCalculatedBMIOutput.Name = "labelCalculatedBMIOutput";
            this.labelCalculatedBMIOutput.Size = new System.Drawing.Size(93, 17);
            this.labelCalculatedBMIOutput.TabIndex = 8;
            this.labelCalculatedBMIOutput.Click += new System.EventHandler(this.labelCalculatedBMIOutput_Click);
            // 
            // labelTextCalculateBMI
            // 
            this.labelTextCalculateBMI.AutoSize = true;
            this.labelTextCalculateBMI.Location = new System.Drawing.Point(15, 26);
            this.labelTextCalculateBMI.Name = "labelTextCalculateBMI";
            this.labelTextCalculateBMI.Size = new System.Drawing.Size(79, 13);
            this.labelTextCalculateBMI.TabIndex = 9;
            this.labelTextCalculateBMI.Text = "Calculated BMI";
            this.labelTextCalculateBMI.Click += new System.EventHandler(this.labelTextCalculateBMI_Click);
            // 
            // labelTextWeightCategory
            // 
            this.labelTextWeightCategory.AutoSize = true;
            this.labelTextWeightCategory.Location = new System.Drawing.Point(15, 53);
            this.labelTextWeightCategory.Name = "labelTextWeightCategory";
            this.labelTextWeightCategory.Size = new System.Drawing.Size(86, 13);
            this.labelTextWeightCategory.TabIndex = 10;
            this.labelTextWeightCategory.Text = "Weight Category";
            // 
            // labelWeightCategory
            // 
            this.labelWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeightCategory.Location = new System.Drawing.Point(116, 52);
            this.labelWeightCategory.Name = "labelWeightCategory";
            this.labelWeightCategory.Size = new System.Drawing.Size(93, 17);
            this.labelWeightCategory.TabIndex = 11;
            // 
            // labelDisclaimer
            // 
            this.labelDisclaimer.AutoSize = true;
            this.labelDisclaimer.Location = new System.Drawing.Point(15, 81);
            this.labelDisclaimer.Name = "labelDisclaimer";
            this.labelDisclaimer.Size = new System.Drawing.Size(185, 13);
            this.labelDisclaimer.TabIndex = 12;
            this.labelDisclaimer.Text = "Normal BMI is between 18.5 and 24.9";
            this.labelDisclaimer.Click += new System.EventHandler(this.labelDisclaimer_Click);
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(18, 19);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(94, 17);
            this.radioButtonMetric.TabIndex = 13;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric (kg/cm)";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            this.radioButtonMetric.CheckedChanged += new System.EventHandler(this.radioButtonMetric_CheckedChanged);
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.Controls.Add(this.radioButtonImperial);
            this.groupBoxUnit.Controls.Add(this.radioButtonMetric);
            this.groupBoxUnit.Location = new System.Drawing.Point(240, 38);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(148, 75);
            this.groupBoxUnit.TabIndex = 14;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit of measurement";
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(18, 42);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(109, 17);
            this.radioButtonImperial.TabIndex = 14;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial unit (ft/lb)";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.radioButtonImperial_CheckedChanged);
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelBmiWeightRange);
            this.groupBoxResult.Controls.Add(this.labelTextCalculateBMI);
            this.groupBoxResult.Controls.Add(this.labelTextWeightCategory);
            this.groupBoxResult.Controls.Add(this.labelDisclaimer);
            this.groupBoxResult.Controls.Add(this.labelCalculatedBMIOutput);
            this.groupBoxResult.Controls.Add(this.labelWeightCategory);
            this.groupBoxResult.Location = new System.Drawing.Point(29, 151);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(344, 129);
            this.groupBoxResult.TabIndex = 15;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Results for";
            this.groupBoxResult.Enter += new System.EventHandler(this.groupBoxResult_Enter);
            // 
            // labelBmiWeightRange
            // 
            this.labelBmiWeightRange.ForeColor = System.Drawing.Color.Green;
            this.labelBmiWeightRange.Location = new System.Drawing.Point(15, 106);
            this.labelBmiWeightRange.Name = "labelBmiWeightRange";
            this.labelBmiWeightRange.Size = new System.Drawing.Size(279, 11);
            this.labelBmiWeightRange.TabIndex = 13;
            this.labelBmiWeightRange.Click += new System.EventHandler(this.labelBmiWeightRange_Click);
            // 
            // labelFeet
            // 
            this.labelFeet.AutoSize = true;
            this.labelFeet.Location = new System.Drawing.Point(145, 45);
            this.labelFeet.Name = "labelFeet";
            this.labelFeet.Size = new System.Drawing.Size(13, 13);
            this.labelFeet.TabIndex = 16;
            this.labelFeet.Text = "ft";
            // 
            // labelInch
            // 
            this.labelInch.AutoSize = true;
            this.labelInch.Location = new System.Drawing.Point(216, 45);
            this.labelInch.Name = "labelInch";
            this.labelInch.Size = new System.Drawing.Size(15, 13);
            this.labelInch.TabIndex = 17;
            this.labelInch.Text = "in";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 304);
            this.Controls.Add(this.labelInch);
            this.Controls.Add(this.labelFeet);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHeightInches);
            this.Controls.Add(this.textBoxHeightFeet);
            this.Controls.Add(this.textUerName);
            this.Controls.Add(this.buttonCalculateBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "BMI (Body Mass Index)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.TextBox textUerName;
        private System.Windows.Forms.TextBox textBoxHeightFeet;
        private System.Windows.Forms.TextBox textBoxHeightInches;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelCalculatedBMIOutput;
        private System.Windows.Forms.Label labelTextCalculateBMI;
        private System.Windows.Forms.Label labelTextWeightCategory;
        private System.Windows.Forms.Label labelWeightCategory;
        private System.Windows.Forms.Label labelDisclaimer;
        private System.Windows.Forms.GroupBox groupBoxUnit;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelFeet;
        private System.Windows.Forms.Label labelInch;
        private System.Windows.Forms.Label labelBmiWeightRange;
    }
}

