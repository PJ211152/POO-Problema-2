using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Problema_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double esp1, esp2, res1, res2;

            try
            {
                

                if (rb_Temperatura.Checked == true)
                {
                    if(txt_1opc.Text.Length != 0)
                    {
                        esp1 = Convert.ToDouble(txt_1opc.Text);
                        res1 = (esp1 * 9 / 5) + 32;
                        txt_1opcR.Text = Convert.ToString(res1);
                    }

                    if (txt_2opc.Text.Length != 0)
                    {
                        esp2 = Convert.ToDouble(txt_2opc.Text);
                        res2 = (esp2 - 32) * (0.555555);
                        txt_2opcR.Text = Convert.ToString(res2);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresar caracteres validos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_1opcR.Enabled = false;
            txt_2opcR.Enabled = false;
            rb_Temperatura.Checked = true;
            

            
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            txt_1opcR.Text = "";
            txt_2opcR.Text = "";
            if (rb_Peso.Checked == true)
            {
                lbl_Texto1.Text = "Kilogramos";
                lbl_Texto2.Text = "Libras";
                lbl_Texto4.Text = "Kilogramos";
                lbl_Texto3.Text = "Libras";
            }

        }

        private void lbl_Texto1_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_Texto2_Click(object sender, EventArgs e)
        {

        }

        private void rb_Longitud_CheckedChanged(object sender, EventArgs e)
        {

            txt_1opcR.Text = "";
            txt_2opcR.Text = "";
            if (rb_Longitud.Checked == true)
            {
                lbl_Texto1.Text = "Metros";
                lbl_Texto2.Text = "Pies";
                lbl_Texto4.Text = "Metros";
                lbl_Texto3.Text = "Pies";
            }
        }

        private void rb_Temperatura_CheckedChanged(object sender, EventArgs e)
        {

            txt_1opcR.Text = "";
            txt_2opcR.Text = "";
            if (rb_Temperatura.Checked == true)
            {
                lbl_Texto1.Text = "Celcius";
                lbl_Texto2.Text = "Fahrenheit";
                lbl_Texto4.Text = "Celcius";
                lbl_Texto3.Text = "Fahrenheit";
            }
        }
    }
}
