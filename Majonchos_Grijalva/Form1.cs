using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majonchos_Grijalva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Majonchoscosto;
        int Cantidadmajonchos;
        double totaldemajonchoscosto;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Majonchoscosto = Convert.ToDouble(textBox2.Text);
            Cantidadmajonchos = Convert.ToInt32(textBox1.Text);
            totaldemajonchoscosto = Majonchoscosto * Cantidadmajonchos;
            textBox3.Text = "$" + Convert.ToInt32(totaldemajonchoscosto);
        }
    }
}
