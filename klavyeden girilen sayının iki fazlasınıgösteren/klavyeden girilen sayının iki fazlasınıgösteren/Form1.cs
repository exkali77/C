using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace klavyeden_girilen_sayının_iki_fazlasınıgösteren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1,s3;
            s1 = Convert.ToInt32(textBox1.Text);

            s3 = s1 + 2;
            label3.Text = s3.ToString();

            label1.Location.X();
        }
    }
}
