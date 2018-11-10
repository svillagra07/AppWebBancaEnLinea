using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cliente
/// </summary>
public class Cliente
{
    public int cli_cod_cliente { get; set; }
    public string cli_identificacion { get; set; }
    public string cli_nombre { get; set; }
    public string cli_email { get; set; }
    public DateTime cli_fec_nac { get; set; }
    public string cli_estado { get; set; }
    public string username { get; set; }

    public Cliente()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}