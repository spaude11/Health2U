namespace H2U_UI
{
    partial class HealthInstitutesForm
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
            label1 = new Label();
            areaLabel = new Label();
            lifeStyleValue = new ComboBox();
            healthInstitutesLabel = new Label();
            healthInstitutesTable = new TableLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 45);
            label1.Name = "label1";
            label1.Size = new Size(548, 30);
            label1.TabIndex = 0;
            label1.Text = "We provides local health institutes location near your locality. ";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new Point(43, 124);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(147, 21);
            areaLabel.TabIndex = 1;
            areaLabel.Text = "Where do you live? ";
            // 
            // lifeStyleValue
            // 
            lifeStyleValue.FormattingEnabled = true;
            lifeStyleValue.Location = new Point(252, 121);
            lifeStyleValue.Name = "lifeStyleValue";
            lifeStyleValue.Size = new Size(157, 29);
            lifeStyleValue.TabIndex = 15;
            lifeStyleValue.Text = "Shreveport";
            // 
            // healthInstitutesLabel
            // 
            healthInstitutesLabel.AutoSize = true;
            healthInstitutesLabel.Location = new Point(75, 202);
            healthInstitutesLabel.Name = "healthInstitutesLabel";
            healthInstitutesLabel.Size = new Size(323, 21);
            healthInstitutesLabel.TabIndex = 16;
            healthInstitutesLabel.Text = "Here are the list of health institutes near you: ";
            // 
            // healthInstitutesTable
            // 
            healthInstitutesTable.ColumnCount = 5;
            healthInstitutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.87689F));
            healthInstitutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.12311F));
            healthInstitutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            healthInstitutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 174F));
            healthInstitutesTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 111F));
            healthInstitutesTable.Location = new Point(33, 251);
            healthInstitutesTable.Name = "healthInstitutesTable";
            healthInstitutesTable.RowCount = 2;
            healthInstitutesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            healthInstitutesTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            healthInstitutesTable.Size = new Size(904, 100);
            healthInstitutesTable.TabIndex = 17;
            healthInstitutesTable.Paint += tableLayoutPanel1_Paint;
            // 
            // HealthInstitutesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 630);
            Controls.Add(healthInstitutesTable);
            Controls.Add(healthInstitutesLabel);
            Controls.Add(lifeStyleValue);
            Controls.Add(areaLabel);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "HealthInstitutesForm";
            Text = "Health Institutes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label areaLabel;
        private ComboBox lifeStyleValue;
        private Label healthInstitutesLabel;
        private TableLayoutPanel healthInstitutesTable;
    }
}