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

  

        private void button1_Click(object sender, EventArgs e)
        {
          Button btn =(Button)sender;
            LinuxForm lin = new LinuxForm(btn.Text);
            lin.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
