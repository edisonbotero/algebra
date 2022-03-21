using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace algebra.formularios
{
    public partial class Inicio : System.Web.UI.Page
    {
        CalculoMatricial metodos = new CalculoMatricial();
        Metodoigualacion igualacion = new Metodoigualacion();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            metodos.Numero1 = Convert.ToInt32(numero1.Text);
           metodos.Numero2 = Convert.ToInt32(numero2.Text);
           metodos.Numero3 = Convert.ToInt32(numero3.Text);
           metodos.Numero4 = Convert.ToInt32(numero4.Text);
           metodos.Numero5 = Convert.ToInt32(numero5.Text);
           metodos.Numero6 = Convert.ToInt32(numero6.Text);
           ecuacion1.Text= (""+ igualacion.ingresovaloresecuacion(metodos));
           despejar.Text= ("" + igualacion.despejarenY(metodos));
           igualarvalores.Text = ("" + igualacion.seigualanlosdosvaloresdexobtenidos(metodos));
           sutituiry.Text = ("" + igualacion.sustituyendovalordey(metodos));


        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            metodos.Numero7 =    Convert.ToInt32(numero7.Text);
            metodos.Numero8 =    Convert.ToInt32(numero8.Text);
            metodos.Numero9 =    Convert.ToInt32(numero9.Text);
            metodos.Numero10 =   Convert.ToInt32(numero10.Text);
            metodos.Numero11 =   Convert.ToInt32(numero11.Text);
            metodos.Numero12 =   Convert.ToInt32(numero12.Text);
            metodos.Numero13 =   Convert.ToInt32(numero13.Text);
            metodos.Numero14 =   Convert.ToInt32(numero14.Text);
            metodos.Numero15 =   Convert.ToInt32(numero15.Text);
            metodos.Numero16 =   Convert.ToInt32(numero16.Text);
            metodos.Numero17 =   Convert.ToInt32(numero17.Text);
            metodos.Numero18 =   Convert.ToInt32(numero18.Text);
            ecuacion2.Text =  ("" + igualacion.ingresoecuacvionesx3incognitas(metodos) );
            transponer1.Text= ("" + igualacion.transponerterminosecuacion1(metodos));           
            Label36.Text = ("(4)");
            Label37.Text = ("(5)");
            Label38.Text = ("(6)");
            Label39.Text = ("Igualar las ecuaciones (4) y (5)");
            transponer5.Text=("" + igualacion.igualarecuacion1y2(metodos));
            multiplicar.Text = ("" + igualacion.multiplicaciondeterminos(metodos));
            multiplicarterminos.Text = ("" + igualacion.resultadomultiplicar(metodos));
            Label19.Text = ("Igualar las ecuaciones (4) y (6)");
            transponer6.Text = ("" + igualacion.igualarecuacion4y6(metodos));
            multiploicarecuaciones4y6.Text = ("" + igualacion.multiplicarecuaciones4y6(metodos));
            Label20.Text = ("Resolver el sistema 2x2 teniendo en cuenta los pasos Ecuacion (7) y (8)");
            Resolverelsistema2x2.Text = ("" + igualacion.resolverelsistema2x2(metodos));
            Label21.Text = ("Igualar ls ecuaciones (7) y (8)");
            igualarecuaciones7y8.Text = ("" + igualacion.Igualarlasecuaciones7y8(metodos));
            Label22.Text = ("para encontrar la variable Y Sustituir Z en caulquiera de las dos ecuaciones  (7) y (8)");
            sustituiren7o8.Text = ("" + igualacion.sustituirencualquieradelasdosecuaciones7y8(metodos));
            Label23.Text = ("para encontrar la variable X Sustituir Y y Z en la ecuacion (1)");
            sustituirprimeraecuaion.Text = ("" + igualacion.sustituirlaprimeraecuacion(metodos));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ecuacion1.Text = "";
           despejar.Text = "";
           igualarvalores.Text = "";
           sutituiry.Text = "";
           numero1.Text = "";
           numero2.Text = "";
           numero3.Text = "";
           numero4.Text = "";
           numero5.Text = "";
           numero6.Text = "";
        }

        protected void numero8_TextChanged(object sender, EventArgs e)
        {
            

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            ecuacion2.Text="";
            transponer1.Text="";
            Label36.Text = "";
            Label37.Text = "";
            Label38.Text = "";
            Label39.Text = "";
            Label19.Text = "";
            transponer5.Text = "";
            transponer6.Text = "";
            multiplicar.Text = "";
            multiplicarterminos.Text = "";
            multiploicarecuaciones4y6.Text = "";
            numero7.Text = "";
            numero8.Text = "";
            numero9.Text = "";
            numero10.Text = "";
            numero11.Text = "";
            numero12.Text = "";
            numero13.Text = "";
            numero14.Text = "";
            numero15.Text = "";
            numero16.Text = "";
            numero17.Text = "";
            numero18.Text = "";
            Label20.Text = "";


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //ecuacion incognita 1
            metodos.Numero1 = Convert.ToInt32(n1.Text);
            metodos.Numero2 = Convert.ToInt32(n2.Text);
            metodos.Numero3 = Convert.ToInt32(n3.Text);
            metodos.Numero4 = Convert.ToInt32(n4.Text);
            metodos.Numero5 = Convert.ToInt32(n5.Text);
            //ecuacion incognita 2
            metodos.Numero6 = Convert.ToInt32(n6.Text);
            metodos.Numero7 = Convert.ToInt32(n7.Text);
            metodos.Numero8 = Convert.ToInt32(n8.Text);
            metodos.Numero9 = Convert.ToInt32(n9.Text);
            metodos.Numero10 = Convert.ToInt32(n10.Text);
            //ecuacion incognita 3
            metodos.Numero11 = Convert.ToInt32(n11.Text);
            metodos.Numero12 = Convert.ToInt32(n12.Text);
            metodos.Numero13 = Convert.ToInt32(n13.Text);
            metodos.Numero14 = Convert.ToInt32(n14.Text);
            metodos.Numero15 = Convert.ToInt32(n15.Text);
            //ecuacion 4
            metodos.Numero16 = Convert.ToInt32(n16.Text);
            metodos.Numero17 = Convert.ToInt32(n17.Text);
            metodos.Numero18 = Convert.ToInt32(n18.Text);
            metodos.Numero19 = Convert.ToInt32(n19.Text);
            metodos.Numero20 = Convert.ToInt32(n20.Text);
            ingresar_valores_incognita1.Text = ("" + igualacion.ingresoecuacionesx4incognitas(metodos));
           
        }
    }
}