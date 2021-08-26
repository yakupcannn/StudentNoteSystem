using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StudentNoteSystem
{
    public partial class TeacherPage : Form
    {
        public TeacherPage()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Students; Integrated Security = True");
        private void addData()
        {
            connection.Open();
            SqlCommand Command = new SqlCommand("insert into [Table] (NameSurname,StudentNo) values(@P1,@P2)", connection);
            Command.Parameters.AddWithValue("@P1", mskTxtName.Text);
            Command.Parameters.AddWithValue("@P2",mskTxtNo.Text);
            Command.ExecuteNonQuery();
            connection.Close();
        }
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            addData();
            MessageBox.Show("New student was added");
        }
        public string getStudentNo(string studentNo)
        {
            string no="";
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From [Table] Where StudentNo=@P1", connection);
            command.Parameters.AddWithValue("@P1", studentNo);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
               no= dataReader[2].ToString();
            }
            connection.Close();
            return no;
        }
        private void getDatas(string studentNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From [Table] Where StudentNo=@P1", connection);
            command.Parameters.AddWithValue("@P1", studentNo);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                txtName.Text = dataReader[1].ToString();
                mskTxtStudent.Text = dataReader[2].ToString();
                txtDepartment.Text = dataReader[3].ToString();
                txtNote1.Text = dataReader[4].ToString();
                txtNote2.Text = dataReader[5].ToString();
                txtNote3.Text = dataReader[6].ToString();

            }
            connection.Close();
        }
        private void mskTxtUpdatedStudent_TextChanged(object sender, EventArgs e)
        {
            string no = mskTxtUpdatedStudent.Text;
            if (getStudentNo(no) == ""&&no.Length==12)
            {
                MessageBox.Show("The student with " + no + " cannot found");
            }
            else
            {
                getDatas(no);
                lblStudent.Text = txtName.Text;
                lblStudentNo.Text = mskTxtStudent.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command=new SqlCommand("Update [Table] Set NameSurname=@p1,StudentNo=@p2,Department=@p3,Note1=@p4,Note2=@p5,Note3=@p6,Average=@p8,Status=@p9 Where StudentNo=@p7", connection);
            command.Parameters.AddWithValue("@p1", txtName.Text);    
            command.Parameters.AddWithValue("@p2", mskTxtStudent.Text);    
            command.Parameters.AddWithValue("@p3", txtDepartment.Text);    
            command.Parameters.AddWithValue("@p4", txtNote1.Text);    
            command.Parameters.AddWithValue("@p5", txtNote2.Text);    
            command.Parameters.AddWithValue("@p6", txtNote3.Text);    
            command.Parameters.AddWithValue("@p7", lblStudentNo.Text);
            if(txtNote1.Text=="")
            {
                txtNote1.Text = "0";
            }
            if (txtNote2.Text == "")
            {
                txtNote2.Text = "0";
            }
            if (txtNote3.Text == "")
            {
                txtNote3.Text = "0";
            }
            double sum = Convert.ToDouble(txtNote1.Text) + Convert.ToDouble(txtNote2.Text) + Convert.ToDouble(txtNote3.Text);
            double avg = sum / 3;
            command.Parameters.AddWithValue("@p8", avg.ToString());
            if (avg>50)
            {
                command.Parameters.AddWithValue("@p9", "True");
            }
            else
            {
                command.Parameters.AddWithValue("@p9", "False");
            }
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Infos about the student was updated");
        }
    }
}
