<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="la pruebita111.aspx.cs" Inherits="algebra.formularios.la_pruebita111" %>

<!DOCTYPE html>
<style>
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
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="wrap">
 
  <main>
 
    <aside>
      <h1>Sidebar</h1>
      <p>
        lipsum...
      </p>
    </aside>
 
    <article>
      <h1>Content</h1>
      <p>
        lipsum...
      </p>
    </article>
 
  </main>
 
</div>
    </form>
</body>
</html>
