using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace algebra.formularios
{
    public class Calculo
    {
        public int CalCulemos(MetodoDeCramer num)
        {
            //ingresamos valores 
            num.Resultado1 = num.Numero1;
            return num.Resultado1;
        }
        public int CalCulemos1(MetodoDeCramer num)
        {

            num.Resultado2 = num.Numero2;
            return num.Resultado2;
        }

        public int CalCulemos2(MetodoDeCramer num)
        {
            num.Resultado3 = num.Numero3;
            return num.Resultado3;
        }

        public int CalCulemos3(MetodoDeCramer num)
        {
            num.Resultado4 = num.Numero4;
            return num.Resultado4;
        }

        public int CalCulemos5(MetodoDeCramer num)
        {
            num.Resultado5 = num.Numero5;
            return num.Resultado5;
        }

        public int CalCulemos6(MetodoDeCramer num)
        {
            num.Resultado6 = num.Numero6;
            return num.Resultado6;
        }

        public int CalCulemos7(MetodoDeCramer num)
        {
            num.Resultado7 = num.Numero7;
            return num.Resultado7;
        }

        public int CalCulemo8(MetodoDeCramer num)
        {
            num.Resultado8 = num.Numero8;
            return num.Resultado8;
        }
        public int CalCulemos9(MetodoDeCramer num)
        {
            num.Resultado9 = num.Numero9;
            return num.Resultado9;
        }
        public int CalCulemos10(MetodoDeCramer num)
        {
            num.Resultado10 = num.Numero10;
            return num.Resultado10;
        }
        public int CalCulemos11(MetodoDeCramer num)
        {
            num.Resultado11 = num.Numero11;
            return num.Resultado11;
        }

        public int CalCulemos12(MetodoDeCramer num)
        {
            num.Resultado12 = num.Numero12;
            return num.Resultado12;
        }
        //hallar la determinante ΔS y desarrollar las operaciones indicadas de la matriz y,z 

        public int CalCulemos13(MetodoDeCramer num)
        {
            num.Resultado13 = num.Resultado6 * num.Resultado11;
            return num.Resultado13;
        }

        public int CalCulemos14(MetodoDeCramer num)
        {
            num.Resultado14 = num.Resultado7 * num.Resultado10;
            return num.Resultado14;
        }

        public int CalCulemos15(MetodoDeCramer num)
        {
            num.Resultado15 = num.Resultado13 + -num.Resultado14;
            return num.Resultado15;
        }

        public int CalCulemos16(MetodoDeCramer num)
        {
            num.Resultado16 = num.Numero1 * num.Resultado15;
            return num.Resultado16;
        }
        //Se ingresa una nueva matriz para los valores de X , Z Y desarrollar las operaciones indicadas

        public int CalCulemos17(MetodoDeCramer num)
        {
            num.Resultado17 = num.Numero5 * num.Numero11;
            return num.Resultado17;
        }
        public int CalCulemos18(MetodoDeCramer num)
        {
            num.Resultado18 = num.Numero7 * num.Numero9;
            return num.Resultado18;
        }
        public int CalCulemos19(MetodoDeCramer num)
        {
            num.Resultado19 = num.Resultado17 + -num.Resultado18;
            return num.Resultado19;
        }
        //resultado de la nueva matriz
        public int CalCulemos20(MetodoDeCramer num)
        {                

            if (num.Numero2 >0)
            {
                num.Resultado20 = -num.Numero2 * num.Resultado19;
            }
            else
            {
                num.Resultado20 = -num.Numero2 * num.Resultado19;
            }
            return num.Resultado20;
        }
        //llenar una cuarta matriz con los valores X , Y De la primera matriz
        public int CalCulemos21(MetodoDeCramer num)
        {
            num.Resultado21 = num.Resultado5 * num.Resultado10;
            return num.Resultado21;
        }
        public int CalCulemos22(MetodoDeCramer num)
        {
            num.Resultado22 = num.Resultado6 * num.Resultado9;
            return num.Resultado22;
        }
        public int CalCulemos23(MetodoDeCramer num)
        {
            num.Resultado23 = num.Resultado21 + -num.Resultado22;
            return num.Resultado23;
        }

        public int CalCulemos24(MetodoDeCramer num)
        {

            if (num.Numero3 > 0)
            {
                num.Resultado24 = num.Numero3 * num.Resultado23;
            }
            else
            {
                num.Resultado24 = num.Numero3 * num.Resultado23;
            }
            return num.Resultado24;
        }
        //hallar resultado delta de s
        public int CalCulemos25(MetodoDeCramer num)
        {
            num.Resultado25 = num.Resultado16 + num.Resultado20 + num.Resultado24;
            return num.Resultado25;
        }

        //hallar del delta de X , resultado de la nueva matriz con los valores de Y Z
        //Desarrollar las operaciones indicadas
        public int CalCulemos26(MetodoDeCramer num)
        {
            num.Resultado26 = num.Resultado13 + -num.Resultado14;
            return num.Resultado26;
        }
        public int CalCulemos27(MetodoDeCramer num)
        {
            num.Resultado27 = num.Numero4 * num.Resultado26;
            return num.Resultado27;
        }

        public int CalCulemos28(MetodoDeCramer num)
        {
            num.Resultado28 = num.Numero8 * num.Numero11;
            return num.Resultado28;
        }

        public int CalCulemos29(MetodoDeCramer num)
        {
            num.Resultado29 = num.Numero7 * num.Numero12;
            return num.Resultado29;
        }

        public int CalCulemos30(MetodoDeCramer num)
        {
            num.Resultado30 = num.Resultado28 + -num.Resultado29;
            return num.Resultado30;
        }

        public int CalCulemos31(MetodoDeCramer num)
        {
            if (num.Numero2 > 0)
            {
                num.Resultado31 = -num.Numero2 * num.Resultado30;
            }
            else
            {
                num.Resultado31 = -num.Numero2 * num.Resultado30;
            }
            return num.Resultado31;
        }
        //desarrollar las operaciones de la nueva matriz de delta de X

        public int CalCulemos32(MetodoDeCramer num)
        {
            num.Resultado32 = num.Numero8 * num.Numero10;
            return num.Resultado32;
        }

        public int CalCulemos33(MetodoDeCramer num)
        {
            num.Resultado33 = num.Numero6 * num.Numero12;
            return num.Resultado33;
        }

        public int CalCulemos34(MetodoDeCramer num)
        {
            num.Resultado34 = num.Resultado32 + -num.Resultado33;
            return num.Resultado34;
        }

        public int CalCulemos35(MetodoDeCramer num)
        {

            if (num.Numero3 > 0)
            {
                num.Resultado35 = num.Numero3 * num.Resultado34;
            }
            else
            {
                num.Resultado35 = num.Numero3 * num.Resultado34;
            }
            return num.Resultado35;
        }
        //Una vez desarrolladas las operaciones indicadas se procede a hallar el resultado delta de X
        public int CalCulemos36(MetodoDeCramer num)
        {
            num.Resultado36 = num.Resultado27 + num.Resultado31 + num.Resultado35;
            return num.Resultado36;
        }
        //luego de haber encontrado delta de X se porcede a desarrollar la operacion indicada (delta de x / delta de y)
        //diviendo los dos valores se dara como resultado el valor de X
        public double CalCulemos37(MetodoDeCramer num)
        {
            double valor, valor1, valor3;
            valor = num.Resultado36;
            valor1 = num.Resultado25;
            valor3 = valor / valor1;
            num.Resultado37 = valor3;
            return num.Resultado37;
        }

        //Hallar delta de Y las operaciones indicadas
        public int CalCulemos38(MetodoDeCramer num)
        {
            num.Resultado38 = num.Numero8 * num.Numero11;
            return num.Resultado38;
        }

        public int CalCulemos39(MetodoDeCramer num)
        {
            num.Resultado39 = num.Numero7 * num.Numero12;
            return num.Resultado39;
        }
        public int CalCulemos40(MetodoDeCramer num)
        {
            num.Resultado40 = num.Resultado38 + -num.Resultado39;
            return num.Resultado40;
        }

        public int CalCulemos41(MetodoDeCramer num)
        {
            num.Resultado41 = num.Numero1 * num.Resultado40;
            return num.Resultado41;
        }

        public int CalCulemos42(MetodoDeCramer num)
        {
            num.Resultado42 = num.Numero5 * num.Numero11;
            return num.Resultado42;
        }

        public int CalCulemos43(MetodoDeCramer num)
        {
            num.Resultado43 = num.Numero7 * num.Numero9;
            return num.Resultado43;
        }
        public int CalCulemos44(MetodoDeCramer num)
        {
            num.Resultado44 = num.Resultado42 + -num.Resultado43;
            return num.Resultado44;
        }
        public int CalCulemos45(MetodoDeCramer num)
        {
            if (num.Numero4 > 0)
            {
                num.Resultado45 = -num.Numero4 * num.Resultado44;
            }
            else
            {
                num.Resultado45 = -num.Numero4 * num.Resultado44;
            }
            return num.Resultado45;
        }
        public int CalCulemos46(MetodoDeCramer num)
        {
            num.Resultado46 = num.Numero5 * num.Numero12;
            return num.Resultado46;
        }
        public int CalCulemos47(MetodoDeCramer num)
        {
            num.Resultado47 = num.Numero8 * num.Numero9;
            return num.Resultado47;
        }
        public int CalCulemos48(MetodoDeCramer num)
        {
            num.Resultado48 = num.Resultado46 + -num.Resultado47;
            return num.Resultado48;
        }

        public int CalCulemos49(MetodoDeCramer num)
        {

            if (num.Numero3 > 0)
            {
                num.Resultado49 = num.Numero3 * num.Resultado48;
            }
            else
            {
                num.Resultado49 = num.Numero3 * num.Resultado48;
            }
            return num.Resultado49;
        }
        public int CalCulemos50(MetodoDeCramer num)
        {
            num.Resultado50 = num.Resultado41 + num.Resultado45 + num.Resultado49;
            return num.Resultado50;
        }
        public double CalCulemos51(MetodoDeCramer num)
        {
            double valores, valores1, valores3;
            valores = num.Resultado50;
            valores1 = num.Resultado25;
            valores3 = valores / valores1;
            num.Resultado51 = valores3;
            return num.Resultado51;
        }

        //hallar delta de z y las operaciones indicadas
        public int CalCulemos52(MetodoDeCramer num)
        {
            num.Resultado52 = num.Numero6 * num.Numero12;
            return num.Resultado52;
        }
        public int CalCulemos53(MetodoDeCramer num)
        {
            num.Resultado53 = num.Numero8 * num.Numero10;
            return num.Resultado53;
        }
        public int CalCulemos54(MetodoDeCramer num)
        {
            num.Resultado54 = num.Resultado52 + -num.Resultado53;
            return num.Resultado54;
        }
        public int CalCulemos55(MetodoDeCramer num)
        {
            num.Resultado55 = num.Numero1 * num.Resultado54;
            return num.Resultado55;
        }

        public int CalCulemos56(MetodoDeCramer num)
        {
            num.Resultado56 = num.Numero5 * num.Numero12;
            return num.Resultado56;
        }

        public int CalCulemos57(MetodoDeCramer num)
        {
            num.Resultado57 = num.Numero8 * num.Resultado9;
            return num.Resultado57;
        }
        public int CalCulemos58(MetodoDeCramer num)
        {
            num.Resultado58 = num.Resultado56 + -num.Resultado57;
            return num.Resultado58;
        }
        public int CalCulemos59(MetodoDeCramer num)
        {
            if (num.Numero2 > 0)
            {
                num.Resultado59 = -num.Numero2 * num.Resultado58;
            }
            else
            {
                num.Resultado59 = -num.Numero2 * num.Resultado58;
            }
            return num.Resultado59;
        }
         public int CalCulemos60(MetodoDeCramer num)
        {
            num.Resultado60 = num.Numero5 * num.Numero10;
            return num.Resultado60;
        }
        public int CalCulemos61(MetodoDeCramer num)
        {
            num.Resultado61 = num.Numero6 * num.Numero9;
            return num.Resultado61;
        }
        public int CalCulemos62(MetodoDeCramer num)
        {
            num.Resultado62 = num.Resultado60 + -num.Resultado61;
            return num.Resultado62;
        }
        public int CalCulemos63(MetodoDeCramer num)
        {

            if (num.Numero4 > 0)
            {
                num.Resultado63 = num.Numero4 * num.Resultado62;
            }
            else
            {
                num.Resultado63 = num.Numero4 * num.Resultado62;
            }
            return num.Resultado63;
        }
        public int CalCulemos64(MetodoDeCramer num)
        {
            num.Resultado64 = num.Resultado55 + num.Resultado59 + num.Resultado63;
            return num.Resultado64;
        }
        public double CalCulemos65(MetodoDeCramer num)
        {
            double A, A1, A3;
            A = num.Resultado64;
            A1 = num.Resultado25;
            A3 = A / A1;
            num.Resultado65 = A3;
            return num.Resultado65;
        }
    }
}