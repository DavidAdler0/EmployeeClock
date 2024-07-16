namespace EmployeeClock
{
    partial class LoginForm
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
            labelTaz = new Label();
            labelPassword = new Label();
            buttonLogin = new Button();
            buttonCangePassword = new Button();
            textBoxTaz = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // labelTaz
            // 
            labelTaz.AutoSize = true;
            labelTaz.Location = new Point(355, 81);
            labelTaz.Name = "labelTaz";
            labelTaz.Size = new Size(104, 25);
            labelTaz.TabIndex = 0;
            labelTaz.Text = "תעודת זהות";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(383, 188);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(64, 25);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "סיסמא";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(355, 294);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 34);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "כניסה";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // buttonCangePassword
            // 
            buttonCangePassword.Location = new Point(325, 346);
            buttonCangePassword.Name = "buttonCangePassword";
            buttonCangePassword.Size = new Size(200, 34);
            buttonCangePassword.TabIndex = 3;
            buttonCangePassword.Text = "החלפת סיסמא";
            buttonCangePassword.UseVisualStyleBackColor = true;
            buttonCangePassword.Click += button2_Click;
            // 
            // textBoxTaz
            // 
            textBoxTaz.Location = new Point(338, 128);
            textBoxTaz.Name = "textBoxTaz";
            textBoxTaz.Size = new Size(150, 31);
            textBoxTaz.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(338, 236);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxTaz);
            Controls.Add(buttonCangePassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelPassword);
            Controls.Add(labelTaz);
            Name = "LoginForm";
            Text = "Form1";
            FormClosed += LoginForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTaz;
        private Label labelPassword;
        private Button buttonLogin;
        private Button buttonCangePassword;
        private TextBox textBoxTaz;
        private TextBox textBoxPassword;
    }
}