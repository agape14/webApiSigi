using System;
using System.Collections.Generic;

namespace webApiSigi.Models;

public partial class TPersona
{
    public string CodPersona { get; set; } = null!;

    public string? TipoPersona { get; set; }

    public string? NombreCompleto { get; set; }

    public string? TipoDoc { get; set; }

    public string? Titulo { get; set; }

    public string? Organizacion { get; set; }

    public string? Area { get; set; }

    public string? Cargo { get; set; }

    public string? Usuario { get; set; }

    public string? Clave { get; set; }

    public string? Email { get; set; }

    public string? Telefono { get; set; }

    public string? Movil { get; set; }

    public string? Estado { get; set; }

    public string? CodRepresentante { get; set; }

    public string? Domicilio { get; set; }

    public string? Ruc { get; set; }

    public string? Ubigeo { get; set; }

    public string? DomicilioCompleto { get; set; }

    public string? TipoUsuario { get; set; }

    public int? CodPerfil { get; set; }

    public string? Sexo { get; set; }

    public string? Paterno { get; set; }

    public string? Materno { get; set; }

    public string? Nombres { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }

    public string? Dist { get; set; }

    public string? Prov { get; set; }

    public string? Dpto { get; set; }

    public string? TipoDocumento { get; set; }
}
