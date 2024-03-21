namespace H2U_UI
{
    partial class medicalHistoryForm
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
            headerLabel = new Label();
            weightLabel = new Label();
            weightValue = new TextBox();
            heightValue = new TextBox();
            heightLabel = new Label();
            bloodSugarValue = new TextBox();
            bloodSugarLabel = new Label();
            bmiValue = new TextBox();
            bmiLabel = new Label();
            diseasesValue = new TextBox();
            diseasesLabel = new Label();
            textBox5 = new TextBox();
            recentCheckupLabel = new Label();
            lifeStyleValue = new ComboBox();
            activeStatusLabel = new Label();
            activeLabel = new Label();
            memoLabel = new Label();
            createMedicalHistoryButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(12, 37);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(259, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Fill up your medical history; ";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new Point(12, 121);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new Size(66, 21);
            weightLabel.TabIndex = 1;
            weightLabel.Text = "Weight: ";
            // 
            // weightValue
            // 
            weightValue.Location = new Point(146, 118);
            weightValue.Name = "weightValue";
            weightValue.Size = new Size(157, 29);
            weightValue.TabIndex = 3;
            // 
            // heightValue
            // 
            heightValue.Location = new Point(146, 183);
            heightValue.Name = "heightValue";
            heightValue.Size = new Size(157, 29);
            heightValue.TabIndex = 5;
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new Point(12, 186);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new Size(63, 21);
            heightLabel.TabIndex = 4;
            heightLabel.Text = "Height: ";
            // 
            // bloodSugarValue
            // 
            bloodSugarValue.Location = new Point(146, 303);
            bloodSugarValue.Name = "bloodSugarValue";
            bloodSugarValue.Size = new Size(157, 29);
            bloodSugarValue.TabIndex = 7;
            // 
            // bloodSugarLabel
            // 
            bloodSugarLabel.AutoSize = true;
            bloodSugarLabel.Location = new Point(12, 306);
            bloodSugarLabel.Name = "bloodSugarLabel";
            bloodSugarLabel.Size = new Size(102, 21);
            bloodSugarLabel.TabIndex = 6;
            bloodSugarLabel.Text = "Blood Sugar: ";
            // 
            // bmiValue
            // 
            bmiValue.Location = new Point(146, 372);
            bmiValue.Name = "bmiValue";
            bmiValue.Size = new Size(157, 29);
            bmiValue.TabIndex = 9;
            // 
            // bmiLabel
            // 
            bmiLabel.AutoSize = true;
            bmiLabel.Location = new Point(12, 375);
            bmiLabel.Name = "bmiLabel";
            bmiLabel.Size = new Size(44, 21);
            bmiLabel.TabIndex = 8;
            bmiLabel.Text = "BMI: ";
            // 
            // diseasesValue
            // 
            diseasesValue.Location = new Point(146, 444);
            diseasesValue.Name = "diseasesValue";
            diseasesValue.Size = new Size(157, 29);
            diseasesValue.TabIndex = 11;
            // 
            // diseasesLabel
            // 
            diseasesLabel.AutoSize = true;
            diseasesLabel.Location = new Point(12, 447);
            diseasesLabel.Name = "diseasesLabel";
            diseasesLabel.Size = new Size(108, 21);
            diseasesLabel.TabIndex = 10;
            diseasesLabel.Text = "Any Diseases: ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(146, 512);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(157, 29);
            textBox5.TabIndex = 13;
            // 
            // recentCheckupLabel
            // 
            recentCheckupLabel.AutoSize = true;
            recentCheckupLabel.Location = new Point(12, 515);
            recentCheckupLabel.Name = "recentCheckupLabel";
            recentCheckupLabel.Size = new Size(106, 21);
            recentCheckupLabel.TabIndex = 12;
            recentCheckupLabel.Text = "Checkup Date";
            // 
            // lifeStyleValue
            // 
            lifeStyleValue.FormattingEnabled = true;
            lifeStyleValue.Location = new Point(146, 249);
            lifeStyleValue.Name = "lifeStyleValue";
            lifeStyleValue.Size = new Size(157, 29);
            lifeStyleValue.TabIndex = 14;
            lifeStyleValue.Text = "Yes";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new Point(12, 252);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new Size(72, 21);
            activeStatusLabel.TabIndex = 15;
            activeStatusLabel.Text = "Life Style";
            // 
            // activeLabel
            // 
            activeLabel.AutoSize = true;
            activeLabel.Location = new Point(337, 254);
            activeLabel.Name = "activeLabel";
            activeLabel.Size = new Size(126, 21);
            activeLabel.TabIndex = 16;
            activeLabel.Text = ": Are you active? ";
            // 
            // memoLabel
            // 
            memoLabel.AutoSize = true;
            memoLabel.Location = new Point(337, 520);
            memoLabel.Name = "memoLabel";
            memoLabel.Size = new Size(309, 21);
            memoLabel.TabIndex = 17;
            memoLabel.Text = ": Your recent checkup? Insert MM/DD/YYYY";
            // 
            // createMedicalHistoryButton
            // 
            createMedicalHistoryButton.FlatAppearance.BorderColor = Color.Silver;
            createMedicalHistoryButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createMedicalHistoryButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createMedicalHistoryButton.FlatStyle = FlatStyle.Flat;
            createMedicalHistoryButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createMedicalHistoryButton.ForeColor = SystemColors.MenuHighlight;
            createMedicalHistoryButton.Location = new Point(101, 586);
            createMedicalHistoryButton.Name = "createMedicalHistoryButton";
            createMedicalHistoryButton.Size = new Size(202, 49);
            createMedicalHistoryButton.TabIndex = 22;
            createMedicalHistoryButton.Text = "Insert: ";
            createMedicalHistoryButton.UseVisualStyleBackColor = true;
            // 
            // medicalHistoryForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(919, 658);
            Controls.Add(createMedicalHistoryButton);
            Controls.Add(memoLabel);
            Controls.Add(activeLabel);
            Controls.Add(activeStatusLabel);
            Controls.Add(lifeStyleValue);
            Controls.Add(textBox5);
            Controls.Add(recentCheckupLabel);
            Controls.Add(diseasesValue);
            Controls.Add(diseasesLabel);
            Controls.Add(bmiValue);
            Controls.Add(bmiLabel);
            Controls.Add(bloodSugarValue);
            Controls.Add(bloodSugarLabel);
            Controls.Add(heightValue);
            Controls.Add(heightLabel);
            Controls.Add(weightValue);
            Controls.Add(weightLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "medicalHistoryForm";
            Text = "Medical History: ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label weightLabel;
        private TextBox weightValue;
        private TextBox heightValue;
        private Label heightLabel;
        private TextBox bloodSugarValue;
        private Label bloodSugarLabel;
        private TextBox bmiValue;
        private Label bmiLabel;
        private TextBox diseasesValue;
        private Label diseasesLabel;
        private TextBox textBox5;
        private Label recentCheckupLabel;
        private ComboBox lifeStyleValue;
        private Label activeStatusLabel;
        private Label activeLabel;
        private Label memoLabel;
        private Button createMedicalHistoryButton;
    }
}