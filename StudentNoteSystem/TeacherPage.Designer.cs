
namespace StudentNoteSystem
{
    partial class TeacherPage
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mskTxtName = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtNo = new System.Windows.Forms.MaskedTextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskTxtUpdatedStudent = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtStudent = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNote3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNote2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tabPage1);
            this.tbControl.Controls.Add(this.tabPage2);
            this.tbControl.Location = new System.Drawing.Point(3, -1);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(797, 457);
            this.tbControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Salmon;
            this.tabPage1.Controls.Add(this.mskTxtName);
            this.tabPage1.Controls.Add(this.mskTxtNo);
            this.tabPage1.Controls.Add(this.btnAddStudent);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(789, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // mskTxtName
            // 
            this.mskTxtName.Location = new System.Drawing.Point(317, 92);
            this.mskTxtName.Name = "mskTxtName";
            this.mskTxtName.Size = new System.Drawing.Size(242, 23);
            this.mskTxtName.TabIndex = 10;
            // 
            // mskTxtNo
            // 
            this.mskTxtNo.Location = new System.Drawing.Point(317, 150);
            this.mskTxtNo.Mask = "000000000000";
            this.mskTxtNo.Name = "mskTxtNo";
            this.mskTxtNo.Size = new System.Drawing.Size(242, 23);
            this.mskTxtNo.TabIndex = 9;
            this.mskTxtNo.ValidatingType = typeof(int);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAddStudent.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddStudent.Location = new System.Drawing.Point(271, 235);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(221, 59);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(156, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(141, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name Surname:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.PeachPuff;
            this.tabPage2.Controls.Add(this.txtDepartment);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.mskTxtUpdatedStudent);
            this.tabPage2.Controls.Add(this.mskTxtStudent);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.lblStudentNo);
            this.tabPage2.Controls.Add(this.lblStudent);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.txtNote3);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtNote2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtNote1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtName);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(244, 212);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(172, 23);
            this.txtDepartment.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label9.Location = new System.Drawing.Point(83, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 30);
            this.label9.TabIndex = 25;
            this.label9.Text = "Department:";
            // 
            // mskTxtUpdatedStudent
            // 
            this.mskTxtUpdatedStudent.Location = new System.Drawing.Point(244, 38);
            this.mskTxtUpdatedStudent.Mask = "000000000000";
            this.mskTxtUpdatedStudent.Name = "mskTxtUpdatedStudent";
            this.mskTxtUpdatedStudent.Size = new System.Drawing.Size(171, 23);
            this.mskTxtUpdatedStudent.TabIndex = 24;
            this.mskTxtUpdatedStudent.TextChanged += new System.EventHandler(this.mskTxtUpdatedStudent_TextChanged);
            // 
            // mskTxtStudent
            // 
            this.mskTxtStudent.Location = new System.Drawing.Point(244, 161);
            this.mskTxtStudent.Mask = "000000000000";
            this.mskTxtStudent.Name = "mskTxtStudent";
            this.mskTxtStudent.Size = new System.Drawing.Size(171, 23);
            this.mskTxtStudent.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(16, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 30);
            this.label8.TabIndex = 21;
            this.label8.Text = "Updated Student No:";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentNo.Location = new System.Drawing.Point(535, 95);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.lblStudentNo.Size = new System.Drawing.Size(183, 30);
            this.lblStudentNo.TabIndex = 20;
            // 
            // lblStudent
            // 
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudent.Location = new System.Drawing.Point(533, 46);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.lblStudent.Size = new System.Drawing.Size(174, 29);
            this.lblStudent.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Plum;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(521, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Update Infos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNote3
            // 
            this.txtNote3.Location = new System.Drawing.Point(244, 388);
            this.txtNote3.Name = "txtNote3";
            this.txtNote3.Size = new System.Drawing.Size(172, 23);
            this.txtNote3.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(83, 379);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = " Note3:";
            // 
            // txtNote2
            // 
            this.txtNote2.Location = new System.Drawing.Point(244, 323);
            this.txtNote2.Name = "txtNote2";
            this.txtNote2.Size = new System.Drawing.Size(172, 23);
            this.txtNote2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(83, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = " Note2:";
            // 
            // txtNote1
            // 
            this.txtNote1.Location = new System.Drawing.Point(244, 266);
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Size = new System.Drawing.Size(172, 23);
            this.txtNote1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(83, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 30);
            this.label5.TabIndex = 12;
            this.label5.Text = " Note1:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(244, 104);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(172, 23);
            this.txtName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(83, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Student No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(68, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name Surname:";
            // 
            // TeacherPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbControl);
            this.Name = "TeacherPage";
            this.Text = "TeacherPage";
            this.tbControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNote3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNote2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskTxtName;
        private System.Windows.Forms.MaskedTextBox mskTxtNo;
        private System.Windows.Forms.MaskedTextBox mskTxtUpdatedStudent;
        private System.Windows.Forms.MaskedTextBox mskTxtStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label9;
    }
}