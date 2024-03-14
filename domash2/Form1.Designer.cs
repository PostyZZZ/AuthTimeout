namespace domash2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logintext = new TextBox();
            passwordtext = new TextBox();
            buttonLogin = new Button();
            SuspendLayout();
            // 
            // logintext
            // 
            logintext.Location = new Point(359, 172);
            logintext.Name = "logintext";
            logintext.Size = new Size(135, 23);
            logintext.TabIndex = 0;
            // 
            // passwordtext
            // 
            passwordtext.Location = new Point(359, 211);
            passwordtext.Name = "passwordtext";
            passwordtext.Size = new Size(135, 23);
            passwordtext.TabIndex = 1;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(386, 261);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(75, 23);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonLogin);
            Controls.Add(passwordtext);
            Controls.Add(logintext);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox logintext;
        private TextBox passwordtext;
        private Button buttonLogin;
    }
}
