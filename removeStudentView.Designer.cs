using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ComboBox();
            this.removeStudentButton = new System.Windows.Forms.Button();
            this.decorativeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // professorName
            // 
            this.professorName.AutoSize = true;
            this.professorName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.professorName.Location = new System.Drawing.Point(12, 9);
            this.professorName.Name = "professorName";
            this.professorName.Size = new System.Drawing.Size(103, 19);
            this.professorName.TabIndex = 4;
            this.professorName.Text = "professorName";
            // 
            // decorativeBox
            // 
            this.decorativeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decorativeBox.AutoSize = true;
            this.decorativeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decorativeBox.Controls.Add(this.selectClassLabel);
            this.decorativeBox.Controls.Add(this.studentList);
            this.decorativeBox.Controls.Add(this.removeStudentButton);
            this.decorativeBox.Location = new System.Drawing.Point(350, 265);
            this.decorativeBox.Name = "decorativeBox";
            this.decorativeBox.Size = new System.Drawing.Size(300, 220);
            this.decorativeBox.TabIndex = 5;
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectClassLabel.Location = new System.Drawing.Point(90, 36);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(121, 22);
            this.selectClassLabel.TabIndex = 2;
            this.selectClassLabel.Text = "Select Student";
            this.selectClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.selectClassLabel.Click += new System.EventHandler(this.selectClassLabel_Click);
            // 
            // studentList
            // 
            this.studentList.AllowDrop = true;
            this.studentList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentList.FormattingEnabled = true;
            this.studentList.Location = new System.Drawing.Point(90, 91);
            this.studentList.Name = "studentList";
            this.studentList.Size = new System.Drawing.Size(121, 27);
            this.studentList.TabIndex = 1;
            this.studentList.Text = "Choose Student";
            // 
            // removeStudentButton
            // 
            this.removeStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.removeStudentButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeStudentButton.Location = new System.Drawing.Point(90, 147);
            this.removeStudentButton.Name = "removeStudentButton";
            this.removeStudentButton.Size = new System.Drawing.Size(121, 23);
            this.removeStudentButton.TabIndex = 0;
            this.removeStudentButton.Text = "Remove Student";
            this.removeStudentButton.UseVisualStyleBackColor = true;
            // 
            // removeStudentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.decorativeBox);
            this.Controls.Add(this.professorName);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "removeStudentView";
            this.Text = "Remove Student";
            this.decorativeBox.ResumeLayout(false);
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