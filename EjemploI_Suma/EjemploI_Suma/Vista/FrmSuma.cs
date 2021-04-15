using EjemploI_Suma.Operacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploI_Suma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            double resultado;
            resultado = Convert.ToDouble(txtD1.Text) + Convert.ToDouble(txtD2.Text);
            txtRes.Text = resultado.ToString();




                      
            //OperacionSuma sum = new OperacionSuma();

            //try
            //{
            //    sum.Dato1 = Convert.ToDouble(value: txtD1.Text);
            //    sum.Dato2 = Convert.ToDouble(value: txtD2.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lo sientimos pero nose permiten letras o caracteres vuelve a ingresar tu numero " /*+ex.ToString()*/);
            //}

            //Double Res = sum.suma();
            //txtRes.Text = Res.ToString(); 
        }
    }
}
