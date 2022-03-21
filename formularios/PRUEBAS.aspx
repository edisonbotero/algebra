<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PRUEBAS.aspx.cs" Inherits="algebra.formularios.PRUEBAS" %>
<!DOCTYPE html>
<style>
*{
  padding: 0;
  margin: 0;
  list-style: none;
  text-decoration: none;
}
body {
  font-family: 'Roboto', sans-serif;
}
.sidebar {
  position: fixed;
  left: -250px;
  width: 250px;
  height: 100%;
  background: #042331;
  transition: all .5s ease;
}
.sidebar header {
  font-size: 22px;
  color: white;
  line-height: 70px;
  text-align: center;
  background: #063146;
  user-select: none;
}
.sidebar ul a{
  display: block;
  height: 100%;
  width: 100%;
  line-height: 65px;
  font-size: 20px;
  color: white;
  padding-left: 40px;
  box-sizing: border-box;
  border-bottom: 1px solid black;
  border-top: 1px solid rgba(255,255,255,.1);
  transition: .4s;
}
ul li:hover a{
  padding-left: 50px;
}
.sidebar ul a i{
  margin-right: 16px;
}
#check{
  display: none;
}
label #btn,label #cancel{
  position: absolute;
  background: #042331;
  border-radius: 3px;
  cursor: pointer;
}
label #btn{
  left: 40px;
  top: 25px;
  font-size: 35px;
  color: white;
  padding: 6px 12px;
  transition: all .5s;
}
label #cancel{
  z-index: 1111;
  left: -195px;
  top: 17px;
  font-size: 30px;
  color: #0a5275;
  padding: 4px 9px;
  transition: all .5s ease;
}
#check:checked ~ .sidebar{
  left: 0;
}
#check:checked ~ label #btn{
  left: 250px;
  opacity: 0;
  pointer-events: none;
}
#check:checked ~ label #cancel{
  left: 195px;
}
#check:checked ~ section{
  margin-left: 250px;
}
section{
  background: url(bg.jpeg) no-repeat;
  background-position: center;
  background-size: cover;
  height: 100vh;
  transition: all .5s;
}




header {
	background:#2c3e50;
	width:100%;
	padding:20px;
 
	/* Flexbox */
	display: flex;
	justify-content:space-between;
	align-items:center;
 
	flex-direction:row;
	flex-wrap:wrap;
}
 
header .logo {
	color:#fff;
	font-size:30px;

}
 
header .logo img {
	width:50px;
	vertical-align: top;
}
 
header .logo a {
	color:#fff;
	text-decoration: none;
	line-height:50px;
}
 
header nav {
	width:50%;
	/* Flexbox */
 
	display:flex;
	flex-wrap:wrap;
	align-items:center;
}
 
header nav a {
	background:#c0392b;
	color:#fff;
	text-align: center;
	text-decoration: none;
	padding:10px;
 
	/* Flexbox */
	flex-grow:1;
}
 
header nav a:hover {
	background:#e74c3c;
}
 

</style>
 <form id="form1" runat="server">
<!-- Created By CodingNepal -->
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <!-- Somehow I got an error, so I comment the title, just uncomment to show -->
    <!-- <title>Sider Menu Bar CSS</title> -->
    <link rel="stylesheet" href="style.css">
    <script src="https://kit.fontawesome.com/a076d05399.js" style="font-size: xx-small"></script>
  </head>
  <body>
    <input type="checkbox" id="check">
    <label for="check">
      <i class="fas fa-bars" id="btn"></i>
      <i class="fas fa-times" id="cancel"></i>
    </label>
    <div class="sidebar">
    <header>Menu Enobo</header>
  <ul>
<li><a href="#"><i class="fas fa-qrcode"></i>Introducion</a></li>
<li><a href="Introduccion.aspx"><i class="fas fa-qrcode"></i>Ecuaciones</a></li>
<li><a href="#"><i class="fas fa-link"></i>Matrices</a></li>
<li><a href="#"><i class="fas fa-stream"></i>Determinantes</a></li>
<li><a href="#"><i class="fas fa-calendar-week"></i>Gauss</a></li>
<li><a href="#"><i class="far fa-question-circle"></i>Gausjordan</a></li>
<li><a href="#"><i class="fas fa-sliders-h"></i>Volver</a></li>
<li><a href="#"><i class="far fa-envelope"></i>Contact</a></li>
</ul>
</div>
<section>
     
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
  <div class="jumbotron text-center" style="border: medium solid #6495ED; background-color: #2c3e50">
   <div class="contenedor">
		<header>
			<div class="logo">
				
                <asp:Image ID="Image1" runat="server" ImageUrl="~/formularios/cubo2.PNG" />
				<a href="#">Enobo</a><br />
               <a href="#">Algebra Lineal Matrices y Resultados</a><br /><br />
			</div>
            </header>
        
   </div>
      </div>
   
<meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
  <div class="jumbotron text-center" style="border: medium solid #FFFFFF; background-color: #FFFFFF" >     
    <div class="container">
        <div class="row">
            <div class="col-md-12" style="margin:40px 0"  >
                <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:4rem">¿Por qué elegirnos?</h3>
                <p style="text-align:justify">
                    Nuestra modalidad virtual permite a nuestros estudiantes conectarse y realizar sus practicas desde la oficina, la casa o desde cualquier lugar.
					Enobo Algebra Lineal ofrece una forma de estudio, en donde desarollamos la solucion, para poder aplicar los sistemas de euaciones lineales de manera mucho mas productiva.
					Resolviendo sistemas al instante por los metodos de Igualacion,sustitucion,reduccion,Cramer,Gaus Jordan, operaciones con matrices entre otros
                    </p>
               </div>
			<div class="jumbotron text-center" style="height: 702px; background-color: #FFFFFF">
            <div class="col-sm-4">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/formularios/Algebra (2222).png" />   
            <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Sistema de ecuaciones</h3>
            <h4  style="font-family: Arial;text-align:justify" >Es la reunion de dos o mas ecuaciones con dos o mas incognitas es un grupo de valores donde las incognitas satisface todas las ecuaciones del sistema
       </h4>
     </div>	
	 <div class="col-sm-4">
      <h3> </h3>
      <asp:Image ID="Image3" runat="server" ImageUrl="~/formularios/algebradepositphotos_226152090.png" Height="136px" />
      <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Matrices</h3>
      <h4 style="font-family: Arial;text-align:justify">Arreglo bidimensional de numeros en donde se pueden desarrollar diferentes 
          calculos matematicos como suma, resta ,multiplicacion entre otros metodos</h4>
    </div>
     <div class="col-sm-4">
     <asp:Image ID="Image4" runat="server" ImageUrl="~/formularios/123veausted.png" />
     <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Gauss Jordan</h3>
     <h4 style="font-family: Arial;text-align:justify">
      Eliminacion de Gauss es un metodo por el cual se pueden resolver sistema de ecuaciones con n numeros de variables, encontrar matrices y matrices inversas
        </h4>
   </div><br /><br /><br /> <br />        
	
      
       <div class="jumbotron text-center" style="height: 902px; background-color: #FFFFFF">
  <div class="container">
  <div class="row">
    <div class="col-sm-4">      
        <asp:Image ID="Image5" runat="server" ImageUrl="~/formularios/primary123.png" />
       <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Regla de Cramer</h3>
      <h4 style="font-family: Arial;text-align:justify">Es un teorema del Algebra Lineal que da la solucion de un sistema lineal de ecuaciones en terminos de determinantes</h4>
    </div>
    <div class="col-sm-4">      
        <asp:Image ID="Image6" runat="server" ImageUrl="~/formularios/11-imagen-7.png" />
      <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Metodo de Gauss</h3>
      <h4 style="font-family: Arial;text-align:justify">Consiste en encontrar una matriz ampliada escalonada equivalente por filas ala matriz correspondiente al sistema original
          se escribe el sistema equivalente correspondiente ala matriz escalonada

      </h4>
    </div>
    <div class="col-sm-4">            
        <asp:Image ID="Image7" runat="server" ImageUrl="~/formularios/algebras (1).png" />
         <h3 class="mb-4 font-weight-bold" style="font-family: cursive; font-style: italic; text-align:center; font-size:2rem">Determinantes</h3>
        <h4 style="font-family: Arial;text-align:justify">
            El determinante es una funcion que le asigna a una matriz de orden n, un único número real llamado, el determinante de la matriz lo denotamos por det(A)
       </h4>
    </div>
      </div>
       </div>
</div>
      </div>
  </div>
 
</div>
	</div>    
     
     </body>
     </section>
	  
   </html>

     </form>

 
