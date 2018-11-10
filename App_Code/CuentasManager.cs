using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de CuentasManager
/// </summary>
public class CuentasManager
{
    const string Url = "http://localhost/WebApiJWT/api/cuenta/"; // URL del Servicio RESTful

    public CuentasManager()
    {
    }

    private HttpClient GetClient()
    {
  
        HttpClient client = new HttpClient();

        client.DefaultRequestHeaders.Add("Authorization", VariablesGlobales.AuthorizationKey);
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        return client;
    }

    public async Task<IEnumerable<Cuenta>> GetAll()
    {

        HttpClient client = GetClient();
        string result = await client.GetStringAsync(Url);
        return JsonConvert.DeserializeObject<IEnumerable<Cuenta>>(result);
    }



    public async Task<Cuenta> GetCuenta(string id)
    {

        HttpClient client = GetClient();
        var uri = new Uri(string.Format(Url + "{0}", id));
        string result = await client.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<Cuenta>(result);
    }
}