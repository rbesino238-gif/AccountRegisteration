using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegisteration
{
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();

            StudentNumber.Text = StudentInfoClass.SetStudent.ToString();
            FullName.Text = StudentInfoClass.SetFullName;
            cbPrograms.Text = StudentInfoClass.SetProgram;
            Birth.Text = StudentInfoClass.SetBrirthday; 
            cbGender.Text = StudentInfoClass.SetGender;
            Contact.Text = StudentInfoClass.SetContact.ToString(); 
            StudentAge.Text = StudentInfoClass.SetAge.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Confirmation frm = new Confirmation(); frm.ShowDialog();


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void cbGender_Click(object sender, EventArgs e)
        {

        }
    }
}
