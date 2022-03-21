using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace algebra.formularios
{
    public class Metodoigualacion
    {
        //ECUACIONES CON DOS IONCOGNITAS
        string a, b, c, d, e, f, g, h, i, j, K, l, g1;
        int aux, aux1, aux2, aux3, aux4, aux5, aux6, aux7, auxi2, auxi3, auxi4, auxiliar2, auxiliar3, auxiliar4,num;
        int calculo1, calculo2, calculo3, calculo4, calculo5, calculo6, calculo7, calculo8;
        double valor,valor1;
        public string ingresovaloresecuacion(CalculoMatricial num)
        {
            num.Resultado1 = num.Numero1;
            num.Resultado2 = num.Numero2;
            num.Resultado3 = num.Numero3;
            num.Resultado4 = num.Numero4;
            num.Resultado5 = num.Numero5;
            num.Resultado6 = num.Numero6;

            if (num.Resultado2 > 0)
            {
                a = "+";
            }
            else
            {
                a = " ";
            }
            if (num.Resultado5 > 0)
            {
                b = "+";
            }
            else
            {
                b = " ";
            }
            //se ingresa valores ala euacion 
            num.Resultado16 = (num.Resultado1 + "X" + "   " + a + num.Resultado2 + "Y =" + num.Resultado3 + "<br/>" + num.Resultado4 + "X" + "   " + b + num.Resultado5 + "Y =" + num.Resultado6);
            return num.Resultado16;
        }
        //despejamos cualquiera de las imcgonitas por ejemplo X en ambas ecuaciones

        public string despejarenY(CalculoMatricial num)
        {
            //despejar X en ambas ecuaciones

            if (num.Resultado2 > 0)
            {
                c = "";

            }
            else
            {
                c = "+";
            }
            if (num.Resultado5 > 0)
            {
                d = "";

            }
            else
            {
                d = "+";
            }


            num.Resultado18 = ("X en (1)        " + num.Resultado1 + "X =    " + num.Resultado3 + "    " + c + -num.Resultado2 + "Y  <br/> X = " + num.Resultado3 + c + -num.Resultado2 + "Y" + " / " + num.Resultado1 + "<br/><br/>" + "X en (2)        " + num.Resultado4 + "X =    " + num.Resultado6 + "    " + d + -num.Resultado5 + "Y  <br/> X = " + num.Resultado6 + d + -num.Resultado5 + "Y" + " / "
                + num.Resultado4);
            return num.Resultado18;
        }
        public string seigualanlosdosvaloresdexobtenidos(CalculoMatricial num)
        {
            //ahora se tiene una sola ecuacion con una icognita se a eliminado la X
            //se hacen las operaciones indicadas 

            int[] A = { num.Resultado4, num.Resultado3, -num.Resultado2, num.Resultado1, num.Resultado6, -num.Resultado5 };
            A[0] = num.Resultado4;
            A[1] = num.Resultado3;
            A[2] = -num.Resultado2;
            A[3] = num.Resultado1;
            A[4] = num.Resultado6;
            A[5] = -num.Resultado5;
            for (int x = 0; x < A.Length; x++)
            {
                aux = A[0] * A[1];
                aux1 = A[0] * A[2];
                aux2 = A[3] * A[4];
                aux3 = A[3] * A[5];

            }
            for (int x = 0; x < A.Length; x++)
            {
                if (aux1 > 0)
                {
                    g = "+ ";
                }
                else
                {
                    g = " ";
                }
                if (aux3 > 0)
                {
                    h = "+ ";
                }
                else
                {
                    h = "";
                }
                aux4 = aux3;
                if (aux4 > 0)
                {
                    i = "";

                }
                else
                {
                    i = "+";
                }

                aux5 = aux;
                if (aux4 > 0)
                {
                    i = "";

                }
                else
                {
                    i = "+";
                }

                if (aux5 > 0)
                {
                    j = "";

                }
                else
                {
                    j = "+";
                }
                aux6 = aux1 + -aux4;
                aux7 = aux2 + -aux5;
                // AUX8 = aux7 / aux6;
                double A3, A1, A2;
                A1 = aux7;
                A2 = aux6;
                A3 = A1 / A2;
                string P;
                P = "" + string.Format("{0:n1}", (Math.Round(A3 * 100) / 100) - 0);
                if (A3 % 1 == 0)
                {
                    P = "" + string.Format("{0:}", (Math.Round(A3 * 100) / 100) - 0);
                }
                num.Resultado19 = (num.Resultado3 + c + -num.Resultado2 + "Y" + " / " + num.Resultado1 + ".....= ....." + num.Resultado6 + d + -num.Resultado5 + "Y" + " / " + num.Resultado4 + "<br/><br/>"
               + num.Resultado4 + " ( " + num.Resultado3 + c + -num.Resultado2 + "Y ) = " + num.Resultado1 + " ( " + num.Resultado6 + d + -num.Resultado5 + "Y ) <br/>"
               + aux + g + aux1 + "Y = " + aux2 + h + aux3 + "Y <br/>" + aux1 + "Y" + i + -aux4 + "Y  =  " + aux2 + j + -aux5 + "<br/>" + aux6 + "Y = " + aux7 + "<br/>" + "Y =" + aux7 + " / " + aux6 + "<br/>" + "Y =" + P);
                //por ultimo se halla el valor de Y
            }
            return num.Resultado19;

            //sustituyendo el valor de y en cualquiera de las ecuaciones dadas 

        }
        public string sustituyendovalordey(CalculoMatricial num)
        {
            double A3, A1, A2, A4, A5, A6, A7;
            A1 = aux7;
            A2 = aux6;
            A3 = A1 / A2;
            A4 = num.Resultado2;
            A5 = A4 * A3;
            if (A5 > 0)
            {
                K = "+ ";
                A6 = num.Resultado3 + -A5;
                A7 = A6 / num.Resultado1;
            }
            else
            {
                K = " ";
                A6 = num.Resultado3 + -A5;
                A7 = A6 / num.Resultado1;
            }
            string P, P1;
            P = "" + string.Format("{0:n1}", (Math.Round(A3 * 100) / 100) - 0);
            P1 = "" + string.Format("{0:n1}", (Math.Round(A7 * 100) / 100) - 0);
            if (A3 % 1 == 0)
            {
                P = "" + string.Format("{0:}", (Math.Round(A3 * 100) / 100) - 0);
            }

            if (A7 % 1 == 0)
            {
                P1 = "" + string.Format("{0:}", (Math.Round(A7 * 100) / 100) - 0);
            }
            num.Resultado20 = num.Resultado1 + "X" + a + num.Resultado2 + "(" + P + ")  =" + num.Resultado3 + "<br/>" + num.Resultado1 + "X" + K + A5 + "  =  " + num.Resultado3 + "<br/>" + num.Resultado1 + "X  = " + A6 + "<br/>" + "X  =" + A6 + " / " + num.Resultado1 + "<br/>" + "X = " + P1;
            return num.Resultado20;
        }
        //ECUACIONES CON TRES INCOGNITAS
        public string ingresoecuacvionesx3incognitas(CalculoMatricial num)
        {
            num.Resultado7 = num.Numero7;
            num.Resultado8 = num.Numero8;
            num.Resultado9 = num.Numero9;
            num.Resultado10 = num.Numero10;

            num.Resultado11 = num.Numero11;
            num.Resultado12 = num.Numero12;
            num.Resultado13 = num.Numero13;
            num.Resultado14 = num.Numero14;

            num.Resultado15 = num.Numero15;
            num.Resultado27 = num.Numero16;
            num.Resultado17 = num.Numero17;
            num.Resultado28 = num.Numero18;
            //se ingresan valores ecuacion  3x3

            if (num.Resultado8 > 0)
            {
                a = "+ ";
            }
            else
            {
                a = " ";
            }

            if (num.Resultado9 > 0)
            {
                b = "+ ";
            }
            else
            {
                b = " ";
            }

            if (num.Resultado12 > 0)
            {
                c = "+";
            }
            else
            {
                c = " ";
            }
            if (num.Resultado13 > 0)
            {
                d = "+";
            }
            else
            {
                d = " ";
            }
            if (num.Resultado27 > 0)
            {
                e = "+";
            }
            else
            {
                e = " ";
            }
            if (num.Resultado17 > 0)
            {
                f = "+";
            }
            else
            {
                f = " ";
            }

            num.Resultado18 = (num.Resultado7 + "X   " + "   " + a + num.Resultado8 + "Y   " + b + num.Resultado9 + "Z = " + num.Resultado10 + "<br/>" + num.Resultado11 + "X   " + "   " + c + num.Resultado12 + "Y   " + d + num.Resultado13 + "Z = " + num.Resultado14 + "<br/>" + num.Resultado15 + "X   " + "   " + e + num.Resultado27 + "Y   " + f + num.Resultado17 + "Z = " + num.Resultado28
                + "<br/><br/>");
            return num.Resultado18;

        }
        public string transponerterminosecuacion1(CalculoMatricial num)
        {
            ///trasponer terminos positivo pasa a negativa sino caso contrario
            num.Resultado7 = num.Numero7;
            num.Resultado8 = num.Numero8;
            num.Resultado9 = num.Numero9;
            num.Resultado10 = num.Numero10;
            string auxi2, auxi3;
            if (num.Resultado8 > 0)
            {
                auxi2 = " ";
            }
            else
            {
                auxi2 = "+ ";
            }

            if (num.Resultado9 > 0)
            {
                auxi3 = " ";
            }
            else
            {
                auxi3 = "+ ";
            }
            string auxi4, auxi5;
            if (num.Resultado12 > 0)
            {
                auxi4 = " ";
            }
            else
            {
                auxi4 = "+";
            }
            if (num.Resultado13 > 0)
            {
                auxi5 = " ";
            }
            else
            {
                auxi5 = "+";
            }
            num.Resultado15 = num.Numero15;
            num.Resultado27 = num.Numero16;
            num.Resultado17 = num.Numero17;
            num.Resultado28 = num.Numero18;
            string auxi6, auxi7;
            if (num.Resultado27 > 0)
            {
                auxi6 = " ";
            }
            else
            {
                auxi6 = "+";
            }
            if (num.Resultado17 > 0)
            {
                auxi7 = " ";
            }
            else
            {
                auxi7 = "+";
            }
            num.Resultado19 = num.Resultado22 = ("X =" + num.Resultado10 + "    " + auxi2 + -num.Resultado8 + "Y   " + auxi3 + -num.Resultado9 + "Z  &nbsp;&nbsp;&nbsp;&nbsp;" + "X =" + num.Resultado14 + "    " + auxi4 + -num.Resultado12 + "Y   " + auxi5 + -num.Resultado13
            + "Z  &nbsp;&nbsp;&nbsp;&nbsp;" + "X =" + num.Resultado28 + "    " + auxi6 + -num.Resultado27 + "Y   " + auxi7 + -num.Resultado17 + "Z <br/>"
            + "____________  ________________  ____________" + "<br/>" + num.Numero7 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + num.Numero11
            + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + num.Numero15);
            return num.Resultado19;
        }
        public string transponerterminosecuacion2(CalculoMatricial num)
        {
            string auxi4, auxi5;
            if (num.Resultado12 > 0)
            {
                auxi4 = " ";
            }
            else
            {
                auxi4 = "+";
            }
            if (num.Resultado13 > 0)
            {
                auxi5 = " ";
            }
            else
            {
                auxi5 = "+";
            }
            num.Resultado20 = ("X  =    " + num.Resultado14 + "    " + auxi4 + -num.Resultado12 + "Y   " + auxi5 + -num.Resultado13 + "Z");
            return num.Resultado20;
            // https://www.youtube.com/watch?v=ize3A5a89YA
            //// https://www.youtube.com/watch?v=OWdyTDDpiWY
            ///https://www.youtube.com/watch?v=mSghUdJCta4
            ///https://www.youtube.com/watch?v=mSghUdJCta4
            ///https://www.youtube.com/watch?v=R1w76s0CeNM
        }

        public string transponerterminosecuacion3(CalculoMatricial num)
        {
            string auxi6, auxi7;
            if (num.Resultado27 > 0)
            {
                auxi6 = " ";
            }
            else
            {
                auxi6 = "+";
            }
            if (num.Resultado17 > 0)
            {
                auxi7 = " ";
            }
            else
            {
                auxi7 = "+";
            }
            num.Resultado21 = ("X  =    " + num.Resultado28 + "    " + auxi6 + -num.Resultado27 + "Y   " + auxi7 + -num.Resultado17 + "Z");
            return num.Resultado21;
        }

        public string igualarecuacion1y2(CalculoMatricial num)
        {
            string auxi2, auxi3;
            if (num.Resultado8 > 0)
            {
                auxi2 = " ";
            }
            else
            {
                auxi2 = "+ ";
            }

            if (num.Resultado9 > 0)
            {
                auxi3 = " ";
            }
            else
            {
                auxi3 = "+ ";
            }
            string auxi4, auxi5;
            if (num.Resultado12 > 0)
            {
                auxi4 = " ";
            }
            else
            {
                auxi4 = "+";
            }
            if (num.Resultado13 > 0)
            {
                auxi5 = " ";
            }
            else
            {
                auxi5 = "+";
            }
            num.Resultado22 = (num.Resultado10 + "    " + auxi2 + -num.Resultado8 + "Y   " + auxi3 + -num.Resultado9 + "Z  &nbsp;&nbsp;&nbsp;&nbsp;" + num.Resultado14 + "    " + auxi4 + -num.Resultado12 + "Y   " + auxi5 + -num.Resultado13 + "Z <br/>"
            + "__________=__________" + "<br/>" + num.Numero7 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + num.Numero11);
            return num.Resultado22;
        }
        public string multiplicaciondeterminos(CalculoMatricial num)
        {
            string auxi2, auxi3;
            if (num.Resultado8 > 0)
            {
                auxi2 = " ";
            }
            else
            {
                auxi2 = "+ ";
            }

            if (num.Resultado9 > 0)
            {
                auxi3 = " ";
            }
            else
            {
                auxi3 = "+ ";
            }
            string auxi4, auxi5;
            if (num.Resultado12 > 0)
            {
                auxi4 = " ";
            }
            else
            {
                auxi4 = "+";
            }
            if (num.Resultado13 > 0)
            {
                auxi5 = " ";
            }
            else
            {
                auxi5 = "+";
            }
            num.Resultado23 = (num.Numero11 + " ( " + num.Resultado10 + auxi2 + -num.Resultado8 + "Y   " + auxi3 + -num.Resultado9 + "Z ) = " + num.Numero7 + " ( " + num.Resultado14 + "    " + auxi4 + -num.Resultado12 + "Y   " + auxi5 + -num.Resultado13 + "Z )");
            return num.Resultado23;
        }
        public string resultadomultiplicar(CalculoMatricial num)
        {
            //multiplicar los coeficientes con los terminos que estan dentros de los paraentesis            
            int[] A = { num.Numero11, num.Resultado10, num.Resultado8, num.Resultado9, num.Numero7, num.Resultado14, num.Resultado12, num.Resultado13 };
            A[0] = num.Numero11;
            A[1] = num.Resultado10;
            A[2] = num.Resultado8;
            A[3] = num.Resultado9;
            A[4] = num.Numero7;
            A[5] = num.Resultado14;
            A[6] = num.Resultado12;
            A[7] = num.Resultado13;
            for (int x = 0; x < A.Length; x++)
            {
                //multiplicar primero coeficiente
                calculo1 = A[0] * A[1];
                calculo2 = A[0] * A[2];
                calculo3 = A[0] * A[3];
                //multiplicar segundo coeficiente
                calculo4 = A[4] * A[5];
                calculo5 = A[4] * A[6];
                calculo6 = A[4] * A[7];
            }

            for (int x = 0; x < A.Length; x++)
            {
                string w1, w2, w3, w4, w5, w6, w7;
                if (calculo2 > 0)
                {
                    w1 = " ";
                }
                else
                {
                    w1 = "+";
                }
                if (calculo3 > 0)
                {
                    w2 = " ";
                }
                else
                {
                    w2 = "+";
                }
                if (calculo5 > 0)
                {
                    w3 = " ";
                }
                else
                {
                    w3 = "+ ";
                }
                if (calculo6 > 0)
                {
                    w4 = " ";

                }
                else
                {
                    w4 = "+";

                }
                calculo7 = -calculo6;
                if (calculo7 > 0)
                {
                    w5 = " ";
                }
                else
                {
                    w5 = "+";
                }
                calculo8 = -calculo5;
                if (calculo8 > 0)
                {
                    w6 = " ";
                }
                else
                {
                    w6 = "+";
                }
                if (calculo1 > 0)
                {
                    w7 = " ";
                }
                else
                {
                    w7 = "+";
                }
                ///simplificar
                auxi2 = -calculo2 - calculo8;
                auxi3 = -calculo3 - calculo7;
                auxi4 = calculo4 - calculo1;
                if (auxi3 > 0)
                {
                    l = "+";
                }
                else
                {
                    l = " ";
                }

                num.Resultado24 = calculo1 + w1 + -calculo2 + "Y" + w2 + -calculo3 + "Z &nbsp;&nbsp;=&nbsp;&nbsp;" + calculo4 + w3 + -calculo5 + "Y" + w4 + -calculo6 + "Z" + "<br/>"
                + -calculo2 + "Y" + w2 + -calculo3 + "Z" + w6 + -calculo8 + "Y" + w5 + -calculo7 + "Z &nbsp;&nbsp;=&nbsp;&nbsp;" + calculo4 + w7 + -calculo1 + "<br/>"
                + auxi2 + "Y" + l + auxi3 + "Z &nbsp;&nbsp;=&nbsp;&nbsp;" + auxi4 + "<br/>" + "Ecuacion&nbsp;&nbsp;(7)";

            }
            return num.Resultado24;
        }
        public string igualarecuacion4y6(CalculoMatricial num)
        {
            string auxi2, auxi3;
            if (num.Resultado8 > 0)
            {
                auxi2 = " ";
            }
            else
            {
                auxi2 = "+ ";
            }

            if (num.Resultado9 > 0)
            {
                auxi3 = " ";
            }
            else
            {
                auxi3 = "+ ";
            }
            string auxi4, auxi5;
            if (num.Resultado27 > 0)
            {
                auxi4 = " ";
            }
            else
            {
                auxi4 = "+";
            }
            if (num.Resultado17 > 0)
            {
                auxi5 = " ";
            }
            else
            {
                auxi5 = "+";
            }
            num.Resultado25 = (num.Resultado10 + "    " + auxi2 + -num.Resultado8 + "Y   " + auxi3 + -num.Resultado9 + "Z  &nbsp;&nbsp;&nbsp;&nbsp;" + num.Resultado28 + "    " + auxi4 + -num.Resultado27 + "Y   " + auxi5 + -num.Resultado17 + "Z <br/>"
            + "__________=__________" + "<br/>" + num.Numero7 + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" + num.Numero15);
            return num.Resultado25;
        }
        public string multiplicarecuaciones4y6(CalculoMatricial num)
        {
            //multiplicar los coeficientes con los terminos que estan dentros de los paraentesis            
            int[] A = { num.Numero15, num.Resultado10, num.Resultado8, num.Resultado9, num.Numero7, num.Resultado28, num.Resultado27, num.Resultado17 };
            A[0] = num.Numero15;
            A[1] = num.Resultado10;
            A[2] = num.Resultado8;
            A[3] = num.Resultado9;
            A[4] = num.Numero7;
            A[5] = num.Resultado28;
            A[6] = num.Resultado27;
            A[7] = num.Resultado17;
            for (int x = 0; x < A.Length; x++)
            {
                calculo1 = A[0] * A[1];
                calculo2 = A[0] * A[2];
                calculo3 = A[0] * A[3];

                calculo4 = A[4] * A[5];
                calculo5 = A[4] * A[6];
                calculo6 = A[4] * A[7];
            }
            for (int x = 0; x < A.Length; x++)
            {
                if (A[2] > 0)
                {
                    a = " ";
                }
                else
                {
                    a = " + ";
                }
                if (A[3] > 0)
                {
                    b = " ";
                }
                else
                {
                    b = " + ";
                }
                if (A[6] > 0)
                {
                    c = " ";
                }
                else
                {
                    c = " + ";
                }
                if (A[7] > 0)
                {
                    d = " ";
                }
                else
                {
                    d = " + ";
                }
                if (calculo2 > 0)
                {
                    e = " ";
                }
                else
                {
                    e = " + ";
                }
                if (calculo3 > 0)
                {
                    f = " ";
                }
                else
                {
                    f = " + ";
                }
                if (calculo5 > 0)
                {
                    g1 = "  ";
                }
                else
                {
                    g1 = " + ";
                }
                if (calculo6 > 0)
                {
                    h = "  ";
                }
                else
                {
                    h = " + ";
                }
                calculo7 = calculo5;
                if (calculo7 > 0)
                {
                    i = " + ";
                }
                else
                {
                    i = "  ";
                }
                calculo8 = calculo6;
                if (calculo8 > 0)
                {
                    j = " + ";
                }
                else
                {
                    j = "  ";
                }
                if (calculo1 > 0)
                {
                    K = "  ";
                }
                else
                {
                    K = " + ";
                }
                auxiliar2 = -calculo2 + calculo7;
                auxiliar3 = -calculo3 + calculo8;
                auxiliar4 = calculo4 - calculo1;
                if (auxiliar3 > 0)
                {
                    g = " + ";
                }
                else
                {
                    g = "  ";
                }
                num.Resultado26 = (A[0] + "&nbsp;(&nbsp;" + A[1] + "&nbsp;" + a + -A[2] + "Y&nbsp;" + b + -A[3] + "&nbsp;Z&nbsp;)&nbsp;=&nbsp;" + A[4] + "&nbsp;(&nbsp;" + A[5] + "&nbsp;" + c + -A[6] + "Y&nbsp;" + d + -A[7] + "&nbsp;Z&nbsp;)" + "<br/>"
                + calculo1 + "&nbsp;" + e + -calculo2 + "Y&nbsp;" + f + -calculo3 + "Z&nbsp;=&nbsp;" + calculo4 + "&nbsp;" + g1 + -calculo5 + "Y&nbsp;" + h + -calculo6 + "Z&nbsp" + "<br/>" + -calculo2 + "Y&nbsp;" + f + -calculo3 + "Z&nbsp;"
                + i + calculo7 + "Y&nbsp;" + j + calculo8 + "Z&nbsp;=&nbsp;" + calculo4 + "&nbsp;" + K + -calculo1 + "<br/>" + -calculo2 + "Y&nbsp;" + i + calculo7 + "Y&nbsp;" + f + -calculo3 + "Z&nbsp;" + j + calculo8 + "Z&nbsp;=&nbsp;" + calculo4 + "&nbsp;" + K + -calculo1
                + "<br/>" + auxiliar2 + "Y" + "&nbsp;" + g + auxiliar3 + "Z&nbsp;=&nbsp;" + auxiliar4 + "<br/>" + "Ecuacion (8)");
            }

            return num.Resultado26;
        }
        public string resolverelsistema2x2(CalculoMatricial num)
        {
            //Resolver el sistema 2x2 toimando como refrencia las ecuaciones (7) y (8)
            int[] A = { auxi2, auxi3, auxi4, auxiliar2, auxiliar3, auxiliar4 };
            A[0] = auxi2;
            A[1] = auxi3;
            A[2] = auxi4;
            A[3] = auxiliar2;
            A[4] = auxiliar3;
            A[5] = auxiliar4;
            for (int x = 0; x < A.Length; x++)
            {
                if (A[1] > 0)
                {
                    a = "+";
                }
                else
                {
                    a = "";
                }
                if (A[4] > 0)
                {
                    b = "+";
                }
                else
                {
                    b = "";
                }
                if (A[4] > 0)
                {
                    c = " ";
                }
                else
                {
                    c = "+";
                }
                if (A[1] > 0)
                {
                    d = " ";
                }
                else
                {
                    d = "+";
                }

            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado30 = (A[0] + "Y&nbsp;" + a + A[1] + "Z&nbsp;=&nbsp;" + A[2] + "<br/>" + A[3] + "Y&nbsp;" + b + A[4] + "Z&nbsp;=&nbsp;" + A[5] + "<br/><br/>" + "Y&nbsp;=&nbsp;" + A[2] + "&nbsp;" + d + -A[1] + "Z&nbsp;&nbsp;&nbsp;&nbsp;" + "Y&nbsp;=&nbsp;" + A[5] + "&nbsp;" + c + -A[4] + "Z" + "<br/>" + "____________&nbsp;&nbsp;&nbsp;&nbsp;" + "____________" + "<br/>" + "&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;" + A[0] + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;"
                + A[3] + "&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;");
                //Igualarlasecuaciones7y8 se multiplica en cruz
                g1 = (A[2] + "&nbsp;" + d + -A[1] + "Z&nbsp;&nbsp;&nbsp;&nbsp;" + "&nbsp;&nbsp;" + A[5] + "&nbsp;" + c + -A[4] + "Z" + "<br/>" + "____________&nbsp;&nbsp;&nbsp;=&nbsp;&nbsp;&nbsp;" + "____________" + "<br/>" + "&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;&nbsp;" + A[0] + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;"
                + A[3] + "&nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp;" + "<br/><br/>" + A[3] + "&nbsp;(&nbsp;" + A[2] + "&nbsp;" + "&nbsp;" + d + "&nbsp;" + -A[1] + "Z&nbsp;)&nbsp;&nbsp;=&nbsp;&nbsp;" + A[0] + "&nbsp;(&nbsp;" + A[5] + "&nbsp;" + "&nbsp;" + c + "&nbsp;" + -A[4] + "Z&nbsp;)");
                aux = A[3] * A[2];
                aux1 = A[3] * -A[1];
                aux2 = A[0] * A[5];
                aux3 = A[0] * -A[4];
            }
            return num.Resultado30;

        }
        public string Igualarlasecuaciones7y8(CalculoMatricial num)
        {
            int[] A = { aux, aux1, aux2, aux3 };
            A[0] = aux;
            A[1] = aux1;
            A[2] = aux2;
            A[3] = aux3;
            for (int x = 0; x < A.Length; x++)
            {
                if (A[1] > 0)
                {
                    a = "+";
                }
                else
                {
                    a = " ";
                }
                if (A[3] > 0)
                {
                    b = "+";
                }
                else
                {
                    b = " ";
                }
                //DESPEJAR Z
                if (A[3] > 0)
                {
                    c = " ";
                }
                else
                {
                    c = " + ";
                }
                if (A[0] > 0)
                {
                    d = " ";
                }
                else
                {
                    d = " + ";
                }
                //a = ("Z&nbsp;=" + aux5 + "&nbsp;/&nbsp;" + aux4);
                //Realizar las operaciones indicadas
                aux4 = A[1] + -A[3];
                aux5 = A[2] + -A[0];
               // a = ("Z&nbsp;=" + aux5 + "&nbsp;/&nbsp;" + aux4);
                //Dividimos para encontrar valor de Z
                double respuesta, a1, a2;
                a1 = aux5;
                a2 = aux4;
                respuesta = a1 / a2;
                valor1 = respuesta;
                string P;
                P = "" + string.Format("{0:n1}", (Math.Round(respuesta * 100) / 100) - 0);
                if (respuesta % 1 == 0)
                {
                    P = "" + string.Format("{0:}", (Math.Round(respuesta * 100) / 100) - 0);
                }
                l = P;
                //
                a = ("Z =" + a1 + "&nbsp;&nbsp; / &nbsp;&nbsp;" + a2);
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado31 = (g1 + "<br/>" + A[0] + "&nbsp;"  + "&nbsp;" + A[1] + "Z&nbsp;&nbsp;=&nbsp;&nbsp;" + A[2] + "&nbsp;" + b + "&nbsp;" + A[3] + "Z" + "<br/>" + A[1] + "Z&nbsp;" + "&nbsp;" + c + "&nbsp;"
                 + -A[3] + "Z&nbsp;&nbsp;=&nbsp;&nbsp;" + A[2] + "&nbsp;" + d + "&nbsp;" + -A[0] + "<br/>" + aux4 + "Z&nbsp;=&nbsp;" + aux5 + "<br/>" + a + "<br/>" + "Z&nbsp;=&nbsp;" + l);
            }
            return num.Resultado31;
        }

        public string sustituirencualquieradelasdosecuaciones7y8(CalculoMatricial num)
        {
            int[] B = { aux5,aux4, auxiliar2, auxiliar3, auxiliar4 };
            B[0] = aux5;
            B[1] = aux4;           
            B[2] = auxiliar2;
            B[3] = auxiliar3;
            B[4] = auxiliar4;
            for (int x = 0; x < B.Length; x++)
            {
                if (B[3]>0)
                {
                    j = "+";
                }
                else
                {
                    j = "";
                }
                int respuesta;
                int respuesta1;               
                respuesta = B[0] / B[1];
                respuesta1= B[3] * -respuesta;
                if (respuesta1>0)
                {
                    i = "";
                }
                else
                {
                    i = "+";
                }
                calculo1 = respuesta1;
                if (calculo1 > 0)
                {
                    g1 = "+";
                }
                else
                {
                    g1 = "";
                }
                double resp;
                aux = B[4] + calculo1;
                resp = aux / B[2];
                valor = resp;
                string P;
                P = "" + string.Format("{0:n1}", (Math.Round(resp * 100) / 100) - 0);
                if (resp % 1 == 0)
                {
                    P = "" + string.Format("{0:}", (Math.Round(resp * 100) / 100) - 0);
                }
                j = P;
                K = (B[2]+"Y"+ "&nbsp;&nbsp;" + j+ "&nbsp;&nbsp;" + B[3]+ "&nbsp;&nbsp;(&nbsp;&nbsp;"+l+ "&nbsp;&nbsp;)&nbsp;&nbsp;=&nbsp;&nbsp;"+B[4] + "<br/>" + B[2] + "Y" + "&nbsp;&nbsp;" +i+ "&nbsp;&nbsp;" + -respuesta1+ "&nbsp;&nbsp;=&nbsp;&nbsp;"+ B[4] 
                    + "<br/>" + B[2] + "Y  =&nbsp;&nbsp;" + B[4]+ "&nbsp;&nbsp;"+g1+"&nbsp;&nbsp;"+calculo1 + "<br/>" + B[2] + "Y  =&nbsp;&nbsp;" +aux + "<br/>" 
                    + "Y&nbsp;&nbsp;=&nbsp;&nbsp;"+aux+ "&nbsp;&nbsp;/&nbsp;&nbsp;"+ B[2] + "<br/>" + "Y&nbsp;&nbsp;=&nbsp;&nbsp;" +j );
            }
            for (int x = 0; x < B.Length; x++)
            {
                num.Resultado32 = (K);
            }
            return num.Resultado32;
        }
        public string sustituirlaprimeraecuacion(CalculoMatricial num)
        {
            //para encontrar valor de X despejamos la ecuacion (1)
            double final,final1,resultado,resultado1;
            double[] B = { num.Numero7, num.Numero8, num.Numero9, num.Numero10,valor,valor1 };
            B[0] = num.Numero7;
            B[1] = num.Numero8;
            B[2] = num.Numero9;
            B[3] = num.Numero10;
            B[4] = valor;
            B[5] = valor1;
            for (int x = 0; x < B.Length; x++)
            {
                if (B[1] > 0)
                {
                    a = "+";
                    c = "";
                    final = -B[1] * B[4];                                                       
                }
                else
                {
                    a = "";
                    c = "+";
                    final = -B[1] * B[4];                    
                }
                if (B[2] > 0)
                {
                    b = "+";
                    d = "";
                    final1 = -B[2] * B[5];
                }
                else
                {
                    b = "";
                    d = "+";
                    final1 = -B[2] * B[5];
                }
                if (final > 0)
                {
                    e = "+";
                }
                else
                {
                    e = "";
                }
                if (final1 > 0)
                {
                    f = "+";
                }
                else
                {
                    f = "";
                }
                resultado = B[3] + final + final1;
                resultado1 = resultado / B[0];
                g1 = (B[0]+"X"+"&nbsp;&nbsp"+a+"&nbsp;&nbsp"+B[1]+"Y"+"&nbsp;&nbsp"+b+"&nbsp;&nbsp"+B[2]+ "Z =&nbsp;&nbsp"+ B[3] + "<br/>" + "X=&nbsp;&nbsp"+B[3]+"&nbsp;&nbsp"+c
                +"&nbsp;&nbsp"+-B[1]+ "(&nbsp;&nbsp" +j+ "&nbsp;&nbsp)"+"&nbsp;&nbsp"+d+"&nbsp;&nbsp"+-B[2]+"(&nbsp;&nbsp"+l+ "&nbsp;&nbsp)" 
                + "<br/>" + "_____________________" + "<br/>" + "&nbsp;&nbsp" + B[0]+ "<br/>" + "X=&nbsp;&nbsp"+B[3]+"&nbsp;&nbsp"+e+"&nbsp;&nbsp"+final+"&nbsp;&nbsp"+f+"&nbsp;&nbsp"+final1 
                + "<br/>" + "_______________" + "<br/>" + "&nbsp;&nbsp" + B[0] + "<br/>" + "X =&nbsp;&nbsp"+ B[0] + "&nbsp;&nbsp/&nbsp;&nbsp"+ resultado + "<br/>" + "X =&nbsp;&nbsp"+resultado1);
            }
            for (int x = 0; x < B.Length; x++)
            {
                num.Resultado33 = (g1);
            }            
            return num.Resultado33;
        }
        //ECUACIONES LINEALES CON CUATRO INCOGNITAS
        public string ingresoecuacionesx4incognitas(CalculoMatricial num)
        {
            //ecuacion 1
            num.Resultado1=num.Numero1;
            num.Resultado2=num.Numero2;
            num.Resultado3=num.Numero3;
            num.Resultado4=num.Numero4;
            num.Resultado5=num.Numero5;
            //ecuacion 2
            num.Resultado6 = num.Numero6;
            num.Resultado7 = num.Numero7;
            num.Resultado8 = num.Numero8;
            num.Resultado9 = num.Numero9;
            num.Resultado10 = num.Numero10;
            //ecuacion 3            
            num.Resultado11 = num.Numero11;
            num.Resultado12 = num.Numero12;
            num.Resultado13 = num.Numero13;
            num.Resultado14 = num.Numero14;
            num.Resultado15 = num.Numero15;
            //ecuacion 4
            num.Resultado17 = num.Numero16;
            num.Resultado27 = num.Numero17;
            num.Resultado28 = num.Numero18;
            num.Resultado29 = num.Numero19;
            num.Resultado34 = num.Numero20;
            //se ingresan valores ecuacion  4x4
            if (num.Resultado2 > 0)
            {
                a = "+ ";
            }
            else
            {
                a = " ";
            }
            if (num.Resultado3 > 0)
            {
                b = "+ ";
            }
            else
            {
                b = " ";
            }
            if (num.Resultado4 > 0)
            {
                c = "+ ";
            }
            else
            {
                c = " ";
            }
            if (num.Resultado7 > 0)
            {
                d = "+ ";
            }
            else
            {
                d = " ";
            }
            if (num.Resultado8 > 0)
            {
                e = "+ ";
            }
            else
            {
                e = " ";
            }
            if (num.Resultado9 > 0)
            {
                f = "+ ";
            }
            else
            {
                f = " ";
            }

            if (num.Resultado12 > 0)
            {
                g = "+ ";
            }
            else
            {
                g = " ";
            }
            if (num.Resultado13 > 0)
            {
                h = "+ ";
            }
            else
            {
                h = " ";
            }
            if (num.Resultado14 > 0)
            {
                i = "+ ";
            }
            else
            {
                i = " ";
            }

            if (num.Resultado27 > 0)
            {
                j = "+ ";
            }
            else
            {
                j = " ";
            }

            if (num.Resultado28 > 0)
            {
                K = "+ ";
            }
            else
            {
                K = " ";
            }

            if (num.Resultado29 > 0)
            {
                l = "+ ";
            }
            else
            {
                l = " ";
            }
            num.Resultado18 = (num.Resultado1 + "X   " + "   " + a + num.Resultado2 + "Y   " + b + num.Resultado3 + "Z  " + c + num.Resultado4 + "U =   " + num.Resultado5 + "<br/>" 
            +num.Resultado6 + "X   " + "   " + d + num.Resultado7 + "Y   " + e + num.Resultado8 + "Z  " + f + num.Resultado9 + "U =   " + num.Resultado10 + "<br/>"
            + num.Resultado11 + "X   " + "   " + g + num.Resultado12 + "Y   " + h + num.Resultado13 + "Z  " + i + num.Resultado14 + "U =   " + num.Resultado15 + "<br/>"
            + num.Resultado17 + "X   " + "   " + j + num.Resultado27 + "Y   " + K + num.Resultado28 + "Z  " + l + num.Resultado29 + "U =   " + num.Resultado34);
            return num.Resultado18;
        }
    }
}







