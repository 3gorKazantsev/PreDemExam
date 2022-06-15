namespace PreDemExam
{
    partial class AuthForm
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
            this.authBtn = new System.Windows.Forms.Button();
            this.userTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.dbNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(107, 350);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(75, 23);
            this.authBtn.TabIndex = 0;
            this.authBtn.Text = "button1";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(58, 133);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(216, 23);
            this.userTB.TabIndex = 1;
            // 
            // passwordTB
            // 
            this.passwordTB.Location = new System.Drawing.Point(58, 207);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '*';
            this.passwordTB.Size = new System.Drawing.Size(216, 23);
            this.passwordTB.TabIndex = 2;
            // 
            // dbNameTB
            // 
            this.dbNameTB.Location = new System.Drawing.Point(58, 269);
            this.dbNameTB.Name = "dbNameTB";
            this.dbNameTB.Size = new System.Drawing.Size(216, 23);
            this.dbNameTB.TabIndex = 3;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 450);
            this.Controls.Add(this.dbNameTB);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.userTB);
            this.Controls.Add(this.authBtn);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button authBtn;
        private TextBox userTB;
        private TextBox passwordTB;
        private TextBox dbNameTB;
    }
}