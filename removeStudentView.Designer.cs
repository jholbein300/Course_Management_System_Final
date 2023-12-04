using System.ComponentModel;

namespace Course_Management_System_Final
{
    partial class removeStudentView
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
            this.professorName = new System.Windows.Forms.Label();
            this.decorativeBox = new System.Windows.Forms.Panel();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.studentList = new System.Windows.Forms.ComboBox();
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.decorativeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // professorName
            // 
            this.professorName.AutoSize = true;
            this.professorName.Location = new System.Drawing.Point(12, 9);
            this.professorName.Name = "professorName";
            this.professorName.Size = new System.Drawing.Size(78, 13);
            this.professorName.TabIndex = 4;
            this.professorName.Text = "professorName";
            // 
            // decorativeBox
            // 
            this.decorativeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decorativeBox.Controls.Add(this.selectClassLabel);
            this.decorativeBox.Controls.Add(this.studentList);
            this.decorativeBox.Controls.Add(this.removeStudentButton);
            this.decorativeBox.Location = new System.Drawing.Point(248, 113);
            this.decorativeBox.Name = "decorativeBox";
            this.decorativeBox.Size = new System.Drawing.Size(305, 224);
            this.decorativeBox.TabIndex = 5;
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeStudentButton.Location = new System.Drawing.Point(105, 145);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(94, 23);
            this.removeStudentButton.TabIndex = 0;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            // 
            // studentList
            // 
            this.studentList.AllowDrop = true;
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(91, 101);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(121, 21);
            this.studentList.TabIndex = 1;
            this.studentList.Text = "Choose Student";
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.AutoSize = true;
            this.selectClassLabel.Location = new System.Drawing.Point(112, 46);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(77, 13);
            this.selectClassLabel.TabIndex = 2;
            this.selectClassLabel.Text = "Select Student";
            this.selectClassLabel.Click += new System.EventHandler(this.selectClassLabel_Click);
            // 
            // removeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.decorativeBox);
            this.Controls.Add(this.professorName);
            this.Name = "removeStudent";
            this.Text = "Remove Student";
            this.decorativeBox.ResumeLayout(false);
            this.decorativeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label professorName;
        private System.Windows.Forms.Panel decorativeBox;
        private System.Windows.Forms.Button removeStudentButton;
        private System.Windows.Forms.ComboBox studentList;
        private System.Windows.Forms.Label selectClassLabel;
    }
}