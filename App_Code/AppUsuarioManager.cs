using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Data.SqlClient;
public class AppUsuarioManager
{
    const string UrlAuthenticate = "http://localhost:49220/api/login/authenticate/";
    const string UrlRegister = "http://localhost:49220/api/login/register/";
    const string UrlReset = "http://localhost:49220/api/login/reset/";
 
    
    public async Task<string> Validar(string username, string password)
    {
        LoginRequest login = new LoginRequest() { Username = username, Password = password };

        HttpClient client = new HttpClient();

        var response = await client.PostAsync(UrlAuthenticate,
            new StringContent(JsonConvert.SerializeObject(login),
            Encoding.UTF8, "application/json"));

        return JsonConvert.DeserializeObject<string>(await response.Content.ReadAsStringAsync());
    }

    public async Task<AppUsuario> Registrar(string username, string nombre, string password, string email)
    {
        AppUsuario user = new AppUsuario()
        {
            Username = username,
            Password = password,
            Nombre = nombre,
            Email = email,
            Estado = "A",
            IntentosFallidos = 0,
            FechaInclusion = DateTime.Now,
            FechaUltimaActividad = DateTime.Now
        };

        HttpClient client = new HttpClient();
        var response = await client.PostAsync(UrlRegister,
            new StringContent(JsonConvert.SerializeObject(user),
            Encoding.UTF8, "application/json"));

        return JsonConvert.DeserializeObject<AppUsuario>(await response.Content.ReadAsStringAsync());
    }

    public AppUsuario ObtenerInfoUsuario(string username)
    {
        AppUsuario usuario = new AppUsuario();

        using (SqlConnection connection =
                      new System.Data.SqlClient.SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["SamaConnectionString"].ConnectionString))
        {
            SqlCommand command = new SqlCommand(" SELECT TOP 1 Codigo, Username, " +
                "Nombre, Email, Estado, IntentosFallidos, FechaInclusion, " +
                    "FechaUltimaActividad FROM AppUsuario WHERE Username = @Username ",
                    connection);

            command.Parameters.AddWithValue("@Username", username);

            connection.Open();

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {

                usuario.Codigo = dr.GetInt32(0);
                usuario.Username = dr.GetString(1);
                usuario.Nombre = dr.GetString(2);
                usuario.Email = dr.GetString(3);
                usuario.Estado = dr.GetString(4);
                usuario.IntentosFallidos = dr.GetInt32(5);
                usuario.FechaInclusion = dr.GetDateTime(6);
                usuario.FechaUltimaActividad = dr.GetDateTime(7);
            }

            connection.Close();
        }

        return usuario;
    }


    public AppUsuarioManager()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}