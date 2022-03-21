using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace algebra.formularios
{
    public partial class jordan : System.Web.UI.Page
    {
        MetodoDeGaussJordan metodo1 = new MetodoDeGaussJordan();
        Calculemos calculo1 = new Calculemos();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //resolver el sistema de ecuaciones con tres incognitas por el metodo de Gauss Jordan
            //se ingresa valores en los textbox para formar la ecuacion
            metodo1.Numero1 = Convert.ToInt32(TextBox1.Text);
            metodo1.Numero2 = Convert.ToInt32(TextBox2.Text);
            metodo1.Numero3 = Convert.ToInt32(TextBox3.Text);
            metodo1.Numero4 = Convert.ToInt32(TextBox4.Text);

            metodo1.Numero5 = Convert.ToInt32(TextBox5.Text);
            metodo1.Numero6 = Convert.ToInt32(TextBox6.Text);
            metodo1.Numero7 = Convert.ToInt32(TextBox7.Text);
            metodo1.Numero8 = Convert.ToInt32(TextBox8.Text);

            metodo1.Numero9 = Convert.ToInt32(TextBox9.Text);
            metodo1.Numero10 = Convert.ToInt32(TextBox10.Text);
            metodo1.Numero11 = Convert.ToInt32(TextBox11.Text);
            metodo1.Numero12 = Convert.ToInt32(TextBox12.Text);

            string A, B, C, D, E, F, G, H, I, j, k, l,M,N,O,P;
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
            M = "X";
            N = "Y";
            O = "Z";
            P = "TI";
            //se tiene la siguiente ecuacion de 3x3
            TextBox13.Text = (A + ' ' + 'X' + ' ' + ' ' + B + ' ' + 'Y' + ' ' + ' ' + C + ' ' + 'Z' + '=' + ' ' + ' ' + D);
            TextBox14.Text = (E + ' ' + 'X' + ' ' + ' ' + F + ' ' + 'Y' + ' ' + ' ' + G + ' ' + 'Z' + '=' + ' ' + ' ' + H);
            TextBox15.Text = (I + ' ' + 'X' + ' ' + ' ' + j + ' ' + 'Y' + ' ' + ' ' + k + ' ' + 'Z' + '=' + ' ' + ' ' + l);
            //convertir a formato matricial Donde TI son los terminos independientes
            TextBox16.Text = (M);
            TextBox17.Text = (N);
            TextBox18.Text = (O);
            TextBox19.Text = (P);
            //Valores en X
            TextBox20.Text = ("" + calculo1.calcular1(metodo1));
            TextBox24.Text = ("" + calculo1.calcular5(metodo1));
            TextBox28.Text = ("" + calculo1.calcular9(metodo1));
            //Valores en Y
            TextBox21.Text = ("" + calculo1.calcular2(metodo1));
            TextBox25.Text = ("" + calculo1.calcular6(metodo1));
            TextBox29.Text = ("" + calculo1.calcular10(metodo1));
            //Valores en Z
            TextBox22.Text = ("" + calculo1.calcular3(metodo1));
            TextBox26.Text = ("" + calculo1.calcular7(metodo1));
            TextBox30.Text = ("" + calculo1.calcular11(metodo1));
            //separando los terminos independientes de X, Y, Z
            //Valores en TI
            TextBox23.Text = ("" + calculo1.calcular4(metodo1));
            TextBox27.Text = ("" + calculo1.calcular8(metodo1));
            TextBox31.Text = ("" + calculo1.calcular12(metodo1));
            //Ahora resolver las operaciones indicadas
            //primero dejar la primera fila (1) y trabajar con la segunda , la primera (1) con la tercera
            //mantengo la primera fila
            //trabajar para eliminar ceros debajo de la X
            TextBox34.Text = ("F1");
            TextBox35.Text = ("F2");
            TextBox36.Text = ("F3");
            TextBox41.Text = ("F1");
            TextBox42.Text = ("F2=  " + calculo1.calcular5(metodo1));
            TextBox43.Text = ("F2");
            TextBox45.Text = ("F1=  " + calculo1.calcular17(metodo1));
            TextBox32.Text = ( calculo1.calcular1(metodo1) + "   " + calculo1.calcular2(metodo1) + "   " + calculo1.calcular3(metodo1) + "    " + calculo1.calcular4(metodo1) + "  ");
            TextBox38.Text = ( calculo1.calcular5(metodo1) + "  ( " + calculo1.calcular1(metodo1) + " ) ( " + calculo1.calcular2(metodo1) + " )  ( " + calculo1.calcular3(metodo1) + " )  ( " + calculo1.calcular4(metodo1) + " ) ");
            TextBox37.Text = ( calculo1.calcular13(metodo1) + "   " + calculo1.calcular14(metodo1) + "   " + calculo1.calcular15(metodo1) + "    " + calculo1.calcular16(metodo1) + "  ");
            TextBox39.Text = ( calculo1.calcular5(metodo1) + "   " + calculo1.calcular6(metodo1) + "   " + calculo1.calcular7(metodo1) + "    " + calculo1.calcular8(metodo1) + "  ");
            TextBox40.Text = ( calculo1.calcular17(metodo1) + "  ( " + calculo1.calcular5(metodo1) + " ) ( " + calculo1.calcular6(metodo1) + " )  ( " + calculo1.calcular7(metodo1) + " )  ( " + calculo1.calcular8(metodo1) + " ) ");
            TextBox47.Text = (calculo1.calcular18(metodo1) + "   " + calculo1.calcular19(metodo1) + "   " + calculo1.calcular20(metodo1) + "    " + calculo1.calcular21(metodo1) + "  ");
            TextBox44.Text = ("R1");
            TextBox46.Text = ("R2");
            TextBox48.Text = (calculo1.calcular13(metodo1) + "   " + calculo1.calcular14(metodo1) + "   " + calculo1.calcular15(metodo1) + "    " + calculo1.calcular16(metodo1) + "  ");
            TextBox49.Text = (calculo1.calcular18(metodo1) + "   " + calculo1.calcular19(metodo1) + "   " + calculo1.calcular20(metodo1) + "    " + calculo1.calcular21(metodo1) + "  ");
            //Label10.Text = ("-----------------------------  ");
            TextBox50.Text = (calculo1.calcular22(metodo1) + "   " + calculo1.calcular23(metodo1) + "   " + calculo1.calcular24(metodo1) + "    " + calculo1.calcular25(metodo1) + "  ");
            TextBox66.Text = ("R1");
            TextBox67.Text = ("R2");
            TextBox68.Text = ("R3");
            //Ahora trabajamos la primera con la tercera P1 , P3
            TextBox51.Text = ("F3 ");
            TextBox52.Text = (calculo1.calcular1(metodo1) + "   " + calculo1.calcular2(metodo1) + "   " + calculo1.calcular3(metodo1) + "    " + calculo1.calcular4(metodo1) + "  ");
            TextBox53.Text = ("F3= " + calculo1.calcular26(metodo1));
            TextBox54.Text = (calculo1.calcular26(metodo1) + "  ( " + calculo1.calcular1(metodo1) + " ) ( " + calculo1.calcular2(metodo1) + " )  ( " + calculo1.calcular3(metodo1) + " )  ( " + calculo1.calcular4(metodo1) + " ) ");
            TextBox56.Text = (calculo1.calcular27(metodo1) + "   " + calculo1.calcular28(metodo1) + "   " + calculo1.calcular29(metodo1) + "    " + calculo1.calcular30(metodo1) + "  ");
            TextBox55.Text = ("R4");
            TextBox57.Text = ("F1= ");
            TextBox58.Text = (calculo1.calcular9(metodo1) + "   " + calculo1.calcular10(metodo1) + "   " + calculo1.calcular11(metodo1) + "    " + calculo1.calcular12(metodo1) + "  ");
            TextBox59.Text = ("F1= " + calculo1.calcular1(metodo1));
            TextBox60.Text = (calculo1.calcular1(metodo1) + "  ( " + calculo1.calcular9(metodo1) + " ) ( " + calculo1.calcular10(metodo1) + " )  ( " + calculo1.calcular11(metodo1) + " )  ( " + calculo1.calcular12(metodo1) + " ) ");
            TextBox62.Text = (calculo1.calcular31(metodo1) + "   " + calculo1.calcular32(metodo1) + "   " + calculo1.calcular33(metodo1) + "    " + calculo1.calcular34(metodo1) + "  ");
            TextBox61.Text = ("R5");
            TextBox69.Text = ("R4");
            TextBox71.Text = ("R6");
            TextBox63.Text = (calculo1.calcular27(metodo1) + "   " + calculo1.calcular28(metodo1) + "   " + calculo1.calcular29(metodo1) + "    " + calculo1.calcular30(metodo1) + "  ");
            TextBox70.Text = ("R5");
            TextBox64.Text = (calculo1.calcular31(metodo1) + "   " + calculo1.calcular32(metodo1) + "   " + calculo1.calcular33(metodo1) + "    " + calculo1.calcular34(metodo1) + "  ");
            TextBox65.Text = (calculo1.calcular35(metodo1) + "   " + calculo1.calcular36(metodo1) + "   " + calculo1.calcular37(metodo1) + "    " + calculo1.calcular38(metodo1) + "  ");
            TextBox80.Text = ("(");
            TextBox81.Text = (")");
            TextBox72.Text = (""+calculo1.calcular1(metodo1));
            TextBox149.Text= (""+calculo1.calcular2(metodo1));
            TextBox150.Text= (""+calculo1.calcular3(metodo1));
            TextBox151.Text= (""+calculo1.calcular4(metodo1));
            TextBox73.Text = (""+calculo1.calcular22(metodo1));
            TextBox152.Text= (""+calculo1.calcular23(metodo1));
            TextBox153.Text= (""+calculo1.calcular24(metodo1));
            TextBox154.Text= (""+calculo1.calcular25(metodo1));
            TextBox74.Text = (""+calculo1.calcular35(metodo1));
            TextBox155.Text= (""+calculo1.calcular36(metodo1));
            TextBox156.Text= (""+calculo1.calcular37(metodo1));
            TextBox157.Text= (""+calculo1.calcular38(metodo1));
            TextBox75.Text = ("R3");
            TextBox79.Text = ("R7");
            TextBox76.Text = (calculo1.calcular22(metodo1) + "   " + calculo1.calcular23(metodo1) + "   " + calculo1.calcular24(metodo1) + "    " + calculo1.calcular25(metodo1) + "  ");
            TextBox77.Text = ("R6=" + calculo1.calcular39(metodo1));
            TextBox78.Text = (calculo1.calcular39(metodo1) + "  ( " + calculo1.calcular22(metodo1) + " ) ( " + calculo1.calcular23(metodo1) + " )  ( " + calculo1.calcular24(metodo1) + " )  ( " + calculo1.calcular25(metodo1) + " ) ");
            TextBox82.Text = (calculo1.calcular40(metodo1) + "   " + calculo1.calcular41(metodo1) + "   " + calculo1.calcular42(metodo1) + "    " + calculo1.calcular43(metodo1) + "  ");
            TextBox84.Text = (calculo1.calcular35(metodo1) + "   " + calculo1.calcular36(metodo1) + "   " + calculo1.calcular37(metodo1) + "    " + calculo1.calcular38(metodo1) + "  ");
            TextBox83.Text = ("R6");
            TextBox86.Text = (calculo1.calcular23(metodo1) + "  ( " + calculo1.calcular35(metodo1) + " ) ( " + calculo1.calcular36(metodo1) + " )  ( " + calculo1.calcular37(metodo1) + " )  ( " + calculo1.calcular38(metodo1) + " ) ");
            TextBox88.Text = (calculo1.calcular44(metodo1) + "   " + calculo1.calcular45(metodo1) + "   " + calculo1.calcular46(metodo1) + "    " + calculo1.calcular47(metodo1) + "  ");
            TextBox85.Text = ("R3=" + calculo1.calcular23(metodo1));
            TextBox87.Text = ("R8");
            TextBox89.Text = ("R7");
            TextBox91.Text = ("R8");
            TextBox93.Text = ("R9");
            TextBox90.Text = (calculo1.calcular40(metodo1) + "   " + calculo1.calcular41(metodo1) + "   " + calculo1.calcular42(metodo1) + "    " + calculo1.calcular43(metodo1) + "  ");
            TextBox92.Text = (calculo1.calcular44(metodo1) + "   " + calculo1.calcular45(metodo1) + "   " + calculo1.calcular46(metodo1) + "    " + calculo1.calcular47(metodo1) + "  ");
            TextBox94.Text = (calculo1.calcular48(metodo1) + "   " + calculo1.calcular49(metodo1) + "   " + calculo1.calcular50(metodo1) + "    " + calculo1.calcular51(metodo1) + "  ");
            TextBox95.Text = ("Dividiendo entre " + calculo1.calcular50(metodo1));
            TextBox96.Text = (calculo1.calcular50(metodo1) + " / "+ calculo1.calcular50(metodo1) + " = " + calculo1.calcular52(metodo1));
            TextBox97.Text = (calculo1.calcular51(metodo1) + " / " + calculo1.calcular50(metodo1) + " = " + calculo1.calcular53(metodo1));
            TextBox98.Text = ("R10=   "+calculo1.calcular48(metodo1) + "   " + calculo1.calcular49(metodo1) + "   " + calculo1.calcular52(metodo1) + "    " + calculo1.calcular53(metodo1) + "  ");
            TextBox100.Text= (""+ calculo1.calcular1(metodo1));
            TextBox158.Text= (""+ calculo1.calcular2(metodo1));
            TextBox159.Text= (""+ calculo1.calcular3(metodo1));
            TextBox160.Text= (""+ calculo1.calcular4(metodo1));
            TextBox101.Text= (""+ calculo1.calcular22(metodo1));
            TextBox161.Text= (""+ calculo1.calcular23(metodo1));
            TextBox162.Text= (""+ calculo1.calcular24(metodo1));
            TextBox163.Text= (""+ calculo1.calcular25(metodo1));
            TextBox102.Text= ("" + calculo1.calcular48(metodo1));
            TextBox164.Text= ("" + calculo1.calcular49(metodo1));
            TextBox165.Text= ("" + calculo1.calcular52(metodo1));
            TextBox166.Text= ("" + calculo1.calcular53(metodo1));
            TextBox99.Text = ("(");
            TextBox103.Text = (")");
            TextBox105.Text = (calculo1.calcular22(metodo1) + "   " + calculo1.calcular23(metodo1) + "   " + calculo1.calcular24(metodo1) + "    " + calculo1.calcular25(metodo1) + "  ");
            TextBox107.Text = (calculo1.calcular54(metodo1) + "  ( " + calculo1.calcular22(metodo1) + " ) ( " + calculo1.calcular23(metodo1) + " )  ( " + calculo1.calcular24(metodo1) + " )  ( " + calculo1.calcular25(metodo1) + " ) ");
            TextBox104.Text = ("R3");
            TextBox106.Text = ("R10=" + calculo1.calcular54(metodo1));
            TextBox109.Text = (calculo1.calcular55(metodo1) + "   " + calculo1.calcular56(metodo1) + "   " + calculo1.calcular57(metodo1) + "    " + calculo1.calcular58(metodo1) + "  ");
            TextBox108.Text = ("R11");
            TextBox111.Text = (calculo1.calcular48(metodo1) + "   " + calculo1.calcular49(metodo1) + "   " + calculo1.calcular52(metodo1) + "    " + calculo1.calcular53(metodo1) + "  ");
            TextBox110.Text = ("R10");
            TextBox113.Text = (calculo1.calcular24(metodo1) + "  ( " + calculo1.calcular48(metodo1) + " ) ( " + calculo1.calcular49(metodo1) + " )  ( " + calculo1.calcular52(metodo1) + " )  ( " + calculo1.calcular53(metodo1) + " ) ");
            TextBox112.Text = ("R3=" + calculo1.calcular24(metodo1));
            TextBox115.Text = (calculo1.calcular59(metodo1) + "   " + calculo1.calcular60(metodo1) + "   " + calculo1.calcular61(metodo1) + "    " + calculo1.calcular62(metodo1) + "  ");
            TextBox114.Text = ("R12");
            TextBox116.Text = ("R11");
            TextBox118.Text = ("R12");
            TextBox117.Text = (calculo1.calcular55(metodo1) + "   " + calculo1.calcular56(metodo1) + "   " + calculo1.calcular57(metodo1) + "    " + calculo1.calcular58(metodo1) + "  ");
            TextBox119.Text = (calculo1.calcular59(metodo1) + "   " + calculo1.calcular60(metodo1) + "   " + calculo1.calcular61(metodo1) + "    " + calculo1.calcular62(metodo1) + "  ");
            TextBox121.Text = (calculo1.calcular63(metodo1) + "   " + calculo1.calcular64(metodo1) + "   " + calculo1.calcular65(metodo1) + "    " + calculo1.calcular66(metodo1) + "  ");
            TextBox120.Text = ("R13");
            TextBox122.Text = ("Dividiendo entre " + calculo1.calcular64(metodo1));
            TextBox123.Text = (calculo1.calcular64(metodo1) + " / " + calculo1.calcular64(metodo1) + " = " + calculo1.calcular67(metodo1));
            TextBox124.Text = (calculo1.calcular66(metodo1) + " / " + calculo1.calcular64(metodo1) + " = " + calculo1.calcular68(metodo1));
            TextBox125.Text = ("R14  =   " + calculo1.calcular63(metodo1) + "   " + calculo1.calcular67(metodo1) + "   " + calculo1.calcular65(metodo1) + "    " + calculo1.calcular68(metodo1) + "  ");
            TextBox126.Text = ("(");
            TextBox130.Text = (")");
            TextBox131.Text = ("F3 ");
            TextBox132.Text = (calculo1.calcular1(metodo1) + "   " + calculo1.calcular2(metodo1) + "   " + calculo1.calcular3(metodo1) + "    " + calculo1.calcular4(metodo1) + "  ");
            TextBox133.Text = ("R10=" + calculo1.calcular54(metodo1));
            TextBox134.Text = (calculo1.calcular54(metodo1) + "  ( " + calculo1.calcular1(metodo1) + " ) ( " + calculo1.calcular2(metodo1) + " )  ( " + calculo1.calcular3(metodo1) + " )  ( " + calculo1.calcular4(metodo1) + " ) ");
            TextBox136.Text = (calculo1.calcular69(metodo1) + "   " + calculo1.calcular70(metodo1) + "   " + calculo1.calcular71(metodo1) + "    " + calculo1.calcular72(metodo1) + "  ");
            TextBox138.Text = (calculo1.calcular48(metodo1) + "   " + calculo1.calcular49(metodo1) + "   " + calculo1.calcular52(metodo1) + "    " + calculo1.calcular53(metodo1) + "  ");
            TextBox137.Text = ("R10");
            TextBox139.Text = ("F3= " + calculo1.calcular3(metodo1));
            TextBox140.Text = (calculo1.calcular3(metodo1) + "  ( " + calculo1.calcular48(metodo1) + " ) ( " + calculo1.calcular49(metodo1) + " )  ( " + calculo1.calcular52(metodo1) + " )  ( " + calculo1.calcular53(metodo1) + " ) ");
            TextBox142.Text = (calculo1.calcular73(metodo1) + "   " + calculo1.calcular74(metodo1) + "   " + calculo1.calcular75(metodo1) + "    " + calculo1.calcular76(metodo1) + "  ");
            TextBox141.Text = ("R16");
            TextBox135.Text = ("R15");
            TextBox145.Text = ("R16");
            TextBox143.Text = ("R15");
            TextBox144.Text = (calculo1.calcular69(metodo1) + "   " + calculo1.calcular70(metodo1) + "   " + calculo1.calcular71(metodo1) + "    " + calculo1.calcular72(metodo1) + "  ");
            TextBox146.Text = (calculo1.calcular73(metodo1) + "   " + calculo1.calcular74(metodo1) + "   " + calculo1.calcular75(metodo1) + "    " + calculo1.calcular76(metodo1) + "  ");
            TextBox148.Text = (calculo1.calcular77(metodo1) + "   " + calculo1.calcular78(metodo1) + "   " + calculo1.calcular79(metodo1) + "    " + calculo1.calcular80(metodo1) + "  ");
            TextBox147.Text = ("R17");
            TextBox127.Text = ("" + calculo1.calcular77(metodo1));
            TextBox167.Text = ("" + calculo1.calcular78(metodo1));
            TextBox168.Text = ("" + calculo1.calcular79(metodo1));
            TextBox169.Text = ("" + calculo1.calcular80(metodo1));
            TextBox128.Text = ("" + calculo1.calcular63(metodo1));
            TextBox170.Text = ("" + calculo1.calcular67(metodo1));
            TextBox171.Text = ("" + calculo1.calcular65(metodo1));
            TextBox172.Text = ("" + calculo1.calcular68(metodo1));
            string a;
            a = string.Format("{0:n2}", (Math.Round(calculo1.calcular53(metodo1) * 100) / 100) - 0);
            TextBox129.Text = ("" + calculo1.calcular48(metodo1));
            TextBox173.Text = ("" + calculo1.calcular49(metodo1));
            TextBox174.Text = ("" + calculo1.calcular52(metodo1));
            TextBox175.Text = ("" + a);
        }
    }
}