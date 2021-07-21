using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;
/// <summary>
/// Descrição resumida de ProdutoBLL
/// </summary>
public class ProdutoBLL
{
    public string Nome {get; set;}
    public string Descricao {get; set;}
    public decimal Preco_Custo {get; set;}
    public decimal Preco_Venda {get; set;}
    public double Quantidade {get; set;}
    public string Unidade_medida {get; set;}
    public int categoria_id {get; set;}
    DAL objDAL = new DAL();

    public DataTable RetListarProdutos()
    {
        return objDAL.RetDataTable("SELECT * FROM produto");
    }
    public DataTable CarregarProdutoPorID(string id)
    {
        return objDAL.RetDataTable("SELECT * FROM produto WHERE id="+ id);
    }
    public void InserirProduto()
    {
        string sql = "INSERT INTO produto(nome, descricao,preco_custo,preco_venda,quantidade,unidade_medida,categoria_id)"+
            "VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
        sql = string.Format(sql, Nome, Descricao, Preco_Custo, Preco_Venda, Quantidade, Unidade_medida, categoria_id);
        objDAL.ExecutarComandoSQL(sql);
    }
    public void AlterarProduto(string id)
    {

        string sql = "UPDATE produto SET nome='{0}',descricao='{1}',preco_custo='{2}',preco_venda='{3}',quantidade='{4}'," +
                     "unidade_medida='{5}',categoria_id='{6}' WHERE id= '{7}'";
        sql = string.Format(sql, Nome, Descricao, Preco_Custo, Preco_Venda, Quantidade, Unidade_medida, categoria_id, id);
        objDAL.ExecutarComandoSQL(sql);
    }
    //Método refatorado
    public void ExcluirProduto(string id)
    {
        string sql = "DELETE FROM produto WHERE id = @id";
        MySqlCommand cmd = new MySqlCommand();
        cmd.Parameters.AddWithValue("@id", id);
        cmd.CommandText = sql;
        objDAL.ExecutarComandoSQL(cmd);
    }
}