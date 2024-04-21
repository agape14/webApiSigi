using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webApiSigi.Models;

public partial class TPerfilUsuario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int CodPerfil { get; set; }

    public string? Descripcion { get; set; }

    [StringLength(1)]
    [Column(TypeName = "char(1)")]
    public string? EstPerfil { get; set; }

    public string? RegistradoPor { get; set; }

    public DateOnly? FechaRegistro { get; set; }

    public string? ModificadoPor { get; set; }

    public DateOnly? FechaModificado { get; set; }
}
