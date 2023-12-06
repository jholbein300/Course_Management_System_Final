using System.ComponentModel;

namespace Course_Management_System_Final
{
    partial class instructorViewHome
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
            this.assignedClasses = new System.Windows.Forms.ComboBox();
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.decorativeBox = new System.Windows.Forms.Panel();
            this.nextButtonInstructor = new System.Windows.Forms.Button();
            this.professorName = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.decorativeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignedClasses
            // 
            this.assignedClasses.AllowDrop = true;
            this.assignedClasses.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.assignedClasses.FormattingEnabled = true;
            this.assignedClasses.Location = new System.Drawing.Point(185, 150);
            this.assignedClasses.Name = "assignedClasses";
            this.assignedClasses.Size = new System.Drawing.Size(230, 43);
            this.assignedClasses.TabIndex = 0;
            this.assignedClasses.Text = "Assigned Classes";
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.Font = new System.Drawing.Font("Trebuchet MS", 24F);
            this.selectClassLabel.Location = new System.Drawing.Point(200, 50);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(200, 60);
            this.selectClassLabel.TabIndex = 1;
            this.selectClassLabel.Text = "Select Class";
            this.selectClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // decorativeBox
            // 
            this.decorativeBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.decorativeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decorativeBox.Controls.Add(this.nextButtonInstructor);
            this.decorativeBox.Controls.Add(this.selectClassLabel);
            this.decorativeBox.Controls.Add(this.assignedClasses);
            this.decorativeBox.Location = new System.Drawing.Point(200, 135);
            this.decorativeBox.Name = "decorativeBox";
            this.decorativeBox.Size = new System.Drawing.Size(600, 380);
            this.decorativeBox.TabIndex = 2;
            // 
            // nextButtonInstructor
            // 
            this.nextButtonInstructor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nextButtonInstructor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButtonInstructor.Font = new System.Drawing.Font("Trebuchet MS", 20F);
            this.nextButtonInstructor.Location = new System.Drawing.Point(225, 250);
            this.nextButtonInstructor.Name = "nextButtonInstructor";
            this.nextButtonInstructor.Size = new System.Drawing.Size(150, 50);
            this.nextButtonInstructor.TabIndex = 0;
            this.nextButtonInstructor.Text = "Next";
            this.nextButtonInstructor.UseVisualStyleBackColor = true;
            // 
            // professorName
            // 
            this.professorName.AutoSize = true;
            this.professorName.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.professorName.Location = new System.Drawing.Point(12, 9);
            this.professorName.Name = "professorName";
            this.professorName.Size = new System.Drawing.Size(160, 27);
            this.professorName.TabIndex = 3;
            this.professorName.Text = "professorName";
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logoutButton.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.logoutButton.Location = new System.Drawing.Point(879, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 36);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // instructorViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.professorName);
            this.Controls.Add(this.decorativeBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "instructorViewHome";
            this.Text = "Home Page";
            this.decorativeBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox assignedClasses;
        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.Panel decorativeBox;
        private System.Windows.Forms.Button nextButtonInstructor;
        private System.Windows.Forms.Label professorName;
        private System.Windows.Forms.Button logoutButton;
    }
}