<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Produto.aspx.cs" Inherits="Produto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="StyleSheet.css"/>
</head>
<body style="height: 523px; width: 816px">
    <form id="form1" runat="server">
        <p style="text-align:center;">
            <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="Cadastro de Produtos no Estoque" CssClass="label_tela"></asp:Label>
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
        <br />
        <asp:Label ID="Label2" runat="server" Text="Descrição:" Width="120px"></asp:Label>
        <asp:TextBox ID="txtDescricao" runat="server" Height="72px" style="margin-left: 0px" TextMode="MultiLine" Width="650px"></asp:TextBox>
        <br />
            <asp:Label ID="Label4" runat="server" Text="Preço custo:" Width="120px"></asp:Label>
            <asp:TextBox ID="txtPrecoCusto" runat="server" style="margin-top: 0px" Width="119px"></asp:TextBox>
        <br />
            <asp:Label ID="Label5" runat="server" Text="Preço de venda:" Width="120px"></asp:Label>
            <asp:TextBox ID="txtPrecoVenda" runat="server" Height="16px" Width="99px"></asp:TextBox>
        <br />
            <asp:Label ID="Label6" runat="server" Text="Quantidade:" Width="120px"></asp:Label>
            <asp:TextBox ID="txtQuantidade" runat="server" Height="16px" Width="125px"></asp:TextBox>
        <br />
            <asp:Label ID="Label7" runat="server" Text="Un. Medida:" Width="120px"></asp:Label>
            <asp:TextBox ID="txtUnidadeMedida" runat="server" Height="16px" Width="125px"></asp:TextBox>
        <br />
            <asp:Label ID="Label3" runat="server" Text="Categoria:" Width="108px"></asp:Label>&nbsp;
            <asp:DropDownList ID="ddlcategoriaProduto" runat="server" Height="18px" Width="134px" style="margin-left: 6px">
            </asp:DropDownList>
        <br />
        <br />
            Produtos disponíveis no estoque:
        <br />
            <asp:GridView ID="gridProdutos" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" Width="374px" OnSelectedIndexChanged="gridProdutos_SelectedIndexChanged">
                <Columns>
                    <asp:CommandField ButtonType="Button" ShowSelectButton="True" />
                </Columns>
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
        <br />
        <asp:Button ID="btnVoltar" runat="server" OnClick="btnVoltar_Click" Text="Voltar" />
    </form>
</body>
</html>
