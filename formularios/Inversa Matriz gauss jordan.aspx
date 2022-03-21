<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inversa Matriz gauss jordan.aspx.cs" Inherits="algebra.formularios.Inversa_Matriz_gauss_jordan" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Matriz Inversa Gauss Jordan</title>
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
  width: 430px;
  background-color: #555;
  color: #fff;
  text-align: center;
  border-radius: 6px;
  padding: 8px 0;
  position: absolute;
  z-index: 1;
  bottom: 125%;
  left: 57%;
  margin-left: -80px;
}

/* Popup arrow */
.popup .popuptext::after {
  content: "";
  position: absolute;
  top: 100%;
  left: 57%;
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
         .auto-style1 {
             margin-left: 35;
         }
     </style>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">

<div class="jumbotron text-center">
  <p>Inversa Matriz 3x3 Metodo Gauss Jordan</p>

  <p></p> 
</div>
  
<div class="container">

          <div class="row">
               <div class="col-sm-4">                     
                         <div>
                            <table>    
                                <tr> 
                                   <td class="auto-style3">
                                   <asp:TextBox ID="TextBox10" runat="server" Width="41px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="XX-Large" Height="49px">A=</asp:TextBox>
                                   <asp:TextBox ID="TextBox126" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox>
                                    </td>
                                   <td class="auto-style12"> 
                                   <asp:Panel ID="Panel1" runat="server" Height="85px" Width="146px" BorderStyle="Solid">
                                   <asp:TextBox ID="TextBox1" runat="server" Width="40px"></asp:TextBox>
                                   <asp:TextBox ID="TextBox2" runat="server" Width="40px"></asp:TextBox>
                                   <asp:TextBox ID="TextBox3" runat="server" Width="40px"></asp:TextBox><br />
                                   <asp:TextBox ID="TextBox4" runat="server" Width="40px"></asp:TextBox>
                                   <asp:TextBox ID="TextBox5" runat="server" Width="40px"></asp:TextBox>
                                   <asp:TextBox ID="TextBox6" runat="server" Width="40px"></asp:TextBox><br />
                                   <asp:TextBox ID="TextBox7" runat="server" Width="40px"></asp:TextBox>
                                  <asp:TextBox ID="TextBox8" runat="server" Width="40px"></asp:TextBox>
                                  <asp:TextBox ID="TextBox9" runat="server" Width="40px"></asp:TextBox>
                                  </asp:Panel>  
                                  </td>         
                                <td class="auto-style3">
                                <asp:TextBox ID="TextBox130" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox>
                            </td>        
                       </tr>
                </table>
                <asp:Button ID="Button1" runat="server" Text="Ejecutar" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Borrar" OnClick="Button2_Click" />

       </div>
</div>

<div class="col-sm-4">
                                              
                     <table>    
                            <tr> 
                                  <td class="auto-style3">
                                  <asp:TextBox ID="TextBox12" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox></td>
                                  <td class="auto-style12">
                                  <asp:Panel ID="Panel2" runat="server" BorderStyle="Solid" Width="329px">
                                   <asp:TextBox ID="FormaMatricial" runat="server" Width="182px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px"></asp:TextBox>  
                                      <asp:TextBox ID="TextBox15" runat="server" Width="16px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px" CssClass="auto-style1" BackColor="#003300"></asp:TextBox>
                                  <asp:TextBox ID="TextBox14" runat="server" Width="112px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="80px"></asp:TextBox>
                                  </asp:Panel> 
                                      <asp:Button ID="Button3" runat="server" Text="Paso 1" OnClick="Button3_Click" />
                                  <td class="auto-style3">                                   
                        <asp:TextBox ID="TextBox11" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox></td>        
                 </tr>
       </table>
</div>

<div class="col-sm-4">
                
                        <asp:TextBox ID="CalculoMatriz" runat="server" Width="322px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="92px"></asp:TextBox>        
           </div>
                   
</div><br />
   
<div class="col-sm-4">      
                
           <asp:TextBox ID="CalculoMatriz1" runat="server" Width="317px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="92px"></asp:TextBox>       
                  
    </div>
    
<div class="row">
          <div class="col-sm-4">
                   
                          <table>    
                                 <tr> 
                                 <td class="auto-style3">
                                  <asp:TextBox ID="TextBox16" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox></td>
                                  <td class="auto-style12">
                                   <asp:TextBox ID="Nuevamatriz" runat="server" Width="131px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px"></asp:TextBox>       
                                   <asp:TextBox ID="TextBox18" runat="server" Width="16px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px" CssClass="auto-style1" BackColor="#003300">|</asp:TextBox>
                                      <asp:TextBox ID="Nuevamatriz1" runat="server" Width="125px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px" CssClass="auto-style1"></asp:TextBox>
                                   <td class="auto-style3">
                              <asp:TextBox ID="TextBox19" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox></td>        
                         </tr>
                  </table>
             
            </div>                
     
    

<div class="row">
          <div class="col-sm-4">                 
                                      
                  <asp:TextBox ID="CalculoMatriz2" runat="server" Width="318px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="92px"></asp:TextBox><br />   
                    
           </div>
   </div>             
     
<div class="row">
    <div class="col-sm-4">
                      <table>    
                           <tr> 
                               <td class="auto-style3">
                                  <asp:TextBox ID="TextBox13" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="101px">(</asp:TextBox></td>
                                  <td class="auto-style12">
                                   <asp:TextBox ID="TextBox17" runat="server" Width="131px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px"></asp:TextBox>       
                                   <asp:TextBox ID="TextBox20" runat="server" Width="16px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px" CssClass="auto-style1" BackColor="#003300">|</asp:TextBox>
                                   <asp:TextBox ID="TextBox21" runat="server" Width="125px" TextMode="MultiLine" style="text-align:center" ReadOnly="True" Font-Bold="True" ForeColor="#006666" Height="79px" CssClass="auto-style1"></asp:TextBox>
                                   <td class="auto-style3">
                          <asp:TextBox ID="TextBox22" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="107px" Font-Bold="True">)</asp:TextBox></td>        
                    </tr>
          </table>              
  </div>         
<div class="row">
     <div class="col-sm-4">
                 <h3>Column 1</h3>
                 <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
                  <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
<div class="row">
    <div class="col-sm-4">
                  <h3>Column 1</h3>
                  <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
                   <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
             </div>
        </div>
  </div>
    </div>
    <div class="row">
    <div class="col-sm-4">
      <h3>Column 1</h3>
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 2</h3>
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 3</h3>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
         </div>
        
 
    
       
     
</form>
</body>
</html>

