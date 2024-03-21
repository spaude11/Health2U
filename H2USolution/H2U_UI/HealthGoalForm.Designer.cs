namespace H2U_UI
{
    partial class healthGoalForm
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
            waterIntakeGoalValue = new TextBox();
            waterIntakeLabel = new Label();
            weightGoalValue = new TextBox();
            weightGoalLabel = new Label();
            caloriesBurnGoalValue = new TextBox();
            caloriesBurnGoalLabel = new Label();
            caloriesBurntValue = new TextBox();
            exerciseDaysGoalLabel = new Label();
            createHealthGoalButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(23, 21);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(234, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Set up your Health Goal: ";
            // 
            // waterIntakeGoalValue
            // 
            waterIntakeGoalValue.Location = new Point(169, 141);
            waterIntakeGoalValue.Name = "waterIntakeGoalValue";
            waterIntakeGoalValue.Size = new Size(157, 29);
            waterIntakeGoalValue.TabIndex = 13;
            // 
            // waterIntakeLabel
            // 
            waterIntakeLabel.AutoSize = true;
            waterIntakeLabel.Location = new Point(12, 144);
            waterIntakeLabel.Name = "waterIntakeLabel";
            waterIntakeLabel.Size = new Size(135, 21);
            waterIntakeLabel.TabIndex = 12;
            waterIntakeLabel.Text = "Water-Intake Goal";
            // 
            // weightGoalValue
            // 
            weightGoalValue.Location = new Point(169, 76);
            weightGoalValue.Name = "weightGoalValue";
            weightGoalValue.Size = new Size(157, 29);
            weightGoalValue.TabIndex = 11;
            // 
            // weightGoalLabel
            // 
            weightGoalLabel.AutoSize = true;
            weightGoalLabel.Location = new Point(12, 84);
            weightGoalLabel.Name = "weightGoalLabel";
            weightGoalLabel.Size = new Size(102, 21);
            weightGoalLabel.TabIndex = 10;
            weightGoalLabel.Text = "Weight Goal: ";
            // 
            // caloriesBurnGoalValue
            // 
            caloriesBurnGoalValue.Location = new Point(169, 262);
            caloriesBurnGoalValue.Name = "caloriesBurnGoalValue";
            caloriesBurnGoalValue.Size = new Size(157, 29);
            caloriesBurnGoalValue.TabIndex = 17;
            // 
            // caloriesBurnGoalLabel
            // 
            caloriesBurnGoalLabel.AutoSize = true;
            caloriesBurnGoalLabel.Location = new Point(12, 265);
            caloriesBurnGoalLabel.Name = "caloriesBurnGoalLabel";
            caloriesBurnGoalLabel.Size = new Size(110, 21);
            caloriesBurnGoalLabel.TabIndex = 16;
            caloriesBurnGoalLabel.Text = "Calories Burn: ";
            // 
            // caloriesBurntValue
            // 
            caloriesBurntValue.Location = new Point(169, 197);
            caloriesBurntValue.Name = "caloriesBurntValue";
            caloriesBurntValue.Size = new Size(157, 29);
            caloriesBurntValue.TabIndex = 15;
            // 
            // exerciseDaysGoalLabel
            // 
            exerciseDaysGoalLabel.AutoSize = true;
            exerciseDaysGoalLabel.Location = new Point(12, 200);
            exerciseDaysGoalLabel.Name = "exerciseDaysGoalLabel";
            exerciseDaysGoalLabel.Size = new Size(110, 21);
            exerciseDaysGoalLabel.TabIndex = 14;
            exerciseDaysGoalLabel.Text = "Exercise Days: ";
            // 
            // createHealthGoalButton
            // 
            createHealthGoalButton.FlatAppearance.BorderColor = Color.Silver;
            createHealthGoalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createHealthGoalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createHealthGoalButton.FlatStyle = FlatStyle.Flat;
            createHealthGoalButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createHealthGoalButton.ForeColor = SystemColors.MenuHighlight;
            createHealthGoalButton.Location = new Point(66, 364);
            createHealthGoalButton.Name = "createHealthGoalButton";
            createHealthGoalButton.Size = new Size(202, 49);
            createHealthGoalButton.TabIndex = 23;
            createHealthGoalButton.Text = "Insert";
            createHealthGoalButton.UseVisualStyleBackColor = true;
            // 
            // healthGoalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(444, 630);
            Controls.Add(createHealthGoalButton);
            Controls.Add(caloriesBurnGoalValue);
            Controls.Add(caloriesBurnGoalLabel);
            Controls.Add(caloriesBurntValue);
            Controls.Add(exerciseDaysGoalLabel);
            Controls.Add(waterIntakeGoalValue);
            Controls.Add(waterIntakeLabel);
            Controls.Add(weightGoalValue);
            Controls.Add(weightGoalLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "healthGoalForm";
            Text = "Health Goal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox waterIntakeGoalValue;
        private Label waterIntakeLabel;
        private TextBox weightGoalValue;
        private Label weightGoalLabel;
        private TextBox caloriesBurnGoalValue;
        private Label caloriesBurnGoalLabel;
        private TextBox caloriesBurntValue;
        private Label exerciseDaysGoalLabel;
        private Button createHealthGoalButton;
    }
}