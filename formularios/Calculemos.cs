using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace algebra.formularios
{
    public class Calculemos
    {
        //resolver el sistema de ecuaciones con tres incognitas por el metodo de Gauss Jordan
        public int calcular1(MetodoDeGaussJordan num)
        {
            //Primera incognita
            //se ingresa numero 1 en el textbox en X
            num.Resultado1 = num.Numero1;
            return num.Resultado1;
        }
        public int calcular2(MetodoDeGaussJordan num)
        {
            //se ingresa numero 2 en el textbox en Y
            num.Resultado2 = num.Numero2;
            return num.Resultado2;
        }

        public int calcular3(MetodoDeGaussJordan num)
        {
            //se ingresa numero 3 en el textbox en Z
            num.Resultado3 = num.Numero3;
            return num.Resultado3;
        }

        public int calcular4(MetodoDeGaussJordan num)
        {
            //seguda inconita
            //se ingresa numero 4 en el textbox
            num.Resultado4 = num.Numero4;
            return num.Resultado4;
        }

        public int calcular5(MetodoDeGaussJordan num)
        {
            //se ingresa numero 5 en el textbox
            num.Resultado5 = num.Numero5;
            return num.Resultado5;
        }

        public int calcular6(MetodoDeGaussJordan num)
        {
            //se ingresa numero 6 en el textbox
            num.Resultado6 = num.Numero6;
            return num.Resultado6;
        }
        public int calcular7(MetodoDeGaussJordan num)
        {
            //se ingresa numero 7 en el textbox
            num.Resultado7 = num.Numero7;
            return num.Resultado7;
        }
        public int calcular8(MetodoDeGaussJordan num)
        {
            //se ingresa numero 8 en el textbox
            num.Resultado8 = num.Numero8;
            return num.Resultado8;
        }
        public int calcular9(MetodoDeGaussJordan num)
        {
            //se ingresa numero 9 en el textbox
            num.Resultado9 = num.Numero9;
            return num.Resultado9;
        }
        public int calcular10(MetodoDeGaussJordan num)
        {
            //se ingresa numero 10 en el textbox
            num.Resultado10 = num.Numero10;
            return num.Resultado10;
        }
        public int calcular11(MetodoDeGaussJordan num)
        {
            //se ingresa numero 11 en el textbox
            num.Resultado11 = num.Numero11;
            return num.Resultado11;
        }
        public int calcular12(MetodoDeGaussJordan num)
        {
            //se ingresa numero 12 en el textbox
            num.Resultado12 = num.Numero12;
            return num.Resultado12;
        }

        //Se desarrolla las operaciones indicadas
        public int calcular13(MetodoDeGaussJordan num)
        {
            num.Resultado13 = num.Resultado5 * num.Resultado1;
            return num.Resultado13;
        }
        public int calcular14(MetodoDeGaussJordan num)
        {
            num.Resultado14 = num.Resultado5 * num.Resultado2;
            return num.Resultado14;
        }

        public int calcular15(MetodoDeGaussJordan num)
        {
            num.Resultado15 = num.Resultado5 * num.Resultado3;
            return num.Resultado15;
        }
        public int calcular16(MetodoDeGaussJordan num)
        {
            num.Resultado16 = num.Resultado5 * num.Resultado4;
            return num.Resultado16;
        }

        public int calcular17(MetodoDeGaussJordan num)
        {
            if (num.Numero1 > 0)
            {
                
                num.Resultado17 = -num.Numero1;
            }
            else
            {
                num.Resultado17 = -num.Numero1;
            }           
            return num.Resultado17;
        }
        public int calcular18(MetodoDeGaussJordan num)
        {
            num.Resultado18 = num.Resultado17 * num.Resultado5;
            return num.Resultado18;
        }

        public int calcular19(MetodoDeGaussJordan num)
        {
            num.Resultado19 = num.Resultado17 * num.Resultado6;
            return num.Resultado19;
        }

        public int calcular20(MetodoDeGaussJordan num)
        {
            num.Resultado20 = num.Resultado17 * num.Resultado7;
            return num.Resultado20;
        }
        public int calcular21(MetodoDeGaussJordan num)
        {
            num.Resultado21 = num.Resultado17 * num.Resultado8;
            return num.Resultado21;
        }
        public int calcular22(MetodoDeGaussJordan num)
        {
            num.Resultado22 = num.Resultado13 + num.Resultado18;
            return num.Resultado22;
        }

        public int calcular23(MetodoDeGaussJordan num)
        {
            num.Resultado23 = num.Resultado14 + num.Resultado19;
            return num.Resultado23;
        }
        public int calcular24(MetodoDeGaussJordan num)
        {
            num.Resultado24 = num.Resultado15 + num.Resultado20;
            return num.Resultado24;
        }
        public int calcular25(MetodoDeGaussJordan num)
        {
            num.Resultado25 = num.Resultado16 + num.Resultado21;
            return num.Resultado25;
        }
        //Ahora calculamos p1 y p3
        public int calcular26(MetodoDeGaussJordan num)
        {
            if (num.Numero9 > 0)
            {

                num.Resultado26 = -num.Numero9;
            }
            else
            {
                num.Resultado26 = -num.Numero9;
            }
            return num.Resultado26;
        }
        public int calcular27(MetodoDeGaussJordan num)
        {
            num.Resultado27 = num.Resultado26 * num.Resultado1;
            return num.Resultado27;
        }
        public int calcular28(MetodoDeGaussJordan num)
        {
            num.Resultado28 = num.Resultado26 * num.Resultado2;
            return num.Resultado28;
        }
        public int calcular29(MetodoDeGaussJordan num)
        {
            num.Resultado29 = num.Resultado26 * num.Resultado3;
            return num.Resultado29;
        }
        public int calcular30(MetodoDeGaussJordan num)
        {
            num.Resultado30 = num.Resultado26 * num.Resultado4;
            return num.Resultado30;
        }
        ////
        public int calcular31(MetodoDeGaussJordan num)
        {
            num.Resultado31 = num.Resultado1 * num.Resultado9;
            return num.Resultado31;
        }

        public int calcular32(MetodoDeGaussJordan num)
        {
            num.Resultado32 = num.Resultado1 * num.Resultado10;
            return num.Resultado32;
        }

        public int calcular33(MetodoDeGaussJordan num)
        {
            num.Resultado33 = num.Resultado1 * num.Resultado11;
            return num.Resultado33;
        }

        public int calcular34(MetodoDeGaussJordan num)
        {
            num.Resultado34 = num.Resultado1 * num.Resultado12;
            return num.Resultado34;
        }

        ////
        public int calcular35(MetodoDeGaussJordan num)
        {
            num.Resultado35 = num.Resultado27 + num.Resultado31;
            return num.Resultado35;
        }
        public int calcular36(MetodoDeGaussJordan num)
        {
            num.Resultado36 = num.Resultado28 + num.Resultado32;
            return num.Resultado36;
        }
        public int calcular37(MetodoDeGaussJordan num)
        {
            num.Resultado37 = num.Resultado29 + num.Resultado33;
            return num.Resultado37;
        }
        public int calcular38(MetodoDeGaussJordan num)
        {
            num.Resultado38 = num.Resultado30 + num.Resultado34;
            return num.Resultado38;
        }

        //CALCULAR R3 , R6
        public int calcular39(MetodoDeGaussJordan num)
        {
            if (num.Resultado36 > 0)
            {

                num.Resultado39 = -num.Resultado36;
            }
            else
            {
                num.Resultado39 = -num.Resultado36;
            }
            return num.Resultado39;
            
         }
        //Desarrollar las operaciones idicacadas 
        public int calcular40(MetodoDeGaussJordan num)
        {
            num.Resultado40 = num.Resultado39 * num.Resultado22;
            return num.Resultado40;
        }
        public int calcular41(MetodoDeGaussJordan num)
        {
            num.Resultado41 = num.Resultado39 * num.Resultado23;
            return num.Resultado41;
        }
        public int calcular42(MetodoDeGaussJordan num)
        {
            num.Resultado42 = num.Resultado39 * num.Resultado24;
            return num.Resultado42;
        }
        public int calcular43(MetodoDeGaussJordan num)
        {
            num.Resultado43 = num.Resultado39 * num.Resultado25;
            return num.Resultado43;
        }
        //desarrollar las operaciones de r3 y r6
        public int calcular44(MetodoDeGaussJordan num)
        {
            num.Resultado44 = num.Resultado23 * num.Resultado35;
            return num.Resultado44;
        }
        public int calcular45(MetodoDeGaussJordan num)
        {
            num.Resultado45 = num.Resultado23 * num.Resultado36;
            return num.Resultado45;
        }
        public int calcular46(MetodoDeGaussJordan num)
        {
            num.Resultado46 = num.Resultado23 * num.Resultado37;
            return num.Resultado46;
        }
        public int calcular47(MetodoDeGaussJordan num)
        {
            num.Resultado47 = num.Resultado23 * num.Resultado38;
            return num.Resultado47;
        }
        //desarollar las operaciones entre R7 , R8
        public int calcular48(MetodoDeGaussJordan num)
        {
            num.Resultado48 = num.Resultado40 + num.Resultado44;
            return num.Resultado48;
        }
        public int calcular49(MetodoDeGaussJordan num)
        {
            num.Resultado49 = num.Resultado41 + num.Resultado45;
            return num.Resultado49;
        }
        public int calcular50(MetodoDeGaussJordan num)
        {
            num.Resultado50 = num.Resultado42 + num.Resultado46;
            return num.Resultado50;
        }
        public int calcular51(MetodoDeGaussJordan num)
        {
            num.Resultado51 = num.Resultado43 + num.Resultado47;
            return num.Resultado51;
        }
        //simplificamos
        public int calcular52(MetodoDeGaussJordan num)
        {
            num.Resultado52 = num.Resultado50 / num.Resultado50;
            return num.Resultado52;
        }
        public double calcular53(MetodoDeGaussJordan num)
        {
            num.Resultado53 = num.Resultado51 / num.Resultado50;
            return num.Resultado53;
        }
        //calcular r3,r10
        public int calcular54(MetodoDeGaussJordan num)
        {
            if (num.Resultado52 > 0)
            {

                num.Resultado54 = -num.Resultado52;
            }
            else
            {
                num.Resultado54 = -num.Resultado52;
            }
            return num.Resultado54;
        }
        //desarrolar las operaciones indicadas
        public int calcular55(MetodoDeGaussJordan num)
        {
            num.Resultado55 = num.Resultado54 * num.Resultado22;
            return num.Resultado55;
        }
        public int calcular56(MetodoDeGaussJordan num)
        {
            num.Resultado56 = num.Resultado54 * num.Resultado23;
            return num.Resultado56;
        }
        public int calcular57(MetodoDeGaussJordan num)
        {
            num.Resultado57 = num.Resultado54 * num.Resultado24;
            return num.Resultado57;
        }
        public int calcular58(MetodoDeGaussJordan num)
        {
            num.Resultado58 = num.Resultado54 * num.Resultado25;
            return num.Resultado58;
        }
        ///
        public int calcular59(MetodoDeGaussJordan num)
        {
            num.Resultado59 = num.Resultado24 * num.Resultado48;
            return num.Resultado59;
        }
        public int calcular60(MetodoDeGaussJordan num)
        {
            num.Resultado60 = num.Resultado24 * num.Resultado49;
            return num.Resultado60;
        }
        public int calcular61(MetodoDeGaussJordan num)
        {
            num.Resultado61 = num.Resultado24 * num.Resultado52;
            return num.Resultado61;
        }
        public int calcular62(MetodoDeGaussJordan num)
        {
            num.Resultado62 = num.Resultado24 * num.Resultado53;
            return num.Resultado62;
        }
        //Desarrollar las operaciones entre r11 y r12
        public int calcular63(MetodoDeGaussJordan num)
        {
            num.Resultado63 = num.Resultado55 + num.Resultado59;
            return num.Resultado63;
        }
        public int calcular64(MetodoDeGaussJordan num)
        {
            num.Resultado64 = num.Resultado56 + num.Resultado60;
            return num.Resultado64;
        }
        public int calcular65(MetodoDeGaussJordan num)
        {
            num.Resultado65 = num.Resultado57 + num.Resultado61;
            return num.Resultado65;
        }
        public int calcular66(MetodoDeGaussJordan num)
        {
            num.Resultado66 = num.Resultado58 + num.Resultado62;
            return num.Resultado66;
        }
        //simplificamos
        public int calcular67(MetodoDeGaussJordan num)
        {
            num.Resultado67 = num.Resultado64 / num.Resultado64;
            return num.Resultado67;
        }
        public int calcular68(MetodoDeGaussJordan num)
        {
            num.Resultado68 = num.Resultado66 / num.Resultado64;
            return num.Resultado68;
        }
        //desarrollar las operaciones indicadas 
        public int calcular69(MetodoDeGaussJordan num)
        {
            num.Resultado69 = num.Resultado54 * num.Resultado1;
            return num.Resultado69;
        }
        public int calcular70(MetodoDeGaussJordan num)
        {
            num.Resultado70 = num.Resultado54 * num.Resultado2;
            return num.Resultado70;
        }
        public int calcular71(MetodoDeGaussJordan num)
        {
            num.Resultado71 = num.Resultado54 * num.Resultado3;
            return num.Resultado71;
        }
        public int calcular72(MetodoDeGaussJordan num)
        {
            num.Resultado72 = num.Resultado54 * num.Resultado4;
            return num.Resultado72;
        }
        //calcilar f5
        public int calcular73(MetodoDeGaussJordan num)
        {
            num.Resultado73 = num.Resultado3 * num.Resultado48;
            return num.Resultado73;
        }
        public int calcular74(MetodoDeGaussJordan num)
        {
            num.Resultado74 = num.Resultado3 * num.Resultado49;
            return num.Resultado74;
        }
        public int calcular75(MetodoDeGaussJordan num)
        {
            num.Resultado75 = num.Resultado3 * num.Resultado52;
            return num.Resultado75;
        }
        public int calcular76(MetodoDeGaussJordan num)
        {
            num.Resultado76 = num.Resultado3 * num.Resultado53;
            return num.Resultado76;
        }
        //Desarrollar las operaciones entre R12 Y R13
        public int calcular77(MetodoDeGaussJordan num)
        {
            num.Resultado77 = num.Resultado69 + num.Resultado73;
            return num.Resultado77;
        }
        public int calcular78(MetodoDeGaussJordan num)
        {
            num.Resultado78 = num.Resultado70 + num.Resultado74;
            return num.Resultado78;
        }
        public int calcular79(MetodoDeGaussJordan num)
        {
            num.Resultado79 = num.Resultado71 + num.Resultado75;
            return num.Resultado79;
        }
        public int calcular80(MetodoDeGaussJordan num)
        {
            num.Resultado80 = num.Resultado72 + num.Resultado76;
            return num.Resultado80;
        }
    }
} 