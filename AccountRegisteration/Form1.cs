using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace AccountRegisteration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            string[] ListOfProgram = new string[]{
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management"


                };
            for (int i = 0; i < 6; i++)
            {
                Program.Items.Add(ListOfProgram[i].ToString());
            }

        }

        private string _FullName;
        private int _Age;
        private long _ContactNo;
        private long _StudentNo;



        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StudentInfoClass.SetFullName = FullName(LastName.Text, FirstName.Text, MiddleName.Text);
                StudentInfoClass.SetProgram = Program.Text;
                StudentInfoClass.SetGender = Gender.Text;
                StudentInfoClass.SetContact = ContactNo(StudentContact.Text);
                StudentInfoClass.SetAge = Age(StudentAge.Text);
                StudentInfoClass.SetBrirthday = dateTimePicker1.Value.ToString("yyyy- MM-dd");

            }
            catch (FormatException ex) 
            {
                MessageBox.Show("Format Error:  " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Null Error:  " + ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Overflow Error:  " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Index Error:  " + ex.Message);
            }

            Confirmation frm = new Confirmation();
            this.Hide();
            frm.ShowDialog();

        }

        private void Program_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
