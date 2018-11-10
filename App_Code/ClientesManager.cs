using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;

/// <summary>
/// Descripción breve de ClientesManager
/// </summary>
public class ClientesManager
{
    const string Url = "http://localhost/WebApiJWT/api/cliente/"; // URL del Servicio RESTful

    public ClientesManager()
    {
    }

    private HttpClient GetClient()
    {
        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        HttpClient client = new HttpClient();

        client.DefaultRequestHeaders.Add("Authorization", VariablesGlobales.AuthorizationKey);
        client.DefaultRequestHeaders.Add("Accept", "application/json");
        return client;
    }

    public async Task<IEnumerable<Cliente>> GetAll()
    {
      
        HttpClient client = GetClient();
        string result = await client.GetStringAsync(Url);
        return JsonConvert.DeserializeObject<IEnumerable<Cliente>>(result);
    }



    public async Task<Cliente> GetCliente(string id)
    {

        HttpClient client = GetClient();
        var uri = new Uri(string.Format(Url + "{0}", id));
        string result = await client.GetStringAsync(uri);
        return JsonConvert.DeserializeObject<Cliente>(result);
    }
}