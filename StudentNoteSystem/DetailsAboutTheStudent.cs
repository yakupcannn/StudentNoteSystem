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
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        public void getDatas(string studentNo)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From [Table] Where StudentNo=@P1", connection);
            command.Parameters.AddWithValue("@P1", studentNo);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                lblNameSurname.Text= dataReader[1].ToString();
                lblNo.Text = dataReader[2].ToString();
                lblNote1.Text = dataReader[4].ToString();
                lblNote2.Text = dataReader[5].ToString();
                lblNote3.Text = dataReader[6].ToString();
                lblAverage.Text = dataReader[7].ToString();
                lblStatus.Text = dataReader[8].ToString()=="True"?"Successful":"Unsuccessfull";
            }
            connection.Close();
        }
    }
}
