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
                textBox1.Text = "Название Linux Дистрибутива:Linux Debian" +
                    System.Environment.NewLine +
                    "Сложность перехода на Windows:Средняя(Система  схожа с Windows)";
                    


            }

            if (linName == "Linux Mint")

            {
                pictureBox1.Load("../../Pictures/Linux Mint.png");
                textBox1.Text = "Название Linux Дистрибутива:Linux Mint" +
                   System.Environment.NewLine +
                   "Сложность перехода на Windows:Легкая(Система  очень похожа на Windows)";
            }

            if (linName == "Linux Kali")

            {
                pictureBox1.Load("../../Pictures/Linux Kali.jpg");
                textBox1.Text = "Название Linux Дистрибутива:Linux Kali" +
                   System.Environment.NewLine +
                   "Сложность перехода на Windows:Тяжело(Нужно много использовать терминал)";
            }




        }



        private void LinuxForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
