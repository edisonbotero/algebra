<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Introduccion.aspx.cs" Inherits="algebra.formularios.Introduccion" %>


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

<!-- Created By CodingNepal -->
<html lang="en" dir="ltr">
  <head>
    <meta charset="utf-8">
    <!-- Somehow I got an error, so I comment the title, just uncomment to show -->
    <!-- <title>Sider Menu Bar CSS</title> -->
    <link rel="stylesheet" href="style.css">
    <script src="https://kit.fontawesome.com/a076d05399.js"></script>
  </head>
  <body>
    <input type="checkbox" id="check">
    <label for="check">
      <i class="fas fa-bars" id="btn"></i>
      
    </label>
    <div class="sidebar">
    <header>Ecuaciones</header>
  <ul>
<li><a href="metodo igualacion.aspx"><i class="fas fa-qrcode"></i>Metodo Igualacion</a></li>
<li><a href="#"><i class="fas fa-qrcode"></i>inicio2</a></li>
<li><a href="#"><i class="fas fa-link"></i>Shortcuts</a></li>
<li><a href="#"><i class="fas fa-stream"></i>Overview</a></li>
<li><a href="#"><i class="fas fa-calendar-week"></i>Events</a></li>
<li><a href="#"><i class="far fa-question-circle"></i>About</a></li>
<li><a href="Introduccion.aspx"><i class="fas fa-sliders-h"></i>Volver</a></li>
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
               <a href="#">Euaciones Lineales</a><br /><br />
			</div>
            </header>        
   </div>
      </div>
	<meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/js/bootstrap.min.js"></script>
<div class="jumbotron text-center" style="border: medium solid #FFFFFF;">
    <p align="center">Clasificación de los sistemas : Sistema compatible determinado tiene solucion unica (S.C.D) , Sistema compatible indeterminado tiene infinitas soluciones (S.C .I)  <br />
		              Sistema incompatible no tiene soluciones.Comprender conceptualmente,el sistema resolviendo ecuaciones  por los siguientes metodos, de igualación, sustitución, reducción <br />  
		             <br />
		                                                                                       Metodo de Igualacion<br /> 
		             Se despeja la misma incognita de ambas ecuaciones ( puede ser X O Y ), se igualan las ecuaciones de la incognita despejada, y luego se resuelve la ecuacion , hallándose el valor<br /> 
		             de una de las incógnitas. Se reemplaza el valor obtenido en cualquiera de las ecuaciones despejadas inicialmente, luego se obtiene el valor de la otra incognita. Dando la solucion<br /><br />  

		                                    2X -2Y =  -6      <br />
		                                    3X -Y  =  -1      <br />
		                                    Y= X+3 ,  Y= 3X+1 <br />
			                                X + 3 = 3X  +  1  <br />
		                                    3 - 1 = 3X - X    <br />
		                                        X = 1         <br />
		                                        Y = 1 + 3     <br />
		                                        Y = 4         <br />
		                                       S={(1;4)}      <br /><br />

		                                                                                   Metodo de Sustitucion<br /> 
		          Se despeja una incognita de una de las ecuaciones y se reemplaza la expresión en la otra ecuacion. Luego se resuelve la ecuacion que queda determinada, y se encuentra<br />
		          el valor de una de las incógnitas. Reemplazando el valor hallado en la primer expresión despejada, se halla el valor de la otra incógnita. Dando la solucion 
    </p>
  
  
  

</div>
</section>
  </body>
</html>
