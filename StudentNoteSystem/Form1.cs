using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace StudentNoteSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Visible = true;
            lblCheck.Text = "Validating ...";
        }
        TeacherPage teacherPage = new TeacherPage();
        int counter = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 5)
                timer1.Stop();
            progressBar1.Value = counter*20;
            if (mskTxtStudentNo.Text == "000000000000"&& progressBar1.Value == 100)
            {
                lblCheck.Text = "";
                teacherPage.Show();
                this.Hide();
            }
            else
            {
                if (progressBar1.Value == 100 && teacherPage.getStudentNo(mskTxtStudentNo.Text) == "")
                {
                    lblCheck.Text = "";
                    MessageBox.Show("The student with " + mskTxtStudentNo.Text + " cannot be found");
                }
                else if (progressBar1.Value == 100)
                {
                    lblCheck.Text = "";
                    StudentInfo Student = new StudentInfo();
                    Student.getDatas(mskTxtStudentNo.Text);
                    Student.Show();
                    this.Hide();
                }
            }
           
        }

        private void mskTxtStudentNo_TextChanged(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            if (mskTxtStudentNo.Text.Length == 12)
            {
                counter = 0;
                progressBar1.Value = 0;
            }
                
        }
    }
}
