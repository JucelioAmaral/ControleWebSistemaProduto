using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Categoria : System.Web.UI.Page
{

    CategoriaBLL objCategoria = new CategoriaBLL();

    protected void Page_Load(object sender, EventArgs e)
    {
        CarregarGridView();
    }
    private void CarregarGridView()
    {
        gridCategorias.DataSource = objCategoria.RetCategoriaProdutos();
        gridCategorias.DataBind();
    }
    protected void btnGravar_Click(object sender, EventArgs e)
    {
        objCategoria.Nome = txtNome.Text;


        if (string.IsNullOrEmpty(txtID.Text))
        {
            objCategoria.InserirCategoria();
        }
        else
        {
            objCategoria.AlterarCategoria(txtID.Text);
        }
        LimparTela();
        CarregarGridView();
    }

    protected void btnCarregar_Click(object sender, EventArgs e)
    {
        DataTable data = objCategoria.CarregarCategoriaPorID(txtID.Text);
        txtNome.Text = data.Rows[0]["nome"].ToString();
    }

    protected void btnExcluir_Click(object sender, EventArgs e)
    {
        objCategoria.ExcluirCategoria(txtID.Text);
        CarregarGridView();
        LimparTela();
    }

    protected void btnLimpar_Click(object sender, EventArgs e)
    {
        LimparTela();
    }
    public void LimparTela()
    {
        txtID.Text = string.Empty;
        txtNome.Text = string.Empty;
    }
    
    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}