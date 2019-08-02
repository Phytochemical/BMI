namespace Assignment3
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
            this.textBoxHightFeet = new System.Windows.Forms.TextBox();
            this.textBoxHightInches = new System.Windows.Forms.TextBox();
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
            this.groupBoxRadioButton = new System.Windows.Forms.GroupBox();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(80, 97);
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
            this.textUerName.Size = new System.Drawing.Size(300, 20);
            this.textUerName.TabIndex = 1;
            // 
            // textBoxHightFeet
            // 
            this.textBoxHightFeet.Location = new System.Drawing.Point(73, 42);
            this.textBoxHightFeet.Name = "textBoxHightFeet";
            this.textBoxHightFeet.Size = new System.Drawing.Size(47, 20);
            this.textBoxHightFeet.TabIndex = 2;
            // 
            // textBoxHightInches
            // 
            this.textBoxHightInches.Location = new System.Drawing.Point(126, 42);
            this.textBoxHightInches.Name = "textBoxHightInches";
            this.textBoxHightInches.Size = new System.Drawing.Size(47, 20);
            this.textBoxHightInches.TabIndex = 3;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(73, 71);
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
            this.labelCalculatedBMIOutput.Location = new System.Drawing.Point(126, 150);
            this.labelCalculatedBMIOutput.Name = "labelCalculatedBMIOutput";
            this.labelCalculatedBMIOutput.Size = new System.Drawing.Size(93, 17);
            this.labelCalculatedBMIOutput.TabIndex = 8;
            // 
            // labelTextCalculateBMI
            // 
            this.labelTextCalculateBMI.AutoSize = true;
            this.labelTextCalculateBMI.Location = new System.Drawing.Point(26, 150);
            this.labelTextCalculateBMI.Name = "labelTextCalculateBMI";
            this.labelTextCalculateBMI.Size = new System.Drawing.Size(79, 13);
            this.labelTextCalculateBMI.TabIndex = 9;
            this.labelTextCalculateBMI.Text = "Calculated BMI";
            this.labelTextCalculateBMI.Click += new System.EventHandler(this.labelTextCalculateBMI_Click);
            // 
            // labelTextWeightCategory
            // 
            this.labelTextWeightCategory.AutoSize = true;
            this.labelTextWeightCategory.Location = new System.Drawing.Point(26, 180);
            this.labelTextWeightCategory.Name = "labelTextWeightCategory";
            this.labelTextWeightCategory.Size = new System.Drawing.Size(86, 13);
            this.labelTextWeightCategory.TabIndex = 10;
            this.labelTextWeightCategory.Text = "Weight Category";
            // 
            // labelWeightCategory
            // 
            this.labelWeightCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelWeightCategory.Location = new System.Drawing.Point(126, 179);
            this.labelWeightCategory.Name = "labelWeightCategory";
            this.labelWeightCategory.Size = new System.Drawing.Size(93, 17);
            this.labelWeightCategory.TabIndex = 11;
            // 
            // labelDisclaimer
            // 
            this.labelDisclaimer.AutoSize = true;
            this.labelDisclaimer.Location = new System.Drawing.Point(34, 217);
            this.labelDisclaimer.Name = "labelDisclaimer";
            this.labelDisclaimer.Size = new System.Drawing.Size(185, 13);
            this.labelDisclaimer.TabIndex = 12;
            this.labelDisclaimer.Text = "Normal BMI is between 18.5 and 24.9";
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
            // 
            // groupBoxRadioButton
            // 
            this.groupBoxRadioButton.Controls.Add(this.radioButtonImperial);
            this.groupBoxRadioButton.Controls.Add(this.radioButtonMetric);
            this.groupBoxRadioButton.Location = new System.Drawing.Point(225, 38);
            this.groupBoxRadioButton.Name = "groupBoxRadioButton";
            this.groupBoxRadioButton.Size = new System.Drawing.Size(148, 81);
            this.groupBoxRadioButton.TabIndex = 14;
            this.groupBoxRadioButton.TabStop = false;
            this.groupBoxRadioButton.Text = "Unit of measurement";
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(18, 42);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(81, 17);
            this.radioButtonImperial.TabIndex = 14;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial unit";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 251);
            this.Controls.Add(this.groupBoxRadioButton);
            this.Controls.Add(this.labelDisclaimer);
            this.Controls.Add(this.labelWeightCategory);
            this.Controls.Add(this.labelTextWeightCategory);
            this.Controls.Add(this.labelTextCalculateBMI);
            this.Controls.Add(this.labelCalculatedBMIOutput);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.textBoxHightInches);
            this.Controls.Add(this.textBoxHightFeet);
            this.Controls.Add(this.textUerName);
            this.Controls.Add(this.buttonCalculateBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Text = "BMI (Body Mass Index)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxRadioButton.ResumeLayout(false);
            this.groupBoxRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.TextBox textUerName;
        private System.Windows.Forms.TextBox textBoxHightFeet;
        private System.Windows.Forms.TextBox textBoxHightInches;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelCalculatedBMIOutput;
        private System.Windows.Forms.Label labelTextCalculateBMI;
        private System.Windows.Forms.Label labelTextWeightCategory;
        private System.Windows.Forms.Label labelWeightCategory;
        private System.Windows.Forms.Label labelDisclaimer;
        private System.Windows.Forms.GroupBox groupBoxRadioButton;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.RadioButton radioButtonImperial;
    }
}

