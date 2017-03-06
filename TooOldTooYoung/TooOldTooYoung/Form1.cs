using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TooOldTooYoung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            int age;
            age = int.Parse(textBox1.Text);

            if (age < 16)
            {
                MessageBox.Show("Still a youngster.");
            }

            if (age >= 16 && age <= 25)
            {
                MessageBox.Show("Fame beckons!");
            }

            if (age > 25 && age < 40)
            {
                MessageBox.Show("There's still time.");
            }

            if (age >= 40)
            {
                MessageBox.Show("Oh dear, you've probably missed it!");
            }
        }
    }
}
