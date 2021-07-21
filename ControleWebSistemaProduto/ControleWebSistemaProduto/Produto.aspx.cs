using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Produto : System.Web.UI.Page
{
    ProdutoBLL objProduto = new ProdutoBLL();
    CategoriaBLL objCategora = new CategoriaBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarGridView();

        if (!IsPostBack)
        {
            CarregarCategorias();
        }
    }
    private void CarregarCategorias()
    {
        ddlcategoriaProduto.DataSource = objCategora.RetCategoriaProdutos();
        ddlcategoriaProduto.DataValueField = "id";
        ddlcategoriaProduto.DataTextField = "nome";
        ddlcategoriaProduto.DataBind();
    }

    private void CarregarGridView()
    {
        gridProdutos.DataSource = objProduto.RetListarProdutos();
        gridProdutos.DataBind();
    }

    protected void btnGravar_Click(object sender, EventArgs e)
    {
        objProduto.Nome = txtNome.Text;
        objProduto.Descricao = txtDescricao.Text;
        objProduto.Preco_Custo = decimal.Parse( txtPrecoCusto.Text);
        objProduto.Preco_Venda = decimal.Parse(txtPrecoVenda.Text);
        objProduto.Quantidade = double.Parse(txtQuantidade.Text);
        objProduto.Unidade_medida = txtUnidadeMedida.Text;
        objProduto.categoria_id = int.Parse(ddlcategoriaProduto.SelectedValue.ToString());

        if (string.IsNullOrEmpty(txtID.Text))
        {
            objProduto.InserirProduto();
        }
        else
        {
            objProduto.AlterarProduto(txtID.Text);
        }
        LimparTela();
        CarregarGridView();
    }

    protected void btnCarregar_Click(object sender, EventArgs e)
    {
        CarregarProduto();
    }
    private void CarregarProduto()
    {
        DataTable data = objProduto.CarregarProdutoPorID(txtID.Text);
        txtNome.Text = data.Rows[0]["nome"].ToString();
        txtDescricao.Text = data.Rows[0]["descricao"].ToString();
        txtPrecoCusto.Text = data.Rows[0]["preco_custo"].ToString();
        txtPrecoVenda.Text = data.Rows[0]["preco_venda"].ToString();
        txtQuantidade.Text = data.Rows[0]["quantidade"].ToString();
        txtUnidadeMedida.Text = data.Rows[0]["unidade_medida"].ToString();
        ddlcategoriaProduto.SelectedValue = data.Rows[0]["categoria_id"].ToString();
    }
    
    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        objProduto.ExcluirProduto(txtID.Text);
        CarregarGridView();
        LimparTela();
    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparTela();
    }
    private void LimparTela()
    {
        txtID.Text = string.Empty;
        txtNome.Text = string.Empty;
        txtDescricao.Text = string.Empty;
        txtPrecoCusto.Text = string.Empty;
        txtPrecoVenda.Text = string.Empty;
        txtQuantidade.Text = string.Empty;
        txtUnidadeMedida.Text = string.Empty;

    }

    protected void gridProdutos_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtID.Text = gridProdutos.SelectedRow.Cells[1].Text;
        CarregarProduto();
    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}