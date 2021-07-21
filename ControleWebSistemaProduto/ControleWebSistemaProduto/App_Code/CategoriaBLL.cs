using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;


public class CategoriaBLL
{
   public string Nome { get; set; }
   DAL objDAL = new DAL();

    public DataTable RetCategoriaProdutos()
    {
        return objDAL.RetDataTable("SELECT * FROM categoria");
    }
    public DataTable CarregarCategoriaPorID(string id)
    {
        return objDAL.RetDataTable("SELECT * FROM categoria WHERE id=" + id);
    }
    public void InserirCategoria()
    {
        string sql = "INSERT INTO categoria (nome) VALUES ('{0}')";
        sql = string.Format(sql, Nome);
        objDAL.ExecutarComandoSQL(sql);
    }
    public void AlterarCategoria(string id)
    {
        string sql = "UPDATE categoria SET nome='{0}' WHERE id= '{1}'";
        sql = string.Format(sql, Nome,id);
        objDAL.ExecutarComandoSQL(sql);
    }
    public void ExcluirCategoria(string id)
    {
        string sql = string.Format("DELETE FROM categoria WHERE id ='{0}'", id);
        objDAL.ExecutarComandoSQL(sql);
    }
}