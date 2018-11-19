using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de TransferenciaManager
/// </summary>
public class TransferenciaManager
{
    const string Url = "http://localhost:49220/api/transferencia/"; // URL del Servicio RESTful
    const string UrlObtener = "http://localhost:49220/api/transferencia/obtener/"; // URL del Servicio RESTful

    public TransferenciaManager()
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

    public async Task<Transferencia> Ingresar(int cli_cod_cliente, int cuentaOrigen, int cuentaDestino, string descripcion, string estado,
        DateTime fecha, decimal monto)
    {
        Transferencia transferencia = new Transferencia()
        {
            tra_cod_transferencia = 0,
            cli_cod_cliente = cli_cod_cliente,
            tra_cuenta_origen = cuentaOrigen,
            tra_cuenta_destino = cuentaDestino,
            tra_descripcion = descripcion,
            tra_estado = "A",
            tra_fecha = fecha,
            tra_monto = monto
        };

        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

        HttpClient client = GetClient();
        var response = await client.PostAsync(Url,
            new StringContent(
                JsonConvert.SerializeObject(transferencia),
                Encoding.UTF8, "application/json"));


        return JsonConvert.DeserializeObject<Transferencia>(
            await response.Content.ReadAsStringAsync());

    }

    public async Task<IEnumerable<Transferencia>> ObtenerTransferencias(int cli_cod_cliente)
    {
        TransferenciaRequest request = new TransferenciaRequest()
        {
            Cli_cod_cliente = cli_cod_cliente
        };


        HttpClient client = GetClient();
        var response = await client.PostAsync(UrlObtener,
            new StringContent(
                JsonConvert.SerializeObject(request),
                Encoding.UTF8, "application/json"));
        return JsonConvert.DeserializeObject<IEnumerable<Transferencia>>(
            await response.Content.ReadAsStringAsync());

    }
}