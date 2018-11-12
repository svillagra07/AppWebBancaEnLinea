using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de VariablesGlobales
/// </summary>
public class VariablesGlobales
{

    public static string AuthorizationKey { get; set; }
    public static string CodigoUsuario { get; set; }
    public static string NombreUsuario { get; set; }
    public static string EmailUsuario { get; set; }
    public static SecurityToken Token { get; set; }
    public static EstadoSesion EstadoSesionActual { get; set; }
    public static Cliente clienteActual { get; set; }

    public VariablesGlobales()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}