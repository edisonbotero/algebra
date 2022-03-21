<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jordan.aspx.cs" Inherits="algebra.formularios.jordan" %>

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
        .auto-style1 {
            width: 184px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
<div class="jumbotron text-center">
  <p>Metodo de Gauss Jordan</p>
    <asp:TextBox ID="TextBox1" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="X" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox2" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label2" runat="server" Text="Y" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Z  =" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox4" runat="server" Width="46px"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox5" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="X" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox6" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label5" runat="server" Text="Y" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label6" runat="server" Text="Z  =" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox8" runat="server" Width="46px"></asp:TextBox>
    <br />
    <asp:TextBox ID="TextBox9" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label7" runat="server" Text="X" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox10" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label8" runat="server" Text="Y" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox11" runat="server" Width="46px"></asp:TextBox>
    <asp:Label ID="Label9" runat="server" Text="Z  =" Font-Bold="True" Font-Size="X-Large"></asp:Label>
    <asp:TextBox ID="TextBox12" runat="server" Width="46px"></asp:TextBox>
    <br /> 
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</div>
  
<div class="container">
  <div class="row">
    <div class="col-sm-4">
      <h3> </h3>
        <asp:TextBox ID="TextBox13" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox14" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox15" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
    </div>
    <div class="col-sm-4">
      <p>ordenar de forma Matricial</p>
        <asp:TextBox ID="TextBox33" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox16" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox17" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox18" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox19" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox34" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
      <asp:TextBox ID="TextBox20" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox21" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox22" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox23" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox35" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
      <asp:TextBox ID="TextBox24" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox25" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox26" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox27" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox36" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
      <asp:TextBox ID="TextBox28" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox29" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox30" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox>
      <asp:TextBox ID="TextBox31" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
       </div>
    
    <div class="col-sm-4">
      <p>Tomar F1 , F2</p>     
         <asp:TextBox ID="TextBox41" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>                          
     <asp:TextBox ID="TextBox32" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox42" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox38" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox44" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox37" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
        <asp:TextBox ID="TextBox43" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox39" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox45" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox40" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox46" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
        <asp:TextBox ID="TextBox47" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
 <br />   
    </div>
    
      <div class="col-sm-4">
      <p>Desarollar las operaciones de R1, R2</p> 
      <asp:TextBox ID="TextBox66" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox48" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox67" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox49" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
      <asp:TextBox ID="TextBox68" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox50" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
    </div>
      <div class="col-sm-4">
      <p>Tomar F1, F3</p>        
        <asp:TextBox ID="TextBox51" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>                          
     <asp:TextBox ID="TextBox52" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox53" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox54" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox55" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox56" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
        <asp:TextBox ID="TextBox57" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox58" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox59" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox60" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox61" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
        <asp:TextBox ID="TextBox62" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
 <br />   
    </div>
 <div class="col-sm-4">
      <p>Desarrolar las operaciones de R4, R5</p> 
     <asp:TextBox ID="TextBox69" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox63" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox70" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox64" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox71" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
   <asp:TextBox ID="TextBox65" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
           
 </div>
      </div>
    <div class="col-sm-4">
      <p>Se toma Los valores F1 , R3 , R6</p> 
       <div>
    <table>    
        <tr> 
              <td class="auto-style3">               
                 <asp:TextBox ID="TextBox80" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="79px"></asp:TextBox>
            </td>
        <td class="auto-style1"> 
             
        <asp:Panel ID="Panel3" runat="server" Height="74px" Width="218px" BorderStyle="None" HorizontalAlign="Center" BackColor="White">
             <asp:TextBox ID="TextBox72" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox149" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox150" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox151" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox73" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox152" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox153" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox154" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox74" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox155" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox156" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox157" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
        </asp:Panel>            
         </td>            
            <td class="auto-style3">
             <asp:TextBox ID="TextBox81" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="79px" Font-Bold="True"></asp:TextBox>
            </td>        
         </tr>
    </table>
    </div>       
           
      
    </div>
    <div class="col-sm-4">
      <P>Tomar R3,R6 desarrolar las multiplicaciones</P>        
         <asp:TextBox ID="TextBox75" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>                          
     <asp:TextBox ID="TextBox76" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox77" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox78" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox79" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox82" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
        <asp:TextBox ID="TextBox83" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox84" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox85" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox86" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox87" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
        <asp:TextBox ID="TextBox88" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
 <br />   



     
    </div>
    <div class="col-sm-4">
      <p>Desarrolar las operaciones de R7, R8</p>        
       <asp:TextBox ID="TextBox89" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox90" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox91" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox92" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox93" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
   <asp:TextBox ID="TextBox94" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
        </div>   
    
    <div class="col-sm-4">
      <p>Simplificar para obtener una ecuacion equivalente</p>        
         <asp:TextBox ID="TextBox95" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
         <asp:TextBox ID="TextBox96" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox97" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
    <asp:TextBox ID="TextBox98" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>

    </div>
    <div class="col-sm-4">
      <p>Se toma los valores de F1,R3,R10 Formando la matriz</p>        
       <div>
    <table>    
        <tr> 
              <td class="auto-style3">               
                 <asp:TextBox ID="TextBox99" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="79px"></asp:TextBox>
            </td>
        <td class="auto-style1"> 
             
        <asp:Panel ID="Panel1" runat="server" Height="74px" Width="218px" BorderStyle="None" HorizontalAlign="Center" BackColor="White">
             <asp:TextBox ID="TextBox100" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox158" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox159" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox160" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox101" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox161" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox162" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox163" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox102" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox164" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox165" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox166" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
        </asp:Panel>            
         </td>            
            <td class="auto-style3">
             <asp:TextBox ID="TextBox103" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="79px" Font-Bold="True"></asp:TextBox>
            </td>        
         </tr>
    </table>
    </div>       
           
    </div>
    <div class="col-sm-4">
      <p>Tomar R3,R10 Desarrollar las multiplicaciones</p>        
       <asp:TextBox ID="TextBox104" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>                          
     <asp:TextBox ID="TextBox105" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox106" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox107" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox108" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox109" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
        <asp:TextBox ID="TextBox110" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox111" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox112" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox113" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox114" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
        <asp:TextBox ID="TextBox115" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
 <br />   

    </div>
    <div class="col-sm-4">
      <p>Desarrollar las operaciones de R11,R12</p>        
       <asp:TextBox ID="TextBox116" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox117" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox118" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox119" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox120" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
   <asp:TextBox ID="TextBox121" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
    </div>
    <div class="col-sm-4">
      <p>Simplificar para obtener una ecuacion equivalente</p>        
       <asp:TextBox ID="TextBox122" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
         <asp:TextBox ID="TextBox123" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox124" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
    <asp:TextBox ID="TextBox125" runat="server" Width="301px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>

    </div>
     <div class="col-sm-4">
      <p>toma valores R14,R11,R10 Formar una nueva matriz</p>        
        <div>
    <table>    
        <tr> 
              <td class="auto-style3">               
                 <asp:TextBox ID="TextBox126" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Bold="True" Font-Size="80px" Height="79px"></asp:TextBox>
            </td>
        <td class="auto-style1"> 
             
        <asp:Panel ID="Panel2" runat="server" Height="74px" Width="218px" BorderStyle="None" HorizontalAlign="Center" BackColor="White">
             <asp:TextBox ID="TextBox127" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox167" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox168" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox169" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>

             <asp:TextBox ID="TextBox128" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox170" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox171" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
             <asp:TextBox ID="TextBox172" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>

             <asp:TextBox ID="TextBox129" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox173" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox174" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
            <asp:TextBox ID="TextBox175" runat="server" Width="46px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#003300" BackColor="White" BorderStyle="Solid"></asp:TextBox>
        </asp:Panel>            
         </td>            
            <td class="auto-style3">
             <asp:TextBox ID="TextBox130" runat="server" Width="27px" BorderStyle="None" style="margin-left: 4px" ReadOnly="True" Font-Size="80px" Height="79px" Font-Bold="True"></asp:TextBox>
            </td>        
         </tr>
    </table>
    </div>       
           
    </div>
     <div class="col-sm-4">
      <p>Tomar F3 , R10 Desarrollar las muliplicaciones</p>        
       <asp:TextBox ID="TextBox131" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>                          
     <asp:TextBox ID="TextBox132" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox133" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox134" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox135" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox136" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox><br />
        <asp:TextBox ID="TextBox137" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox138" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox139" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
     <asp:TextBox ID="TextBox140" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
        <asp:TextBox ID="TextBox141" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
        <asp:TextBox ID="TextBox142" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
 <br />   

    </div>
       <div class="col-sm-4">
      <P>Desarrollar las operaciones entre R12,R13</P>        
        <asp:TextBox ID="TextBox143" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox144" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox145" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
    <asp:TextBox ID="TextBox146" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True"></asp:TextBox><br />
     <asp:TextBox ID="TextBox147" runat="server" Width="50px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0066FF"></asp:TextBox>
   <asp:TextBox ID="TextBox148" runat="server" Width="231px" style="text-align:center" Font-Bold="True" ReadOnly="True" ForeColor="#0099FF"></asp:TextBox>
    </div>
    <div class="col-sm-4">
      <h3>Column 6</h3>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 6</h3>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 6</h3>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    <div class="col-sm-4">
      <h3>Column 6</h3>        
      <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit...</p>
      <p>Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris...</p>
    </div>
    </div>
</form>
</body>
</html>

