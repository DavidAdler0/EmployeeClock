namespace EmployeeClock
{
    partial class PasswordCangerForm
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
            labelNewP = new Label();
            labelConfirmP = new Label();
            labelOldP = new Label();
            textBoxTaz = new TextBox();
            textBoxOP = new TextBox();
            textBoxNewP = new TextBox();
            textBoxConfirmP = new TextBox();
            linkLabelCancel = new LinkLabel();
            buttonChangeP = new Button();
            SuspendLayout();
            // 
            // labelTaz
            // 
            labelTaz.AutoSize = true;
            labelTaz.Location = new Point(521, 55);
            labelTaz.Name = "labelTaz";
            labelTaz.Size = new Size(104, 25);
            labelTaz.TabIndex = 0;
            labelTaz.Text = "תעודת זהות";
            // 
            // labelNewP
            // 
            labelNewP.AutoSize = true;
            labelNewP.Location = new Point(521, 147);
            labelNewP.Name = "labelNewP";
            labelNewP.Size = new Size(116, 25);
            labelNewP.TabIndex = 0;
            labelNewP.Text = "סיסמא חדשה";
            // 
            // labelConfirmP
            // 
            labelConfirmP.AutoSize = true;
            labelConfirmP.Location = new Point(521, 214);
            labelConfirmP.Name = "labelConfirmP";
            labelConfirmP.Size = new Size(166, 25);
            labelConfirmP.TabIndex = 0;
            labelConfirmP.Text = "אישור סיסמא חדשה";
            // 
            // labelOldP
            // 
            labelOldP.AutoSize = true;
            labelOldP.Location = new Point(521, 108);
            labelOldP.Name = "labelOldP";
            labelOldP.Size = new Size(107, 25);
            labelOldP.TabIndex = 0;
            labelOldP.Text = "סיסמא ישנה";
            // 
            // textBoxTaz
            // 
            textBoxTaz.Location = new Point(324, 50);
            textBoxTaz.Name = "textBoxTaz";
            textBoxTaz.Size = new Size(150, 31);
            textBoxTaz.TabIndex = 1;
            // 
            // textBoxOP
            // 
            textBoxOP.Location = new Point(324, 102);
            textBoxOP.Name = "textBoxOP";
            textBoxOP.Size = new Size(150, 31);
            textBoxOP.TabIndex = 1;
            // 
            // textBoxNewP
            // 
            textBoxNewP.Location = new Point(324, 164);
            textBoxNewP.Name = "textBoxNewP";
            textBoxNewP.Size = new Size(150, 31);
            textBoxNewP.TabIndex = 1;
            // 
            // textBoxConfirmP
            // 
            textBoxConfirmP.Location = new Point(324, 214);
            textBoxConfirmP.Name = "textBoxConfirmP";
            textBoxConfirmP.Size = new Size(150, 31);
            textBoxConfirmP.TabIndex = 1;
            // 
            // linkLabelCancel
            // 
            linkLabelCancel.AutoSize = true;
            linkLabelCancel.Location = new Point(560, 334);
            linkLabelCancel.Name = "linkLabelCancel";
            linkLabelCancel.Size = new Size(54, 25);
            linkLabelCancel.TabIndex = 2;
            linkLabelCancel.TabStop = true;
            linkLabelCancel.Text = "ביטול";
            linkLabelCancel.LinkClicked += linkLabelCancel_LinkClicked;
            // 
            // buttonChangeP
            // 
            buttonChangeP.Location = new Point(96, 314);
            buttonChangeP.Name = "buttonChangeP";
            buttonChangeP.Size = new Size(201, 34);
            buttonChangeP.TabIndex = 3;
            buttonChangeP.Text = "ביצוע החלפת סיסמא";
            buttonChangeP.UseVisualStyleBackColor = true;
            buttonChangeP.Click += buttonChangeP_Click;
            // 
            // PasswordCangerForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 450);
            Controls.Add(buttonChangeP);
            Controls.Add(linkLabelCancel);
            Controls.Add(textBoxConfirmP);
            Controls.Add(textBoxNewP);
            Controls.Add(textBoxOP);
            Controls.Add(textBoxTaz);
            Controls.Add(labelOldP);
            Controls.Add(labelConfirmP);
            Controls.Add(labelNewP);
            Controls.Add(labelTaz);
            Name = "PasswordCangerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTaz;
        private Label labelNewP;
        private Label labelConfirmP;
        private Label labelOldP;
        private TextBox textBoxTaz;
        private TextBox textBoxOP;
        private TextBox textBoxNewP;
        private TextBox textBoxConfirmP;
        private LinkLabel linkLabelCancel;
        private Button buttonChangeP;
    }
}