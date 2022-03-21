<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="metodo igualacion.aspx.cs" Inherits="algebra.formularios.Inicio" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap Example</title>
   
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
    <style type="text/css">
        html, body {
  height: 100%;
}
 
.wrap {
  height: 100vh;
  display: flex;
}
main {
  flex: 1;
  display: flex;
}
 
aside, article {
  overflow-y: scroll;
  padding: 2em;
}
 
aside {
  flex: 1;
}
 
article {
  flex: 2;
}
@media (max-width: 800px) {
  main {
    flex-direction: column;
  }
}
    </style>
</head>
<body>
     
<div class="jumbotron text-center" style="border: medium solid #6495ED; background-color: #2c3e50">
<div class="contenedor">
		<header>
			<div class="logo">
				
                <asp:Image ID="Image1" runat="server" ImageUrl="~/formularios/cubo2.PNG" />
				<a href="#">Enobo</a><br />
               <a href="#">Metodo de Igualacion De Terminos</a><br /><br />
               <a href="#">Con Cuantas Incognitas desea trabajar</a><br /><br />
               
			</div>
            </header>
           </div>
          </div>
    <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
 
  <main>
 
    <aside style="text-align:center">
        <asp:Label ID="Label46" runat="server" Text="Ecuaciones con Dos Incognitas" Font-Bold="True"></asp:Label><br /><br />
      <asp:TextBox ID="numero1" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label1" runat="server" Text="X" Width="25px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	          <asp:TextBox ID="numero2" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	          <asp:Label ID="Label2" runat="server" Text="Y  =" Width="38px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	          <asp:TextBox ID="numero3" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
              <asp:Label ID="Label3" runat="server" Text="Incognita 1" Width="132px" Font-Bold="True" Font-Size="12" Height="20px"></asp:Label><br />	
	          <asp:TextBox ID="numero4" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
              <asp:Label ID="Label4" runat="server" Text="X" Width="25px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	          <asp:TextBox ID="numero5" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	          <asp:Label ID="Label5" runat="server" Text="Y  =" Width="38px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	          <asp:TextBox ID="numero6" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
              <asp:Label ID="Label6" runat="server" Text="Incognita 2" Width="136px" Font-Bold="True" Font-Size="12" BorderColor="#2C3E50"></asp:Label><br /><br />
              <asp:Button ID="Button1" runat="server" Text="Calcular" style="text-align:center" BorderColor="#3399FF" OnClick="Button1_Click" />   
	         <asp:Button ID="Button2" runat="server" Text="Limpiar" style="text-align:center" BorderColor="#3399FF" OnClick="Button2_Click" /><br /><br />
             <asp:Label ID="ecuacion1" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12"></asp:Label><br /><br />
	         <asp:Label ID="despejar" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><br /><br />
             <asp:Label ID="igualarvalores" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt"></asp:Label><br /><br />
             <asp:Label ID="sutituiry" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12"></asp:Label><br />
 </aside>
 
    <article  style="text-align:center">
       <asp:Label ID="Label47" runat="server" Text="Ecuaciones con Tres Incognitas" Font-Bold="True"></asp:Label><br /><br />
      <asp:TextBox ID="numero7" runat="server" style="text-align:center" Width="37px" BackColor="#99CCFF" BorderColor="CornflowerBlue" BorderStyle="Solid" Font-Size="12pt"></asp:TextBox>
                  <asp:Label ID="Label7" runat="server" Text="X" Width="16px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero8" runat="server" style="text-align:center" Width="37px" OnTextChanged="numero8_TextChanged"></asp:TextBox>
	              <asp:Label ID="Label8" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero9" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label10" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero10" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label9" runat="server" Text="Ecuacion 1" Width="132px" Font-Bold="True" Font-Size="10" Height="20px" CssClass="auto-style3" style="text-align:left"></asp:Label><br />	
                   <asp:TextBox ID="numero11" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label11" runat="server" Text="X" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero12" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	              <asp:Label ID="Label12" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero13" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label13" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero14" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label14" runat="server" Text="Ecuacion 2" Width="132px" Font-Bold="True" Font-Size="10" Height="20px" style="text-align:left"></asp:Label><br />
                   <asp:TextBox ID="numero15" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label15" runat="server" Text="X" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero16" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	              <asp:Label ID="Label16" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero17" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label17" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="numero18" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label18" runat="server" Text="Ecuacion 3" Width="128px" Font-Bold="True" Font-Size="10pt" Height="20px" style="text-align:left"></asp:Label><br /><br />
                  <asp:Button ID="Button3" runat="server" Text="Calcular" OnClick="Button3_Click" />  
                  <asp:Button ID="Button5" runat="server" Text="Limpiar" OnClick="Button5_Click" /><br /><br />
                  <asp:Label ID="ecuacion2" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12"></asp:Label><br /> 
                   <asp:Label ID="Label36" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="Red"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Label ID="Label37" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="Label38" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />                
                  <asp:Label ID="transponer1" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><br />          
                    <br /><br />
                  <asp:Label ID="Label39" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><br /><br />
                  <asp:Label ID="transponer5" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><br /><br />
                  <asp:Label ID="multiplicar" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><br />
                  <asp:Label ID="multiplicarterminos" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><BR /><BR />
                  <asp:Label ID="Label19" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><BR /><BR />
                  <asp:Label ID="transponer6" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12"></asp:Label><br /><br />
                  <asp:Label ID="multiploicarecuaciones4y6" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12pt"></asp:Label><BR /><BR />
                  <asp:Label ID="Label20" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><BR /><BR />
                   <asp:Label ID="Resolverelsistema2x2" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12pt"></asp:Label><br /><br />
                  <asp:Label ID="Label21" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><br /><br />
                  <asp:Label ID="igualarecuaciones7y8" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12pt"></asp:Label><BR /><BR />
                  <asp:Label ID="Label22" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><br /><br />
                  <asp:Label ID="sustituiren7o8" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12pt"></asp:Label><br /><br />
                  <asp:Label ID="Label23" runat="server" Text="Label" style="text-align:center" Font-Bold="True" Font-Size="12pt" ForeColor="#FF3300"></asp:Label><br /><br />
                   <asp:Label ID="sustituirprimeraecuaion" runat="server" Text="Label" style="text-align:left" Font-Bold="True" Font-Size="12pt"></asp:Label><br /><br />
    </article>
 
      <article style="text-align:center">
          <asp:Label ID="Label48" runat="server" Text="Ecuaciones Con Cuatro Incognitas" Font-Bold="True"></asp:Label><br /><br />
      <asp:TextBox ID="n1" runat="server" style="text-align:center" Width="37px" BackColor="#99CCFF" BorderColor="CornflowerBlue" BorderStyle="Solid" Font-Size="12pt"></asp:TextBox>
                  <asp:Label ID="Label24" runat="server" Text="X" Width="16px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n2" runat="server" style="text-align:center" Width="37px" OnTextChanged="numero8_TextChanged"></asp:TextBox>
	              <asp:Label ID="Label25" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n3" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label26" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n4" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
               <asp:Label ID="Label40" runat="server" Text="U=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
          <asp:TextBox ID="n5" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label27" runat="server" Text="Ecuacion 1" Width="132px" Font-Bold="True" Font-Size="10" Height="20px" CssClass="auto-style3" style="text-align:left"></asp:Label><br />	
                   <asp:TextBox ID="n6" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label28" runat="server" Text="X" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n7" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	              <asp:Label ID="Label29" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n8" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label30" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n9" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
          <asp:Label ID="Label41" runat="server" Text="U=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
          <asp:TextBox ID="n10" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label31" runat="server" Text="Ecuacion 2" Width="132px" Font-Bold="True" Font-Size="10" Height="20px" style="text-align:left"></asp:Label><br />
                   <asp:TextBox ID="n11" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label32" runat="server" Text="X" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n12" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	              <asp:Label ID="Label33" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n13" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="n" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n14" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
          <asp:Label ID="Label42" runat="server" Text="U=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
          <asp:TextBox ID="n15" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label35" runat="server" Text="Ecuacion 3" Width="128px" Font-Bold="True" Font-Size="10pt" Height="20px" style="text-align:left"></asp:Label><br />
           <asp:TextBox ID="n16" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label34" runat="server" Text="X" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n17" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
	              <asp:Label ID="Label43" runat="server" Text="Y" Width="19px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n18" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                   <asp:Label ID="Label44" runat="server" Text="Z=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
	              <asp:TextBox ID="n19" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
          <asp:Label ID="Label45" runat="server" Text="U=" Width="29px" Font-Bold="True" Font-Size="X-Large"></asp:Label>
          <asp:TextBox ID="n20" runat="server" style="text-align:center" Width="37px"></asp:TextBox>
                  <asp:Label ID="Label49" runat="server" Text="Ecuacion 4" Width="128px" Font-Bold="True" Font-Size="10pt" Height="20px" style="text-align:left"></asp:Label><br /><br />
                  <asp:Button ID="Button4" runat="server" Text="Calcular" OnClick="Button4_Click" /><br /><br />  
                   <asp:Label ID="ingresar_valores_incognita1" runat="server" Text="Ecuacion 1"  Font-Bold="True" Font-Size="12pt"  style="text-align:center"></asp:Label>
           
                  
    </article>
  </main>
 
</div>
    </form>
       </body>
  </html>
 


    



