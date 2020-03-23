using System;
using System.Data.SqlClient;
using System.Globalization;
using Vendas.WebApp.Models;

namespace Vendas.WebApp.DAL
{
    public class ProdutoContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true;";
        //string _ConnectionString = "Server=47.254.54.175;Database=estoque;User Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public string ValorUnitario(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                string valor;
                sqlConnection.Open();
                string sql = "SELECT [estoque].[dbo].[Produto].[Valor] FROM [estoque].[dbo].[Produto] WHERE [estoque].[dbo].[Produto].[Id] = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                return valor = (string)cmd.ExecuteScalar();
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
        public Produto ObjProdutoBanco(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                Produto p = new Produto();
                sqlConnection.Open();
                string sql = "SELECT * FROM [estoque].[dbo].[Produto] WHERE [estoque].[dbo].[Produto].[Id] = " + id + ";";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    p.Nome = dr["Nome"].ToString();
                    p.Quantidade = Convert.ToInt32(dr["Quantidade"]);
                    p.QuantidadeMinima = Convert.ToInt32(dr["QuantidadeMinima"]);
                    p.Valor = dr["Valor"].ToString();
                    p.ValorBruto = dr["ValorBruto"].ToString();
                    p.ValorCustoTotal = dr["ValorCustoTotal"].ToString();
                    p.ValorCustoUnitario = dr["ValorCustoUnitario"].ToString();
                    p.ValorLucroTotal = dr["ValorLucroTotal"].ToString();
                    p.ValorLucroUnitario = dr["ValorLucroUnitario"].ToString();
                }
                dr.Close();
                return p;
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
        public void UpdateProduto(int idProduto, int quantProdutoPedido)
        {
            Produto objBanco = new Produto();
            objBanco = ObjProdutoBanco(idProduto);
            objBanco.Quantidade = objBanco.Quantidade - quantProdutoPedido ;
            double valorcustopedido = double.Parse(objBanco.ValorCustoTotal) - (double.Parse(objBanco.ValorCustoUnitario) * quantProdutoPedido); 
            objBanco.ValorCustoTotal = valorcustopedido.ToString(@"#\.##", CultureInfo.InvariantCulture);
            double valorlucropedido = double.Parse(objBanco.ValorLucroTotal) - (double.Parse(objBanco.ValorLucroUnitario) * quantProdutoPedido);
            objBanco.ValorLucroTotal = valorlucropedido.ToString(@"#\.##", CultureInfo.InvariantCulture);
            objBanco.ValorBruto = (double.Parse(objBanco.ValorCustoTotal) + double.Parse(objBanco.ValorLucroTotal)).ToString(@"#\.##", CultureInfo.InvariantCulture);
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "UPDATE [estoque].[dbo].[Produto] SET [Quantidade] = " + objBanco.Quantidade + ", [ValorCustoTotal] = " + objBanco.ValorCustoTotal + ", [ValorLucroTotal] = " + objBanco.ValorLucroTotal + ", [ValorBruto] = " + objBanco.ValorBruto + " WHERE [estoque].[dbo].[Produto].[Id] = " + idProduto + ";";
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
