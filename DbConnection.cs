using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
namespace WebApplication2.Models
{
    public class DbConnection
    {
        private IDbConnection connection;
        
        public DbConnection()
        {

            connection = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BibliotecaFal;Data Source=.");
        }

        public void CrearUsuario(UsuarioModel usuario){
             connection.Execute
                ("insert into Usuarios(Nombre,Email,Password) values(@Nombre,@Email,@Password)", usuario);
    
        }

        public UsuarioModel BuscarPorEmail(string email)
        {
            return connection.Query<UsuarioModel>("SELECT top 1 * FROM Usuarios where Email = @Email", new { Email = email }).FirstOrDefault();
        }

        public IEnumerable<UsuarioModel> Usuarios
        {
            get
            {
                return connection.Query<UsuarioModel>("SELECT * FROM Usuarios");
            }
        }
 
    }
}