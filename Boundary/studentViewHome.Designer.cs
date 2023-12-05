using System.ComponentModel;

namespace Course_Management_System_Final
{
    partial class studentViewHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.studentName = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.scheduleOfClasses = new System.Windows.Forms.ListBox();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.addClassButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(12, 9);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 23);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "studentName";
            this.studentName.Click += new System.EventHandler(this.label1_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Location = new System.Drawing.Point(713, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // scheduleOfClasses
            // 
            this.scheduleOfClasses.FormattingEnabled = true;
            this.scheduleOfClasses.Location = new System.Drawing.Point(275, 178);
            this.scheduleOfClasses.Name = "scheduleOfClasses";
            this.scheduleOfClasses.Size = new System.Drawing.Size(240, 134);
            this.scheduleOfClasses.TabIndex = 2;
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Location = new System.Drawing.Point(290, 126);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(189, 23);
            this.scheduleLabel.TabIndex = 3;
            this.scheduleLabel.Text = "Current Schedule of Classes";
            this.scheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addClassButton
            // 
            this.addClassButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClassButton.Location = new System.Drawing.Point(344, 344);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(75, 23);
            this.addClassButton.TabIndex = 4;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            // 
            // studentViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.scheduleOfClasses);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.studentName);
            this.Name = "studentViewHome";
            this.Text = "Home Page";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button addClassButton;

        private System.Windows.Forms.ListBox scheduleOfClasses;
        private System.Windows.Forms.Label scheduleLabel;

        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.Label studentName;

        #endregion
    }
}