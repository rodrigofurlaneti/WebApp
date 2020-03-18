using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.DAL
{
    public class UsuarioContext
    {
        string _ConnectionString = "Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true;";
        //string _ConnectionString = "Server=47.254.54.175;Database=estoque;user Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;";
        public List<Usuario> FindByUser(string user)
        {
            List<Usuario> usuario = new List<Usuario>();
            SqlConnection sqlConnection = new SqlConnection(_ConnectionString);
            try
            {
                sqlConnection.Open();
                string sql = "USE [estoque] SELECT .[dbo].[Usuario].[Id], [dbo].[Usuario].[Nome], [dbo].[Usuario].[Senha], [dbo].[Usuario].[IdCargo], [dbo].[Cargo].[Nome] as NomeCargo FROM [dbo].[Usuario] INNER JOIN[estoque].[dbo].[Cargo] ON[estoque].[dbo].[Usuario].[IdCargo] = [estoque].[dbo].[Cargo].[Id] WHERE[Usuario].[Nome] = '" + user+"';";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    usuario.Add(new Usuario()
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nome = dr["Nome"].ToString(),
                        Senha = dr["Senha"].ToString(),
                        IdCargo = Convert.ToInt32(dr["IdCargo"]),
                        NomeCargo = dr["NomeCargo"].ToString(),
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
