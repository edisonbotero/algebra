<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inversa De una Matriz 3x3.aspx.cs" Inherits="algebra.formularios.Inversa_De_una_Matriz_3x3" %>
<!DOCTYPE html>

<html lang="en">
   
<head>
  <title>Matriz Inversa de 3x3</title>
     <style>
  /* Popup container */
.popup {
  position: relative;
  display: inline-block;
  cursor: pointer;
}

/* The actual popup (appears on top) */
.popup .popuptext {
  visibility: hidden;
  width: 300px;
  background-color: #555;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 8px 0;
  position: absolute;
  z-index: 1;
  bottom: 125%;
  left: 50%;
  margin-left: -80px;
}

/* Popup arrow */
.popup .popuptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 50%;
  margin-left: -5px;
  border-width: 5px;
  border-style: solid;
  border-color: #555 transparent transparent transparent;
}

/* Toggle this class when clicking on the popup container (hide and show the popup) */
.popup .show {
  visibility: visible;
  -webkit-animation: fadeIn 1s;
  animation: fadeIn 1s
}

/* Add animation (fade in the popup) */
@-webkit-keyframes fadeIn {
  from {opacity: 0;}
  to {opacity: 1;}
}

@keyframes fadeIn {
  from {opacity: 0;}
  to {opacity:1 ;}
}
</style>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        .auto-style1 {
            margin-top: 22px;
        }

        .auto-style2 {
            width: 30px;
            height: 139px;
        }
        .auto-style3 {
            margin-top: 21px;
        }
        .auto-style4 {
            margin-top: 45px;
        }
        .auto-style5 {
            margin-top: 54px;
            margin-left: 0px;
        }
        .auto-style6 {
            margin-top: 21px;
            width: 37px;
            height: 139px;
        }
        .auto-style7 {
            margin-top: 22px;
            height: 139px;
        }

  

       
        .auto-style8 {
            margin-top: 21px;
        }
        .auto-style9 {
            margin-top: 22px;
            height: 131px;
            width: 254px;
        }
        .auto-style10 {
            margin-top: 21px;
        }
        .auto-style11 {
             margin-top: 22px;
        }
        .auto-style12 {
            margin-top: 22px;
            width: 154px;
        }

  

       
        </style>
</head>
<body>


<div class="jumbotron text-center" style="border: medium solid #6495ED; background-color: #2c3e50">
  <asp:Image ID="Image1" runat="server" ImageUrl="~/formularios/cubo2.PNG" />
				<a href="#">Enobo Algebra Lineal</a><br />
                 <a href="#">Matriz Inversa De 3 x 3</a><br /><br />
                 <a href="#">Aplicamos Regla de sarrus en La forma Matricial</a><br />
                 <a href="#">Multiplicando sus diagonales Secundarias y Pirmarias</a><br /><br />
  </div>
  
      <form id="form1" runat="server" style="border: thick solid #6495ED">
<div class="container">
  <div class="row">
    <div class="col-sm-4">
       <div class="popup" onclick="myFunction()">Paso1!
  <span class="popuptext" id="myPopup">Encontrar la invresa de la Matrixz 3x3 lo primero es encontrar el determinante<br />det(A)=


  </span>

</div>
<script>
// When the user clicks on <div>, open the popup
function myFunction() {
  var popup = document.getElementById("myPopup");
  popup.classList.toggle("show");
}
</script>

       <div>
    <table>    
        <tr> 
              <td class="auto-style3">
                  <asp:TextBox ID="TextBox1" runat="server" Width="41px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="XX-Large" Height="49px">A=</asp:TextBox>
                 <asp:TextBox ID="TextBox126" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
            </td>
            <td class="auto-style12"> 
            <asp:Panel ID="Panel1" runat="server" Height="85px" Width="146px" BorderStyle="Solid">
            <asp:TextBox ID="TextBox13" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox><br />   
            <asp:TextBox ID="TextBox4" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox5" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox6" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox><br />               
            <asp:TextBox ID="TextBox14" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox8" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox>
            <asp:TextBox ID="TextBox9" runat="server" Width="40px" ForeColor="#006666"></asp:TextBox><br />
            </asp:Panel>
                     </td>            
                     <td class="auto-style3">
                     <asp:TextBox ID="TextBox130" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox>
                 </td>        
            </tr>
    </table>
   <asp:Button ID="Button1" runat="server" Text="Calcular" OnClick="Button1_Click" />
           <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
