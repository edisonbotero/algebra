using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Windows.Forms;

namespace algebra.formularios
{
    public partial class cramer : System.Web.UI.Page
    {
        MetodoDeCramer metodo = new MetodoDeCramer();
        Calculo calcular = new Calculo();
     

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            metodo.Numero1 = Convert.ToInt32(TextBox1.Text);
            metodo.Numero2 = Convert.ToInt32(TextBox2.Text);
            metodo.Numero3 = Convert.ToInt32(TextBox3.Text);
            metodo.Numero4 = Convert.ToInt32(TextBox4.Text);

            metodo.Numero5 = Convert.ToInt32(TextBox5.Text);
            metodo.Numero6 = Convert.ToInt32(TextBox6.Text);
            metodo.Numero7 = Convert.ToInt32(TextBox7.Text);
            metodo.Numero8 = Convert.ToInt32(TextBox8.Text);

            metodo.Numero9 = Convert.ToInt32(TextBox9.Text);
            metodo.Numero10 = Convert.ToInt32(TextBox10.Text);
            metodo.Numero11 = Convert.ToInt32(TextBox11.Text);
            metodo.Numero12 = Convert.ToInt32(TextBox12.Text);

            ///valor = metodo.Numero1;

            
            string A, B, C, D , E , F , G, H,I,j,k,l;
            
            A = TextBox1.Text;
            B = TextBox2.Text;
            C = TextBox3.Text;
            D = TextBox4.Text;
            E = TextBox5.Text;
            F = TextBox6.Text; 
            G = TextBox7.Text;
            H = TextBox8.Text;
            I = TextBox9.Text;
            j = TextBox10.Text;
            k = TextBox11.Text;
            l = TextBox12.Text;

            //ingrsar valores en la ecuacion
            TextBox13.Text = (A + ' ' + 'X' + ' ' + ' ' + B + ' ' + 'Y' + ' ' + ' ' + C + ' ' + 'Z' + '=' + ' ' + ' ' + D);
            TextBox14.Text = (E + ' ' + 'X' + ' ' + ' ' + F + ' ' + 'Y' + ' ' + ' ' + G + ' ' + 'Z' + '=' + ' ' + ' ' + H);
            TextBox15.Text = (I + ' ' + 'X' + ' ' + ' ' + j + ' ' + 'Y' + ' ' + ' ' + k + ' ' + 'Z' + '=' + ' ' + ' ' + l);
           
            //hallar la matriz  matriz principal
            //valores de x
            TextBox20.Text = (""+ A);
            TextBox24.Text = (""+ E);
            TextBox28.Text = (""+ I);
            //valores de y
            TextBox21.Text = (""+ calcular.CalCulemos1(metodo));
            TextBox25.Text = (""+ calcular.CalCulemos6(metodo));
            TextBox29.Text = (""+ calcular.CalCulemos10(metodo));
            //valores de z
            TextBox22.Text = (""+ calcular.CalCulemos2(metodo));
            TextBox26.Text = (""+ calcular.CalCulemos7(metodo));
            TextBox30.Text = (""+ calcular.CalCulemos11(metodo));
            //hallar valores de TI donde (TI) es el termino independiente
            TextBox23.Text = (""+ D);
            TextBox27.Text = (""+ H);
            TextBox31.Text = (""+ l);
           
