using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cuenta
/// </summary>
public class Cuenta
{
    public int cue_cod_cuenta { get; set; }
    public int cli_cod_cliente { get; set; }
    public string cue_descripcion { get; set; }
    public decimal cue_saldo { get; set; }
    public string cue_estado { get; set; }
    public string cue_moneda { get; set; }

    public Cuenta()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}