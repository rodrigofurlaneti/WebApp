using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.DAL
{
    public class UsuarioContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true";
        public List<Usuario> FindByUser(string user)
        {
            List<Usuario> usuario = new List<Usuario>();
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "USE [estoque] SELECT [Senha] FROM [dbo].[Usuario] WHERE [Usuario].[Nome] = '"+user+"';";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usuario.Add(new Usuario()
                    {
                        Senha = dr["Senha"].ToString(),
                    });
                }
                dr.Close();
                return usuario;
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
