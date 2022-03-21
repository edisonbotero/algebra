using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace algebra.formularios
{
    public class InversaGaussJordan
    {
        string aux, a1, a2, a3, a4, a5, a6, a7;
        int a, b, c, d, e, f, g, h, i, j, k, l, aux1, aux2, aux3, aux4, aux5, aux6, aux11, aux12, aux13, aux14, aux15, aux16;
        public string matriz(CalculoMatricial num)
        {
            num.Resultado1 = num.Numero1;
            num.Resultado2 = num.Numero2;
            num.Resultado3 = num.Numero3;
            num.Resultado4 = num.Numero4;
            num.Resultado5 = num.Numero5;
            num.Resultado6 = num.Numero6;
            num.Resultado7 = num.Numero7;
            num.Resultado8 = num.Numero8;
            num.Resultado9 = num.Numero9;
            num.Resultado10 = 1;
            num.Resultado11 = 0;
            num.Resultado12 = 0;
            //Expresar e forma matricial
            num.Resultado16 = ("(F1)         " + num.Resultado1 + "         " + num.Resultado2 + "         " + num.Resultado3 + "\n" + "(F2)         " + num.Resultado4 + "         " + num.Resultado5 + "         " + num.Resultado6 + "\n" + "(F3)         " + num.Resultado7 + "         " + num.Resultado8 + "         " + num.Resultado9);
            return num.Resultado16;

        }
        //formar otra matris identidad  conla primera matriz, matriz convirtiendo a ceros y unos
        public string calcularmatriz(CalculoMatricial num)
        {
            int[] A = { num.Resultado1, num.Resultado2, num.Resultado3, num.Resultado4, num.Resultado5, num.Resultado6 };
            //cruzar los coeficientes de la primera y segunda fila 
            //a uno de ellos se le cambia el signo a cualquiera 
            //primera fila
            A[0] = num.Resultado1;
            A[1] = num.Resultado2;
            A[2] = num.Resultado3;
            //seguna fila 
            A[3] = num.Resultado4;
            A[4] = num.Resultado5;
            A[5] = num.Resultado6;
            for (int x = 0; x < A.Length; x++)
            {
                //la primera fila queda tal como esta 
                // aux = (A[0] + "  " + A[1] + "  " + A[2]);
                //trabajar para eeliminar ceros                               
                a = -A[0];
                b = A[3];
                //se hacen las operaciones 
                f = A[3] * A[0];
                d = A[3] * A[1];
                e = A[3] * A[2];
                g = A[3] * 1;

                a = -A[0] * A[3];
                b = -A[0] * A[4];
                c = -A[0] * A[5];
                h = -A[0] * 1;

                a5 = (A[3] + "(" + A[0] + ") =&nbsp" + f + " &nbsp;&nbsp   " + A[3] + "(" + A[1] + ") =&nbsp" + d + " &nbsp;&nbsp   " + A[3] + "(" + A[2] + ") =&nbsp" + e + " &nbsp;&nbsp   " + A[3] + "(" + 1 + ") =&nbsp" + g + " &nbsp;&nbsp   " + A[3] + "(" + 0 + ") =&nbsp" + 0 + " &nbsp;&nbsp   " + A[3] + "(" + 0 + ") =&nbsp" + 0 + "<br /><br />" + "Realizar las operaciones indicadas entre F2 * F1" + "<br />" +
                  -A[0] + "(" + A[3] + ") =&nbsp" + a + " &nbsp;&nbsp   " + -A[0] + "(" + A[4] + ") =&nbsp" + b + " &nbsp;&nbsp   " + -A[0] + "(" + A[5] + ") =&nbsp" + c + " &nbsp;&nbsp   " + -A[0] + "(" + 0 + ") =&nbsp" + 0 + " &nbsp;&nbsp   " + -A[0] + "(" + 1 + ") =&nbsp" + h + " &nbsp;&nbsp   " + -A[0] + "(" + 0 + ") =&nbsp" + 0 + "<br /><br />" + "Luego se suman los resultados obtenidos entre F1 y F2");
                //sumar);
                //sumar

                aux11 = f + a;
                aux12 = d + b;
                aux13 = e + c;
                aux14 = g + 0;
                aux15 = 0 + h;
                aux16 = 0;
                a6 = ("(F2)" + " &nbsp;&nbsp  " + aux11 + " &nbsp;&nbsp  " + aux12 + " &nbsp;&nbsp  " + aux13 + " &nbsp;&nbsp  " + aux14 + " &nbsp;&nbsp  " + aux15 + " &nbsp;&nbsp  " + 0);

            }
            for (int x = 0; x < A.Length; x++)
            {

                num.Resultado18 = (f + "         " + d + "         " + e + "         " + g + "         " + " 0 " + "         " + " 0 " + "\n" + a + "         " + b + "         " + c + "         " + " 0 " + "         " + h + "         " + "0" + "\n" +
                    "______________________________" + "\n" + aux11 + "         " + aux12 + "         " + aux13 + "         " + aux14 + "         " + aux15 + "         " + 0);
            }
            return num.Resultado18;
        }
        public string calcularmatriz1(CalculoMatricial num)
        {
            int[] A = { num.Resultado1, num.Resultado2, num.Resultado3, num.Resultado7, num.Resultado8, num.Resultado9 };
            //cruzar los coeficientes de la primera y tercera  fila 
            //a uno de ellos se le cambia el signo a cualquiera 
            //primera fila
            A[0] = num.Resultado1;
            A[1] = num.Resultado2;
            A[2] = num.Resultado3;
            //tercera fila
            A[3] = num.Resultado7;
            A[4] = num.Resultado8;
            A[5] = num.Resultado9;
            for (int x = 0; x < A.Length; x++)
            {
                //trabajar para eeliminar ceros

                //se hacen las operaciones 
                f = A[3] * A[0];
                d = A[3] * A[1];
                e = A[3] * A[2];
                g = A[3] * 1;
                i = A[3] * 0;
                j = A[3] * 0;

                a = -A[0] * A[3];
                b = -A[0] * A[4];
                c = -A[0] * A[5];
                h = -A[0] * 0;
                k = -A[0] * 0;
                l = -A[0] * 1;
                a2 = (A[3] + "(" + A[0] + ") =&nbsp" + f + " &nbsp;&nbsp   " + A[3] + "(" + A[1] + ") =&nbsp" + d + " &nbsp;&nbsp   " + A[3] + "(" + A[2] + ") =&nbsp" + e + "  &nbsp;&nbsp " + A[3] + "(" + 1 + ") =&nbsp" + g + " &nbsp;&nbsp   " + A[3] + "(" + 0 + ") =&nbsp" + i + " &nbsp;&nbsp  " + A[3] + "(" + 0 + ") =&nbsp" + j + "<br /><br />" + "Realizar las operaciones indicadas entre F1 * F3" + "<br />" + -A[0] + "(" + A[3] + ") =&nbsp" + a
                + " &nbsp;&nbsp  " + -A[0] + "(" + A[4] + ") =&nbsp" + b + " &nbsp;&nbsp  " + -A[0] + "(" + A[5] + ") =&nbsp" + c + " &nbsp;&nbsp  " + -A[0] + "(" + A[0] + ") =&nbsp" + h + " &nbsp;&nbsp  " + -A[0] + "(" + A[0] + ") =&nbsp" + k + " &nbsp;&nbsp  " + -A[0] + "(" + 1 + ") =&nbsp" + l +
                "<br /><br />" + "Luego se suman los resultados obtenidos entre F1 y F3");
                aux = (f + "         " + d + "         " + e + "         " + g + "         " + i + "         " + j);
                a1 = (a + "         " + b + "         " + c + "         " + h + "         " + k + "         " + l);
                //SUMAR
                aux1 = f + a;
                aux2 = d + b;
                aux3 = e + c;
                aux4 = g + h;
                aux5 = i + k;
                aux6 = j + l;
                a4 = (aux1 + "         " + aux2 + "         " + aux3 + "         " + aux4 + "         " + aux5 + "         " + aux6);

                a7 = ("(F3)" + " &nbsp;&nbsp  " + aux1 + " &nbsp;&nbsp  " + aux2 + " &nbsp;&nbsp  " + aux3 + " &nbsp;&nbsp  " + aux4 + " &nbsp;&nbsp  " + aux5 + " &nbsp;&nbsp  " + aux6);

            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado19 = (aux + "\n" + a1 + "\n" + "______________________________" + "\n" + a4);

            }
            return num.Resultado19;

        }
        public string mensajespaso1(CalculoMatricial num)
        {
            a3 = ("(F1)           " + num.Resultado1 + " &nbsp;&nbsp  " + num.Resultado2 + " &nbsp;&nbsp  " + num.Resultado3 + " &nbsp;&nbsp  " + " 1  " + " &nbsp;&nbsp  " + " 0  " + " &nbsp;&nbsp  " + " 0  " + "<br />" + "(F3)           " + num.Resultado7 + " &nbsp;&nbsp  " + num.Resultado8 + " &nbsp;&nbsp  " + num.Resultado9 + " &nbsp;&nbsp  " + " 0  " + " &nbsp;&nbsp  " + " 0  " + " &nbsp;&nbsp  " + " 1  " + "<br /><br />" +
            "Realizar las operaciones indicadas entre F3 * F1" + "<br />" + a2);

            num.Resultado20 = (a3);
            return num.Resultado20;
        }

        public string mensajespaso2(CalculoMatricial num)
        {
            a1 = ("(F1)&nbsp;&nbsp" + num.Resultado1 + " &nbsp;&nbsp  " + num.Resultado2 + " &nbsp;&nbsp  " + num.Resultado3 + " &nbsp;&nbsp  " + " 1  " + " &nbsp;&nbsp  " + " 0  " + " &nbsp;&nbsp  " + " 0  " + "<br />" + "(F2)&nbsp;&nbsp" + num.Resultado4 + " &nbsp;&nbsp  " + num.Resultado5 + " &nbsp;&nbsp  " + num.Resultado6 + " &nbsp;&nbsp  " + " 0  " + " &nbsp;&nbsp  " + " 1  " + " &nbsp;&nbsp  " + " 0  " + "<br /><br />"
            + "Realizar las operaciones indicadas entre F1 * F2" + "<br />" + a5);
            num.Resultado21 = (a1);
            return num.Resultado21;
        }
        public string mensajespaso3(CalculoMatricial num)
        {
            aux = ("(F1)" + " &nbsp;&nbsp  " + num.Resultado1 + " &nbsp;&nbsp  " + num.Resultado2 + " &nbsp;&nbsp  " + num.Resultado3 + " &nbsp;&nbsp  " + 1 + " &nbsp;&nbsp  " + 0 + " &nbsp;&nbsp  " + 0 + "<br />" + a6 + "<br />" + a7);
            num.Resultado22 = (aux);
            return num.Resultado22;
        }
        //se obtiene una nueva matriz de los resultados de los cruces de los coeficiente, de la primera y segunda fila, primera y tercera fila
        //dejando fila 1 tal como esta
        public string nuevamatriz(CalculoMatricial num)
        {
            int[] A = { num.Resultado1, num.Resultado2, num.Resultado3, aux11, aux12, aux13, aux1, aux2, aux3 };
            A[0] = num.Resultado1;
            A[1] = num.Resultado2;
            A[2] = num.Resultado3;
            A[3] = aux11;
            A[4] = aux12;
            A[5] = aux13;
            A[6] = aux1;
            A[7] = aux2;
            A[8] = aux3;
            for (int x = 0; x < A.Length; x++)
            {
                a1 = (A[0] + "        " + A[1] + "        " + A[2] + "\n" + A[3] + "        " + A[4] + "        " + A[5] + "\n" + A[6] + "        " + A[7] + "        " + A[8]);
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado23 = (a1);
            }
            return num.Resultado23;
        }
        public string nuevamatrizidentidad(CalculoMatricial num)
        {
            int[] A = { num.Resultado10, num.Resultado11, num.Resultado12, aux14, aux15, aux16, aux4, aux5, aux6 };
            A[0] = num.Resultado10;
            A[1] = num.Resultado11;
            A[2] = num.Resultado12;
            A[3] = aux14;
            A[4] = aux15;
            A[5] = aux16;
            A[6] = aux4;
            A[7] = aux5;
            A[8] = aux6;
            for (int x = 0; x < A.Length; x++)
            {
                a2 = (A[0] + "        " + A[1] + "        " + A[2] + "\n" + A[3] + "        " + A[4] + "        " + A[5] + "\n" + A[6] + "        " + A[7] + "        " + A[8]);
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado24 = (a2);
            }
            return num.Resultado24;
        }
        public string calcularmatriz2(CalculoMatricial num)
        {
            //cruzar los coeficientes de la segunda y tercera fila de nueva matriz y nuevamatrizidentidad
            int[] A = {aux11, aux12, aux13,aux14, aux15, aux16, aux1, aux2, aux3, aux4, aux5, aux6 };
            //fila1
            A[0]= aux11;
            A[1]= aux12;
            A[2]= aux13;
            A[3] = aux14;
            A[4] = aux15;
            A[5] = aux16;
            //fila2
            A[6] = aux1;
            A[7] = aux2;
            A[8] = aux3;
            A[9] = aux4;
            A[10] = aux5;
            A[11] = aux6;
            for (int x = 0; x < A.Length; x++)
            {
                //se realizan las operaciones y a uno de ellos de la fila a1 y a3 se le cambia el signo a cualquiera
                //se cambia el sigino a -A[7]
                f = A[1] * A[6];
                d = A[1] * A[7];
                e = A[1] * A[8];
                g = A[1] * A[9];
                i = A[1] * A[10];
                j = A[1] * A[11];
                a = -A[7] * A[0];
                b = -A[7] * A[1];
                c = -A[7] * A[2];
                h = -A[7] * A[3];
                k = -A[7] * A[4];
                l = -A[7] * A[5];
                a1 = (a + "         " + b + "         " +  c + "         " +  h + "         " +  k + "         " +  l );
                a2 = (f + "         " + d + "         " +  e + "         " +  g + "         " +  i + "         " +  j );
                //realizar las operaciones indicadas
                a4 = (-A[7] + "(" + A[0] + ") ="+ a + " &nbsp;&nbsp"
                + -A[7] + "(" + A[1] + ") ="+b
                + " &nbsp;&nbsp;&nbsp" + -A[7] + "(" + A[2] + ") ="+ c 
                + " &nbsp;&nbsp;&nbsp" + -A[7] + "(" + A[3] + ") ="+ h 
                + " &nbsp;&nbsp;&nbsp" + -A[7] + "(" + A[4] + ") ="+ k
                + " &nbsp;&nbsp;&nbsp" + -A[7] + "(" + A[5] + ") ="+ l);
                //realizar las operaciones indicadas
                a5= (A[1] + "(" + A[6] + ") =" + f + " &nbsp;&nbsp"
                +  A[1] + "(" + A[7] + ") =" + d
                + " &nbsp;&nbsp;&nbsp" + A[1] + "(" + A[8] + ") =" + e
                + " &nbsp;&nbsp;&nbsp" + A[1] + "(" + A[9] + ") =" + g
                + " &nbsp;&nbsp;&nbsp" + A[1] + "(" + A[10] + ") =" + i
                + " &nbsp;&nbsp;&nbsp" + A[1] + "(" + A[11] + ") =" + j);
                //sumar a1 y a2
                int total, total1, total2, total3,total4,total5;
                total = a + f;
                total1 = b + d;
                total2 = c + e;
                total3 = h + g;
                total4 = k + i;
                total5 = l + j;
                a3 =(total + "         " + total1 + "         " + total2 + "         " + total3 + "         " + total4 + "         " + total5);
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado25 = (a1 + "\n" + a2 + "\n" + "______________________________" + "\n" +a3);
            }
            return num.Resultado25;

        }
        public string mensagespaso4(CalculoMatricial num)
        {
            a1 = ("(F2)" + " &nbsp;&nbsp  " + aux11 + " &nbsp;&nbsp  " + aux12 + " &nbsp;&nbsp  " + aux13 + " &nbsp;&nbsp  " + aux14 + " &nbsp;&nbsp  " + aux15 + " &nbsp;&nbsp  " + aux16 + "<br />" + "(F3)&nbsp;&nbsp" 
            +aux1 + " &nbsp;&nbsp  " +aux2 + " &nbsp;&nbsp  " +aux3 + " &nbsp;&nbsp  " +aux4 + " &nbsp;&nbsp  " +aux5 + " &nbsp;&nbsp  " +aux6 + "<br /><br />" + "Realizar las operaciones indicadas entre F3 Y F2" +"<br />"+a4 + "<br /><br />"
            + "Realizar las operaciones indicadas entre F2 Y F3" + "<br />" +a5);
            num.Resultado26 = (a1);
            return num.Resultado26;
        }
    }
}