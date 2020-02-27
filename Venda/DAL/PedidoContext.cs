﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using WebApp.Models;
namespace WebApp.DAL
{
    public class PedidoContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true";
        public List<Pedido> ToList()
        {
            List<Pedido> pedido = new List<Pedido>();
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "SELECT " +
                                    "[estoque].[dbo].[Produto].[Nome] as Produto" +
                                    ",[estoque].[dbo].[VendaProduto].[Quantidade]" +
                                    ",[estoque].[dbo].[Cliente].[Nome]" +
                                    ",[estoque].[dbo].[Venda].[Data]" +
                                    "FROM[estoque].[dbo].[VendaProduto]" +
                                    "INNER JOIN[estoque].[dbo].[Produto]" +
                                    "ON[estoque].[dbo].[VendaProduto].[ProdutoId] = [estoque].[dbo].[Produto].[Id]" +
                                    "INNER JOIN[estoque].[dbo].[venda]" +
                                    "ON[estoque].[dbo].[VendaProduto].[VendaId] = [estoque].[dbo].[Venda].[Id]" +
                                    "INNER JOIN[estoque].[dbo].[cliente]" +
                                    "ON[estoque].[dbo].[Venda].[ClienteId] = [estoque].[dbo].[Cliente].[Id]" +
                                    "ORDER BY [estoque].[dbo].[Venda].[Data] DESC;";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    pedido.Add(new Pedido()
                    {
                        Produto = dr["Produto"].ToString(),
                        Quantidade = dr["Quantidade"].ToString(),
                        Nome = dr["Nome"].ToString(),
                        Data = dr["Data"].ToString(),
                    });
                }
                dr.Close();
                return pedido;
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
