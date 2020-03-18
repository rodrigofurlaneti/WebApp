using System;
using System.Data.SqlClient;
namespace Vendas.WebApp.DAL
{
    public class ProdutoContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true;";
        //string _ConnectionString = "Server=47.254.54.175;Database=estoque;User Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public decimal ValorUnitario(int id)
        {
            decimal valorUnitario;
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "SELECT [estoque].[dbo].[Produto].[Valor] FROM [estoque].[dbo].[Produto] WHERE [estoque].[dbo].[Produto].[Id] = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                valorUnitario = (decimal)cmd.ExecuteScalar();
                return valorUnitario;
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

        public int QuantProduto(int id)
        {
            int quant;
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "SELECT [estoque].[dbo].[Produto].[Quantidade] FROM [estoque].[dbo].[Produto] WHERE [estoque].[dbo].[Produto].[Id] = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                quant = (Int32)cmd.ExecuteScalar();
                return quant;
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

        public void DeleteProduto(int idProduto, int quantProdutoPedido)
        {
            int quantBanco = QuantProduto(idProduto);
            int quantAtual = quantBanco - quantProdutoPedido;
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "UPDATE [estoque].[dbo].[Produto] SET[estoque].[dbo].[Produto].[Quantidade] = "+ quantAtual +" WHERE[estoque].[dbo].[Produto].[Id] = "+ idProduto +";";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.ExecuteNonQuery();
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