            //hallar la determinante ΔS
            //llenando la prmera matriz con los valores de x,y,z de la matriz principal
            TextBox32.Text = ("X");
            TextBox33.Text = ("Y");
            TextBox34.Text = ("Z");
            //Valores de Y
            TextBox36.Text = ("" + calcular.CalCulemos1(metodo));
            TextBox39.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox42.Text = ("" + calcular.CalCulemos10(metodo));
            //Valores de X
            TextBox35.Text = ("" + A);
            TextBox38.Text = ("" + E);
            TextBox41.Text = ("" + I);
            //Valores de Z
            TextBox37.Text = ("" + calcular.CalCulemos2(metodo));
            TextBox40.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox43.Text = ("" + calcular.CalCulemos11(metodo));
            //Despues de llenar la matriz de los campos X,Y,Z se selecciona el primer valor e X
            TextBox44.Text = ("" + A);
            //se llena una segunda matriz con los valores de Y,Z de la primera matriz
            TextBox45.Text = ("Y");
            TextBox46.Text = ("Z");
            TextBox47.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox48.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox49.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox50.Text = ("" + calcular.CalCulemos11(metodo));
            //desarrollar las operaciones indicadas de la segunda matriz
           TextBox51.Text = (A+ "[(" + calcular.CalCulemos6(metodo) + ") (" + calcular.CalCulemos11(metodo) + ") - (" + calcular.CalCulemos7(metodo) + ") (" + calcular.CalCulemos10(metodo)+ ") ]");
            string a;
            if (calcular.CalCulemos14(metodo) > 0)
            {

                a = " ";
            }
            else
            {
                a = "+";

            }
            TextBox52.Text = (A + "    [  (  " + calcular.CalCulemos13(metodo)+ "  "+a+"  "+ -calcular.CalCulemos14(metodo) + ") ]");
            TextBox53.Text = (A + "    (  " + calcular.CalCulemos15(metodo) + ") ="+ calcular.CalCulemos16(metodo));
            //llenar una tercera matriz con los valores de X , Z de la primera matriz
            string w1;
            if (calcular.CalCulemos1(metodo) > 0)
            {
                w1 = "  ";
            }
            else
            {
                w1 = " + ";
            }
            TextBox54.Text = (w1 + "" + -calcular.CalCulemos1(metodo));
            TextBox55.Text = ("X");
            TextBox56.Text = ("Z");
            TextBox57.Text = (E);
            TextBox58.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox59.Text = (I);
            TextBox60.Text = ("" + calcular.CalCulemos11(metodo));
            TextBox61.Text = (w1 + "" + -calcular.CalCulemos1(metodo) + "[(" + TextBox57.Text + ") (" + TextBox60.Text + ") - (" + TextBox58.Text + ") (" + TextBox59.Text + ") ]");
            string b;
            if (calcular.CalCulemos18(metodo) > 0)
            {

                b = " ";
            }
            else
            {
                b = "+";

            }
            TextBox63.Text = (w1 + "" + -calcular.CalCulemos1(metodo) + "    [  (  " + calcular.CalCulemos17(metodo) + "  " + b + "  " + -calcular.CalCulemos18(metodo) + ") ]");
            TextBox65.Text = (w1 + "" + -calcular.CalCulemos1(metodo) + "    (  " + calcular.CalCulemos19(metodo) + ") =" + calcular.CalCulemos20(metodo));
            //llenar una cuarta matriz con los valores X , Y De la primera matriz y desarrollar las operaciones
            TextBox88.Text = ("X");
            TextBox89.Text = ("Y");
            TextBox90.Text = ("" + calcular.CalCulemos5(metodo));
            TextBox91.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox92.Text = ("" + calcular.CalCulemos9(metodo));
            TextBox93.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox81.Text = ("("+C+")");
            TextBox62.Text = (C+ "[(" + calcular.CalCulemos5(metodo) + ") (" + calcular.CalCulemos10(metodo) + ") - (" + calcular.CalCulemos6(metodo) + ") (" + calcular.CalCulemos9(metodo) + ") ]");
            string b1;
            if (calcular.CalCulemos22(metodo) > 0)
            {

                b1 = " ";
            }
            else
            {
                b1 = "+";

            }
            TextBox64.Text = (C + "    [  (  " + calcular.CalCulemos21(metodo) + "  " + b1 + "  " + -calcular.CalCulemos22(metodo) + ") ]");
            TextBox66.Text = (C + "    (  " + calcular.CalCulemos23(metodo) + ") =" + calcular.CalCulemos24(metodo));
            //una vez resueltas las operaciones indicadas en las  matrices se procede a hallar el resultado ΔS
            string a1;
            if (calcular.CalCulemos20(metodo) > 0)
            {
               a1= " + ";

            }
            else
            {
                a1 = " ";
            }
            string a2;
            if (calcular.CalCulemos24(metodo) > 0)
            {
                a2 = " + ";

            }
            else
            {
                a2 = " ";
            }
            TextBox67.Text = ("ΔS = " + calcular.CalCulemos16(metodo) +a1+calcular.CalCulemos20(metodo)+a2+calcular.CalCulemos24(metodo)+ "  = "+ calcular.CalCulemos25(metodo));

