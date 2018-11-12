using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Text;

/// <summary>
/// Descripción breve de ClientesManager
/// </summary>
public class ClientesManager
{
    const string Url = "http://localhost:49220/api/cliente/"; // URL del Servicio RESTful
    const string UrlObtener = "http://localhost:49220/api/cliente/obtener/"; // URL del Servicio RESTful

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



    public async Task<Cliente> GetCliente(int cli_cod_cliente, string username)
    {
        ClienteRequest clienteRequest = new ClienteRequest()
        {
            Cli_cod_cliente = cli_cod_cliente,
            Username = username
        };


        HttpClient client = GetClient();
        var response = await client.PostAsync(UrlObtener,
            new StringContent(
                JsonConvert.SerializeObject(clienteRequest),
                Encoding.UTF8, "application/json"));
        return JsonConvert.DeserializeObject<Cliente>(
            await response.Content.ReadAsStringAsync());

    }
}