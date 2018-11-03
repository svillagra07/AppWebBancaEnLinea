using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using Microsoft.IdentityModel.Tokens;
public enum EstadoSesion
{
    Activa,
    Cerrada,
    Expirada
}
public class AppUsuario
{
    public int Codigo { get; set; }
    public string Username { get; set; }
    public string Nombre { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Estado { get; set; }
    public int IntentosFallidos { get; set; }
    public DateTime FechaInclusion { get; set; }
    public DateTime FechaUltimaActividad { get; set; }
    public SecurityToken Token { get; set; }
    public EstadoSesion EstadoSesionActual { get; set; }

    public AppUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
}