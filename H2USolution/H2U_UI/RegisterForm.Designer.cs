namespace H2U_UI
{
    partial class registerForm
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.userPasswordValue = new System.Windows.Forms.TextBox();
            this.userPasswordLabel = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.BackColor = System.Drawing.Color.White;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.headerLabel.Location = new System.Drawing.Point(135, 39);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(159, 30);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Register/Log In ";
            // 
            // userPasswordValue
            // 
            this.userPasswordValue.Location = new System.Drawing.Point(160, 151);
            this.userPasswordValue.Name = "userPasswordValue";
            this.userPasswordValue.Size = new System.Drawing.Size(157, 29);
            this.userPasswordValue.TabIndex = 8;
            // 
            // userPasswordLabel
            // 
            this.userPasswordLabel.AutoSize = true;
            this.userPasswordLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userPasswordLabel.Location = new System.Drawing.Point(19, 159);
            this.userPasswordLabel.Name = "userPasswordLabel";
            this.userPasswordLabel.Size = new System.Drawing.Size(123, 21);
            this.userPasswordLabel.TabIndex = 7;
            this.userPasswordLabel.Text = "User Password:  ";
            // 
            // userNameValue
            // 
            this.userNameValue.Location = new System.Drawing.Point(160, 101);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(157, 29);
            this.userNameValue.TabIndex = 6;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userNameLabel.Location = new System.Drawing.Point(19, 104);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(95, 21);
            this.userNameLabel.TabIndex = 5;
            this.userNameLabel.Text = "User Name: ";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Location = new System.Drawing.Point(115, 237);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(202, 49);
            this.loginButton.TabIndex = 22;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 387);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPasswordValue);
            this.Controls.Add(this.userPasswordLabel);
            this.Controls.Add(this.userNameValue);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "registerForm";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.registerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label headerLabel;
        private TextBox userPasswordValue;
        private Label userPasswordLabel;
        private TextBox userNameValue;
        private Label userNameLabel;
        private Button loginButton;
    }
}