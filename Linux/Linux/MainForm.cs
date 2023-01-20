using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linux
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Debian_Click(object sender, EventArgs e)
        {

        }

        private void Mint_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm1 hf = new HelpForm1();
            hf.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LinuxForm lin = new LinuxForm(button2.Text);
            lin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinuxForm lin = new LinuxForm(button1.Text);
            lin.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LinuxForm lin = new LinuxForm(button3.Text);
            lin.ShowDialog();
        }
    }
}
