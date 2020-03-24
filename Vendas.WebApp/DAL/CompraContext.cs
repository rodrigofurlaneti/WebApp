using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.DAL
{
    public class CompraContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true;";
        //string _ConnectionString = "Server=47.254.54.175;Database=estoque;User Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public List<Compra> FindAll()
        {
            List<Compra> Compra = new List<Compra>();
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "SELECT [Nome] as Produto, [Quantidade], [QuantidadeMinima], [ValorCustoUnitario], [ValorCustoTotal], ([QuantidadeMinima] - [Quantidade]) AS QuantidadeCompra FROM [dbo].[Produto];";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (Convert.ToInt32(dr["QuantidadeCompra"]) > 0)
                    {
                        Compra.Add(new Compra()
                        {
                            Produto = dr["Produto"].ToString(),
                            Quantidade = Convert.ToInt32(dr["Quantidade"]),
                            QuantidadeMinima = Convert.ToInt32(dr["QuantidadeMinima"]),
                            QuantidadeCompra = dr["QuantidadeCompra"].ToString(),
                            ValorCustoUnitario = dr["ValorCustoUnitario"].ToString(),
                            ValorCustoTotal = dr["ValorCustoTotal"].ToString(),
                        });
                    }
                }
                dr.Close();
                return Compra;
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