</div>
    </div>
 <div class="col-sm-4">
      <div class="popup" onclick="myFunction2()">paso 2!
          <span class="popuptext" id="myPopup3">Expresar de forma matricial<br />Repitiendo las dos primeras columnas X y Y<br />det(A)=<br />
                

          </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction2() {
                        var popup = document.getElementById("myPopup3");
                        popup.classList.toggle("show");
                    }
             </script><br /> 
 <div>
    <table class="auto-style11">    
        <tr> 
              <td class="auto-style8">
                 <asp:TextBox ID="TextBox21" runat="server" Width="88px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="X-Large" Height="48px" CssClass="auto-style4">det(A)=</asp:TextBox>
        </td>
        <td class="auto-style9"> 
               
                <asp:Panel ID="Panel2" runat="server" Height="125px" Width="247px" BackColor="White" BorderColor="#009933" BorderStyle="Solid" HorizontalAlign="Center">
                <asp:TextBox ID="TextBox22" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox>
                <asp:TextBox ID="TextBox108" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox>
                <asp:TextBox ID="TextBox109" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox>
                <asp:TextBox ID="TextBox112" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox>
                <asp:TextBox ID="TextBox113" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br />

                <asp:TextBox ID="TextBox7" runat="server" Width="40px" ReadOnly="True" style="text-align: center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox>
                <asp:TextBox ID="TextBox10" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox11" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox20" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>  
                <asp:TextBox ID="TextBox23" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox><br />   
                <asp:TextBox ID="TextBox12" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox15" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox16" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox24" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox> 
                <asp:TextBox ID="TextBox25" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox><br />   
                <asp:TextBox ID="TextBox17" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox18" runat="server" Width="40px" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>
                <asp:TextBox ID="TextBox19" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666" ></asp:TextBox>
                <asp:TextBox ID="TextBox26" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>  
               <asp:TextBox ID="TextBox27" runat="server" Width="40px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />   
               </asp:Panel>
                       </td>            
                       <td class="auto-style10">
                           &nbsp;</td>        
                   </tr>
             </table>
         </div> 
      
    </div>
 <div class="col-sm-4">
 <p>Column 3</p>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>      
</div>
<div class="col-sm-4">
           <div class="popup" onclick="myFunction1()">paso 3!
          <span class="popuptext" id="myPopup1">Realizar las operaciones indicadas<br />de la diagonal principal de la matriz<br />del paso (2)   </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction1() {
                        var popup = document.getElementById("myPopup1");
                        popup.classList.toggle("show");
                    }
             </script><br /> 
          <asp:TextBox ID="TextBox28" runat="server" Width="234px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />   
          <asp:TextBox ID="TextBox30" runat="server" Width="233px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
          <asp:TextBox ID="TextBox32" runat="server" Width="233px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
  </div>
         <div class="col-sm-4">
          <div class="popup" onclick="myFunction3()">paso 4!
          <span class="popuptext" id="myPopup2">Realizar las operaciones indicadas<br />de la diagonal Secundaria de la matriz<br />del paso (2)<br />
            Observacion : Cuando el resultado de su diagonal es positivo este pasa a negativo<br /> sino caso contrario 
          </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction3() {
                        var popup = document.getElementById("myPopup2");
                        popup.classList.toggle("show");
                    }
             </script><br />       
         <asp:TextBox ID="TextBox34" runat="server" Width="233px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
         <asp:TextBox ID="TextBox36" runat="server" Width="233px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
         <asp:TextBox ID="TextBox38" runat="server" Width="233px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
 </div>
        <div class="col-sm-4">
        <div class="popup" onclick="myFunction4()">paso 5!
          <span class="popuptext" id="myPopup4">Una vez desarrolado los pasos anteriores<br />Se procede hacer la suma del resultado de las diagonales<br />principales y secundarias<br />
            ( DP ) ( DS )<br />Tomando como resultado el det( A )
          </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction4() {
                        var popup = document.getElementById("myPopup4");
                        popup.classList.toggle("show");
                    }
             </script><br />         
        <asp:TextBox ID="TextBox40" runat="server" Width="369px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
        <asp:TextBox ID="TextBox41" runat="server" Width="91px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
 </div>  
       <div class="col-sm-4">
            <h3> </h3>        
            <asp:TextBox ID="TextBox42" runat="server" Width="369px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
              <br />
         <br />
    </div>   