            //luego de allar el resultado ΔS 
            // hallar delta de x ΔX llenando la matriz con los valores de TI ,Y,Z donde TI (Termino independiente)
            // generar una nueva matriz para hallar delta ΔX
            TextBox70.Text = ("TI");
            TextBox71.Text = ("Y");
            TextBox72.Text = ("Z");
            //Valores de TI termino independiente
            TextBox73.Text = ("" + D);
            TextBox76.Text = ("" + H);
            TextBox79.Text = ("" + l);
            //Valores de Y 
            TextBox74.Text = ("" + calcular.CalCulemos1(metodo));
            TextBox77.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox80.Text = ("" + calcular.CalCulemos10(metodo));
            //Valores de Z
            TextBox75.Text = ("" + calcular.CalCulemos2(metodo));
            TextBox78.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox82.Text = ("" + calcular.CalCulemos11(metodo));
            TextBox83.Text = ("" + D);
            //Se arma otra matriz con los valores de Y Z
            TextBox84.Text = ("Y");
            TextBox85.Text = ("Z");
            TextBox86.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox87.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox94.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox95.Text = ("" + calcular.CalCulemos11(metodo));
            //Desarrollar las operaciones indicadas en la matriz con los valores de Y , Z
             TextBox110.Text = (D + "[(" + calcular.CalCulemos6(metodo) + ") (" + calcular.CalCulemos11(metodo) + ") - (" + calcular.CalCulemos7(metodo) + ") (" + calcular.CalCulemos10(metodo) + ") ]");
            string valor;
            if (calcular.CalCulemos14(metodo) > 0)
            {

                valor = " ";
            }
            else
            {
               valor = "+";

            }
            TextBox111.Text = (D + "    [  (  " + calcular.CalCulemos13(metodo) + "  " + valor + "  " + -calcular.CalCulemos14(metodo) + ") ]");
            TextBox112.Text = (D + "    (  " + calcular.CalCulemos26(metodo) + ") =" + calcular.CalCulemos27(metodo));
            //llenar otra matriz con los valores de delta de X ( ΔX )
            //Matriz a llenar valores (TI , Z)
            TextBox97.Text = ("TI");
            TextBox98.Text = ("Z");
            //Valores de TI
            TextBox99.Text = ("" + H);
            TextBox101.Text= ("" + l);
            //Valores de Z
            TextBox100.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox102.Text = ("" + calcular.CalCulemos11(metodo));
            string VALOR;
            if (calcular.CalCulemos1(metodo) > 0)
            {
                VALOR = "  ";
            }
            else
            {
                VALOR = " + ";
            }
            TextBox96.Text = (VALOR + "" + -calcular.CalCulemos1(metodo));
            TextBox113.Text= (VALOR + "" + -calcular.CalCulemos1(metodo) + "[(" + H + ") (" + TextBox82.Text + ") - (" + TextBox100.Text + ") (" + l + ") ]");
            string VALOR1;
            if (calcular.CalCulemos29(metodo) > 0)
            {

               VALOR1 = " ";
            }
            else
            {
               VALOR1 = "+";

            }
            TextBox115.Text= (VALOR + "" + -calcular.CalCulemos1(metodo) + "    [  (  " + calcular.CalCulemos28(metodo) + "  " + VALOR1 + "  " + -calcular.CalCulemos29(metodo) + ") ]");
            TextBox117.Text= (VALOR + "" + -calcular.CalCulemos1(metodo) + "    (  " + calcular.CalCulemos30(metodo) + ") =" + calcular.CalCulemos31(metodo));
            //LLenar otra matriz con los valores de delta de x
            //Matriz a llenar valores   TI Y Y
            TextBox104.Text = ("TI");
            TextBox105.Text = ("Y");
            //Valores de TI
            TextBox106.Text = ("" + H);
            TextBox108.Text = ("" + l);
            //Valores de Y
            TextBox107.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox109.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox103.Text = ("(" + C + ")");
            TextBox114.Text = (C + "[(" + H + ") (" + calcular.CalCulemos10(metodo) + ") - (" + calcular.CalCulemos6(metodo) + ") (" + l + ") ]");
            string VALOR2;
            if (calcular.CalCulemos33(metodo) > 0)
            {

                VALOR2 = " ";
            }
            else
            {
                VALOR2 = "+";

            }
            TextBox116.Text = (C + "    [  (  " + calcular.CalCulemos32(metodo) + "  " + VALOR2 + "  " + -calcular.CalCulemos33(metodo) + ") ]");
            TextBox118.Text = (C + "    (  " + calcular.CalCulemos34(metodo) + ") =" + calcular.CalCulemos35(metodo));

