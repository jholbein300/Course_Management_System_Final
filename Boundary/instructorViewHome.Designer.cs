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
            this.assignedClasses.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.assignedClasses.FormattingEnabled = true;
            this.assignedClasses.Location = new System.Drawing.Point(74, 100);
            this.assignedClasses.Name = "assignedClasses";
            this.assignedClasses.Size = new System.Drawing.Size(156, 27);
            this.assignedClasses.TabIndex = 0;
            this.assignedClasses.Text = "Assigned Classes";
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectClassLabel.Location = new System.Drawing.Point(74, 48);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(156, 21);
            this.selectClassLabel.TabIndex = 1;
            this.selectClassLabel.Text = "Select Class";
            this.selectClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectClassLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // decorativeBox
            // 
            this.decorativeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decorativeBox.Controls.Add(this.nextButtonInstructor);
            this.decorativeBox.Controls.Add(this.selectClassLabel);
            this.decorativeBox.Controls.Add(this.assignedClasses);
            this.decorativeBox.Location = new System.Drawing.Point(373, 237);
            this.decorativeBox.Name = "decorativeBox";
            this.decorativeBox.Size = new System.Drawing.Size(305, 224);
            this.decorativeBox.TabIndex = 2;
            // 
            // nextButtonInstructor
            // 
            this.nextButtonInstructor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.nextButtonInstructor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButtonInstructor.Location = new System.Drawing.Point(117, 159);
            this.nextButtonInstructor.Name = "nextButtonInstructor";
            this.nextButtonInstructor.Size = new System.Drawing.Size(75, 23);
            this.nextButtonInstructor.TabIndex = 0;
            this.nextButtonInstructor.Text = "Next";
            this.nextButtonInstructor.UseVisualStyleBackColor = true;
            // 
            // professorName
            // 
            this.professorName.AutoSize = true;
            this.professorName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.professorName.Location = new System.Drawing.Point(12, 9);
            this.professorName.Name = "professorName";
            this.professorName.Size = new System.Drawing.Size(103, 19);
            this.professorName.TabIndex = 3;
            this.professorName.Text = "professorName";
            this.professorName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.logoutButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.logoutButton.Location = new System.Drawing.Point(897, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            // 
            // instructorViewHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.professorName);
            this.Controls.Add(this.decorativeBox);
            this.Location = new System.Drawing.Point(15, 15);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "instructorViewHome";
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