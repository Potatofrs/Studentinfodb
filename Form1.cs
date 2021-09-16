using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentinfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   //Design
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           


            Student studentObject = new Student();
            studentObject.IDno = idnumbox.Text;
            studentObject.Lastname = lnamebox.Text;
            studentObject.Firstname = fnamebox.Text;
            studentObject.QuizScore = scorebox.Text;

            Output.Items.Add("ID Number :");
            Output.Items.Add(studentObject.IDno);
            Output.Items.Add("");
            Output.Items.Add("Last Name :");
            Output.Items.Add(studentObject.Lastname);
            Output.Items.Add("");
            Output.Items.Add("First Name :");
            Output.Items.Add(studentObject.Firstname);
            Output.Items.Add("");
            Output.Items.Add("Quiz Score :");
            Output.Items.Add(studentObject.QuizScore);
            Output.Items.Add("");
            Output.Items.Add("");
            Output.Items.Add("REMARK :");

            double QuizScore;
            QuizScore = double.Parse(scorebox.Text);

            if (QuizScore < 70)
            {
                Output.Items.Add("Poor");             
            }
            else if (QuizScore < 80)
            {
                Output.Items.Add("Fair");
            }
            else if (QuizScore < 90)
            {
                Output.Items.Add("Good");
            }
            else if (QuizScore <= 100)
            {
                Output.Items.Add("Excellent");
            }




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Output_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scorebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
