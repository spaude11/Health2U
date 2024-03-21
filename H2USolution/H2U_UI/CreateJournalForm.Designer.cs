namespace H2U_UI
{
    partial class createJournalForm
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
            journalLabel = new Label();
            journalValue = new TextBox();
            createJournalButton = new Button();
            SuspendLayout();
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Segoe UI Light", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            headerLabel.Location = new Point(22, 36);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(649, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "We encourage you to create journal to keep your mental health on track";
            // 
            // journalLabel
            // 
            journalLabel.AutoSize = true;
            journalLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            journalLabel.Location = new Point(36, 109);
            journalLabel.Name = "journalLabel";
            journalLabel.Size = new Size(195, 30);
            journalLabel.TabIndex = 1;
            journalLabel.Text = "Create your journal:";
            // 
            // journalValue
            // 
            journalValue.Location = new Point(36, 159);
            journalValue.Multiline = true;
            journalValue.Name = "journalValue";
            journalValue.Size = new Size(461, 190);
            journalValue.TabIndex = 2;
            // 
            // createJournalButton
            // 
            createJournalButton.FlatAppearance.BorderColor = Color.Silver;
            createJournalButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            createJournalButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            createJournalButton.FlatStyle = FlatStyle.Flat;
            createJournalButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            createJournalButton.ForeColor = SystemColors.MenuHighlight;
            createJournalButton.Location = new Point(126, 380);
            createJournalButton.Name = "createJournalButton";
            createJournalButton.Size = new Size(202, 49);
            createJournalButton.TabIndex = 24;
            createJournalButton.Text = "Insert";
            createJournalButton.UseVisualStyleBackColor = true;
            // 
            // createJournalForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(960, 630);
            Controls.Add(createJournalButton);
            Controls.Add(journalValue);
            Controls.Add(journalLabel);
            Controls.Add(headerLabel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.MenuHighlight;
            Margin = new Padding(4, 4, 4, 4);
            Name = "createJournalForm";
            Text = "Create Journal Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerLabel;
        private Label journalLabel;
        private TextBox journalValue;
        private Button createJournalButton;
    }
}