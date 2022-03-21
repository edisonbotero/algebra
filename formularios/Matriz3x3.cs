using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace algebra.formularios
{
    public class Matriz3x3
    {
        
        private int produto;
        private int produto2;
        private int produto3;
        private int produto4;
        private int produto5;
        private int produto6;
        private int auxiliar;
        private int auxiliar1;
        private int auxiliar2;
        private int valor;
        private int valor1;
        private int valor2;
        private int valor3;
        private int valor4;
        private int valor5;
        private int valor6;
        private int valor7;
        private int valor8;
        private int valor9;
        private int valor10;
        private int valor11;
        private int suma;
        private int suma1;
        private int suma2;
        private int suma3;
        private int suma4;
        private int suma5;
        private int suma6;
        private int suma7;
        private int suma8;
        private int r;
        private string a;
        private string b;
        private string c;
        private string d;
        private string e;
        private int matf;
        private int matf1;
        private int auxiliar3;
        private int auxiliar4;
        private int matf2;
        private int matf3;
        private int Z;
        private string f;
        private string f1;
        public void matriz(CalculoMatricial  num)
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
            
        }
    //calcular primera diagonal
        public int calculo(CalculoMatricial num)
        {           
            int[] A = { num.Numero1, num.Numero5, num.Numero9 };
            A[0] = num.Numero1;
            A[1] = num.Numero5;
            A[2] = num.Numero9;
            for (int x=0; x < A.Length;x++)
            {
                produto = A[0] * A[1] * A[2];
            }

            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado10 = produto;
            }
            return num.Resultado10;
        }
        //calcular segunda diagonal
        public int segundaDiagonal(CalculoMatricial num)
        {
            int[] A = { num.Numero2, num.Numero6, num.Numero7 };
            A[0] = num.Numero2;
            A[1] = num.Numero6;
            A[2] = num.Numero7;
            for (int x = 0; x < A.Length; x++)
            {
                produto2 = A[0] * A[1] * A[2];
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado11 = produto2;
            }
            return num.Resultado11;
        
          }
        //calcular tercera diagonal
        public int TerceraDiagonal(CalculoMatricial num)
        {
            int[] A = { num.Numero3, num.Numero4, num.Numero8 };
            A[0] = num.Numero3;
            A[1] = num.Numero4;
            A[2] = num.Numero8;
            for (int x = 0; x < A.Length; x++)
            {
                produto3 = A[0] * A[1] * A[2];
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado12 = produto3;
            }
            return num.Resultado12;
        }
        //cacular cuarta diagonal
        public int CuartaDiagonal(CalculoMatricial num)
        {
            int[] A = { num.Numero3, num.Numero5, num.Numero7 };
            A[0] = num.Numero3;
            A[1] = num.Numero5;
            A[2] = num.Numero7;
            for (int x = 0; x < A.Length; x++)
            {
                produto4 = A[0] * A[1] * A[2];
                if (produto4 > 0)
                {
                    auxiliar = -produto4;
                }
                else
                {
                    auxiliar = -produto4;
                }
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado13 = auxiliar;
            }
            return num.Resultado13;
        }
        //calcular quinta diagonal
        public int quintaDiagonal(CalculoMatricial num)
        {
            int[] A = { num.Numero1, num.Numero6, num.Numero8 };
            A[0] = num.Numero1;
            A[1] = num.Numero6;
            A[2] = num.Numero8;
            for (int x = 0; x < A.Length; x++)
            {
                produto5 = A[0] * A[1] * A[2];
                if (produto5 > 0)
                {
                    auxiliar1 = -produto5;
                }
                else
                {
                    auxiliar1 = -produto5;
                }
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado14 = auxiliar1;
            }
            return num.Resultado14;
        }
        //calcular quinta diaonal
        public int sextaDiagonal(CalculoMatricial num)
        {
            int[] A = { num.Numero2, num.Numero4, num.Numero9 };
            A[0] = num.Numero2;
            A[1] = num.Numero4;
            A[2] = num.Numero9;
            for (int x = 0; x < A.Length; x++)
            {
                produto6 = A[0] * A[1] * A[2];
                if (produto6 > 0)
                {
                    auxiliar2 = -produto6;
                }
                else
                {
                    auxiliar2 = -produto6;
                }
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado15 = auxiliar2;
            }
            return num.Resultado15;
        }
        //Una vez generado los calculos se procede a caluar determinante de A
        public string calculoA(CalculoMatricial num)
        {
            ///produto4 = num.Numero3 * num.Numero5 * num.Numero7;
            if (produto4 > 0)
            {
                a = " ";
            }
            else
            {
                a = "+";
            }
            if (produto5 > 0)
            {
                b = " ";
            }
            else
            {
                b = "+";
            }

            if (produto6 > 0)
            {
                c = " ";
            }
            else
            {
                c = "+";
            }

            if (produto2 > 0)
            {
                d = "+";
            }
            else
            {
                d = " ";
            }
            if (produto3 > 0)
            {
                e = "+";
            }
            else
            {
                e = " ";
            }         

            num.Resultado16 = ("" + produto + " " +d+ produto2 + " " +e+ produto3 + " " +a+ -produto4 + " " +b+ -produto5 + " " +c+ -produto6);
            return num.Resultado16;
        }
        public int resultadoDeterminante(CalculoMatricial num)
        {

            int[] A = { num.Resultado10, num.Resultado11, num.Resultado12, num.Resultado13, num.Resultado14, num.Resultado15 };
            for (int x = 0; x < A.Length; x++)
            {
                suma = suma + A[x];
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado17 = suma;

            }
            return num.Resultado17;
        }
        public string DeterminanteDistintodecero(CalculoMatricial num)
        {
            if (suma == 0)
            {
                num.Resultado18 = ("Observacion el determinante debe ser distinto cero");
               
            }
            return num.Resultado18;            
        }
        //calcular cofactores llenado de matriz
        public string llenarMatrisfila1(CalculoMatricial num)
        {
            num.Resultado1 = num.Numero1;
            num.Resultado2 = num.Numero2;
            num.Resultado3 = num.Numero3;
            num.Resultado20 = ("    " + num.Resultado1 + "       " + num.Resultado2 + "      " + num.Resultado3);

            return num.Resultado20;
        }
        public string llenarMatrisfila2(CalculoMatricial num)
        {
            num.Resultado4 = num.Numero4;
            num.Resultado5 = num.Numero5;
            num.Resultado6 = num.Numero6;
            num.Resultado21 = ("    "+num.Resultado4 + "       "+ num.Resultado5 + "      "+ num.Resultado6);
            return num.Resultado21;
        }
        public string llenarMatrisFila3(CalculoMatricial num)
        {
            num.Resultado7 = num.Numero7;
            num.Resultado8 = num.Numero8;
            num.Resultado9 = num.Numero9;
            num.Resultado22 = ("    " + num.Resultado7 + "       " + num.Resultado8 + "      " + num.Resultado9);
            return num.Resultado22;
        }
        public string valores(CalculoMatricial num)
        {
            num.Resultado23 = ("    " + "X" + "       " + "Y" + "      " + "Z");
            return num.Resultado23;
        }
        //Calcular cofactor de  X y Y
        public string valores2(CalculoMatricial num)
        {
            num.Resultado23 = ("    " + "Y" + "       " + "Z");
            return num.Resultado23;
        }
        //llenar matriz de  2 x 2 para Y  y z 
        public string llenarmatrizparaXyz(CalculoMatricial num)
        {
            int[] A = { num.Resultado5, num.Resultado6 };
            A[0] = num.Resultado5;
            A[1] = num.Resultado6;
            for (int x = 0; x < A.Length; x++)
            {
                matf = A[0];
                matf1= A[1];
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado24 = ("    " + matf + "       " + matf1);
            }         
           return num.Resultado24;
        }
        public string llenarmatrizparaXyZ1(CalculoMatricial num)
        {
            int[] B = { num.Resultado8, num.Resultado9 };
            B[0] = num.Resultado8;
            B[1] = num.Resultado9;
            for (int x = 0; x < B.Length; x++)
            {
                matf2 = B[0];
                matf3 = B[1];
            }
            for (int x = 0; x < B.Length; x++)
            {
                num.Resultado25 = ("    " + matf2 + "       " + matf3);
            }
            return num.Resultado25;
        }

        public string MultiplicarCofactoresdeYyZ(CalculoMatricial num)
        {
            num.Resultado26 = ("  [(" +matf+ ") ("+matf3+")  -  ("+matf1+") ("+matf2+")] ");
            return num.Resultado26;
        }
        //multiplicar cofactor de Y y Z
        public int multiplicarcofactorYyZ(CalculoMatricial num)
        {
            int[] A = { num.Numero5, num.Numero9};
            A[0] = num.Numero5;
            A[1] = num.Numero9;
            for (int x = 0; x < A.Length; x++)
            {
                auxiliar3 = A[0] * A[1];
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado27 = auxiliar3;
            }
            return num.Resultado27;
        }
        public int multiplicarcofactoresYyZ(CalculoMatricial num)
        {
            int[] A = { num.Numero6, num.Numero8 };
            A[0] = num.Numero6;
            A[1] = num.Numero8;
            for (int x = 0; x < A.Length; x++)
            {
               auxiliar4 = A[0] * A[1];
                if (auxiliar4 > 0)
                {
                    r = -auxiliar4;
                }
                else
                {
                    r = -auxiliar4;
                }
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado28 = auxiliar4;
            }
            return num.Resultado28;
        }
        public int calculosignos(CalculoMatricial num)
        {
           
            num.Resultado29 = auxiliar3+r;
            return num.Resultado29;            
        }

        //----------------------------------------------------sguiente paso------------------------------------
        //ingresar cofactores de X y Z
        public string valoresXyZ(CalculoMatricial num)
        {
            num.Resultado30 = ("    " + "X" + "       " + "Z");
            return num.Resultado30;
        }
        public string ingresovaloresdeXyZ(CalculoMatricial num)
        {
            int[] A = { num.Numero4, num.Numero6,num.Numero9 };
            A[0] = num.Numero4;
            A[1] = num.Numero6;
            A[2] = num.Numero9;
            for (int x = 0; x < A.Length; x++)
            {
                valor = (A[0]);
                valor1= (A[1]);
                valor4 = A[0] * A[2];
            }
            for (int x = 0; x < A.Length; x++)
            {
               num.Resultado31 = ("    " + valor + "       " + valor1);
              
            }
            return num.Resultado31;           
        }
        public string IngresoValoresXyZ(CalculoMatricial num)
        {
            int[] A = { num.Numero7, num.Numero9,num.Numero6 };
            A[0] = num.Numero7;
            A[1] = num.Numero9;
            A[2] = num.Numero6;
            for (int x = 0; x < A.Length; x++)
            {
                valor2 = (A[0]);
                valor3 = (A[1]);
                valor5 = A[2] * A[0];
            }
            for (int x = 0; x < A.Length; x++)
            {
               num.Resultado32 = ("    " + valor2 + "       " + valor3);
            }
            return num.Resultado32;
            //Multiplcar cofactores de XyZ          
         }
        public string Ingresodevaloresamultiplicar(CalculoMatricial num)
        {
            num.Resultado33 = ("  [(" + valor + ") (" + valor3 + ")  -  (" + valor1 + ") (" + valor2 + ")] ");
            return num.Resultado33;
        }
        //Hallar resultado de XyZ       
        //en valor5 se calcula si es positivo pasa a negativo sino caso contrario
        public string calcular_sies_positivo_pasanegativo_caso_contrario(CalculoMatricial num)
        {
            if (valor5 > 0)
            {
                f = " ";
            }
            else
            {
                f = "+";
            }
            //se suma los valores de valor4 + valor5 para hallar el resultado de X Y Z
            suma1 = valor4 + -valor5;
            num.Resultado35 = ("( " + valor4 + " " + f + -valor5+" )  ="+suma1);
            return num.Resultado35;
        }

        //----------------------------------------------------------------siguiente paso-------------------------------
        //ingresar cofactores de X y Y
        public string valoresXyY(CalculoMatricial num)
        {
            num.Resultado36 = ("    " + "X" + "       " + "Y");
            return num.Resultado36;
        }
        //Multiplicar valores cofactores de  X y Y

        public string IngresodevaloresamultiplicardeXyY(CalculoMatricial num)
        {
            num.Resultado38 = ("  [(" + num.Numero4 + ") (" + num.Numero8 + ")  -  (" + num.Numero5 + ") (" + num.Numero7 + ")] ");
            return num.Resultado38;
        }
        public string ingresar_cofactoresXyY(CalculoMatricial num)
        {
            int[] A = { num.Numero4, num.Numero5, num.Numero7,num.Numero8 };
            A[0] = num.Numero4;
            A[1] = num.Numero5;
            A[2] = num.Numero7;
            A[3] = num.Numero8;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma2 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado37 = (" (" + valor10 + " "+f1+-valor11+" ) = "+suma2);
            }
            return num.Resultado37;
        }
      //-----------------------------------------------------------siguiente paso---------------------------
        //calcular cofactores de Y y Z
        public string valoresYyZ(CalculoMatricial num)
        {
            num.Resultado39 = ("    " + "Y" + "       " + "Z");
            return num.Resultado39;
        }

        public string llenar_primerafila_matrizparaYyZ(CalculoMatricial num)
        {
            num.Resultado41 = ("    " + num.Numero2 + "       " + num.Numero3);
            return num.Resultado41;
        }

        public string llenar_segunda_fila_matrizparaYyZ(CalculoMatricial num)
        {
            num.Resultado42 = ("    " + num.Numero8 + "       " + num.Numero9);
            return num.Resultado42;
        }
        //Multiplicar valores de Y y Z
        public string Multiplicar_valoresXyZ(CalculoMatricial num)
        {
            num.Resultado43 = ("  [(" + num.Numero2 + ") (" + num.Numero9 + ")  -  (" + num.Numero3 + ") (" + num.Numero8 + ")] ");
            return num.Resultado43;
        }

        // hallar el resultado
        public string ingresarcofactoresdeYyZ_hllarelresultado(CalculoMatricial num)
        {
            int[] A = { num.Numero2, num.Numero3, num.Numero8, num.Numero9 };
            A[0] = num.Numero2;
            A[1] = num.Numero3;
            A[2] = num.Numero8;
            A[3] = num.Numero9;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma3 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado40 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma3);
            }
            return num.Resultado40;
        }

        //-------------------------------------------------------Siuiente paso------------------------
        //calcular cofactores de X y Z
        public string valores_XyZ(CalculoMatricial num)
        {
            num.Resultado44 = ("    " + "X" + "       " + "Z");
            return num.Resultado44;
        }
        
        public string llenar_primera_fila_paraXyz(CalculoMatricial num)
        {
            num.Resultado45 = ("    " + num.Numero1 + "       " + num.Numero3);
            return num.Resultado45;
        }

        public string llenar_segunda_fila_paraXyz(CalculoMatricial num)
        {
            num.Resultado46 = ("    " + num.Numero7 + "       " + num.Numero9);
            return num.Resultado46;
        }
        //Multiplcar valores de XyZ

        public string multipilcar_valores_de_XyZ(CalculoMatricial num)
        {
            num.Resultado47 = ("  [(" + num.Numero1 + ") (" + num.Numero9 + ")  -  (" + num.Numero3 + ") (" + num.Numero7 + ")] ");
            return num.Resultado47;
        }
        //hallar resultado de X y Z
        public string hallar_resultado_de_Xyz(CalculoMatricial num)
        {

            int[] A = { num.Numero1, num.Numero3, num.Numero7, num.Numero9 };
            A[0] = num.Numero1;
            A[1] = num.Numero3;
            A[2] = num.Numero7;
            A[3] = num.Numero9;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma4 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado48 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma4);
            }
            return num.Resultado48;
        }

        //-------------------------------------------Siguiente paso-----------------------------------------------
        //calcular cofactores de X Y Y
        public string valores_de_XyY(CalculoMatricial num)
        {
            num.Resultado49 = ("    " + "X" + "       " + "Y");
            return num.Resultado49;
        }

        public string LLenar_primera_fila_paraXyY(CalculoMatricial num)
        {
            num.Resultado49 = ("    " + num.Numero1 + "       " + num.Numero2);
            return num.Resultado49;
        }

        public string llenar_segunda_fila_paraXyY(CalculoMatricial num)
        {
            num.Resultado50 = ("    " + num.Numero7 + "       " + num.Numero8);
            return num.Resultado50;
        }
        //Multiplicar valores de XyY
        public string Multipllicar_valores_de_XyY(CalculoMatricial num)
        {
            num.Resultado51 = ("  [(" + num.Numero1 + ") (" + num.Numero8 + ")  -  (" + num.Numero2 + ") (" + num.Numero7 + ")] ");
            return num.Resultado51;
        }
        //hallar resultado de XyY
        public string resultado_de_XyY(CalculoMatricial num)
        {
            int[] A = { num.Numero1, num.Numero2, num.Numero7, num.Numero8 };
            A[0] = num.Numero1;
            A[1] = num.Numero2;
            A[2] = num.Numero7;
            A[3] = num.Numero8;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma5 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado52 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma5);
            }
            return num.Resultado52;
        }

        //-------------------------------------------------------------------------Suiente paso--------------------
        //calcular cofactores de YyZ
        public string Vlores_de_Yyz(CalculoMatricial num)
        {
            num.Resultado53 = ("    " + "Y" + "       " + "Z");
            return num.Resultado53;
        }
        public string LLenar_primera_fila_paraYyZ(CalculoMatricial num)
        {
            num.Resultado54 = ("    " + num.Numero2 + "       " + num.Numero3);
            return num.Resultado54;
        }
        public string LLenar_segunda_fila_paraYyZ(CalculoMatricial num)
        {
            num.Resultado55 = ("    " + num.Numero5 + "       " + num.Numero6);
            return num.Resultado55;
        }
        //Multiplicar valores de Yyz
        public string multiplicar_valores_de_XyZ(CalculoMatricial num)
        {
            num.Resultado56 = ("  [(" + num.Numero2 + ") (" + num.Numero6 + ")  -  (" + num.Numero3 + ") (" + num.Numero5 + ")] ");
            return num.Resultado56;
        }
        //hallar resultado de XyZ
        public string hallar_resultado_deYyZ(CalculoMatricial num)
        {

            int[] A = { num.Numero2, num.Numero3, num.Numero5, num.Numero6 };
            A[0] = num.Numero2;
            A[1] = num.Numero3;
            A[2] = num.Numero5;
            A[3] = num.Numero6;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma6 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado57 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma6);
            }
            return num.Resultado57;

        }
        //------------------------------------------------Siguiente paso--------------------------------------
        //calcular cofctores de XyZ
        public string Valores_deXyZ(CalculoMatricial num)
        {
            num.Resultado58 = ("    " + "X" + "       " + "Z");
            return num.Resultado58;
        }
        public string LLenar_primera_fila_paraXyZ(CalculoMatricial num)
        {
            num.Resultado59 = ("    " + num.Numero1 + "       " + num.Numero3);
            return num.Resultado59;
        }
        public string LLenar_segunda_fila_paraXyZ(CalculoMatricial num)
        {
            num.Resultado60 = ("    " + num.Numero4 + "       " + num.Numero6);
            return num.Resultado60;
        }
        //Multiplicar valores de XyZ
        public string Multiplicar_valores_deXyz(CalculoMatricial num)
        {
            num.Resultado61 = ("  [(" + num.Numero1 + ") (" + num.Numero6 + ")  -  (" + num.Numero3 + ") (" + num.Numero4 + ")] ");
            return num.Resultado61;
        }
        //hallar resultado de XyZ
        public string Resultado_deXyZ(CalculoMatricial num)
        {
            int[] A = { num.Numero1, num.Numero3, num.Numero4, num.Numero6 };
            A[0] = num.Numero1;
            A[1] = num.Numero3;
            A[2] = num.Numero4;
            A[3] = num.Numero6;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma7 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado62 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma7);
            }
            return num.Resultado62;
        }

        //------------------------------------------------sguiente paso-----------------------
        //calcular cofactores de X y Y
        public string Valores_deXyY(CalculoMatricial num)
        {
            num.Resultado63 = ("    " + "X" + "       " + "Y");
            return num.Resultado63;
        }
        public string LLenar_primera_fila_paraXyy(CalculoMatricial num)
        {
            num.Resultado64 = ("    " + num.Numero1 + "       " + num.Numero2);
            return num.Resultado64;
        }

        public string LLenar_segunda_fila_paraXyy(CalculoMatricial num)
        {
            num.Resultado65 = ("    " + num.Numero4 + "       " + num.Numero5);
            return num.Resultado65;
        }
        public string Multiplicar_valores_deXyy(CalculoMatricial num)
        {
            num.Resultado66 = ("  [(" + num.Numero1 + ") (" + num.Numero5 + ")  -  (" + num.Numero2 + ") (" + num.Numero4 + ")] ");
            return num.Resultado66;
        }
        //Hallar resultado para X y Y

        public string Resultado_deXyY(CalculoMatricial num)
        {
            int[] A = { num.Numero1, num.Numero2, num.Numero4, num.Numero5 };
            A[0] = num.Numero1;
            A[1] = num.Numero2;
            A[2] = num.Numero4;
            A[3] = num.Numero5;
            for (int x = 0; x < A.Length; x++)
            {
                valor6 = A[0];
                valor7 = A[1];
                valor8 = A[2];
                valor9 = A[3];
                valor10 = valor6 * valor9;
                valor11 = valor7 * valor8;
                if (valor11 > 0)
                {
                    f1 = " ";
                }
                else
                {
                    f1 = "+";
                }
                suma8 = valor10 + -valor11;
            }
            for (int x = 0; x < A.Length; x++)
            {
                num.Resultado67 = (" (" + valor10 + " " + f1 + -valor11 + " ) = " + suma8);
            }
            return num.Resultado67;
        }
        //-----------------------------------HAORA SE TIENEN LOS NUEVE COFACTORES -------------------

        public string cofactores(CalculoMatricial num)
        {
            num.Resultado68 = (" CF(1)   " + num.Resultado29 + "  CF(2)     " + suma1 + "   CF(3)    " + suma2);
            return num.Resultado68;
        }
        public string cofactores1(CalculoMatricial num)
        {
            num.Resultado69 = (" CF(4)   " + suma3 + "  CF(5)     " + suma4 + "   CF(6)    " + suma5);
            return num.Resultado69;
        }

        public string cofactores2(CalculoMatricial num)
        {
            num.Resultado70 = (" CF(7)   " + suma6 + "  CF(8)     " + suma7 + "   CF(9)    " + suma8);
            return num.Resultado70;
        }
        //---------------------------generar matriz con los cofactores----------------------------------
        public string cofactores_primera_fila(CalculoMatricial num)
        {
            num.Resultado71 = ("    " + num.Resultado29 + "       " + suma3 + "       " + suma6);
            return num.Resultado71;
        }

        public string cofactores_segunda_fila(CalculoMatricial num)
        {
            num.Resultado72 = ("    " + suma1 + "       " + suma4 + "       " + suma7);
            return num.Resultado72;
        }

        public string cofactores_tercera_fila(CalculoMatricial num)
        {
            num.Resultado73 = ("    " + suma2 + "       " + suma5 + "       " + suma8);
            return num.Resultado73;
        }
        //regla cofactores
        public string cofactores_cambio_signo(CalculoMatricial num)
        {            
            if (suma3 > 0)
            {
                a = " ";
            }
            else
            {
                a = "+";
            }
            num.Resultado74 = ("    " + num.Resultado29 + "       "+ -suma3 + "       " + suma6);
            return num.Resultado74;
        }

        public string cofactores_cambio_signo1(CalculoMatricial num)
        {
           
            if (suma1 > 0)
            {
                a = " ";
            }
            else
            {
                a = "+";
            }
            if (suma7 > 0)
            {
                a = " ";
            }
            else
            {
                a = "+";
            }
            num.Resultado75 = ("    " +-suma1 + "       " +suma4 + "       " +-suma7);
            return num.Resultado75;
        }

        public string cofactores_cambio_signo2(CalculoMatricial num)
        {
            
            if (suma5 > 0)
            {
                a = " ";
            }
            else
            {
                a = "+";
            }
            num.Resultado76 = ("    " + suma2 + "       " +-suma5 + "       " + suma8);
            return num.Resultado76;
        }
        //dividir por el reciproco del determinante 
        public string dividir_determinante(CalculoMatricial num)
        {
           

            num.Resultado77 = ("    " +num.Resultado29+ " / "+suma+"      "+-suma3+" / "+suma+"      "+suma6+" / "+suma);
            return num.Resultado77;
        }
        public string dividir_sobre_determinante(CalculoMatricial num)
        {

            num.Resultado78 = ("    " + -suma1 + " / " + suma + "      " + suma4 + " / " + suma + "      " + -suma7 + " / " + suma);
            return num.Resultado78;
        }

        public string dividir_sobre_determinantes(CalculoMatricial num)
        {

            num.Resultado79 = ("    " + suma2 + " / " + suma + "      " + -suma5 + " / " + suma + "      " + suma8 + " / " + suma);
            return num.Resultado79;
        }
        //------------------------------------Resultado de la matriz inversa-------------------------------------------------------------------
        public string resultado_primerafila(CalculoMatricial num)
        {

          
         double A, A1, A2;
                A = num.Resultado29;
                A1 = suma;
                A2 = A / A1;
                string P;             
               P = "" + string.Format("{0:n1}", (Math.Round(A2 * 100) / 100) - 0);
            if (A2 % 1 == 0)
            {
                P = "" + string.Format("{0:}", (Math.Round(A2 * 100) / 100) - 0);
            }      
                                 
        double A4, A5, A6;
            A4 = -suma3;
            A5 = suma;
            A6 = A4 / A5;
            string p1;
            p1 = "" + string.Format("{0:n1}", (Math.Round(A6 * 100) / 100) - 0);
            if (A6 % 1 == 0)
            {
               p1 = "" + string.Format("{0:}", (Math.Round(A6 * 100) / 100) - 0);
            }

         double A7, A8, A9;
            A7 = suma6;
            A8 = suma;
            A9 = A7 / A8;
            string valor;
            valor = "" + string.Format("{0:n1}", (Math.Round(A9 * 100) / 100) - 0);
            if (A9 % 1 == 0)
            {
                valor = "" + string.Format("{0:}", (Math.Round(A9 * 100) / 100) - 0);
            }           

          num.Resultado80 = "" + P + "    " + p1 + "    " + valor;           
           
            return num.Resultado80;
        }
        public string resultado_segundafila(CalculoMatricial num)
        {
            double A, A1, A2;
            A = -suma1;
            A1 = suma;
            A2 = A / A1;
            string p;
            p = "" + string.Format("{0:n1}", (Math.Round(A2 * 100) / 100) - 0);
            if (A2 % 1 == 0)
            {
                p = "" + string.Format("{0:}", (Math.Round(A2 * 100) / 100) - 0);
            }

            double A4, A5, A6;
            A4 = suma4;
            A5 = suma;
            A6 = A4 / A5;
            string p1;
            p1 = "" + string.Format("{0:n1}", (Math.Round(A6 * 100) / 100) - 0);
            if (A6 % 1 == 0)
            {
                p1 = "" + string.Format("{0:}", (Math.Round(A6 * 100) / 100) - 0);
            }

            double A7, A8, A9;
            A7 = -suma7;
            A8 = suma;
            A9 = A7 / A8;
            string valor;
            valor = "" + string.Format("{0:n1}", (Math.Round(A9 * 100) / 100) - 0);
            if (A9 % 1 == 0)
            {
                valor = "" + string.Format("{0:}", (Math.Round(A9 * 100) / 100) - 0);
            }
            num.Resultado81 = ("" + p + "    " + p1 + "    " + valor);
            return num.Resultado81;
        }
        public string resultado_tercerafila(CalculoMatricial num)
        {
            double A, A1, A2;
            A = suma2;
            A1 = suma;
            A2 = A / A1;
            string p;
            p = "" + string.Format("{0:n1}", (Math.Round(A2 * 100) / 100) - 0);
            if (A2 % 1 == 0)
            {
                p = "" + string.Format("{0:}", (Math.Round(A2 * 100) / 100) - 0);
            }

            double A4, A5, A6;
            A4 = -suma5;
            A5 = suma;
            A6 = A4 / A5;
            string p1;
            p1 = "" + string.Format("{0:n1}", (Math.Round(A6 * 100) / 100) - 0);
            if (A6 % 1 == 0)
            {
                p1 = "" + string.Format("{0:}", (Math.Round(A6 * 100) / 100) - 0);
            }
                       
            double A7, A8, A9;
            A7 = suma8;
            A8 = suma;
            A9 = A7 / A8;
            string valor;
            valor = "" + string.Format("{0:n1}", (Math.Round(A9 * 100) / 100) - 0);
            if (A9 % 1 == 0)
            {
                valor = "" + string.Format("{0:}", (Math.Round(A9 * 100) / 100) - 0);
            }

            num.Resultado82 = ("" + p + "    " + p1 + "    " + valor);
            return num.Resultado82;
        }
    }
}