            //una vez resueltas las operaciones indicadas en las  matrices se procede a hallar el resultado ΔX
            string VALOR6;
            if (calcular.CalCulemos31(metodo) > 0)
            {
                VALOR6 = " + ";

            }
            else
            {
                VALOR6 = " ";
            }
            string VALOR7;
            if (calcular.CalCulemos35(metodo) > 0)
            {
                VALOR7 = " + ";

            }
            else
            {
                VALOR7 = " ";
            }
            TextBox119.Text = ("ΔX = " + calcular.CalCulemos27(metodo) + VALOR6 + calcular.CalCulemos31(metodo) + VALOR7 + calcular.CalCulemos35(metodo));
            TextBox120.Text = ("ΔX = " + calcular.CalCulemos36(metodo));
            //Hallar delta de x (ΔX) dividiendo ΔX / ΔS
            TextBox121.Text = ("ΔX  / ΔS = "+ calcular.CalCulemos36(metodo)+"  /  "+calcular.CalCulemos25(metodo));
            //Una vez verificado el paso anterior da como resultado el valor de X
            TextBox212.Text = "X =" + string.Format("{0:n2}", (Math.Round(calcular.CalCulemos37(metodo) * 100) / 100)-0);

            //-----------------------------------HALLAR DELTA DE Y Y RESOLVER LAS OPERACIONES INDICADAS--------------------------------------
            //Hallar del ta de y
            //llenar otra matriz con los valores de delta de Y ( YX )
            //Matriz a llenar valores (X , TI , Z
            TextBox122.Text = ("X");
            TextBox123.Text = ("TI");
            TextBox124.Text = ("Z");
            //Valores de X
            TextBox125.Text = ("" + A);
            TextBox128.Text = ("" + E);
            TextBox131.Text = ("" + I);
            //Valores de TI
            TextBox126.Text = ("" + D);
            TextBox129.Text = ("" + H);
            TextBox132.Text = ("" + l);
            //Valores de Z
            TextBox127.Text = ("" + calcular.CalCulemos2(metodo));
            TextBox130.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox133.Text = ("" + calcular.CalCulemos11(metodo));
            TextBox134.Text = ("" + A);
            //llenar otra matriz con los valores de  TI, Z
            TextBox135.Text = ("TI");
            TextBox136.Text = ("Z");
            TextBox137.Text = ("" + H);
            TextBox138.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox139.Text = ("" + l);
            TextBox140.Text = ("" + calcular.CalCulemos11(metodo));
            TextBox158.Text = (A + "[(" + H + ") (" + calcular.CalCulemos11(metodo) + ") - (" + calcular.CalCulemos7(metodo) + ") (" + l + ") ]");
            //Desarrollar las operaciones
            string VALOR8;
            if (calcular.CalCulemos39(metodo) > 0)
            {

                VALOR8 = " ";
            }
            else
            {
                VALOR8 = "+";

            }
            TextBox159.Text = (A + "    [  (  " + calcular.CalCulemos38(metodo) + "  " + VALOR8 + "  " + -calcular.CalCulemos39(metodo) + ") ]");
            TextBox160.Text = (A + "    (  " + calcular.CalCulemos40(metodo) + ") =" + calcular.CalCulemos41(metodo));
            //se genera una nueva matriz con los valores de X ,Z
            TextBox142.Text = ("X");
            TextBox143.Text = ("Z");
            //Valores de X
            TextBox144.Text = ("" + E);
            TextBox146.Text = ("" + I);
            //Valores de Z
            TextBox145.Text = ("" + calcular.CalCulemos7(metodo));
            TextBox147.Text = ("" + calcular.CalCulemos11(metodo));
            string VALOR9;
            if (calcular.CalCulemos3(metodo) > 0)
            {
                VALOR9 = "  ";
            }
            else
            {
                VALOR9 = " + ";
            }
            TextBox141.Text = (VALOR9 + "" + -calcular.CalCulemos3(metodo));
            TextBox161.Text = (VALOR9 + "" + -calcular.CalCulemos3(metodo) + "[(" + E + ") (" + TextBox147.Text + ") - (" + TextBox145.Text + ") (" + I + ") ]");
            string VALOR10;
            if (calcular.CalCulemos43(metodo) > 0)
            {

                VALOR10 = " ";
            }
            else
            {
                VALOR10 = "+";

            }
            TextBox163.Text = (VALOR9 + "" + -calcular.CalCulemos3(metodo) + "    [  (  " + calcular.CalCulemos42(metodo) + "  " + VALOR10 + "  " + -calcular.CalCulemos43(metodo) + ") ]");
            TextBox165.Text = (VALOR9 + "" + -calcular.CalCulemos3(metodo) + "    (  " + calcular.CalCulemos44(metodo) + ") =" + calcular.CalCulemos45(metodo));
            //generar otra matriz con los valores de X, TTI
            TextBox149.Text = ("X");
            TextBox150.Text = ("TI");
            //Valores de X
            TextBox151.Text = ("" + E);
            TextBox153.Text = ("" + I);
            //Valores de TI
            TextBox152.Text = ("" + H);
            TextBox154.Text = ("" + l);
            TextBox148.Text = ("(" + C + ")");
            TextBox162.Text = (C + "[(" + TextBox151.Text + ") (" + TextBox154.Text + ") - (" + TextBox152.Text + ") (" + TextBox153.Text + ") ]");
            string VALOR11;
            if (calcular.CalCulemos47(metodo) > 0)
            {

                VALOR11 = " ";
            }
            else
            {
                VALOR11 = "+";

            }
            TextBox164.Text = (C + "    [  (  " + calcular.CalCulemos46(metodo) + "  " + VALOR11 + "  " + -calcular.CalCulemos47(metodo) + ") ]");
            TextBox166.Text = (C + "    (  " + calcular.CalCulemos48(metodo) + ") =" + calcular.CalCulemos49(metodo));
            //una vez resueltas las operaciones indicadas en las  matrices se procede a hallar el resultado ΔX
            string VALOR12;
            if (calcular.CalCulemos45(metodo) > 0)
            {
                VALOR12 = " + ";

            }
            else
            {
                VALOR12 = " ";
            }
            string VALOR13;
            if (calcular.CalCulemos49(metodo) > 0)
            {
                VALOR13 = " + ";

            }
            else
            {
                VALOR13 = " ";
            }
            TextBox155.Text = ("ΔY = " + calcular.CalCulemos41(metodo) + VALOR12 + calcular.CalCulemos45(metodo) + VALOR13 + calcular.CalCulemos49(metodo));
            TextBox156.Text = ("ΔY = " + calcular.CalCulemos50(metodo));
            TextBox157.Text = ("ΔY  / ΔS = " + calcular.CalCulemos50(metodo) + "  /  " + calcular.CalCulemos25(metodo));
            TextBox213.Text = "Y =" + string.Format("{0:n2}", (Math.Round(calcular.CalCulemos51(metodo) * 100) / 100) - 0);

