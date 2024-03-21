namespace H2U_UI
{
    partial class exerciseRecordForm
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
            newWeightValue = new TextBox();
            newWeightLabel = new Label();
            caloriesBurntValue = new TextBox();
            caloriesBurntLabel = new Label();
            commentLabel = new Label();
            daysAtGymValue = new TextBox();
            daysAtGymLabel = new Label();
            commentValue = new TextBox();
            createExerciseRecordButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(41, 28);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(264, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Enter Your Exercise Routine: ";
            // 
            // newWeightValue
            // 
            newWeightValue.Location = new Point(148, 166);
            newWeightValue.Name = "newWeightValue";
            newWeightValue.Size = new Size(157, 29);
            newWeightValue.TabIndex = 9;
            // 
            // newWeightLabel
            // 
            newWeightLabel.AutoSize = true;
            newWeightLabel.Location = new Point(14, 169);
            newWeightLabel.Name = "newWeightLabel";
            newWeightLabel.Size = new Size(66, 21);
            newWeightLabel.TabIndex = 8;
            newWeightLabel.Text = "Weight: ";
            // 
            // caloriesBurntValue
            // 
            caloriesBurntValue.Location = new Point(148, 101);
            caloriesBurntValue.Name = "caloriesBurntValue";
            caloriesBurntValue.Size = new Size(157, 29);
            caloriesBurntValue.TabIndex = 7;
            // 
            // caloriesBurntLabel
            // 
            caloriesBurntLabel.AutoSize = true;
            caloriesBurntLabel.Location = new Point(14, 104);
            caloriesBurntLabel.Name = "caloriesBurntLabel";
            caloriesBurntLabel.Size = new Size(115, 21);
            caloriesBurntLabel.TabIndex = 6;
            caloriesBurntLabel.Text = "Calories Burnt: ";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new Point(14, 307);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new Size(124, 21);
            commentLabel.TabIndex = 12;
            commentLabel.Text = "Any Comments: ";
            // 
            // daysAtGymValue
            // 
            daysAtGymValue.Location = new Point(148, 239);
            daysAtGymValue.Name = "daysAtGymValue";
            daysAtGymValue.Size = new Size(157, 29);
            daysAtGymValue.TabIndex = 11;
            // 
            // daysAtGymLabel
            // 
            daysAtGymLabel.AutoSize = true;
            daysAtGymLabel.Location = new Point(14, 242);
            daysAtGymLabel.Name = "daysAtGymLabel";
            daysAtGymLabel.Size = new Size(103, 21);
            daysAtGymLabel.TabIndex = 10;
            daysAtGymLabel.Text = "Exercise Days";
            // 
            // commentValue
            // 
            commentValue.Location = new Point(148, 304);
            commentValue.Name = "commentValue";
            commentValue.Size = new Size(157, 29);
            commentValue.TabIndex = 13;
            // 
            // createExerciseRecordButton
            // 
            createExerciseRecordButton.FlatAppearance.BorderColor = Color.Silver;
            createExerciseRecordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createExerciseRecordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createExerciseRecordButton.FlatStyle = FlatStyle.Flat;
            createExerciseRecordButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createExerciseRecordButton.ForeColor = SystemColors.MenuHighlight;
            createExerciseRecordButton.Location = new Point(65, 396);
            createExerciseRecordButton.Name = "createExerciseRecordButton";
            createExerciseRecordButton.Size = new Size(202, 49);
            createExerciseRecordButton.TabIndex = 23;
            createExerciseRecordButton.Text = "Insert ";
            createExerciseRecordButton.UseVisualStyleBackColor = true;
            // 
            // exerciseRecordForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(781, 630);
            Controls.Add(createExerciseRecordButton);
            Controls.Add(commentValue);
            Controls.Add(commentLabel);
            Controls.Add(daysAtGymValue);
            Controls.Add(daysAtGymLabel);
            Controls.Add(newWeightValue);
            Controls.Add(newWeightLabel);
            Controls.Add(caloriesBurntValue);
            Controls.Add(caloriesBurntLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "exerciseRecordForm";
            Text = "Exercise Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private TextBox newWeightValue;
        private Label newWeightLabel;
        private TextBox caloriesBurntValue;
        private Label caloriesBurntLabel;
        private Label commentLabel;
        private TextBox daysAtGymValue;
        private Label daysAtGymLabel;
        private TextBox commentValue;
        private Button createExerciseRecordButton;
    }
}