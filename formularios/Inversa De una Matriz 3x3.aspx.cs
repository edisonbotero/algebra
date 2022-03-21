using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace algebra.formularios
{
    public partial class Inversa_De_una_Matriz_3x3 : System.Web.UI.Page
    {
        CalculoMatricial metodos = new CalculoMatricial();
        Matriz3x3 matriz = new Matriz3x3();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            TextBox126.Text = ("(");
            TextBox130.Text = (")");
            metodos.Numero1 = Convert.ToInt32(TextBox13.Text);
            metodos.Numero2 = Convert.ToInt32(TextBox2.Text);
            metodos.Numero3 = Convert.ToInt32(TextBox3.Text);
            metodos.Numero4 = Convert.ToInt32(TextBox4.Text);
            metodos.Numero5 = Convert.ToInt32(TextBox5.Text);
            metodos.Numero6 = Convert.ToInt32(TextBox6.Text);
            metodos.Numero7 = Convert.ToInt32(TextBox14.Text);
            metodos.Numero8 = Convert.ToInt32(TextBox8.Text);
            metodos.Numero9 = Convert.ToInt32(TextBox9.Text);
            //Expresar en forma matricial para encntrar determinante de a);
            TextBox7.Text = TextBox13.Text;
            TextBox10.Text = TextBox2.Text;
            TextBox11.Text = TextBox3.Text;
            TextBox12.Text = TextBox4.Text;
            TextBox15.Text = TextBox5.Text;
            TextBox16.Text = TextBox6.Text;
            TextBox17.Text = TextBox14.Text;
            TextBox18.Text = TextBox8.Text;
            TextBox19.Text = TextBox9.Text;
            TextBox20.Text = TextBox13.Text;
            TextBox24.Text = TextBox4.Text;
            TextBox26.Text = TextBox14.Text;
            TextBox23.Text = TextBox2.Text;
            TextBox25.Text = TextBox5.Text;
            TextBox27.Text = TextBox8.Text;
            //calcullos para hallar la diagonal primaria
            //se hacen los calculos  para hallar el resultado de la primera diagonal
            TextBox28.Text = ("DP  =   ( "+TextBox7.Text+" )  " +  "( "+TextBox15.Text+" ) " + "( "+TextBox19.Text+"  )  = "+matriz.calculo(metodos));         
            //se hacen los calculos  para hallar el resultado de la Segunda diagonal
            TextBox30.Text = ("DP  =   ( "+TextBox10.Text+" ) " +  "( "+TextBox16.Text+" ) " + "( "+TextBox26.Text+"  )  = "+matriz.segundaDiagonal(metodos));
            //se hacen los calculos  para hallar el resultado de la tercera diagonal
            TextBox32.Text = ("DP  =   ( "+TextBox11.Text+" ) " +  "( "+TextBox24.Text+" ) " + "( "+TextBox27.Text+"  )  = " + matriz.TerceraDiagonal(metodos));
            //calcullos para hallar la diagonal secundaria
            //se hacen los calculos  para hallar el resultado de la Cuarta diagonal
            TextBox34.Text = ("DS  =   ( "+TextBox11.Text+" ) " +  "( "+TextBox15.Text+" ) " + "( "+TextBox17.Text+"  )  = " + matriz.CuartaDiagonal(metodos));
            //se hacen los calculos  para hallar el resultado de la quinta diagonal
            TextBox36.Text = ("DS  =   ( "+TextBox20.Text+" ) " +  "( "+TextBox16.Text+" ) " + "( "+TextBox18.Text+"  )  = " + matriz.quintaDiagonal(metodos));
            //se hacen los calculos  para hallar el resultado de la sesta diagonal
            TextBox38.Text = ("DS  =   ( "+TextBox23.Text+" ) " +  "( "+TextBox24.Text+" ) " + "( " +TextBox19.Text+" )  = " + matriz.sextaDiagonal(metodos));
             //Una vez generado los calculos se procede a caluar determinante de A
            TextBox40.Text = ("Determinantes de (A) = " + matriz.calculoA(metodos));
            TextBox41.Text = ("De (A) = " + matriz.resultadoDeterminante(metodos));
            TextBox42.Text = (" " + matriz.DeterminanteDistintodecero(metodos));
            //llenar matriz para calcular los cofactores
            TextBox46.Text = (""+matriz.llenarMatrisfila1(metodos));
            TextBox47.Text = (""+matriz.llenarMatrisfila2(metodos));
            TextBox48.Text = (""+matriz.llenarMatrisFila3(metodos));
            TextBox49.Text = (""+matriz.valores(metodos));
            TextBox50.Text = (""+matriz.valores2(metodos));
            TextBox51.Text = ("" + matriz.llenarmatrizparaXyz(metodos));
            TextBox52.Text = ("" + matriz.llenarmatrizparaXyZ1(metodos));
            //calcular cofactor de Y y Z
            TextBox29.Text = ("" + matriz.MultiplicarCofactoresdeYyZ(metodos));
            //hacer las operacones indicadas
            string a;
            if (matriz.multiplicarcofactoresYyZ(metodos) > 0)
            {
                
                a = " ";
            }
            else
            {
                
               a = "+";
            }
            TextBox31.Text = (" Cf(1) ( "+matriz.multiplicarcofactorYyZ(metodos)+" "+a+-matriz.multiplicarcofactoresYyZ(metodos)+")   =   "+matriz.calculosignos(metodos));
            //Calcular cofactor de X y Z
            TextBox55.Text = ("" + matriz.valoresXyZ(metodos));
            TextBox57.Text = ("" + matriz.ingresovaloresdeXyZ(metodos));
            TextBox59.Text = ("" + matriz.IngresoValoresXyZ(metodos));
            TextBox33.Text = ("" + matriz.Ingresodevaloresamultiplicar(metodos));
            TextBox35.Text = ("" + matriz.calcular_sies_positivo_pasanegativo_caso_contrario(metodos));
            //calcaular cofactor de X y Y
            TextBox88.Text = ("" + matriz.valoresXyY(metodos));            
            TextBox90.Text = ("    " + metodos.Numero4 + "       " + metodos.Numero5);            
            TextBox92.Text = ("    " + metodos.Numero7 + "       " + metodos.Numero8);
            TextBox37.Text = ("" + matriz.IngresodevaloresamultiplicardeXyY(metodos));
            TextBox39.Text = ("" + matriz.ingresar_cofactoresXyY(metodos));
            //Calcular cofactor de Y y Z
            TextBox43.Text = ("" + matriz.valoresYyZ(metodos));
            //ingresar valores
            TextBox44.Text = ("" + matriz.llenar_primerafila_matrizparaYyZ(metodos));
            TextBox53.Text = ("" + matriz.llenar_segunda_fila_matrizparaYyZ(metodos));
            TextBox54.Text = ("" + matriz.Multiplicar_valoresXyZ(metodos));
            TextBox56.Text = ("" + matriz.ingresarcofactoresdeYyZ_hllarelresultado(metodos));
            //calcular cofactores de X y Z
            TextBox58.Text = ("" + matriz.valores_XyZ(metodos));
            TextBox60.Text = ("" + matriz.llenar_primera_fila_paraXyz(metodos));
            TextBox62.Text = ("" + matriz.llenar_segunda_fila_paraXyz(metodos));
            TextBox63.Text = ("" + matriz.multipilcar_valores_de_XyZ(metodos));
            TextBox64.Text = ("" + matriz.hallar_resultado_de_Xyz(metodos));
            //calcular cofacores de XyY
            TextBox65.Text = ("" + matriz.valores_de_XyY(metodos));
            TextBox66.Text = ("" + matriz.LLenar_primera_fila_paraXyY(metodos));
            TextBox67.Text = ("" + matriz.llenar_segunda_fila_paraXyY(metodos));
            TextBox68.Text = ("" + matriz.Multipllicar_valores_de_XyY(metodos));
            TextBox69.Text = ("" + matriz.resultado_de_XyY(metodos));
            //calcular cofactor de YyZ
            TextBox70.Text = ("" + matriz.Vlores_de_Yyz(metodos));
            TextBox71.Text = ("" + matriz.LLenar_primera_fila_paraYyZ(metodos));
            TextBox72.Text = ("" + matriz.LLenar_segunda_fila_paraYyZ(metodos));
            TextBox73.Text = ("" + matriz.multiplicar_valores_de_XyZ(metodos));
            TextBox74.Text = ("" + matriz.hallar_resultado_deYyZ(metodos));
            //calcular cofactores de XyZ
            TextBox75.Text = ("" + matriz.Valores_deXyZ(metodos));
            TextBox76.Text = ("" + matriz.LLenar_primera_fila_paraXyZ(metodos));
            TextBox77.Text = ("" + matriz.LLenar_segunda_fila_paraXyZ(metodos));
            TextBox78.Text = ("" + matriz.Multiplicar_valores_deXyz(metodos));
            TextBox79.Text = ("" + matriz.Resultado_deXyZ(metodos));
            //calcular cofactores de X y Y
            TextBox80.Text = ("" + matriz.Valores_deXyY(metodos));
            TextBox81.Text = ("" + matriz.LLenar_primera_fila_paraXyy(metodos));
            TextBox82.Text = ("" + matriz.LLenar_segunda_fila_paraXyy(metodos));
            TextBox83.Text = ("" + matriz.Multiplicar_valores_deXyy(metodos));
            TextBox84.Text = ("" + matriz.Resultado_deXyY(metodos));
            //Se tienen los nueve cofactores ya calulados
            TextBox85.Text = (" "+ matriz.cofactores(metodos));
            TextBox86.Text = (" "+ matriz.cofactores1(metodos));
            TextBox87.Text = (" "+ matriz.cofactores2(metodos));
            //se llena una nueva matriz con el valor de los cofactores
            TextBox93.Text = (" " + matriz.cofactores_primera_fila(metodos));
            TextBox94.Text = (" " + matriz.cofactores_segunda_fila(metodos));
            TextBox95.Text = (" " + matriz.cofactores_tercera_fila(metodos));
            //regla para los cofactores
            //en la matriz          
            TextBox100.Text = (" " + matriz.cofactores_cambio_signo(metodos));
            TextBox104.Text = (" " + matriz.cofactores_cambio_signo1(metodos));
            TextBox105.Text = (" " + matriz.cofactores_cambio_signo2(metodos));
            //Dividir sobre el reciproco del determinante
            TextBox96.Text = (" " + matriz.dividir_determinante(metodos));
            TextBox97.Text = (" " + matriz.dividir_sobre_determinante(metodos));
            TextBox99.Text = (" " + matriz.dividir_sobre_determinantes(metodos));
            //Resultado de la matriz inversa          
            ///TextBox107.Text = "" + string.Format("{0:n2}", (Math.Round(matriz.resultado_primerafila(metodos) * 100) / 100) - 0);            
            TextBox107.Text += "\n"+ matriz.resultado_primerafila(metodos)+ "\n" +matriz.resultado_segundafila(metodos) + "\n" +matriz.resultado_tercerafila(metodos);
            /// TextBox22.Text = (metodos.Numero1 + "    " + metodos.Numero2+"    "+metodos.Numero3+"    "+metodos.Numero1 + "    " + metodos.Numero2 + "\n" + metodos.Numero4 + "    " +metodos.Numero5 + "    " + metodos.Numero6 + "    " + metodos.Numero4 + "    " + metodos.Numero5
            /// + "\n" + metodos.Numero7 + "    " + metodos.Numero8 + "    " + metodos.Numero9 + "    " + metodos.Numero7 + "    " + metodos.Numero8);
            TextBox22.Text = ("X");
            TextBox108.Text = ("Y");
            TextBox109.Text = ("Z");
            TextBox112.Text = ("X");
            TextBox113.Text = ("Y");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox13.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox4.Text = " ";
            TextBox5.Text = " ";
            TextBox6.Text = " ";
            TextBox14.Text = " ";
            TextBox8.Text = " ";
            TextBox9.Text = " ";
            TextBox7.Text = " ";
            TextBox10.Text = " ";
            TextBox11.Text = " ";
            TextBox20.Text = " ";
            TextBox2.Text = " ";
            TextBox3.Text = " ";
            TextBox23.Text = " ";
            TextBox12.Text = " ";
            TextBox15.Text = " ";
            TextBox16.Text = " ";
            TextBox24.Text = " ";
            TextBox25.Text = " ";
            TextBox17.Text = " ";
            TextBox18.Text = " ";
            TextBox19.Text = " ";
            TextBox26.Text = " ";
            TextBox27.Text = " ";
            TextBox28.Text = " ";
            TextBox30.Text = " ";
            TextBox32.Text = " ";
            TextBox34.Text = " ";
            TextBox36.Text = " ";
            TextBox38.Text = " ";
            TextBox40.Text = " ";
            TextBox41.Text = " ";
            TextBox42.Text = " ";
            TextBox49.Text = " ";
            TextBox46.Text = " ";
            TextBox47.Text = " ";
            TextBox48.Text = " ";
            TextBox50.Text = " ";
            TextBox51.Text = " ";
            TextBox52.Text = " ";
            TextBox29.Text = " ";
            TextBox31.Text = " ";
            TextBox55.Text = " ";
            TextBox57.Text = " ";
            TextBox59.Text = " ";
            TextBox88.Text = " ";
            TextBox90.Text = " ";
            TextBox92.Text = " ";
            TextBox33.Text = " ";
            TextBox35.Text = " ";
            TextBox37.Text = " ";
            TextBox39.Text = " ";
            TextBox43.Text = " ";
            TextBox44.Text = " ";
            TextBox53.Text = " ";
            TextBox54.Text = " ";
            TextBox53.Text = " ";
            TextBox58.Text = " ";
            TextBox60.Text = " ";
            TextBox62.Text = " ";
            TextBox65.Text = " ";
            TextBox66.Text = " ";
            TextBox67.Text = " ";
            TextBox63.Text = " ";
            TextBox64.Text = " ";
            TextBox68.Text = " ";
            TextBox69.Text = " ";
            TextBox70.Text = " ";
            TextBox71.Text = " ";
            TextBox72.Text = " ";
            TextBox73.Text = " ";
            TextBox74.Text = " ";
            TextBox75.Text = " ";
            TextBox76.Text = " ";
            TextBox77.Text = " ";
            TextBox80.Text = " ";
            TextBox81.Text = " ";
            TextBox82.Text = " ";
            TextBox78.Text = " ";
            TextBox79.Text = " ";
            TextBox83.Text = " ";
            TextBox84.Text = " ";
            TextBox85.Text = " ";
            TextBox86.Text = " ";
            TextBox87.Text = " ";
            TextBox93.Text = " ";
            TextBox94.Text = " ";
            TextBox95.Text = " ";
            TextBox100.Text = " ";
            TextBox104.Text = " ";
            TextBox105.Text = " ";
            TextBox96.Text = " ";
            TextBox97.Text = " ";
            TextBox99.Text = " ";
            TextBox107.Text = " ";
            
        }
    }
}