</div>
     <div class="container">
    <div class="row">
    <div class="col-sm-4">
          <div>
    <table>    
        <tr> 
              <td class="auto-style6">
                 <asp:TextBox ID="TextBox45" runat="server" Width="31px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="99px" CssClass="auto-style4">(</asp:TextBox>
            </td>
        <td class="auto-style7">
        <div class="popup" onclick="myFunction5()">paso 6!
          <span class="popuptext" id="myPopup5">Calcular Cofactores<br />Tomando como Referencia la Matriz<br />Del paso(1)<br />
            <br />
          </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction5() {
                        var popup = document.getElementById("myPopup5");
                        popup.classList.toggle("show");
                    }
             </script><br />        
        <asp:Panel ID="Panel3" runat="server" Height="96px" Width="163px" BackColor="White" BorderColor="White" BorderStyle="Solid" HorizontalAlign="Center">
        <asp:TextBox ID="TextBox49" runat="server" Width="147px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox46" runat="server" Width="147px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox47" runat="server" Width="147px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox48" runat="server" Width="147px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
           <br />          
    </asp:Panel>
 </td>            
       <td class="auto-style2">
           <asp:TextBox ID="TextBox61" runat="server" Width="31px" BorderStyle="None" ReadOnly="True" Font-Size="80px" Height="99px" Font-Bold="True" CssClass="auto-style5">)</asp:TextBox>
                   </td>        
               </tr>
        </table>
    </div>   
