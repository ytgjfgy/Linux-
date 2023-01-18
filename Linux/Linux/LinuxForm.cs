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
    public partial class LinuxForm : Form
    {
        public LinuxForm(String linName)
        {
            InitializeComponent();
        Text = linName;
           label1.Text = linName;
            if (linName == "Linux Debian")
            {
                pictureBox1.Load("../../Pictures/Linux Debian.png");
            }

            if (linName == "Linux mint")

            {
                pictureBox1.Load("../../Pictures/Linux mint.png");
            }





        }



        private void LinuxForm_Load(object sender, EventArgs e)
        {

        }
    }
}