            //-----------------------------------HALLAR DELTA DE Z Y RESOLVER LAS OPERACIONES INDICADAS--------------------------------------
            //LLenar una matriz valores de X , Y , TI
            //Valores de X
            TextBox167.Text = ("X");
            TextBox170.Text = ("" + A);
            TextBox173.Text = ("" + E);
            TextBox176.Text = ("" + I);
            //Valores de Y
            TextBox168.Text = ("Y");
            TextBox171.Text = ("" + calcular.CalCulemos1(metodo));
            TextBox174.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox177.Text = ("" + calcular.CalCulemos10(metodo));
            //Valores de TI
            TextBox169.Text = ("TI");
            TextBox172.Text = ("" + D);
            TextBox175.Text = ("" + H);
            TextBox178.Text = ("" + l);
            //Hallar otra matriz secundaria con los valores de Y , TI
            TextBox180.Text = ("Y");
            TextBox181.Text = ("TI");
            TextBox182.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox183.Text = ("" + H);
            TextBox184.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox185.Text = ("" + l);
            TextBox179.Text = ("" + A);
            //Resolver las operaciones indicadas de la matriz secundaria
            TextBox203.Text = (A + "[(" + calcular.CalCulemos6(metodo) + ") (" + l + ") - (" + H + ") (" + calcular.CalCulemos10(metodo) + ") ]");
            string VALOR14;
            if (calcular.CalCulemos53(metodo) > 0)
            {

                VALOR14 = " ";
            }
            else
            {
                VALOR14 = "+";

            }
            TextBox204.Text = (A + "    [  (  " + calcular.CalCulemos52(metodo) + "  " + VALOR14 + "  " + -calcular.CalCulemos53(metodo) + ") ]");
            TextBox205.Text = (A + "    (  " + calcular.CalCulemos54(metodo) + ") =" + calcular.CalCulemos55(metodo));
            //llenar una nueva matriz con los valores de X , TI
            //Valores de x
            TextBox187.Text = ("X");
            TextBox189.Text = ("" + E);
            TextBox191.Text = ("" + I);
            //Valores de TI
            TextBox188.Text = ("TI");
            TextBox190.Text = ("" + H);
            TextBox192.Text = ("" + l);
            string VALOR15;
            if (calcular.CalCulemos1(metodo) > 0)
            {
                VALOR15 = "  ";
            }
            else
            {
                VALOR15 = " + ";
            }
            TextBox186.Text = (VALOR15 + "" + -calcular.CalCulemos1(metodo));
            TextBox206.Text = (VALOR15 + "" + -calcular.CalCulemos1(metodo) + "[(" + E + ") (" + TextBox192.Text + ") - (" + TextBox190.Text + ") (" + I + ") ]");
            string VALOR16;
            if (calcular.CalCulemos57(metodo) > 0)
            {

                VALOR16 = " ";
            }
            else
            {
                VALOR16 = "+";

            }
            TextBox208.Text = (VALOR15 + "" + -calcular.CalCulemos1(metodo) + "    [  (  " + calcular.CalCulemos56(metodo) + "  " + VALOR16 + "  " + -calcular.CalCulemos57(metodo) + ") ]");
            TextBox210.Text = (VALOR15 + "" + -calcular.CalCulemos1(metodo) + "    (  " + calcular.CalCulemos58(metodo) + ") =" + calcular.CalCulemos59(metodo));
            //LLenar una nueva matriz con los valores de X , Y
            //Valores de Y
            TextBox194.Text = ("X");
            TextBox196.Text = ("" + E);
            TextBox198.Text = ("" + I);
            //Valores de TI
            TextBox195.Text = ("Y");
            TextBox197.Text = ("" + calcular.CalCulemos6(metodo));
            TextBox199.Text = ("" + calcular.CalCulemos10(metodo));
            TextBox193.Text = ("(" + D + ")");
            TextBox207.Text = (D + "[(" + TextBox196.Text + ") (" + TextBox199.Text + ") - (" + TextBox197.Text + ") (" + TextBox198.Text + ") ]");
            string VALOR17;
            if (calcular.CalCulemos61(metodo) > 0)
            {

                VALOR17 = " ";
            }
            else
            {
                VALOR17 = "+";

            }
            TextBox209.Text = (D + "    [  (  " + calcular.CalCulemos60(metodo) + "  " + VALOR17 + "  " + -calcular.CalCulemos61(metodo) + ") ]");
            TextBox211.Text = (D + "    (  " + calcular.CalCulemos62(metodo) + ") =" + calcular.CalCulemos63(metodo));
            //Una vez resultas las operaciones indicadas se procede a hallar valor delta de z
            string VALOR18;
            if (calcular.CalCulemos59(metodo) > 0)
            {
                VALOR18 = " + ";

            }
            else
            {
                VALOR18 = " ";
            }
            string VALOR19;
            if (calcular.CalCulemos63(metodo) > 0)
            {
                VALOR19 = " + ";

            }
            else
            {
                VALOR19 = " ";
            }
            TextBox200.Text = ("ΔZ = " + calcular.CalCulemos55(metodo) + VALOR18 + calcular.CalCulemos59(metodo) + VALOR19 + calcular.CalCulemos63(metodo));
            TextBox201.Text = ("ΔZ = " + calcular.CalCulemos64(metodo));
            TextBox202.Text = ("ΔZ  / ΔS = " + calcular.CalCulemos64(metodo) + "  /  " + calcular.CalCulemos25(metodo));
            TextBox214.Text = "Z =" + string.Format("{0:n2}", (Math.Round(calcular.CalCulemos65(metodo) * 100) / 100) - 0);
        }

            
              
              

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox13.Text = " ";
            TextBox14.Text = " ";
            TextBox15.Text = " ";
            TextBox20.Text = " ";
            TextBox21.Text = " ";
            TextBox22.Text = " ";
            TextBox23.Text = " ";
            TextBox24.Text = " ";
            TextBox25.Text = " ";
            TextBox26.Text = " ";
            TextBox27.Text = " ";
            TextBox28.Text = " ";
            TextBox29.Text = " ";
            TextBox30.Text = " ";
            TextBox31.Text = " ";
            TextBox35.Text = " ";
            TextBox36.Text = " ";
            TextBox37.Text = " ";
            TextBox38.Text = " ";
            TextBox39.Text = " ";
            TextBox40.Text = " ";
            TextBox41.Text = " ";
            TextBox42.Text = " ";
            TextBox43.Text = " ";
            TextBox44.Text = " ";
            TextBox47.Text = " ";
            TextBox48.Text = " ";
            TextBox49.Text = " ";
            TextBox50.Text = " ";
            TextBox51.Text = " ";
            TextBox52.Text = " ";
            TextBox53.Text = " ";
            TextBox54.Text = " ";
            TextBox57.Text = " ";
            TextBox58.Text = " ";
            TextBox59.Text = " ";
            TextBox60.Text = " ";
            TextBox80.Text = " ";
            TextBox90.Text = " ";
            TextBox91.Text = " ";
            TextBox92.Text = " ";
            TextBox93.Text = " ";
            TextBox61.Text = " ";
            TextBox62.Text = " ";
            TextBox63.Text = " ";
            TextBox64.Text = " ";
            TextBox65.Text = " ";
            TextBox66.Text = " ";
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
            TextBox68.Text = " ";
            TextBox69.Text = " ";

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