</div>
       <div class="col-sm-4">
         <div class="popup" onclick="myFunction6()">paso 7!
          <span class="popuptext" id="myPopup6">Calcular CF ( 1 )<br />Se toman valores de la columna Y y Z<br />Se procede hacer las operaciones indicadas<br />
            <br />
          </span>
         </div>
                <script>
                    // When the user clicks on <div>, open the popup
                    function myFunction6() {
                        var popup = document.getElementById("myPopup6");
                        popup.classList.toggle("show");
                    }
             </script><br />   
         <asp:Panel ID="Panel4" runat="server" Width="106px" Height="85px" BorderColor="#006666" BorderStyle="Solid">
         <asp:TextBox ID="TextBox50" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox51" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox52" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         </asp:Panel>
         <asp:TextBox ID="TextBox29" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox31" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
  </div>
       <div class="col-sm-4">
      <p>CALCULAR   CF (2)  ,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        CF (3)</p>        
      <div>
      <table>    
        <tr> 
              <td class="auto-style3">               
                  &nbsp;</td>
        <td class="auto-style2">              
        <asp:Panel ID="Panel5" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
        <asp:TextBox ID="TextBox55" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox57" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox59" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
        <br />
        </asp:Panel>  
        <asp:TextBox ID="TextBox33" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox35" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        </td>            
            <td class="auto-style3">
                &nbsp;</td>            
        <td class="auto-style1">             
        <asp:Panel ID="Panel6" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
        <asp:TextBox ID="TextBox88" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox90" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox92" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center" ForeColor="#006666"></asp:TextBox>
        <br />
        </asp:Panel> 
        <asp:TextBox ID="TextBox37" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox39" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
                 </td>
             </tr>
           </table>
       </div>       
  </div>
       <div class="col-sm-4">
     

    </div> 
       <div class="col-sm-4">
      <P>CALCULAR  CF (4)</P>
         <asp:Panel ID="Panel7" runat="server" Width="106px" Height="85px" BorderColor="#006666" BorderStyle="Solid">
        <asp:TextBox ID="TextBox43" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox44" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox53" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
        </asp:Panel>
        <asp:TextBox ID="TextBox54" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox56" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
    </div>
      <div class="col-sm-4">
      <p>CALCULAR   CF (5)  ,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        CF (6)</p>        
      <div>
    <table>    
        <tr> 
              <td class="auto-style3">               
                  &nbsp;</td>
        <td class="auto-style2">              
        <asp:Panel ID="Panel8" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
        <asp:TextBox ID="TextBox58" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox60" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox62" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
        <br />
        </asp:Panel>  
        <asp:TextBox ID="TextBox63" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
        <asp:TextBox ID="TextBox64" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
             </td>            
            <td class="auto-style3">
                &nbsp;</td>            
            <td class="auto-style1">             
            <asp:Panel ID="Panel9" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
             <asp:TextBox ID="TextBox65" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox66" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox67" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
             <br />
        </asp:Panel> 
             <asp:TextBox ID="TextBox68" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
             <asp:TextBox ID="TextBox69" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
                 </td>
             </tr>
       </table>          
  </div>            
</div>
       <div class="col-sm-4">
      
      </div>
       <div class="col-sm-4">
      <P>CALCULAR  CF (7)</P>
         <asp:Panel ID="Panel10" runat="server" Width="106px" Height="85px" BorderColor="#006666" BorderStyle="Solid">
         <asp:TextBox ID="TextBox70" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox71" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox72" runat="server" Width="99px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
         </asp:Panel>
         <asp:TextBox ID="TextBox73" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
         <asp:TextBox ID="TextBox74" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
    </div>
       <div class="col-sm-4">
      <p>CALCULAR   CF (8)  ,&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;        CF (9)</p>        
      <div>
    <table>    
        <tr> 
           <td class="auto-style3">               
                  &nbsp;</td>
           <td class="auto-style2">              
        <asp:Panel ID="Panel11" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
             <asp:TextBox ID="TextBox75" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox76" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center" ></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox77" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
             <br />
        </asp:Panel>  
            <asp:TextBox ID="TextBox78" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox79" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
             </td>            
            <td class="auto-style3">
                &nbsp;</td>            
            <td class="auto-style1">             
        <asp:Panel ID="Panel12" runat="server" Height="85px" Width="106px" BorderStyle="Solid" HorizontalAlign="Center" BackColor="White" BorderColor="#006666">
              <asp:TextBox ID="TextBox80" runat="server" Width="99" Font-Bold="True" ReadOnly="True" BackColor="#FFFFCC" style="text-align:center"></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox81" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
             <br />
             <asp:TextBox ID="TextBox82" runat="server" Width="99" Font-Bold="True" ReadOnly="True" style="text-align:center"></asp:TextBox>
             <br />
        </asp:Panel> 
             <asp:TextBox ID="TextBox83" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
             <asp:TextBox ID="TextBox84" runat="server" Width="175px" ReadOnly="True" style="text-align:center" ForeColor="#006666" Font-Bold="True" ></asp:TextBox><br /> 
                 </td>
             </tr>
       </table>              
  </div>       
