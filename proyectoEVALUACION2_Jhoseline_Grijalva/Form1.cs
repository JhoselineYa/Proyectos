using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoEVALUACION2_Jhoseline_Grijalva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double not1;
        double not2;
        double not3;
        double not4;
        double not5;
        double not6;
        double Prom;

        private void button1_Click(object sender, EventArgs e)
        {
            not1 = Convert.ToInt32(textBox1.Text);
            not2 = Convert.ToInt32(textBox2.Text);
            not3 = Convert.ToInt32(textBox3.Text);
            not4 = Convert.ToInt32(textBox4.Text);
            not5 = Convert.ToInt32(textBox5.Text);
            not6 = Convert.ToInt32(textBox6.Text);

            Prom = ((not1 + not2 + not3 + not4 + not5 + not6)/6);
            textBox7.Text = "Promedio: " + Prom.ToString();

            if (Prom >= 7 && Prom <= 10)
            {
                textBox8.Text = "Aprobado".ToString();
                textBox7.Text = "Muy bien".ToString();
                pictureBox1.Image = Properties.Resources.Feliz;
                pictureBox1.Visible = true;

            }
            if (Prom >= 6 && Prom <= 6.99)
            {

                textBox8.Text = "Aprobado".ToString();
                textBox7.Text = "Vamos mejorando.".ToString();
                pictureBox1.Image = Properties.Resources.Igual;
                pictureBox1.Visible = true;
            }
            if (Prom >= 3 && Prom <= 5.99)
            {

                textBox8.Text = "Reprobado".ToString();
                textBox7.Text = "Muy mal".ToString();
                pictureBox1.Image = Properties.Resources.Decepcion;
                pictureBox1.Visible = true;
            }
            if (Prom <= 0.00 && Prom >= 2.99)
            {

                textBox8.Text = "Reprobado".ToString();
                textBox7.Text = "Ya no pasara de año ".ToString();
                pictureBox1.Image = Properties.Resources.Triste;
                pictureBox1.Visible = true;
            }
        }
    }
}
