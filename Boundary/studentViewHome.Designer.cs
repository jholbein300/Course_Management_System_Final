using System.ComponentModel;
using Course_Management_System_Final.Control;

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
            this.studentName.AutoSize = true;
            this.studentName.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.studentName.Location = new System.Drawing.Point(12, 9);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(123, 24);
            this.studentName.TabIndex = 0;
            this.studentName.Text = DBConnector.SessionManager.Instance.LoggedInUsername;
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logoutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logoutButton.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.logoutButton.Location = new System.Drawing.Point(882, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(90, 40);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            // 
            // scheduleOfClasses
            // 
            this.scheduleOfClasses.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.scheduleOfClasses.FormattingEnabled = true;
            this.scheduleOfClasses.ItemHeight = 27;
            this.scheduleOfClasses.Location = new System.Drawing.Point(290, 240);
            this.scheduleOfClasses.Name = "scheduleOfClasses";
            this.scheduleOfClasses.Size = new System.Drawing.Size(420, 166);
            this.scheduleOfClasses.TabIndex = 2;
            
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.scheduleLabel.Location = new System.Drawing.Point(290, 140);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(420, 50);
            this.scheduleLabel.TabIndex = 3;
            this.scheduleLabel.Text = "Current Schedule of Classes";
            this.scheduleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addClassButton
            // 
            this.addClassButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.addClassButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addClassButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.addClassButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addClassButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.addClassButton.Location = new System.Drawing.Point(425, 470);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(150, 45);
            this.addClassButton.TabIndex = 4;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = false;
            // 
            // studentViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.addClassButton);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.scheduleOfClasses);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.studentName);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "studentViewHome";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addClassButton;

        private System.Windows.Forms.ListBox scheduleOfClasses;
        private System.Windows.Forms.Label scheduleLabel;

        private System.Windows.Forms.Button logoutButton;

        private System.Windows.Forms.Label studentName;

        #endregion
    }
}