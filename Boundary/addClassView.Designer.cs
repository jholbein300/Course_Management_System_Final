using System.ComponentModel;

namespace Course_Management_System_Final
{
    partial class addClassView
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
            this.decorativeBox = new System.Windows.Forms.Panel();
            this.selectClassLabel = new System.Windows.Forms.Label();
            this.classList = new System.Windows.Forms.ComboBox();
            this.addClassButton = new System.Windows.Forms.Button();
            this.studentName = new System.Windows.Forms.Label();
            this.decorativeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // decorativeBox
            // 
            this.decorativeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decorativeBox.AutoSize = true;
            this.decorativeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.decorativeBox.Controls.Add(this.selectClassLabel);
            this.decorativeBox.Controls.Add(this.classList);
            this.decorativeBox.Controls.Add(this.addClassButton);
            this.decorativeBox.Location = new System.Drawing.Point(250, 115);
            this.decorativeBox.Name = "decorativeBox";
            this.decorativeBox.Size = new System.Drawing.Size(300, 220);
            this.decorativeBox.TabIndex = 6;
            // 
            // selectClassLabel
            // 
            this.selectClassLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectClassLabel.Location = new System.Drawing.Point(90, 36);
            this.selectClassLabel.Name = "selectClassLabel";
            this.selectClassLabel.Size = new System.Drawing.Size(121, 22);
            this.selectClassLabel.TabIndex = 2;
            this.selectClassLabel.Text = "Select Class";
            this.selectClassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // classList
            // 
            this.classList.AllowDrop = true;
            this.classList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classList.FormattingEnabled = true;
            this.classList.Location = new System.Drawing.Point(90, 91);
            this.classList.Name = "classList";
            this.classList.Size = new System.Drawing.Size(121, 27);
            this.classList.TabIndex = 1;
            this.classList.Text = "Choose Class";
            // 
            // addClassButton
            // 
            this.addClassButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addClassButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addClassButton.Location = new System.Drawing.Point(90, 147);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(121, 23);
            this.addClassButton.TabIndex = 0;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(12, 9);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(100, 23);
            this.studentName.TabIndex = 7;
            this.studentName.Text = "studentName";
            // 
            // addClassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.decorativeBox);
            this.Name = "addClassView";
            this.Text = "addCourseView";
            this.decorativeBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label studentName;

        private System.Windows.Forms.Panel decorativeBox;
        private System.Windows.Forms.Label selectClassLabel;
        private System.Windows.Forms.ComboBox classList;
        private System.Windows.Forms.Button addClassButton;

        #endregion
    }
}