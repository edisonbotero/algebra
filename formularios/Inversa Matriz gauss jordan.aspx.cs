using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace algebra.formularios
{
    public partial class Inversa_Matriz_gauss_jordan : System.Web.UI.Page
    {
        CalculoMatricial metodos = new CalculoMatricial();
        InversaGaussJordan matriz = new InversaGaussJordan();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            metodos.Numero1 = Convert.ToInt32(TextBox1.Text);
            metodos.Numero2 = Convert.ToInt32(TextBox2.Text);
            metodos.Numero3 = Convert.ToInt32(TextBox3.Text);
            metodos.Numero4 = Convert.ToInt32(TextBox4.Text);
            metodos.Numero5 = Convert.ToInt32(TextBox5.Text);
            metodos.Numero6 = Convert.ToInt32(TextBox6.Text);
            metodos.Numero7 = Convert.ToInt32(TextBox7.Text);
            metodos.Numero8 = Convert.ToInt32(TextBox8.Text);
            metodos.Numero9 = Convert.ToInt32(TextBox9.Text);
            //Expresar de forma matricial 
            ///TextBox55.Text = ("" + matriz.valoresXyZ(metodos));
            FormaMatricial.Text = ("" + matriz.matriz(metodos));
            //formar otra matriz llamada identidad
            TextBox14.Text = ("1" + "         " + "0" + "         " + "0" + "\n"+ "0" + "         " + "1" + "         " + "0" + "\n"+"0" + "         " + "0" + "         " + "1");
            //convertir la primera matriz en una mariz identidad utilizando metodo de reduccion de gauss jordan
            CalculoMatriz.Text = ("" + matriz.calcularmatriz(metodos));
            CalculoMatriz1.Text = ("" + matriz.calcularmatriz1(metodos));
            ///CalculoMatriz2.Text = ("" + matriz.calcularmatriz1(metodos));
           /// Label1.Text= ("" + matriz.mensajespaso1(metodos));
           /// Label2.Text= ("" + matriz.mensajespaso2(metodos));
           /// Label3.Text= ("" + matriz.mensajespaso3(metodos));
            //se forma una nueva matriz con dejanfo F1 tal como esta y obteniendo los resultados de los pasos 1 y 2
            Nuevamatriz.Text = ("" + matriz.nuevamatriz(metodos));
            Nuevamatriz1.Text = ("" + matriz.nuevamatrizidentidad(metodos));
            CalculoMatriz2.Text= ("" + matriz.calcularmatriz2(metodos));
            ///Label4.Text = ("" + matriz.mensagespaso4(metodos));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Inversa Matriz 3X3 Gauss Jordan\n\n" + "Se tiene la siguiente matriz de 3x3 \n\n" +TextBox1.Text+" "+TextBox2.Text);
            MessageBox.Show("Se tiene la siguiente matriz de 3x3 A= \n\n" + TextBox1.Text + "      " + TextBox2.Text + "      " + TextBox3.Text + "\n      " + TextBox4.Text + "      " + TextBox5.Text + "      " + TextBox6.Text + "\n      " + TextBox7.Text + "      " + TextBox8.Text + "      " + TextBox9.Text, "Inversa Matriz 3X3 Gauss Jordan", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Crea una nueva matriz de 3x3 y se le añade la Identidad \n\n"+ "Ahora cojemos los valores de la Matriz ( A ) todas sus filas  tal como estan añadiendo los valores de la matriz identidad ( I ) \n\n "
                + TextBox1.Text + "      " + TextBox2.Text + "      " + TextBox3.Text + "   1   0   0   " + "\n      " + TextBox4.Text + "      " + TextBox5.Text + "      " + TextBox6.Text + "   0   1   0   " + "\n      " + TextBox7.Text + "      " + TextBox8.Text + "      " + TextBox9.Text + "   0   0   1   ", "Inversa Matriz 3X3 Gauss Jordan", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
        }
    }
}