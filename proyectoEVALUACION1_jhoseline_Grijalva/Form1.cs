using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION1_jhoseline_Grijalva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double Pupusascantidad;
        double Pupusasprecio;
        double Bebidascantidad;
        double Bebidasprecio;
        double Total;
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pupusascantidad = Convert.ToDouble(textBox1.Text);
            Pupusasprecio = Convert.ToDouble(textBox2.Text);
            Bebidascantidad = Convert.ToDouble(textBox3.Text);
            Bebidasprecio = Convert.ToDouble(textBox4.Text);
            Total = (Pupusascantidad * Pupusasprecio) + (Bebidasprecio * Bebidascantidad);
            textBox5.Text = "$" + Convert.ToString(Total);
        }
    }
}
