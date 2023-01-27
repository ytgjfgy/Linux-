using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linux
{
    public partial class LinuxForm : Form
    {
        public LinuxForm(String linName)
        {
            InitializeComponent();
        Text = linName;
        label1.Text = linName;
            try
            {
                pictureBox1.Load("../../Pictures/" + linName + ".png");
                textBox1.Text = File.ReadAllText("../../Pictures/" + linName + ".txt");



            }
            catch (Exception) { }




        }



        private void LinuxForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
