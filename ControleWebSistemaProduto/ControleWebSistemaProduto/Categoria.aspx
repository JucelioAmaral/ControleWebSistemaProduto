<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Categoria.aspx.cs" Inherits="Categoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

.label_tela {
    font-family: Algerian;
    font-size: larger;
    font-weight: 500;    
}
.botao {
    font-family:Constantia;
    font-size:small;
    font-weight:500;
    background-color:#808080;
}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <p style="text-align:center;">
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Cadastro de Categorias" CssClass="label_tela"></asp:Label>
        </p>
        <br />
            <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" style="margin-left: 21px" Width="57px" CssClass="botao" />
            <asp:Button ID="btnCarregar" runat="server" OnClick="btnCarregar_Click" Text="Carregar" style="margin-left: 21px" Width="71px" CssClass="botao" />
            <asp:Button ID="btnExcluir" runat="server" OnClick="btnExcluir_Click" Text="Excluir" style="margin-left: 21px" Width="71px" CssClass="botao"  />
            <asp:Button ID="btnLimpar" runat="server" OnClick="btnLimpar_Click" Text="Limpar" style="margin-left: 21px" Width="71px" CssClass="botao" />
        <br />
        <br />
            <asp:Label ID="Label8" runat="server" Text="ID: " Width="120px"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
        <br />
            <asp:Label ID="Label9" runat="server" Text="Nome: " Width="120px" Height="19px"></asp:Label>
            <asp:TextBox ID="txtNome" runat="server" Width="650px"></asp:TextBox>
        </div>
            <asp:GridView ID="gridCategorias" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="374px">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
        <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
    </form>
    </body>
</html>
