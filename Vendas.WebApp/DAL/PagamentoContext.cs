using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.DAL
{
    public class PagamentoContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=False;MultipleActiveResultSets=true;";
        //string _ConnectionString = "Server=47.254.54.175;Database=estoque;User Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public List<Pagamento> ToListProdutosComanda(int id)
        {
            List<Pagamento> pagamento = new List<Pagamento>();
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "USE [estoque] SELECT [dbo].[Produto].[Nome] AS Produto, " +
                                        "[dbo].[VendaProduto].[Quantidade] AS Quantidade, " +
                                        "[dbo].[VendaProduto].[Valor] AS Valor, " +
                                        "[dbo].[Venda].[Data] AS Data " +
                                        "FROM [dbo].[VendaProduto] " +
                                        "INNER JOIN [dbo].[Produto] " +
                                        "ON [dbo].[VendaProduto].[ProdutoId] = [dbo].[Produto].[Id] " +
                                        "INNER JOIN [dbo].[Venda] " +
                                        "ON [dbo].[VendaProduto].[VendaId] = [dbo].[Venda].[Id] " +
                                        "INNER JOIN [estoque].[dbo].[Comanda] " +
                                        "ON [dbo].[Venda].[ComandaId] = [dbo].[Comanda].[Id] " +
                                        "WHERE [dbo].[Comanda].[Id] = " + id + " ;";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pagamento.Add(new Pagamento()
                    {
                        Produto = dr["Produto"].ToString(),
                        Quantidade = dr["Quantidade"].ToString(),
                        Valor = dr["Valor"].ToString(),
                        Data = dr["Data"].ToString(),
                    });
                }
                dr.Close();
                return pagamento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
