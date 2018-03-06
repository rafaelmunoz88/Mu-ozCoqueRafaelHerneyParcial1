<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculadora.aspx.cs" Inherits="_20180305parcialPweb.calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="lblCalculadora" dir="auto">
            CALCULADORA</div>
        PRIMER NUMERO<asp:TextBox ID="txtnum1" runat="server" OnTextChanged="num1_TextChanged"></asp:TextBox>
        SEGUNDO NUMERO<asp:TextBox ID="txnum2" runat="server" OnTextChanged="num2_TextChanged"></asp:TextBox>
        <p id="operDeseada">
            OPERACION DESEADA</p>
        <p>
            <asp:Button ID="BtnSuma" runat="server" OnClick="Button1_Click" Text="Suma" />
            <asp:Button ID="BtnResta" runat="server" OnClick="Button2_Click" Text="Resta" />
            <asp:Button ID="BtnMult" runat="server" Text="Multiplicación" OnClick="BtnMult_Click" />
            <asp:Button ID="BtnDiv" runat="server" Text="División" OnClick="BtnDiv_Click" />
        </p>
        RESULTADO<br />
        <asp:TextBox ID="txtresultado" runat="server"></asp:TextBox>
    </form>
</body>
</html>
