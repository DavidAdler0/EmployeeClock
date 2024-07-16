namespace EmployeeClock
{
    partial class ClockForm
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
            idLabel = new Label();
            entryDateLabel = new Label();
            entryDate = new Label();
            id = new Label();
            exitDatelabel = new Label();
            exitDate = new Label();
            delete = new LinkLabel();
            buttonArrive = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(318, 38);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(88, 25);
            idLabel.TabIndex = 0;
            idLabel.Text = "זהות עובד";
            // 
            // entryDateLabel
            // 
            entryDateLabel.AutoSize = true;
            entryDateLabel.Location = new Point(436, 90);
            entryDateLabel.Name = "entryDateLabel";
            entryDateLabel.Size = new Size(160, 25);
            entryDateLabel.TabIndex = 0;
            entryDateLabel.Text = "תאריך כניסה אחרון";
            // 
            // entryDate
            // 
            entryDate.AutoSize = true;
            entryDate.Location = new Point(436, 140);
            entryDate.Name = "entryDate";
            entryDate.Size = new Size(40, 25);
            entryDate.TabIndex = 0;
            entryDate.Text = "null";
            // 
            // id
            // 
            id.AutoSize = true;
            id.Location = new Point(237, 38);
            id.Name = "id";
            id.Size = new Size(40, 25);
            id.TabIndex = 0;
            id.Text = "null";
            // 
            // exitDatelabel
            // 
            exitDatelabel.AutoSize = true;
            exitDatelabel.Location = new Point(436, 186);
            exitDatelabel.Name = "exitDatelabel";
            exitDatelabel.Size = new Size(158, 25);
            exitDatelabel.TabIndex = 0;
            exitDatelabel.Text = "תאריך יציאה אחרון";
            // 
            // exitDate
            // 
            exitDate.AutoSize = true;
            exitDate.Location = new Point(436, 245);
            exitDate.Name = "exitDate";
            exitDate.Size = new Size(40, 25);
            exitDate.TabIndex = 0;
            exitDate.Text = "null";
            // 
            // delete
            // 
            delete.AutoSize = true;
            delete.Location = new Point(296, 320);
            delete.Name = "delete";
            delete.Size = new Size(54, 25);
            delete.TabIndex = 1;
            delete.TabStop = true;
            delete.Text = "ביטול";
            delete.LinkClicked += delete_LinkClicked;
            // 
            // buttonArrive
            // 
            buttonArrive.Enabled = false;
            buttonArrive.Location = new Point(522, 494);
            buttonArrive.Name = "buttonArrive";
            buttonArrive.Size = new Size(74, 76);
            buttonArrive.TabIndex = 3;
            buttonArrive.Text = "כניסה";
            buttonArrive.UseVisualStyleBackColor = true;
            buttonArrive.Click += buttonArrive_Click;
            // 
            // buttonExit
            // 
            buttonExit.Enabled = false;
            buttonExit.Location = new Point(50, 494);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(74, 76);
            buttonExit.TabIndex = 3;
            buttonExit.Text = "יציאה";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // ClockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 601);
            Controls.Add(buttonExit);
            Controls.Add(buttonArrive);
            Controls.Add(delete);
            Controls.Add(exitDate);
            Controls.Add(entryDate);
            Controls.Add(exitDatelabel);
            Controls.Add(entryDateLabel);
            Controls.Add(id);
            Controls.Add(idLabel);
            Name = "ClockForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idLabel;
        private Label entryDateLabel;
        private Label entryDate;
        private Label id;
        private Label exitDatelabel;
        private Label exitDate;
        private LinkLabel delete;
        private Button enterButton;
        private Button exitButton;
        private Button buttonArrive;
        private Button buttonExit;
    }
}