</div> 
    <div class="col-sm-4">
      <P>Se tiene los cofactores</P>
            <asp:TextBox ID="TextBox85" runat="server" Width="289px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox86" runat="server" Width="289px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox><br />
            <asp:TextBox ID="TextBox87" runat="server" Width="289px" ReadOnly="True" style="text-align:center" Font-Bold="True" ForeColor="#006666"></asp:TextBox>
    </div>
        <div class="col-sm-4">
       <p>llevar los cofactores a una nueva matriz</p>        
       <div>
    <table>    
        <tr> 
              <td class="auto-style3">
                  
                 <asp:TextBox ID="TextBox91" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
            </td>
            <td class="auto-style1"> 
            <asp:Panel ID="Panel13" runat="server" Height="84px" Width="145px" BorderStyle="Solid">
            <asp:TextBox ID="TextBox93" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox94" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox95" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br />   
            
            </asp:Panel>
                     </td>            
                     <td class="auto-style3">
                     <asp:TextBox ID="TextBox102" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox>
                 </td>        
            </tr>
    </table>
           <br />
</div>
    </div>
        <div class="col-sm-4">
            <p> matriz cofactores verificando signos</p>
      <div>
    <table>    
        <tr> 
              <td class="auto-style3">
                  
                 <asp:TextBox ID="TextBox98" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
            </td>
            <td class="auto-style1"> 
            
            <asp:Panel ID="Panel14" runat="server" Height="85px" Width="142px" BorderStyle="Solid">
            <asp:TextBox ID="TextBox100" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox104" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox105" runat="server" Width="134px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br />   
            
            </asp:Panel>
                     </td>            
                     <td class="auto-style3">
                     <asp:TextBox ID="TextBox106" runat="server" Width="26px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="97px" Font-Bold="True">)</asp:TextBox>
                 </td>        
            </tr>
    </table>
  <br />
</div>
    </div>
        </div>
      <div class="col-sm-4">
      <p>Dividir sobre resultado del determinante</p>
      <div>
    <table>    
        <tr> 
              <td class="auto-style3">
                  
                 <asp:TextBox ID="TextBox89" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
            </td>
            <td class="auto-style1"> 
            
            <asp:Panel ID="Panel15" runat="server" Height="85px" Width="228px" BorderStyle="Solid">
            <asp:TextBox ID="TextBox96" runat="server" Width="219px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox97" runat="server" Width="219px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br /> 
            <asp:TextBox ID="TextBox99" runat="server" Width="219px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True"></asp:TextBox><br />   
            </asp:Panel>
                     </td>            
                     <td class="auto-style3">
                     <asp:TextBox ID="TextBox101" runat="server" Width="26px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="97px" Font-Bold="True">)</asp:TextBox>
                 </td>        
            </tr>
    </table>
  <br />
</div>
    </div>
         <div class="col-sm-4">
      <p>La Matriz inversa es</p>
      <table>    
        <tr> 
              <td class="auto-style3">
                 <asp:TextBox ID="TextBox111" runat="server" Width="41px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="XX-Large" Height="49px">A=</asp:TextBox>

                 <asp:TextBox ID="TextBox103" runat="server" Width="26px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
            </td>
            <td class="auto-style1"> 
            
            <asp:Panel ID="Panel16" runat="server" Height="92px" Width="92px" BorderStyle="None">
            <asp:TextBox ID="TextBox107" runat="server" Width="109px" ForeColor="#006666" ReadOnly="True" style="text-align:center" Font-Bold="True" BorderStyle="None" Height="85px" TextMode="MultiLine"></asp:TextBox><br /> 
                <br /> 
                <br />   
            </asp:Panel>
                     </td>            
                     <td class="auto-style3">
                     <asp:TextBox ID="TextBox110" runat="server" Width="26px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="97px" Font-Bold="True">)</asp:TextBox>
                 </td>        
            </tr>
    </table>
  <br />
</div>
    </div>
    

    
</form>
</body>
</html>
