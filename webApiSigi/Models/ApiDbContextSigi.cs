using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace webApiSigi.Models;

public partial class ApiDbContextSigi : DbContext
{
    private readonly IConfiguration _configuration;
    
    public ApiDbContextSigi(DbContextOptions<ApiDbContextSigi> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public virtual DbSet<Configuracion> Configuracions { get; set; }

    public virtual DbSet<Depositante> Depositantes { get; set; }

    public virtual DbSet<EmisionComprobanteManal> EmisionComprobanteManals { get; set; }

    public virtual DbSet<EmisionComprobanteManalCopy1> EmisionComprobanteManalCopy1s { get; set; }

    public virtual DbSet<EmisionComprobanteManalCopy2> EmisionComprobanteManalCopy2s { get; set; }

    public virtual DbSet<MotivoDesocupacion> MotivoDesocupacions { get; set; }

    public virtual DbSet<PersonasItl> PersonasItls { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<ReporteMargesi> ReporteMargesis { get; set; }

    public virtual DbSet<Sysdiagram> Sysdiagrams { get; set; }

    public virtual DbSet<TActo> TActos { get; set; }

    public virtual DbSet<TActoAnulacion> TActoAnulacions { get; set; }

    public virtual DbSet<TActoBeneficiario> TActoBeneficiarios { get; set; }

    public virtual DbSet<TAperturaCierreInmueble> TAperturaCierreInmuebles { get; set; }

    public virtual DbSet<TAuditorium> TAuditoria { get; set; }

    public virtual DbSet<TBanco> TBancos { get; set; }

    public virtual DbSet<TCarga> TCargas { get; set; }

    public virtual DbSet<TComprobante> TComprobantes { get; set; }

    public virtual DbSet<TComprobanteCreditoCab> TComprobanteCreditoCabs { get; set; }

    public virtual DbSet<TComprobanteCreditoDet> TComprobanteCreditoDets { get; set; }

    public virtual DbSet<TConceptoGasto> TConceptoGastos { get; set; }

    public virtual DbSet<TConceptoIngreso> TConceptoIngresos { get; set; }

    public virtual DbSet<TContrato> TContratos { get; set; }

    public virtual DbSet<TContratoAnulacion> TContratoAnulacions { get; set; }

    public virtual DbSet<TContratoBk20230321> TContratoBk20230321s { get; set; }

    public virtual DbSet<TContratoGarantia> TContratoGarantias { get; set; }

    public virtual DbSet<TContratoPersona> TContratoPersonas { get; set; }

    public virtual DbSet<TDatosCobranzaTmp> TDatosCobranzaTmps { get; set; }

    public virtual DbSet<TDetallePagoParcial> TDetallePagoParcials { get; set; }

    public virtual DbSet<TDetalleReporteBanco> TDetalleReporteBancos { get; set; }

    public virtual DbSet<TDetraccion> TDetraccions { get; set; }

    public virtual DbSet<TDeudasXTrimestre> TDeudasXTrimestres { get; set; }

    public virtual DbSet<TEdificacion> TEdificacions { get; set; }

    public virtual DbSet<TEdificacionInspeccion> TEdificacionInspeccions { get; set; }

    public virtual DbSet<TEdificacionInspeccionUi> TEdificacionInspeccionUis { get; set; }

    public virtual DbSet<TEnviaResuman> TEnviaResumen { get; set; }

    public virtual DbSet<TExportaBancoCab> TExportaBancoCabs { get; set; }

    public virtual DbSet<TExportaBancoDet> TExportaBancoDets { get; set; }

    public virtual DbSet<TExportaContaCab> TExportaContaCabs { get; set; }

    public virtual DbSet<TExportaContaCabSimula> TExportaContaCabSimulas { get; set; }

    public virtual DbSet<TExportaContaDet> TExportaContaDets { get; set; }

    public virtual DbSet<TExportaContaDetSimula> TExportaContaDetSimulas { get; set; }

    public virtual DbSet<TExportaInfocorpCab> TExportaInfocorpCabs { get; set; }

    public virtual DbSet<TFotoProvisional> TFotoProvisionals { get; set; }

    public virtual DbSet<TGasto> TGastos { get; set; }

    public virtual DbSet<TGuiaRemisionCab> TGuiaRemisionCabs { get; set; }

    public virtual DbSet<TGuiaRemisionDet> TGuiaRemisionDets { get; set; }

    public virtual DbSet<TImagenReporte> TImagenReportes { get; set; }

    public virtual DbSet<TImportaBancoCab> TImportaBancoCabs { get; set; }

    public virtual DbSet<TImportaBancoCabAct> TImportaBancoCabActs { get; set; }

    public virtual DbSet<TImportaBancoDet> TImportaBancoDets { get; set; }

    public virtual DbSet<TImportaBancoDetAct> TImportaBancoDetActs { get; set; }

    public virtual DbSet<TIngresoTesorerium> TIngresoTesoreria { get; set; }

    public virtual DbSet<TInmueble> TInmuebles { get; set; }

    public virtual DbSet<TInmuebleFoto> TInmuebleFotos { get; set; }

    public virtual DbSet<TInspeccion> TInspeccions { get; set; }

    public virtual DbSet<TInspeccionTecnica> TInspeccionTecnicas { get; set; }

    public virtual DbSet<TInspeccionTecnicaAnalisi> TInspeccionTecnicaAnalises { get; set; }

    public virtual DbSet<TInspeccionTecnicaConclusione> TInspeccionTecnicaConclusiones { get; set; }

    public virtual DbSet<TInspeccionTecnicaRecomendacione> TInspeccionTecnicaRecomendaciones { get; set; }

    public virtual DbSet<TInspeccionTecnicaUi> TInspeccionTecnicaUis { get; set; }

    public virtual DbSet<TItl> TItls { get; set; }

    public virtual DbSet<TItlAnalisi> TItlAnalises { get; set; }

    public virtual DbSet<TItlAnulacion> TItlAnulacions { get; set; }

    public virtual DbSet<TItlConclusione> TItlConclusiones { get; set; }

    public virtual DbSet<TMargesiReporte> TMargesiReportes { get; set; }

    public virtual DbSet<TMotivo> TMotivos { get; set; }

    public virtual DbSet<TMotivoTraslado> TMotivoTraslados { get; set; }

    public virtual DbSet<TMovimientoContable> TMovimientoContables { get; set; }

    public virtual DbSet<TOpinionLegal> TOpinionLegals { get; set; }

    public virtual DbSet<TPagoContrato> TPagoContratos { get; set; }

    public virtual DbSet<TPagoContratoBak> TPagoContratoBaks { get; set; }

    public virtual DbSet<TParametro> TParametros { get; set; }

    public virtual DbSet<TParametroSistema> TParametroSistemas { get; set; }

    public virtual DbSet<TParticipanteSubastum> TParticipanteSubasta { get; set; }

    public virtual DbSet<TPerfilUsuario> TPerfilUsuarios { get; set; }

    public virtual DbSet<TPerfilUsuarioAcceso> TPerfilUsuarioAccesos { get; set; }

    public virtual DbSet<TPersona> TPersonas { get; set; }

    public virtual DbSet<TPlanillaCobranza> TPlanillaCobranzas { get; set; }

    public virtual DbSet<TPlanillaDeposito> TPlanillaDepositos { get; set; }

    public virtual DbSet<TPostorSubastum> TPostorSubasta { get; set; }

    public virtual DbSet<TProcesoJudicial> TProcesoJudicials { get; set; }

    public virtual DbSet<TProcesoJudicialCitum> TProcesoJudicialCita { get; set; }

    public virtual DbSet<TProcesoJudicialDoc> TProcesoJudicialDocs { get; set; }

    public virtual DbSet<TProcesoJudicialEtapa> TProcesoJudicialEtapas { get; set; }

    public virtual DbSet<TProcesoJudicialGasto> TProcesoJudicialGastos { get; set; }

    public virtual DbSet<TProcesoJudicialSeguimiento> TProcesoJudicialSeguimientos { get; set; }

    public virtual DbSet<TProvisional> TProvisionals { get; set; }

    public virtual DbSet<TProvisional2> TProvisional2s { get; set; }

    public virtual DbSet<TProvisionalBk> TProvisionalBks { get; set; }

    public virtual DbSet<TReprogramaDeudaContrato> TReprogramaDeudaContratos { get; set; }

    public virtual DbSet<TSubastaInmueble> TSubastaInmuebles { get; set; }

    public virtual DbSet<TSubastaPostorInmueble> TSubastaPostorInmuebles { get; set; }

    public virtual DbSet<TSubastum> TSubasta { get; set; }

    public virtual DbSet<TSupervision> TSupervisions { get; set; }

    public virtual DbSet<TTipoDocumento> TTipoDocumentos { get; set; }

    public virtual DbSet<TTiponotum> TTiponota { get; set; }

    public virtual DbSet<TTmpRepIngresosDetallado> TTmpRepIngresosDetallados { get; set; }

    public virtual DbSet<TUbigeo> TUbigeos { get; set; }

    public virtual DbSet<TUnidadInmobiliariaEdificacion> TUnidadInmobiliariaEdificacions { get; set; }

    public virtual DbSet<TUnidadInmobiliariaEdificacionInspeccion> TUnidadInmobiliariaEdificacionInspeccions { get; set; }

    public virtual DbSet<TUnidadInmobiliarium> TUnidadInmobiliaria { get; set; }

    public virtual DbSet<TbChangeCod> TbChangeCods { get; set; }

    public virtual DbSet<TbChangeCodV2> TbChangeCodV2s { get; set; }

    public virtual DbSet<TblComprobantesSi> TblComprobantesses { get; set; }

    public virtual DbSet<TblValidaArchivoBanco> TblValidaArchivoBancos { get; set; }

    public virtual DbSet<TblVentaLibro> TblVentaLibros { get; set; }

    public virtual DbSet<TblVentaLibros2> TblVentaLibros2s { get; set; }

    public virtual DbSet<VAprobacionGarantia> VAprobacionGarantias { get; set; }

    public virtual DbSet<VConsultum> VConsulta { get; set; }

    public virtual DbSet<VInfocorp> VInfocorps { get; set; }

    public virtual DbSet<VMargesiAmpliado> VMargesiAmpliados { get; set; }

    public virtual DbSet<VMargesiAmpliadoDetallado> VMargesiAmpliadoDetallados { get; set; }

    public virtual DbSet<_28092022> _28092022s { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("conexionDbSigi"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Configuracion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONFIGURACION");

            entity.Property(e => e.ConfDesc)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CONF_DESC");
            entity.Property(e => e.ConfValor)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("CONF_VALOR");
            entity.Property(e => e.ConfVariable)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CONF_VARIABLE");
        });

        modelBuilder.Entity<Depositante>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEPOSITANTES");

            entity.Property(e => e.Cuenta)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CUENTA");
            entity.Property(e => e.Fecha)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("FECHA");
            entity.Property(e => e.Importe)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("IMPORTE");
            entity.Property(e => e.Operacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("OPERACION");
            entity.Property(e => e.Persona)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("PERSONA");
        });

        modelBuilder.Entity<EmisionComprobanteManal>(entity =>
        {
            entity.HasKey(e => e.Idtbl).HasName("PK__EmisionC__2A4161FE7CEC2C52");

            entity.ToTable("EmisionComprobanteManal");

            entity.Property(e => e.Idtbl)
                .ValueGeneratedNever()
                .HasColumnName("idtbl");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.Codconcepto).HasColumnName("codconcepto");
            entity.Property(e => e.DescConcepto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("desc_concepto");
            entity.Property(e => e.DniRuc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("dni_ruc");
            entity.Property(e => e.Documento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Glosa)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("glosa");
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mes");
            entity.Property(e => e.NombreRazsocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre_razsocial");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Nvoid).HasColumnName("nvoid");
            entity.Property(e => e.Procesado)
                .HasDefaultValue(0)
                .HasColumnName("procesado");
            entity.Property(e => e.RentaActualizado).HasColumnName("renta_actualizado");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<EmisionComprobanteManalCopy1>(entity =>
        {
            entity.HasKey(e => e.Idtbl).HasName("PK__EmisionC__2A4161FE7CEC2C52_copy1");

            entity.ToTable("EmisionComprobanteManal_copy1");

            entity.Property(e => e.Idtbl)
                .ValueGeneratedNever()
                .HasColumnName("idtbl");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.Codconcepto).HasColumnName("codconcepto");
            entity.Property(e => e.DescConcepto)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("desc_concepto");
            entity.Property(e => e.DescEstado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("desc_estado");
            entity.Property(e => e.DniRuc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("dni_ruc");
            entity.Property(e => e.Documento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Estados)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estados");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Glosa)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("glosa");
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mes");
            entity.Property(e => e.NombreRazsocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre_razsocial");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Nvoid).HasColumnName("nvoid");
            entity.Property(e => e.PagoPendiente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("pagoPendiente");
            entity.Property(e => e.Procesado)
                .HasDefaultValue(0)
                .HasColumnName("procesado");
            entity.Property(e => e.RentaActualizado).HasColumnName("renta_actualizado");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<EmisionComprobanteManalCopy2>(entity =>
        {
            entity.HasKey(e => e.Idtbl).HasName("PK__EmisionC__2A4161FE7CEC2C52_copy1_copy1");

            entity.ToTable("EmisionComprobanteManal_copy2");

            entity.Property(e => e.Idtbl)
                .ValueGeneratedNever()
                .HasColumnName("idtbl");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.Codconcepto).HasColumnName("codconcepto");
            entity.Property(e => e.DescConcepto)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("desc_concepto");
            entity.Property(e => e.DniRuc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("dni_ruc");
            entity.Property(e => e.Documento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.Estado)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Glosa)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("glosa");
            entity.Property(e => e.Mes)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("mes");
            entity.Property(e => e.NombreRazsocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombre_razsocial");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Nvoid).HasColumnName("nvoid");
            entity.Property(e => e.Procesado)
                .HasDefaultValue(0)
                .HasColumnName("procesado");
            entity.Property(e => e.RentaActualizado).HasColumnName("renta_actualizado");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<MotivoDesocupacion>(entity =>
        {
            entity.HasKey(e => e.IdMotivoDesocup).HasName("PK__motivo_d__0F9411066C63F08C");

            entity.ToTable("motivo_desocupacion");

            entity.Property(e => e.IdMotivoDesocup)
                .ValueGeneratedNever()
                .HasColumnName("idMotivoDesocup");
            entity.Property(e => e.CodDesocup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codDesocup");
            entity.Property(e => e.EstDesocup).HasColumnName("estDesocup");
            entity.Property(e => e.NomDesocup)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nomDesocup");
        });

        modelBuilder.Entity<PersonasItl>(entity =>
        {
            entity.HasKey(e => e.IIdtabla).HasName("PK__personas__0DEEB981BF8656F0");

            entity.ToTable("personas_itl");

            entity.Property(e => e.IIdtabla).HasColumnName("iIdtabla");
            entity.Property(e => e.Dni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("dni");
            entity.Property(e => e.Migrado).HasColumnName("migrado");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Telefono)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("productos");

            entity.Property(e => e.Alias)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("alias");
            entity.Property(e => e.AvatarProducto)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("avatar_producto");
            entity.Property(e => e.CondicionProducto)
                .HasDefaultValue(1)
                .HasColumnName("condicion_producto");
            entity.Property(e => e.DescripcionProducto)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion_producto");
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_producto");
            entity.Property(e => e.PrecioProducto)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("precio_producto");
            entity.Property(e => e.StockPrevio)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("stock_previo");
            entity.Property(e => e.StockProducto).HasColumnName("stock_producto");
            entity.Property(e => e.TipoProducto)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValue("fisico")
                .HasColumnName("tipo_producto");
        });

        modelBuilder.Entity<ReporteMargesi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("reporteMargesi");

            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
        });

        modelBuilder.Entity<Sysdiagram>(entity =>
        {
            entity.HasKey(e => e.DiagramId).HasName("PK__sysdiagr__C2B05B613F0A40B4");

            entity.ToTable("sysdiagrams");

            entity.HasIndex(e => new { e.PrincipalId, e.Name }, "UK_principal_name").IsUnique();

            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Definition).HasColumnName("definition");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Name)
                .HasMaxLength(128)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<TActo>(entity =>
        {
            entity.HasKey(e => e.CodActo).HasName("PK__t_acto__5692A6CAF9294AAC");

            entity.ToTable("t_acto", tb => tb.HasTrigger("trg_t_acto"));

            entity.Property(e => e.CodActo)
                .ValueGeneratedNever()
                .HasColumnName("codActo");
            entity.Property(e => e.ActaEntrega)
                .HasMaxLength(150)
                .HasColumnName("actaEntrega");
            entity.Property(e => e.ActoConclu).HasColumnName("actoConclu");
            entity.Property(e => e.AcuerdoDirectorio)
                .HasMaxLength(150)
                .HasColumnName("acuerdoDirectorio");
            entity.Property(e => e.Administrado)
                .HasMaxLength(255)
                .HasColumnName("administrado");
            entity.Property(e => e.CausalesConclu)
                .HasMaxLength(2000)
                .HasColumnName("causalesConclu");
            entity.Property(e => e.CodActoAnterior).HasColumnName("codActoAnterior");
            entity.Property(e => e.CodActoFin).HasColumnName("codActoFin");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.CodInspConclu).HasColumnName("codInspConclu");
            entity.Property(e => e.Condiciones)
                .HasColumnType("text")
                .HasColumnName("condiciones");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.DocAprob)
                .HasMaxLength(150)
                .HasColumnName("docAprob");
            entity.Property(e => e.DocConclu)
                .HasMaxLength(255)
                .HasColumnName("docConclu");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FecActaEntrega).HasColumnName("fecActaEntrega");
            entity.Property(e => e.FecAcuerdo).HasColumnName("fecAcuerdo");
            entity.Property(e => e.FecAcuerdoDirec).HasColumnName("fecAcuerdoDirec");
            entity.Property(e => e.FecAprobGg).HasColumnName("fecAprobGG");
            entity.Property(e => e.FecDocAprob).HasColumnName("fecDocAprob");
            entity.Property(e => e.FecFin).HasColumnName("fecFin");
            entity.Property(e => e.FecInforme).HasColumnName("fecInforme");
            entity.Property(e => e.FecInicio).HasColumnName("fecInicio");
            entity.Property(e => e.FecPropuesta).HasColumnName("fecPropuesta");
            entity.Property(e => e.FecSolicitud).HasColumnName("fecSolicitud");
            entity.Property(e => e.FecSolicitudSc).HasColumnName("fecSolicitudSc");
            entity.Property(e => e.FechaConclu).HasColumnName("fechaConclu");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FinEsp)
                .HasMaxLength(6)
                .HasColumnName("finEsp");
            entity.Property(e => e.FinGen)
                .HasMaxLength(6)
                .HasColumnName("finGen");
            entity.Property(e => e.InformeAlcance)
                .HasMaxLength(150)
                .HasColumnName("informeAlcance");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoActo).HasColumnName("motivoActo");
            entity.Property(e => e.NroMeses).HasColumnName("nroMeses");
            entity.Property(e => e.NroNotificacion).HasColumnName("nroNotificacion");
            entity.Property(e => e.NumDocAprob)
                .HasMaxLength(200)
                .HasColumnName("numDocAprob");
            entity.Property(e => e.NumeroAcuerdo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("numeroAcuerdo");
            entity.Property(e => e.NumeroAcuerdoDirec)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("numeroAcuerdoDirec");
            entity.Property(e => e.NumeroInformeAlcance)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("numeroInformeAlcance");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .HasColumnName("observaciones");
            entity.Property(e => e.PropTecnEconomica)
                .HasMaxLength(150)
                .HasColumnName("propTecnEconomica");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.SolicitudAcuerdoDirec)
                .HasMaxLength(150)
                .HasColumnName("solicitudAcuerdoDirec");
            entity.Property(e => e.SolicitudArrendamiento)
                .HasMaxLength(150)
                .HasColumnName("solicitudArrendamiento");
            entity.Property(e => e.SolicitudArrendamientoSc)
                .HasMaxLength(150)
                .HasColumnName("solicitudArrendamientoSc");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoBeneficiario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoBeneficiario");
            entity.Property(e => e.TipoInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoInmueble");
        });

        modelBuilder.Entity<TActoAnulacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_acto_anulacion");

            entity.Property(e => e.ActoConclu).HasColumnName("actoConclu");
            entity.Property(e => e.Administrado)
                .HasMaxLength(255)
                .HasColumnName("administrado");
            entity.Property(e => e.CausalesConclu)
                .HasMaxLength(2000)
                .HasColumnName("causalesConclu");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodActoAnterior).HasColumnName("codActoAnterior");
            entity.Property(e => e.CodActoAnulacion).HasColumnName("codActoAnulacion");
            entity.Property(e => e.CodActoFin).HasColumnName("codActoFin");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.CodInspConclu).HasColumnName("codInspConclu");
            entity.Property(e => e.Condiciones)
                .HasColumnType("text")
                .HasColumnName("condiciones");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.DocAprob)
                .HasMaxLength(150)
                .HasColumnName("docAprob");
            entity.Property(e => e.DocConclu)
                .HasMaxLength(255)
                .HasColumnName("docConclu");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FecAprobGg).HasColumnName("fecAprobGG");
            entity.Property(e => e.FecDocAprob).HasColumnName("fecDocAprob");
            entity.Property(e => e.FecFin).HasColumnName("fecFin");
            entity.Property(e => e.FecInicio).HasColumnName("fecInicio");
            entity.Property(e => e.FechaConclu).HasColumnName("fechaConclu");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FinEsp)
                .HasMaxLength(6)
                .HasColumnName("finEsp");
            entity.Property(e => e.FinGen)
                .HasMaxLength(6)
                .HasColumnName("finGen");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NroMeses).HasColumnName("nroMeses");
            entity.Property(e => e.NroNotificacion).HasColumnName("nroNotificacion");
            entity.Property(e => e.NumDocAprob)
                .HasMaxLength(200)
                .HasColumnName("numDocAprob");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .HasColumnName("observaciones");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoBeneficiario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoBeneficiario");
            entity.Property(e => e.TipoInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoInmueble");
        });

        modelBuilder.Entity<TActoBeneficiario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_acto_beneficiario");

            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodBenef).HasColumnName("codBenef");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TAperturaCierreInmueble>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_apertura_cierre_inmueble");

            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.CodAperturaCierreInmueble)
                .ValueGeneratedOnAdd()
                .HasColumnName("codAperturaCierreInmueble");
            entity.Property(e => e.CodMargesiReporte).HasColumnName("codMargesiReporte");
            entity.Property(e => e.EstMargesiReporte)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("estMargesiReporte");
            entity.Property(e => e.FecApertura).HasColumnName("fecApertura");
            entity.Property(e => e.FecCierre).HasColumnName("fecCierre");
        });

        modelBuilder.Entity<TAuditorium>(entity =>
        {
            entity.HasKey(e => e.CodA);

            entity.ToTable("t_auditoria");

            entity.Property(e => e.CodA)
                .ValueGeneratedNever()
                .HasColumnName("codA");
            entity.Property(e => e.ArchivoLog)
                .HasMaxLength(100)
                .HasColumnName("archivoLog");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(20)
                .HasColumnName("codPersona");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Fechahora)
                .HasColumnType("datetime")
                .HasColumnName("fechahora");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(200)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Registro)
                .HasColumnType("text")
                .HasColumnName("registro");
            entity.Property(e => e.Tabla)
                .HasMaxLength(150)
                .HasColumnName("tabla");
        });

        modelBuilder.Entity<TBanco>(entity =>
        {
            entity.HasKey(e => e.CodBanco);

            entity.ToTable("t_banco");

            entity.Property(e => e.CodBanco)
                .ValueGeneratedNever()
                .HasColumnName("codBanco");
            entity.Property(e => e.Abrev)
                .HasMaxLength(15)
                .HasColumnName("abrev");
            entity.Property(e => e.CContable)
                .HasMaxLength(15)
                .HasColumnName("cContable");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.NumCuenta)
                .HasMaxLength(30)
                .HasColumnName("numCuenta");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TCarga>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_carga");

            entity.Property(e => e.Carga)
                .HasMaxLength(6)
                .HasColumnName("carga");
            entity.Property(e => e.CodCarga).HasColumnName("codCarga");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.EntCarga)
                .HasMaxLength(150)
                .HasColumnName("entCarga");
            entity.Property(e => e.FecCarga).HasColumnName("fecCarga");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.VigCarga)
                .HasMaxLength(20)
                .HasColumnName("vigCarga");
        });

        modelBuilder.Entity<TComprobante>(entity =>
        {
            entity.HasKey(e => e.CodComprob).HasName("PK__t_compro__6FFB7559F5461BB5");

            entity.ToTable("t_comprobante");

            entity.Property(e => e.CodComprob)
                .ValueGeneratedNever()
                .HasColumnName("codComprob");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(1)
                .HasColumnName("cantidad");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.DireccionSunat)
                .HasMaxLength(250)
                .HasColumnName("direccionSUNAT");
            entity.Property(e => e.Emitido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("emitido");
            entity.Property(e => e.EstComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estComprob");
            entity.Property(e => e.FacturaElectronica)
                .HasMaxLength(200)
                .HasColumnName("facturaElectronica");
            entity.Property(e => e.FechaEmision).HasColumnName("fechaEmision");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaResumen).HasColumnName("fechaResumen");
            entity.Property(e => e.FechaVenc).HasColumnName("fechaVenc");
            entity.Property(e => e.Generado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("generado");
            entity.Property(e => e.HoraComprobante)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("horaComprobante");
            entity.Property(e => e.IdPedido).HasColumnName("idPedido");
            entity.Property(e => e.Igv)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("igv");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("metodoPago");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoNota)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("motivoNota");
            entity.Property(e => e.NombreCompletoSunat)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoSUNAT");
            entity.Property(e => e.NumComprobOrigen).HasColumnName("numComprobOrigen");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .HasColumnName("observaciones");
            entity.Property(e => e.Origen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("origen");
            entity.Property(e => e.PagoPendiente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagoPendiente");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Ruc)
                .HasMaxLength(11)
                .HasColumnName("ruc");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .HasColumnName("serie");
            entity.Property(e => e.SerieComprobOrigen)
                .HasMaxLength(5)
                .HasColumnName("serieComprobOrigen");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.TicketAnio).HasColumnName("ticketAnio");
            entity.Property(e => e.TicketAutorizado)
                .HasDefaultValue(1)
                .HasColumnName("ticketAutorizado");
            entity.Property(e => e.TicketCreado).HasColumnName("ticketCreado");
            entity.Property(e => e.TicketMes).HasColumnName("ticketMes");
            entity.Property(e => e.TicketValido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ticketValido");
            entity.Property(e => e.TicketVence)
                .HasColumnType("datetime")
                .HasColumnName("ticketVence");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoComprobOrigen)
                .HasMaxLength(2)
                .HasColumnName("tipoComprobOrigen");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(20)
                .HasColumnName("tipoDoc");
            entity.Property(e => e.TipoMaterial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoMaterial");
            entity.Property(e => e.TipoNota)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("tipoNota");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.Voucher).HasColumnName("voucher");
        });

        modelBuilder.Entity<TComprobanteCreditoCab>(entity =>
        {
            entity.HasKey(e => e.CodComprobCredito).HasName("PK__t_compro__CFDFDE10F9D8E6FC");

            entity.ToTable("t_comprobante_credito_cab");

            entity.Property(e => e.CodComprobCredito)
                .ValueGeneratedNever()
                .HasColumnName("codComprobCredito");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodDetraccion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codDetraccion");
            entity.Property(e => e.FormaPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("formaPago");
            entity.Property(e => e.Subtotal1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("subtotal1");
            entity.Property(e => e.Subtotal2)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("subtotal2");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalComprob)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalComprob");
        });

        modelBuilder.Entity<TComprobanteCreditoDet>(entity =>
        {
            entity.HasKey(e => e.CodComprobCredDet).HasName("PK__t_compro__D5FE6948D0AC16B1");

            entity.ToTable("t_comprobante_credito_det");

            entity.Property(e => e.CodComprobCredDet)
                .ValueGeneratedNever()
                .HasColumnName("codComprobCredDet");
            entity.Property(e => e.CodComprobCred).HasColumnName("codComprobCred");
            entity.Property(e => e.Correlativo).HasColumnName("correlativo");
            entity.Property(e => e.Cuota)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaVencimiento).HasColumnName("fechaVencimiento");
            entity.Property(e => e.VCorrelativo)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("vCorrelativo");
            entity.Property(e => e.ValorCredito)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valorCredito");
        });

        modelBuilder.Entity<TConceptoGasto>(entity =>
        {
            entity.HasKey(e => e.CodConGas).HasName("PK__t_concep__BD6D576CF1D70110");

            entity.ToTable("t_concepto_gasto");

            entity.Property(e => e.CodConGas)
                .ValueGeneratedNever()
                .HasColumnName("codConGas");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre ");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TConceptoIngreso>(entity =>
        {
            entity.HasKey(e => e.CodConcepto).HasName("PK__t_concep__98FBDF3D7D12E6E9");

            entity.ToTable("t_concepto_ingreso");

            entity.Property(e => e.CodConcepto)
                .ValueGeneratedNever()
                .HasColumnName("codConcepto");
            entity.Property(e => e.CcCuentasPorCobrar)
                .HasMaxLength(10)
                .HasColumnName("ccCuentasPorCobrar");
            entity.Property(e => e.CcRemTransito)
                .HasMaxLength(10)
                .HasColumnName("ccRemTransito");
            entity.Property(e => e.CcRemTransitoDetrac)
                .HasMaxLength(10)
                .HasColumnName("ccRemTransitoDetrac");
            entity.Property(e => e.CcVentas)
                .HasMaxLength(10)
                .HasColumnName("ccVentas");
            entity.Property(e => e.CcVentasImpuesto)
                .HasMaxLength(10)
                .HasColumnName("ccVentasImpuesto");
            entity.Property(e => e.Clase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("clase");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
        });

        modelBuilder.Entity<TContrato>(entity =>
        {
            entity.HasKey(e => e.CodContrato).HasName("PK__t_contra__CBEBC73A1142387A");

            entity.ToTable("t_contrato", tb => tb.HasTrigger("trg_t_contrato"));

            entity.Property(e => e.CodContrato)
                .ValueGeneratedNever()
                .HasColumnName("codContrato");
            entity.Property(e => e.AccionesLegales)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("accionesLegales");
            entity.Property(e => e.ActaConciliacionDoc)
                .HasMaxLength(50)
                .HasColumnName("actaConciliacionDoc");
            entity.Property(e => e.Adenda).HasColumnName("adenda");
            entity.Property(e => e.AptoRenovacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("aptoRenovacion");
            entity.Property(e => e.CausalesResolucion)
                .HasMaxLength(250)
                .HasColumnName("causalesResolucion");
            entity.Property(e => e.CesionarioDni)
                .HasMaxLength(15)
                .HasColumnName("cesionarioDNI");
            entity.Property(e => e.CesionarioNomb)
                .HasMaxLength(150)
                .HasColumnName("cesionarioNomb");
            entity.Property(e => e.CodContratoNuevo).HasColumnName("codContratoNuevo");
            entity.Property(e => e.CodPcontReajusteGarantia).HasColumnName("codPContReajusteGarantia");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.ComunicaResolucion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comunicaResolucion");
            entity.Property(e => e.ComunicaResolucionDoc)
                .HasMaxLength(50)
                .HasColumnName("comunicaResolucionDoc");
            entity.Property(e => e.Conclusion)
                .HasMaxLength(250)
                .HasColumnName("conclusion");
            entity.Property(e => e.ContratoFirmado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contratoFirmado");
            entity.Property(e => e.CopiaDniarrend)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIArrend");
            entity.Property(e => e.CopiaDnifiador)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIFiador");
            entity.Property(e => e.CopiaDnifiador2)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIFiador2");
            entity.Property(e => e.CopiaPoder)
                .HasMaxLength(50)
                .HasColumnName("copiaPoder");
            entity.Property(e => e.CopiaPoderAntiguedad).HasColumnName("copiaPoderAntiguedad");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.CumpleNoDeter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumpleNoDeter");
            entity.Property(e => e.CumpleNoSubarrend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumpleNoSubarrend");
            entity.Property(e => e.CumplePagoArbitr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoArbitr");
            entity.Property(e => e.CumplePagoRentaPunt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoRentaPunt");
            entity.Property(e => e.CumplePagoServ)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoServ");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.DatosCobranza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datosCobranza");
            entity.Property(e => e.DerivadoOgaf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derivadoOGAF");
            entity.Property(e => e.DerivadoOgafdoc)
                .HasMaxLength(50)
                .HasColumnName("derivadoOGAFDoc");
            entity.Property(e => e.DeseaRenovar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("deseaRenovar");
            entity.Property(e => e.DjArrend)
                .HasMaxLength(50)
                .HasColumnName("djArrend");
            entity.Property(e => e.DjFiador)
                .HasMaxLength(50)
                .HasColumnName("djFiador");
            entity.Property(e => e.DjFiador2)
                .HasMaxLength(50)
                .HasColumnName("djFiador2");
            entity.Property(e => e.DocReprogramacion)
                .HasMaxLength(50)
                .HasColumnName("docReprogramacion");
            entity.Property(e => e.DocumentoPagoReajusteGarantia)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoReajusteGarantia");
            entity.Property(e => e.EstContrato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estContrato");
            entity.Property(e => e.EstadoResolCont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoResolCont");
            entity.Property(e => e.Fallece)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fallece");
            entity.Property(e => e.FecActaConciliacion).HasColumnName("fecActaConciliacion");
            entity.Property(e => e.FecCesion).HasColumnName("fecCesion");
            entity.Property(e => e.FecComunicaResolucion).HasColumnName("fecComunicaResolucion");
            entity.Property(e => e.FecDerivadoOgaf).HasColumnName("fecDerivadoOGAF");
            entity.Property(e => e.FecEntregaNotifVencim).HasColumnName("fecEntregaNotifVencim");
            entity.Property(e => e.FecFin).HasColumnName("fecFin");
            entity.Property(e => e.FecInicio).HasColumnName("fecInicio");
            entity.Property(e => e.FecReprogramacion).HasColumnName("fecReprogramacion");
            entity.Property(e => e.FecRespNotificacion).HasColumnName("fecRespNotificacion");
            entity.Property(e => e.FecSolicitaConciliacion).HasColumnName("fecSolicitaConciliacion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaAnulacion).HasColumnName("fechaAnulacion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Fiador2Dni)
                .HasMaxLength(50)
                .HasColumnName("fiador2DNI");
            entity.Property(e => e.Fiador2Domicilio)
                .HasMaxLength(150)
                .HasColumnName("fiador2Domicilio");
            entity.Property(e => e.Fiador2Email)
                .HasMaxLength(150)
                .HasColumnName("fiador2Email");
            entity.Property(e => e.Fiador2Movil)
                .HasMaxLength(20)
                .HasColumnName("fiador2Movil");
            entity.Property(e => e.Fiador2NombCompl)
                .HasMaxLength(50)
                .HasColumnName("fiador2NombCompl");
            entity.Property(e => e.Fiador2Telefono)
                .HasMaxLength(20)
                .HasColumnName("fiador2Telefono");
            entity.Property(e => e.Fiador2TipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fiador2TipoPersona");
            entity.Property(e => e.FiadorDni)
                .HasMaxLength(50)
                .HasColumnName("fiadorDNI");
            entity.Property(e => e.FiadorDomicilio)
                .HasMaxLength(150)
                .HasColumnName("fiadorDomicilio");
            entity.Property(e => e.FiadorEmail)
                .HasMaxLength(150)
                .HasColumnName("fiadorEmail");
            entity.Property(e => e.FiadorMovil)
                .HasMaxLength(20)
                .HasColumnName("fiadorMovil");
            entity.Property(e => e.FiadorNombCompl)
                .HasMaxLength(50)
                .HasColumnName("fiadorNombCompl");
            entity.Property(e => e.FiadorTelefono)
                .HasMaxLength(20)
                .HasColumnName("fiadorTelefono");
            entity.Property(e => e.FiadorTipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fiadorTipoPersona");
            entity.Property(e => e.FichaRegPropFiador)
                .HasMaxLength(50)
                .HasColumnName("fichaRegPropFiador");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaPropuestaRenovacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaPropuestaRenovacion");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.IncumpleArbitrio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleArbitrio");
            entity.Property(e => e.IncumpleRenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleRenta");
            entity.Property(e => e.IncumpleReposGarant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleReposGarant");
            entity.Property(e => e.IncumpleServ)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleServ");
            entity.Property(e => e.Infocor)
                .HasMaxLength(50)
                .HasColumnName("infocor");
            entity.Property(e => e.Inhabitable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inhabitable");
            entity.Property(e => e.Interes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interes");
            entity.Property(e => e.Justificacion)
                .HasMaxLength(250)
                .HasColumnName("justificacion");
            entity.Property(e => e.LetraCambio)
                .HasMaxLength(50)
                .HasColumnName("letraCambio");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(6)
                .HasColumnName("modalidad");
            entity.Property(e => e.ModifSinConsect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("modifSinConsect");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoAnulacion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("motivoAnulacion");
            entity.Property(e => e.NotificaVencim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("notificaVencim");
            entity.Property(e => e.NotificaVencimDoc)
                .HasMaxLength(50)
                .HasColumnName("notificaVencimDoc");
            entity.Property(e => e.NumCartaCobranza).HasColumnName("numCartaCobranza");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumContratoFisico)
                .HasMaxLength(20)
                .HasColumnName("numContratoFisico");
            entity.Property(e => e.NumContratoNuevo)
                .HasMaxLength(150)
                .HasColumnName("numContratoNuevo");
            entity.Property(e => e.Obligaciones)
                .HasMaxLength(250)
                .HasColumnName("obligaciones");
            entity.Property(e => e.Ocupantes)
                .HasMaxLength(500)
                .HasColumnName("ocupantes");
            entity.Property(e => e.OperPagoRenta)
                .HasMaxLength(50)
                .HasColumnName("operPagoRenta");
            entity.Property(e => e.PagoReajusteGarantia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagoReajusteGarantia");
            entity.Property(e => e.Penalidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("penalidad");
            entity.Property(e => e.PenalidadCesion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("penalidadCesion");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Renta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("renta");
            entity.Property(e => e.RentaAdelantada)
                .HasMaxLength(50)
                .HasColumnName("rentaAdelantada");
            entity.Property(e => e.RentaCodConcepto).HasColumnName("rentaCodConcepto");
            entity.Property(e => e.RentaPropuestaRenovacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rentaPropuestaRenovacion");
            entity.Property(e => e.Reprogramaciones).HasColumnName("reprogramaciones");
            entity.Property(e => e.ReqProyMuni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reqProyMuni");
            entity.Property(e => e.RespNotificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("respNotificacion");
            entity.Property(e => e.RespNotificacionDoc)
                .HasMaxLength(50)
                .HasColumnName("respNotificacionDoc");
            entity.Property(e => e.ResponsablePagoAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoAgua");
            entity.Property(e => e.ResponsablePagoArbitrios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoArbitrios");
            entity.Property(e => e.ResponsablePagoImpPredial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoImpPredial");
            entity.Property(e => e.ResponsablePagoLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoLuz");
            entity.Property(e => e.Restric)
                .HasMaxLength(250)
                .HasColumnName("restric");
            entity.Property(e => e.ResulConciliacion)
                .HasMaxLength(250)
                .HasColumnName("resulConciliacion");
            entity.Property(e => e.SociedadConyugal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sociedadConyugal");
            entity.Property(e => e.SolicitaConciliacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("solicitaConciliacion");
            entity.Property(e => e.SolicitaConciliacionDoc)
                .HasMaxLength(50)
                .HasColumnName("solicitaConciliacionDoc");
            entity.Property(e => e.SubArrend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("subArrend");
            entity.Property(e => e.TasaInteres)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tasaInteres");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoArrendatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoArrendatario");
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprobante");
            entity.Property(e => e.Unilateral)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unilateral");
            entity.Property(e => e.UsoDeposito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("usoDeposito");
            entity.Property(e => e.UsoDiferente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("usoDiferente");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsuarioAnulacion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuarioAnulacion");
            entity.Property(e => e.ValorLetraCambio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valorLetraCambio");
            entity.Property(e => e.VariacionPorc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("variacionPorc");
        });

        modelBuilder.Entity<TContratoAnulacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_contrato_anulacion");

            entity.Property(e => e.AccionesLegales)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("accionesLegales");
            entity.Property(e => e.ActaConciliacionDoc)
                .HasMaxLength(50)
                .HasColumnName("actaConciliacionDoc");
            entity.Property(e => e.Adenda).HasColumnName("adenda");
            entity.Property(e => e.AptoRenovacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("aptoRenovacion");
            entity.Property(e => e.CausalesResolucion)
                .HasMaxLength(250)
                .HasColumnName("causalesResolucion");
            entity.Property(e => e.CesionarioDni)
                .HasMaxLength(15)
                .HasColumnName("cesionarioDNI");
            entity.Property(e => e.CesionarioNomb)
                .HasMaxLength(150)
                .HasColumnName("cesionarioNomb");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodContratoAnulacion).HasColumnName("codContratoAnulacion");
            entity.Property(e => e.CodContratoNuevo).HasColumnName("codContratoNuevo");
            entity.Property(e => e.CodPcontReajusteGarantia).HasColumnName("codPContReajusteGarantia");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.ComunicaResolucion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("comunicaResolucion");
            entity.Property(e => e.ComunicaResolucionDoc)
                .HasMaxLength(50)
                .HasColumnName("comunicaResolucionDoc");
            entity.Property(e => e.Conclusion)
                .HasMaxLength(250)
                .HasColumnName("conclusion");
            entity.Property(e => e.ContratoFirmado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contratoFirmado");
            entity.Property(e => e.CopiaDniarrend)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIArrend");
            entity.Property(e => e.CopiaDnifiador)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIFiador");
            entity.Property(e => e.CopiaDnifiador2)
                .HasMaxLength(50)
                .HasColumnName("copiaDNIFiador2");
            entity.Property(e => e.CopiaPoder)
                .HasMaxLength(50)
                .HasColumnName("copiaPoder");
            entity.Property(e => e.CopiaPoderAntiguedad).HasColumnName("copiaPoderAntiguedad");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.CumpleNoDeter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumpleNoDeter");
            entity.Property(e => e.CumpleNoSubarrend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumpleNoSubarrend");
            entity.Property(e => e.CumplePagoArbitr)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoArbitr");
            entity.Property(e => e.CumplePagoRentaPunt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoRentaPunt");
            entity.Property(e => e.CumplePagoServ)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cumplePagoServ");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.DatosCobranza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("datosCobranza");
            entity.Property(e => e.DerivadoOgaf)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derivadoOGAF");
            entity.Property(e => e.DerivadoOgafdoc)
                .HasMaxLength(50)
                .HasColumnName("derivadoOGAFDoc");
            entity.Property(e => e.DeseaRenovar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("deseaRenovar");
            entity.Property(e => e.DjArrend)
                .HasMaxLength(50)
                .HasColumnName("djArrend");
            entity.Property(e => e.DjFiador)
                .HasMaxLength(50)
                .HasColumnName("djFiador");
            entity.Property(e => e.DjFiador2)
                .HasMaxLength(50)
                .HasColumnName("djFiador2");
            entity.Property(e => e.DocReprogramacion)
                .HasMaxLength(50)
                .HasColumnName("docReprogramacion");
            entity.Property(e => e.DocumentoPagoReajusteGarantia)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoReajusteGarantia");
            entity.Property(e => e.EstContrato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estContrato");
            entity.Property(e => e.EstadoResolCont)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoResolCont");
            entity.Property(e => e.Fallece)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fallece");
            entity.Property(e => e.FecActaConciliacion).HasColumnName("fecActaConciliacion");
            entity.Property(e => e.FecCesion).HasColumnName("fecCesion");
            entity.Property(e => e.FecComunicaResolucion).HasColumnName("fecComunicaResolucion");
            entity.Property(e => e.FecDerivadoOgaf).HasColumnName("fecDerivadoOGAF");
            entity.Property(e => e.FecEntregaNotifVencim).HasColumnName("fecEntregaNotifVencim");
            entity.Property(e => e.FecFin).HasColumnName("fecFin");
            entity.Property(e => e.FecInicio).HasColumnName("fecInicio");
            entity.Property(e => e.FecReprogramacion).HasColumnName("fecReprogramacion");
            entity.Property(e => e.FecRespNotificacion).HasColumnName("fecRespNotificacion");
            entity.Property(e => e.FecSolicitaConciliacion).HasColumnName("fecSolicitaConciliacion");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaAnulacion).HasColumnName("fechaAnulacion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Fiador2Dni)
                .HasMaxLength(50)
                .HasColumnName("fiador2DNI");
            entity.Property(e => e.Fiador2Domicilio)
                .HasMaxLength(150)
                .HasColumnName("fiador2Domicilio");
            entity.Property(e => e.Fiador2Email)
                .HasMaxLength(150)
                .HasColumnName("fiador2Email");
            entity.Property(e => e.Fiador2Movil)
                .HasMaxLength(20)
                .HasColumnName("fiador2Movil");
            entity.Property(e => e.Fiador2NombCompl)
                .HasMaxLength(50)
                .HasColumnName("fiador2NombCompl");
            entity.Property(e => e.Fiador2Telefono)
                .HasMaxLength(20)
                .HasColumnName("fiador2Telefono");
            entity.Property(e => e.Fiador2TipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fiador2TipoPersona");
            entity.Property(e => e.FiadorDni)
                .HasMaxLength(50)
                .HasColumnName("fiadorDNI");
            entity.Property(e => e.FiadorDomicilio)
                .HasMaxLength(150)
                .HasColumnName("fiadorDomicilio");
            entity.Property(e => e.FiadorEmail)
                .HasMaxLength(150)
                .HasColumnName("fiadorEmail");
            entity.Property(e => e.FiadorMovil)
                .HasMaxLength(20)
                .HasColumnName("fiadorMovil");
            entity.Property(e => e.FiadorNombCompl)
                .HasMaxLength(50)
                .HasColumnName("fiadorNombCompl");
            entity.Property(e => e.FiadorTelefono)
                .HasMaxLength(20)
                .HasColumnName("fiadorTelefono");
            entity.Property(e => e.FiadorTipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fiadorTipoPersona");
            entity.Property(e => e.FichaRegPropFiador)
                .HasMaxLength(50)
                .HasColumnName("fichaRegPropFiador");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaPropuestaRenovacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaPropuestaRenovacion");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.IncumpleArbitrio)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleArbitrio");
            entity.Property(e => e.IncumpleRenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleRenta");
            entity.Property(e => e.IncumpleReposGarant)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleReposGarant");
            entity.Property(e => e.IncumpleServ)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incumpleServ");
            entity.Property(e => e.Infocor)
                .HasMaxLength(50)
                .HasColumnName("infocor");
            entity.Property(e => e.Inhabitable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inhabitable");
            entity.Property(e => e.Interes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interes");
            entity.Property(e => e.Justificacion)
                .HasMaxLength(250)
                .HasColumnName("justificacion");
            entity.Property(e => e.LetraCambio)
                .HasMaxLength(50)
                .HasColumnName("letraCambio");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(6)
                .HasColumnName("modalidad");
            entity.Property(e => e.ModifSinConsect)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("modifSinConsect");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoAnulacion)
                .HasMaxLength(250)
                .HasColumnName("motivoAnulacion");
            entity.Property(e => e.NotificaVencim)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("notificaVencim");
            entity.Property(e => e.NotificaVencimDoc)
                .HasMaxLength(50)
                .HasColumnName("notificaVencimDoc");
            entity.Property(e => e.NumCartaCobranza).HasColumnName("numCartaCobranza");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumContratoFisico)
                .HasMaxLength(20)
                .HasColumnName("numContratoFisico");
            entity.Property(e => e.NumContratoNuevo)
                .HasMaxLength(150)
                .HasColumnName("numContratoNuevo");
            entity.Property(e => e.Obligaciones)
                .HasMaxLength(250)
                .HasColumnName("obligaciones");
            entity.Property(e => e.Ocupantes)
                .HasMaxLength(500)
                .HasColumnName("ocupantes");
            entity.Property(e => e.OperPagoRenta)
                .HasMaxLength(50)
                .HasColumnName("operPagoRenta");
            entity.Property(e => e.PagoReajusteGarantia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagoReajusteGarantia");
            entity.Property(e => e.Penalidad)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("penalidad");
            entity.Property(e => e.PenalidadCesion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("penalidadCesion");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Renta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("renta");
            entity.Property(e => e.RentaAdelantada)
                .HasMaxLength(50)
                .HasColumnName("rentaAdelantada");
            entity.Property(e => e.RentaCodConcepto).HasColumnName("rentaCodConcepto");
            entity.Property(e => e.RentaPropuestaRenovacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("rentaPropuestaRenovacion");
            entity.Property(e => e.Reprogramaciones).HasColumnName("reprogramaciones");
            entity.Property(e => e.ReqProyMuni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reqProyMuni");
            entity.Property(e => e.RespNotificacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("respNotificacion");
            entity.Property(e => e.RespNotificacionDoc)
                .HasMaxLength(50)
                .HasColumnName("respNotificacionDoc");
            entity.Property(e => e.ResponsablePagoAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoAgua");
            entity.Property(e => e.ResponsablePagoArbitrios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoArbitrios");
            entity.Property(e => e.ResponsablePagoImpPredial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoImpPredial");
            entity.Property(e => e.ResponsablePagoLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoLuz");
            entity.Property(e => e.Restric)
                .HasMaxLength(250)
                .HasColumnName("restric");
            entity.Property(e => e.ResulConciliacion)
                .HasMaxLength(250)
                .HasColumnName("resulConciliacion");
            entity.Property(e => e.SociedadConyugal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sociedadConyugal");
            entity.Property(e => e.SolicitaConciliacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("solicitaConciliacion");
            entity.Property(e => e.SolicitaConciliacionDoc)
                .HasMaxLength(50)
                .HasColumnName("solicitaConciliacionDoc");
            entity.Property(e => e.SubArrend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("subArrend");
            entity.Property(e => e.TasaInteres)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tasaInteres");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoArrendatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoArrendatario");
            entity.Property(e => e.TipoComprobante)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprobante");
            entity.Property(e => e.Unilateral)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("unilateral");
            entity.Property(e => e.UsoDeposito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("usoDeposito");
            entity.Property(e => e.UsoDiferente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("usoDiferente");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsuarioAnulacion)
                .HasMaxLength(100)
                .HasColumnName("usuarioAnulacion");
            entity.Property(e => e.ValorLetraCambio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("valorLetraCambio");
            entity.Property(e => e.VariacionPorc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("variacionPorc");
        });

        modelBuilder.Entity<TContratoBk20230321>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_contrato_bk20230321");

            entity.Property(e => e.AccionBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("accionBanco");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("anticipo");
            entity.Property(e => e.AutorizaAnulado).HasColumnName("autorizaAnulado");
            entity.Property(e => e.Canal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("canal");
            entity.Property(e => e.CancelaComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cancelaComprob");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodConcepto).HasColumnName("codConcepto");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodIngreso).HasColumnName("codIngreso");
            entity.Property(e => e.CodIngresoAnticipo).HasColumnName("codIngresoAnticipo");
            entity.Property(e => e.CodPcont).HasColumnName("codPCont");
            entity.Property(e => e.CodPersonaComprob)
                .HasMaxLength(15)
                .HasColumnName("codPersonaComprob");
            entity.Property(e => e.DiasAtrazados).HasColumnName("diasAtrazados");
            entity.Property(e => e.DireccionInmueble)
                .HasMaxLength(500)
                .HasColumnName("direccionInmueble");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.EnviadoBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enviadoBanco");
            entity.Property(e => e.EstPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPago");
            entity.Property(e => e.FecEnvioBanco).HasColumnName("fecEnvioBanco");
            entity.Property(e => e.FechaAnula).HasColumnName("fechaAnula");
            entity.Property(e => e.FechaAutoriza).HasColumnName("fechaAutoriza");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaValidoCanal).HasColumnName("fechaValidoCanal");
            entity.Property(e => e.ImporteAdicional).HasColumnName("importeAdicional");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotImporteAdicional)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motImporteAdicional");
            entity.Property(e => e.NomDepositante)
                .HasMaxLength(500)
                .HasColumnName("nomDepositante");
            entity.Property(e => e.NombreCompletoComprob)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoComprob");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumCuota).HasColumnName("numCuota");
            entity.Property(e => e.Pagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pagado");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RucComprob)
                .HasMaxLength(11)
                .HasColumnName("rucComprob");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.TicketAutorizado).HasColumnName("ticketAutorizado");
            entity.Property(e => e.TicketVence).HasColumnName("ticketVence");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprob");
            entity.Property(e => e.TipoDocPersComprob)
                .HasMaxLength(3)
                .HasColumnName("tipoDocPersComprob");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(6)
                .HasColumnName("ubigeo");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioAutoriza)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuarioAutoriza");
        });

        modelBuilder.Entity<TContratoGarantia>(entity =>
        {
            entity.HasKey(e => e.CodGcont).HasName("PK__t_contra__4064D7BC01DF7999");

            entity.ToTable("t_contrato_garantias");

            entity.Property(e => e.CodGcont)
                .ValueGeneratedNever()
                .HasColumnName("codGCont");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodOl).HasColumnName("codOL");
            entity.Property(e => e.CodPcont).HasColumnName("codPCont");
            entity.Property(e => e.DocAprobacion)
                .HasMaxLength(150)
                .HasColumnName("docAprobacion");
            entity.Property(e => e.EjecutoTicketG)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("N")
                .IsFixedLength()
                .HasColumnName("ejecutoTicketG");
            entity.Property(e => e.EstGarantia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estGarantia");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Informe)
                .HasMaxLength(150)
                .HasColumnName("informe");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Motivo)
                .HasMaxLength(256)
                .HasColumnName("motivo");
            entity.Property(e => e.OpinionLegal)
                .HasMaxLength(150)
                .HasColumnName("opinionLegal");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TContratoPersona>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_contrato_persona");

            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodCpers).HasColumnName("codCPers");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TDatosCobranzaTmp>(entity =>
        {
            entity.HasKey(e => e.CodDatCobranza).HasName("PK__t_datos___55CD4D846BB29B13");

            entity.ToTable("t_datos_cobranza_tmp");

            entity.Property(e => e.CodDatCobranza)
                .ValueGeneratedNever()
                .HasColumnName("codDatCobranza");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodConcepto).HasColumnName("codConcepto");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodPersonaComprob)
                .HasMaxLength(15)
                .HasColumnName("codPersonaComprob");
            entity.Property(e => e.EnviadoBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enviadoBanco");
            entity.Property(e => e.EstPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPago");
            entity.Property(e => e.NombreCompletoComprob)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoComprob");
            entity.Property(e => e.RucComprob)
                .HasMaxLength(11)
                .HasColumnName("rucComprob");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprob");
            entity.Property(e => e.TipoDocPersComprob)
                .HasMaxLength(3)
                .HasColumnName("tipoDocPersComprob");
        });

        modelBuilder.Entity<TDetallePagoParcial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_detalle_pago_parcial");

            entity.Property(e => e.APagar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("aPagar");
            entity.Property(e => e.CodComprobante).HasColumnName("codComprobante");
            entity.Property(e => e.CodDpagPar).HasColumnName("codDPagPar");
            entity.Property(e => e.CtaContable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ctaContable");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.PorcPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("porcPago");
            entity.Property(e => e.Saldo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("saldo");
            entity.Property(e => e.TotalPago)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalPago");
        });

        modelBuilder.Entity<TDetalleReporteBanco>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_detalle_reporte_banco");

            entity.Property(e => e.AnioReporte).HasColumnName("anio_reporte");
            entity.Property(e => e.DescripcionReporteBanco)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion_reporte_banco");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.FechaValuta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha_valuta");
            entity.Property(e => e.IdDetalleReporteBanco).HasColumnName("id_detalle_reporte_banco");
            entity.Property(e => e.MesReporte).HasColumnName("mes_reporte");
            entity.Property(e => e.MontoReporteBanco)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto_reporte_banco");
        });

        modelBuilder.Entity<TDetraccion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_detraccion");

            entity.Property(e => e.CodDetraccion)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codDetraccion");
            entity.Property(e => e.DescDetraccion)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descDetraccion");
            entity.Property(e => e.PorcDetraccion).HasColumnName("porcDetraccion");
        });

        modelBuilder.Entity<TDeudasXTrimestre>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_deudas_x_trimestre");

            entity.Property(e => e.Administrados)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("administrados");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Coduso).HasColumnName("coduso");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cuotas).HasColumnName("cuotas");
            entity.Property(e => e.Direccion)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.EjecucionPj)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("EjecucionPJ");
            entity.Property(e => e.FecActual)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecActual");
            entity.Property(e => e.FecFin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecFin");
            entity.Property(e => e.FecInicio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecInicio");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.Inquilino)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NumInterior)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("numInterior");
            entity.Property(e => e.Ocupado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Pjudicial)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("PJudicial");
            entity.Property(e => e.Renta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("renta");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.TotalDeuda1700).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Uso)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("uso");
        });

        modelBuilder.Entity<TEdificacion>(entity =>
        {
            entity.HasKey(e => e.CodEdif).HasName("PK__t_edific__BDD12E5AC8D3FAEF");

            entity.ToTable("t_edificacion");

            entity.Property(e => e.CodEdif)
                .ValueGeneratedNever()
                .HasColumnName("codEdif");
            entity.Property(e => e.AreaConstVerif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConstVerif");
            entity.Property(e => e.Banio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("banio");
            entity.Property(e => e.CodInm).HasColumnName("codInm");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InstElectricas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("instElectricas");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("muro");
            entity.Property(e => e.NumPiso).HasColumnName("numPiso");
            entity.Property(e => e.Piso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("piso");
            entity.Property(e => e.Pisos)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pisos");
            entity.Property(e => e.Puertas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("puertas");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Revest)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("revest");
            entity.Property(e => e.Techo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("techo");
            entity.Property(e => e.TotalValor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalValor");
            entity.Property(e => e.ValEdifEstimado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdifEstimado");
        });

        modelBuilder.Entity<TEdificacionInspeccion>(entity =>
        {
            entity.HasKey(e => e.CodEdif).HasName("PK__t_edific__BDD12E5A33BB4E97");

            entity.ToTable("t_edificacion_inspeccion");

            entity.Property(e => e.CodEdif)
                .ValueGeneratedNever()
                .HasColumnName("codEdif");
            entity.Property(e => e.AreaConstVerif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConstVerif");
            entity.Property(e => e.Banio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("banio");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InstElectricas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("instElectricas");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("muro");
            entity.Property(e => e.NumPiso).HasColumnName("numPiso");
            entity.Property(e => e.Pisos)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pisos");
            entity.Property(e => e.Puertas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("puertas");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Revest)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("revest");
            entity.Property(e => e.Techo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("techo");
            entity.Property(e => e.TotalValor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalValor");
            entity.Property(e => e.ValEdifEstimado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdifEstimado");
        });

        modelBuilder.Entity<TEdificacionInspeccionUi>(entity =>
        {
            entity.HasKey(e => e.CodEdifUi).HasName("PK__t_edific__33A5D39CEED054A1");

            entity.ToTable("t_edificacion_inspeccion_ui");

            entity.Property(e => e.CodEdifUi)
                .ValueGeneratedNever()
                .HasColumnName("codEdifUI");
            entity.Property(e => e.AreaConstVerif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConstVerif");
            entity.Property(e => e.Banio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("banio");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InstElectricas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("instElectricas");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("muro");
            entity.Property(e => e.NumPiso).HasColumnName("numPiso");
            entity.Property(e => e.Pisos)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pisos");
            entity.Property(e => e.Puertas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("puertas");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Revest)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("revest");
            entity.Property(e => e.Techo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("techo");
            entity.Property(e => e.TotalValor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalValor");
            entity.Property(e => e.ValEdifEstimado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdifEstimado");
        });

        modelBuilder.Entity<TEnviaResuman>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_enviaResumen");

            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fecha)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("fecha");
            entity.Property(e => e.IId)
                .ValueGeneratedOnAdd()
                .HasColumnName("iId");
        });

        modelBuilder.Entity<TExportaBancoCab>(entity =>
        {
            entity.HasKey(e => e.CodEbanco).HasName("PK__t_export__5EF00A813C19A912");

            entity.ToTable("t_exporta_banco_cab");

            entity.Property(e => e.CodEbanco)
                .ValueGeneratedNever()
                .HasColumnName("codEBanco");
            entity.Property(e => e.CantTotReg)
                .HasMaxLength(9)
                .HasColumnName("cantTotReg");
            entity.Property(e => e.CantTotRegD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cantTotRegD");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.EstExpBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estExpBanco");
            entity.Property(e => e.FecTransmision)
                .HasMaxLength(8)
                .HasColumnName("fecTransmision");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler)
                .HasMaxLength(113)
                .HasColumnName("filler");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MontoTotEnv)
                .HasMaxLength(15)
                .HasColumnName("montoTotEnv");
            entity.Property(e => e.MontoTotEnvD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoTotEnvD");
            entity.Property(e => e.NomEmpresa)
                .HasMaxLength(40)
                .HasColumnName("nomEmpresa");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.OperacionEnvio)
                .HasMaxLength(20)
                .HasColumnName("operacionEnvio");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoArchivo)
                .HasMaxLength(1)
                .HasColumnName("tipoArchivo");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
            entity.Property(e => e.TipoValidacion)
                .HasMaxLength(1)
                .HasColumnName("tipoValidacion");
        });

        modelBuilder.Entity<TExportaBancoDet>(entity =>
        {
            entity.HasKey(e => e.CodEbancoD).HasName("PK__t_export__28E15865AA3FDC2B");

            entity.ToTable("t_exporta_banco_det");

            entity.Property(e => e.CodEbancoD)
                .ValueGeneratedNever()
                .HasColumnName("codEBancoD");
            entity.Property(e => e.CodEbanco).HasColumnName("codEBanco");
            entity.Property(e => e.CodIdUsiario)
                .HasMaxLength(14)
                .HasColumnName("codIdUsiario");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.DireccionInmueble)
                .HasMaxLength(500)
                .HasColumnName("direccionInmueble");
            entity.Property(e => e.EmisionD).HasColumnName("emisionD");
            entity.Property(e => e.FecEmisionCupo)
                .HasMaxLength(8)
                .HasColumnName("fecEmisionCupo");
            entity.Property(e => e.FecVencimientoCupo)
                .HasMaxLength(8)
                .HasColumnName("fecVencimientoCupo");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler)
                .HasMaxLength(113)
                .HasColumnName("filler");
            entity.Property(e => e.Incluir)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("incluir");
            entity.Property(e => e.InfoRetorno)
                .HasMaxLength(30)
                .HasColumnName("infoRetorno");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MontoCupo)
                .HasMaxLength(15)
                .HasColumnName("montoCupo");
            entity.Property(e => e.MontoD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoD");
            entity.Property(e => e.MontoMinimo)
                .HasMaxLength(9)
                .HasColumnName("montoMinimo");
            entity.Property(e => e.MontoMora)
                .HasMaxLength(15)
                .HasColumnName("montoMora");
            entity.Property(e => e.NomUsuario)
                .HasMaxLength(40)
                .HasColumnName("nomUsuario");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoAccionRegistro)
                .HasMaxLength(1)
                .HasColumnName("tipoAccionRegistro");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(6)
                .HasColumnName("ubigeo");
            entity.Property(e => e.VenceD).HasColumnName("venceD");
        });

        modelBuilder.Entity<TExportaContaCab>(entity =>
        {
            entity.HasKey(e => e.CodEconta).HasName("PK__t_export__BC2942DF1B0D7EF2");

            entity.ToTable("t_exporta_conta_cab");

            entity.Property(e => e.CodEconta)
                .ValueGeneratedNever()
                .HasColumnName("codEConta");
            entity.Property(e => e.EstExpConta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estExpConta");
            entity.Property(e => e.FecDesde).HasColumnName("fecDesde");
            entity.Property(e => e.FecHasta).HasColumnName("fecHasta");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TExportaContaCabSimula>(entity =>
        {
            entity.HasKey(e => e.CodEconta).HasName("PK__t_export__BC2942DFA4A7134D");

            entity.ToTable("t_exporta_conta_cab_simula");

            entity.Property(e => e.CodEconta)
                .ValueGeneratedNever()
                .HasColumnName("codEConta");
            entity.Property(e => e.EstExpConta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estExpConta");
            entity.Property(e => e.FecDesde).HasColumnName("fecDesde");
            entity.Property(e => e.FecHasta).HasColumnName("fecHasta");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TExportaContaDet>(entity =>
        {
            entity.HasKey(e => e.CodEcontaD).HasName("PK__t_export__4260DE64C70B07D1");

            entity.ToTable("t_exporta_conta_det");

            entity.Property(e => e.CodEcontaD)
                .ValueGeneratedNever()
                .HasColumnName("codEContaD");
            entity.Property(e => e.ApeMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("apeMaterno");
            entity.Property(e => e.ApePaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("apePaterno");
            entity.Property(e => e.CargaDebeHaber)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cargaDebeHaber");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("centroCosto");
            entity.Property(e => e.CodEconta).HasColumnName("codEConta");
            entity.Property(e => e.CodProvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codProvCli");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cuentaContable");
            entity.Property(e => e.DetraccionFec)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("detraccionFec");
            entity.Property(e => e.DetraccionNum)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("detraccionNum");
            entity.Property(e => e.FecComprobante)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecComprobante");
            entity.Property(e => e.FecDocumento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecDocumento");
            entity.Property(e => e.FecVencimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecVencimiento");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FlujoEfectivo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flujoEfectivo");
            entity.Property(e => e.Glosa)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("glosa");
            entity.Property(e => e.MedioPago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("medioPago");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Moneda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("monto");
            entity.Property(e => e.MontoIgv)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoIGV");
            entity.Property(e => e.MontoNeto1Libro)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto1Libro");
            entity.Property(e => e.MontoNeto2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto2");
            entity.Property(e => e.MontoNeto3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto3");
            entity.Property(e => e.MontoNeto4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto4");
            entity.Property(e => e.MontoNeto5)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto5");
            entity.Property(e => e.MontoNeto6)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto6");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nombres");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numDocumento");
            entity.Property(e => e.NumOrigen)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numOrigen");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("presupuesto");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("razonSocial");
            entity.Property(e => e.RefFecha)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refFecha");
            entity.Property(e => e.RefNumero)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refNumero");
            entity.Property(e => e.RefTipoDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refTipoDoc");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RucProvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("rucProvCli");
            entity.Property(e => e.TipoCambio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDNI");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.TipoLibro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoLibro");
            entity.Property(e => e.TipoOrigen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoOrigen");
            entity.Property(e => e.TipoProvCli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoProvCli");
        });

        modelBuilder.Entity<TExportaContaDetSimula>(entity =>
        {
            entity.HasKey(e => e.CodEcontaD).HasName("PK__t_export__4260DE6464161F36");

            entity.ToTable("t_exporta_conta_det_simula");

            entity.Property(e => e.CodEcontaD)
                .ValueGeneratedNever()
                .HasColumnName("codEContaD");
            entity.Property(e => e.ApeMaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("apeMaterno");
            entity.Property(e => e.ApePaterno)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("apePaterno");
            entity.Property(e => e.CargaDebeHaber)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cargaDebeHaber");
            entity.Property(e => e.CentroCosto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("centroCosto");
            entity.Property(e => e.CodEconta).HasColumnName("codEConta");
            entity.Property(e => e.CodProvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("codProvCli");
            entity.Property(e => e.CuentaContable)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cuentaContable");
            entity.Property(e => e.DetraccionFec)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("detraccionFec");
            entity.Property(e => e.DetraccionNum)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("detraccionNum");
            entity.Property(e => e.FecComprobante)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecComprobante");
            entity.Property(e => e.FecDocumento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecDocumento");
            entity.Property(e => e.FecVencimiento)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecVencimiento");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FlujoEfectivo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("flujoEfectivo");
            entity.Property(e => e.Glosa)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("glosa");
            entity.Property(e => e.MedioPago)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("medioPago");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Moneda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("monto");
            entity.Property(e => e.MontoIgv)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoIGV");
            entity.Property(e => e.MontoNeto1Libro)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto1Libro");
            entity.Property(e => e.MontoNeto2)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto2");
            entity.Property(e => e.MontoNeto3)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto3");
            entity.Property(e => e.MontoNeto4)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto4");
            entity.Property(e => e.MontoNeto5)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto5");
            entity.Property(e => e.MontoNeto6)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("montoNeto6");
            entity.Property(e => e.Nombres)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nombres");
            entity.Property(e => e.NumDocumento)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numDocumento");
            entity.Property(e => e.NumOrigen)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numOrigen");
            entity.Property(e => e.Presupuesto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("presupuesto");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(60)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("razonSocial");
            entity.Property(e => e.RefFecha)
                .HasMaxLength(8)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refFecha");
            entity.Property(e => e.RefNumero)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refNumero");
            entity.Property(e => e.RefTipoDoc)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refTipoDoc");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RucProvCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("rucProvCli");
            entity.Property(e => e.TipoCambio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDni)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDNI");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.TipoLibro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoLibro");
            entity.Property(e => e.TipoOrigen)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoOrigen");
            entity.Property(e => e.TipoProvCli)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoProvCli");
        });

        modelBuilder.Entity<TExportaInfocorpCab>(entity =>
        {
            entity.HasKey(e => e.CodEinfocorp).HasName("PK__t_export__8D281E25244569A9");

            entity.ToTable("t_exporta_infocorp_cab");

            entity.Property(e => e.CodEinfocorp)
                .ValueGeneratedNever()
                .HasColumnName("codEInfocorp");
            entity.Property(e => e.Archivo)
                .HasMaxLength(100)
                .HasColumnName("archivo");
            entity.Property(e => e.CantTotReg).HasColumnName("cantTotReg");
            entity.Property(e => e.EstExp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estExp");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MontoTotEnv)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoTotEnv");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TFotoProvisional>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_foto_provisional");

            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.Comentario)
                .HasMaxLength(250)
                .HasColumnName("comentario");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Imagen)
                .HasMaxLength(150)
                .HasColumnName("imagen");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TGasto>(entity =>
        {
            entity.HasKey(e => e.CodGasto).HasName("PK__t_gasto__F06E1C0F1137FF52");

            entity.ToTable("t_gasto");

            entity.Property(e => e.CodGasto)
                .ValueGeneratedNever()
                .HasColumnName("codGasto");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodPersonaOcup)
                .HasMaxLength(15)
                .HasColumnName("codPersonaOcup");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Detalle)
                .HasMaxLength(255)
                .HasColumnName("detalle");
            entity.Property(e => e.DiasAtrazados).HasColumnName("diasAtrazados");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.DocPago)
                .HasMaxLength(200)
                .HasColumnName("docPago");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaCorte).HasColumnName("fechaCorte");
            entity.Property(e => e.FechaEmision).HasColumnName("fechaEmision");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaVcmto).HasColumnName("fechaVcmto");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreCompletoOcup)
                .HasMaxLength(255)
                .HasColumnName("nombreCompletoOcup");
            entity.Property(e => e.Pagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pagado");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Responsable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsable");
            entity.Property(e => e.TipoGasto)
                .HasMaxLength(6)
                .HasColumnName("tipoGasto");
            entity.Property(e => e.TipoPeriodo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPeriodo");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
        });

        modelBuilder.Entity<TGuiaRemisionCab>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_guia_remision_cab");

            entity.Property(e => e.CodRemision).HasColumnName("codRemision");
            entity.Property(e => e.CorrelativoRem).HasColumnName("correlativoRem");
            entity.Property(e => e.CorreoRazSocDest)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("correoRazSocDest");
            entity.Property(e => e.DireccionRazSocDest)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("direccionRazSocDest");
            entity.Property(e => e.FechaRem).HasColumnName("fechaRem");
            entity.Property(e => e.Hora)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hora");
            entity.Property(e => e.NombreRazSocDest)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreRazSocDest");
            entity.Property(e => e.NroDocDestinatario)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("nroDocDestinatario");
            entity.Property(e => e.ObservacionRem)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("observacionRem");
            entity.Property(e => e.SerieRem)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serieRem");
            entity.Property(e => e.TipoDocDestinatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoDocDestinatario");
            entity.Property(e => e.TipoDocRem)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("tipoDocRem");
        });

        modelBuilder.Entity<TGuiaRemisionDet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_guia_remision_det");

            entity.Property(e => e.CantidadBien).HasColumnName("cantidadBien");
            entity.Property(e => e.CodPuerto)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("codPuerto");
            entity.Property(e => e.CodRemision).HasColumnName("codRemision");
            entity.Property(e => e.CodRemisionDet).HasColumnName("codRemisionDet");
            entity.Property(e => e.CodigoBien)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("codigoBien");
            entity.Property(e => e.CodigoSunat)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("codigoSunat");
            entity.Property(e => e.DescTraslado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descTraslado");
            entity.Property(e => e.DescripcionBien)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descripcionBien");
            entity.Property(e => e.DireccionLlegada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccionLLegada");
            entity.Property(e => e.DireccionPartida)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("direccionPartida");
            entity.Property(e => e.FechaEntrega).HasColumnName("fechaEntrega");
            entity.Property(e => e.FechaIniTrasl).HasColumnName("fechaIniTrasl");
            entity.Property(e => e.IndicadorTransbordo).HasColumnName("indicadorTransbordo");
            entity.Property(e => e.ModalidadTrasl)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("modalidadTrasl");
            entity.Property(e => e.MotivoTraslado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("motivoTraslado");
            entity.Property(e => e.NombreRazSocTransp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreRazSocTransp");
            entity.Property(e => e.NroBultos).HasColumnName("nroBultos");
            entity.Property(e => e.NroContenedor)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("nroContenedor");
            entity.Property(e => e.NroDocConducPriva)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("nroDocConducPriva");
            entity.Property(e => e.NroDocTransp)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("nroDocTransp");
            entity.Property(e => e.NroOrdenBien)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("nroOrdenBien");
            entity.Property(e => e.PesoTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("pesoTotal");
            entity.Property(e => e.TipoDocConducPriva).HasColumnName("tipoDocConducPriva");
            entity.Property(e => e.TipoDocTransp).HasColumnName("tipoDocTransp");
            entity.Property(e => e.UbigeoLlegada)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ubigeoLlegada");
            entity.Property(e => e.UbigeoPartida)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("ubigeoPartida");
            entity.Property(e => e.UnidMedBien)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("unidMedBien");
            entity.Property(e => e.UnidadMed)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("unidadMed");
            entity.Property(e => e.Vehiculo)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("vehiculo");
        });

        modelBuilder.Entity<TImagenReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_imagen_reporte");

            entity.Property(e => e.IdImagen).HasColumnName("idImagen");
            entity.Property(e => e.IdReporte).HasColumnName("idReporte");
            entity.Property(e => e.NroPag).HasColumnName("nroPag");
            entity.Property(e => e.RutaImagen).HasColumnName("rutaImagen");
        });

        modelBuilder.Entity<TImportaBancoCab>(entity =>
        {
            entity.HasKey(e => e.CodIbanco).HasName("PK__t_import__5E0D33ED32B627D5");

            entity.ToTable("t_importa_banco_cab");

            entity.Property(e => e.CodIbanco)
                .ValueGeneratedNever()
                .HasColumnName("codIBanco");
            entity.Property(e => e.CantTotReg)
                .HasMaxLength(9)
                .HasColumnName("cantTotReg");
            entity.Property(e => e.CantTotRegD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("cantTotRegD");
            entity.Property(e => e.CantTotRegProcesado).HasColumnName("cantTotRegProcesado");
            entity.Property(e => e.Casilla)
                .HasMaxLength(6)
                .HasColumnName("casilla");
            entity.Property(e => e.CodIntBcp)
                .HasMaxLength(4)
                .HasColumnName("codIntBCP");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.EstImpBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estImpBanco");
            entity.Property(e => e.FecOperacion).HasColumnName("fecOperacion");
            entity.Property(e => e.FecProceso)
                .HasMaxLength(8)
                .HasColumnName("fecProceso");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler)
                .HasMaxLength(144)
                .HasColumnName("filler");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MontoTot)
                .HasMaxLength(15)
                .HasColumnName("montoTot");
            entity.Property(e => e.MontoTotD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoTotD");
            entity.Property(e => e.MontoTotProcesado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoTotProcesado");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .HasColumnName("nombreArchivo");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
            entity.Property(e => e.TipoValidacion)
                .HasMaxLength(1)
                .HasColumnName("tipoValidacion");
        });

        modelBuilder.Entity<TImportaBancoCabAct>(entity =>
        {
            entity.HasKey(e => e.CodIbanco).HasName("PK__t_import__5E0D33ED12C4645F");

            entity.ToTable("t_importa_banco_cab_act");

            entity.Property(e => e.CodIbanco)
                .ValueGeneratedNever()
                .HasColumnName("codIBanco");
            entity.Property(e => e.CantTotReg)
                .HasMaxLength(9)
                .HasColumnName("cantTotReg");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.EstImpBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estImpBanco");
            entity.Property(e => e.FecProceso)
                .HasMaxLength(8)
                .HasColumnName("fecProceso");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler1)
                .HasMaxLength(2)
                .HasColumnName("filler1");
            entity.Property(e => e.Filler2)
                .HasMaxLength(15)
                .HasColumnName("filler2");
            entity.Property(e => e.Filler3)
                .HasMaxLength(153)
                .HasColumnName("filler3");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreArchivo)
                .HasMaxLength(100)
                .HasColumnName("nombreArchivo");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
        });

        modelBuilder.Entity<TImportaBancoDet>(entity =>
        {
            entity.HasKey(e => e.CodIbancoD).HasName("PK__t_import__1CC4195218D7C465");

            entity.ToTable("t_importa_banco_det");

            entity.Property(e => e.CodIbancoD)
                .ValueGeneratedNever()
                .HasColumnName("codIBancoD");
            entity.Property(e => e.AnioPago)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("anioPago");
            entity.Property(e => e.CargoFijoPagado)
                .HasMaxLength(10)
                .HasColumnName("cargoFijoPagado");
            entity.Property(e => e.CodBanco)
                .HasMaxLength(2)
                .HasColumnName("codBanco");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodIbanco).HasColumnName("codIBanco");
            entity.Property(e => e.CodIdUsiario)
                .HasMaxLength(14)
                .HasColumnName("codIdUsiario");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodPcont).HasColumnName("codPCont");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.CodigoOficina)
                .HasMaxLength(6)
                .HasColumnName("codigoOficina");
            entity.Property(e => e.ComprobDesc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("comprobDesc");
            entity.Property(e => e.CuotaDestino)
                .HasMaxLength(8)
                .HasColumnName("cuotaDestino");
            entity.Property(e => e.DiasAtrazados).HasColumnName("diasAtrazados");
            entity.Property(e => e.Diferencia)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("diferencia");
            entity.Property(e => e.FecPago)
                .HasMaxLength(8)
                .HasColumnName("fecPago");
            entity.Property(e => e.FecPagoD).HasColumnName("fecPagoD");
            entity.Property(e => e.FecVencimiento)
                .HasMaxLength(8)
                .HasColumnName("fecVencimiento");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler)
                .HasMaxLength(4)
                .HasColumnName("filler");
            entity.Property(e => e.HoraAtencion)
                .HasMaxLength(6)
                .HasColumnName("horaAtencion");
            entity.Property(e => e.IdTerminal)
                .HasMaxLength(4)
                .HasColumnName("idTerminal");
            entity.Property(e => e.InfoRetorno)
                .HasMaxLength(30)
                .HasColumnName("infoRetorno");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.MedioAtencion)
                .HasMaxLength(12)
                .HasColumnName("medioAtencion");
            entity.Property(e => e.MesPago)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mesPago");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MontoMoraPagado)
                .HasMaxLength(15)
                .HasColumnName("montoMoraPagado");
            entity.Property(e => e.MontoMoraPagadoD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoMoraPagadoD");
            entity.Property(e => e.MontoPagado)
                .HasMaxLength(15)
                .HasColumnName("montoPagado");
            entity.Property(e => e.MontoPagadoD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoPagadoD");
            entity.Property(e => e.MontoTotalPagado)
                .HasMaxLength(15)
                .HasColumnName("montoTotalPagado");
            entity.Property(e => e.MontoTotalPagadoD)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("montoTotalPagadoD");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(150)
                .HasColumnName("nombreUsuario");
            entity.Property(e => e.NumCheque)
                .HasMaxLength(10)
                .HasColumnName("numCheque");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.NumOperacion)
                .HasMaxLength(6)
                .HasColumnName("numOperacion");
            entity.Property(e => e.Procesado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("procesado");
            entity.Property(e => e.Referencia)
                .HasMaxLength(22)
                .HasColumnName("referencia");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.Validado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("validado");
        });

        modelBuilder.Entity<TImportaBancoDetAct>(entity =>
        {
            entity.HasKey(e => e.CodIbancoD).HasName("PK__t_import__1CC419525424855E");

            entity.ToTable("t_importa_banco_det_act");

            entity.Property(e => e.CodIbancoD)
                .ValueGeneratedNever()
                .HasColumnName("codIBancoD");
            entity.Property(e => e.CodIbanco).HasColumnName("codIBanco");
            entity.Property(e => e.CodIdUsiario)
                .HasMaxLength(14)
                .HasColumnName("codIdUsiario");
            entity.Property(e => e.CodInternoCuenta)
                .HasMaxLength(4)
                .HasColumnName("codInternoCuenta");
            entity.Property(e => e.CodMoneda)
                .HasMaxLength(1)
                .HasColumnName("codMoneda");
            entity.Property(e => e.CodSucursal)
                .HasMaxLength(3)
                .HasColumnName("codSucursal");
            entity.Property(e => e.EstAccion)
                .HasMaxLength(1)
                .HasColumnName("estAccion");
            entity.Property(e => e.FecProceso)
                .HasMaxLength(8)
                .HasColumnName("fecProceso");
            entity.Property(e => e.FecVencimientoCupon)
                .HasMaxLength(8)
                .HasColumnName("fecVencimientoCupon");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Filler)
                .HasMaxLength(111)
                .HasColumnName("filler");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumCuentaEmpresa)
                .HasMaxLength(7)
                .HasColumnName("numCuentaEmpresa");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(40)
                .HasColumnName("observaciones");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoRegActualizacion)
                .HasMaxLength(1)
                .HasColumnName("tipoRegActualizacion");
            entity.Property(e => e.TipoRegistro)
                .HasMaxLength(2)
                .HasColumnName("tipoRegistro");
        });

        modelBuilder.Entity<TIngresoTesorerium>(entity =>
        {
            entity.HasKey(e => e.CodIngreso).HasName("PK__t_ingres__9072792111EF1933");

            entity.ToTable("t_ingreso_tesoreria");

            entity.Property(e => e.CodIngreso)
                .ValueGeneratedNever()
                .HasColumnName("codIngreso");
            entity.Property(e => e.AfectoIgv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .HasColumnName("afectoIGV");
            entity.Property(e => e.Canal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("canal");
            entity.Property(e => e.Cantidad)
                .HasDefaultValue(1)
                .HasColumnName("cantidad");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodConcepto).HasColumnName("codConcepto");
            entity.Property(e => e.CodPla).HasColumnName("codPla");
            entity.Property(e => e.CodRefer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("codRefer");
            entity.Property(e => e.Detalle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.Documento)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("documento");
            entity.Property(e => e.EstIngreso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estIngreso");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Igv)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("igv");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Intereses)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("intereses");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Numero)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.PagoPendiente)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagoPendiente");
            entity.Property(e => e.PendientePago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pendientePago");
            entity.Property(e => e.Preciounit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("preciounit");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Serie)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("subtotal");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalExonerado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("totalExonerado");
        });

        modelBuilder.Entity<TInmueble>(entity =>
        {
            entity.HasKey(e => e.CodProv);

            entity.ToTable("t_inmueble");

            entity.Property(e => e.CodProv)
                .ValueGeneratedNever()
                .HasColumnName("codProv");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Asunto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.CodProvAgua)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvAgua");
            entity.Property(e => e.CodProvLuz)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvLuz");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.CodTitularReg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codTitularReg");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estInmueble");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecIncorporacion).HasColumnName("fecIncorporacion");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecItl)
                .HasColumnType("datetime")
                .HasColumnName("fecITL");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.GeneraRenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("generaRenta");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itlConclusion");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoProvisional)
                .HasMaxLength(6)
                .HasColumnName("motivoProvisional");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.NumMargesi).HasColumnName("numMargesi");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(15)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(150)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TInmuebleFoto>(entity =>
        {
            entity.HasKey(e => e.CodFcum).HasName("PK__t_inmueb__AA32833FC3FF6957");

            entity.ToTable("t_inmueble_foto");

            entity.Property(e => e.CodFcum)
                .ValueGeneratedNever()
                .HasColumnName("codFCUM");
            entity.Property(e => e.Archivo)
                .HasMaxLength(150)
                .HasColumnName("archivo");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TInspeccion>(entity =>
        {
            entity.HasKey(e => e.CodInsp).HasName("PK__t_inspec__AAD47663CA73C3EA");

            entity.ToTable("t_inspeccion");

            entity.Property(e => e.CodInsp)
                .ValueGeneratedNever()
                .HasColumnName("codInsp");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FecDesocupacion).HasColumnName("fecDesocupacion");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecInspVig).HasColumnName("fecInspVig");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InspAgua)
                .HasMaxLength(6)
                .HasColumnName("inspAgua");
            entity.Property(e => e.InspArchivo)
                .HasMaxLength(200)
                .HasColumnName("inspArchivo");
            entity.Property(e => e.InspArea)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("inspArea");
            entity.Property(e => e.InspConformidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inspConformidad");
            entity.Property(e => e.InspLuz)
                .HasMaxLength(6)
                .HasColumnName("inspLuz");
            entity.Property(e => e.InspObserv)
                .HasMaxLength(250)
                .HasColumnName("inspObserv");
            entity.Property(e => e.InspOcupado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inspOcupado");
            entity.Property(e => e.InspParedes)
                .HasMaxLength(6)
                .HasColumnName("inspParedes");
            entity.Property(e => e.InspPiso)
                .HasMaxLength(6)
                .HasColumnName("inspPiso");
            entity.Property(e => e.InspPuertas)
                .HasMaxLength(6)
                .HasColumnName("inspPuertas");
            entity.Property(e => e.InspResponsable)
                .HasMaxLength(15)
                .HasColumnName("inspResponsable");
            entity.Property(e => e.InspResponsableNombreCompleto)
                .HasMaxLength(200)
                .HasColumnName("inspResponsableNombreCompleto");
            entity.Property(e => e.InspTecho)
                .HasMaxLength(6)
                .HasColumnName("inspTecho");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoDesocupacion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("motivoDesocupacion");
            entity.Property(e => e.NumInspDoc)
                .HasMaxLength(150)
                .HasColumnName("numInspDoc");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
        });

        modelBuilder.Entity<TInspeccionTecnica>(entity =>
        {
            entity.HasKey(e => e.CodInsp).HasName("PK__t_inspec__AAD476637D2CD579");

            entity.ToTable("t_inspeccion_tecnica");

            entity.Property(e => e.CodInsp)
                .ValueGeneratedNever()
                .HasColumnName("codInsp");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodProvAgua)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvAgua");
            entity.Property(e => e.CodProvLuz)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvLuz");
            entity.Property(e => e.Conclusiones)
                .HasColumnType("ntext")
                .HasColumnName("conclusiones");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecInspProg).HasColumnName("fecInspProg");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .HasColumnName("motivo");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NivelInspeccion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivelInspeccion");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.Recomendaciones)
                .HasColumnType("ntext")
                .HasColumnName("recomendaciones");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.ResponsableInsp)
                .HasMaxLength(15)
                .HasColumnName("responsableInsp");
            entity.Property(e => e.Resultado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("resultado");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TInspeccionTecnicaAnalisi>(entity =>
        {
            entity.HasKey(e => e.CodItem).HasName("PK__t_inspec__ABA592C4FEEF8817");

            entity.ToTable("t_inspeccion_tecnica_analisis");

            entity.Property(e => e.CodItem)
                .ValueGeneratedNever()
                .HasColumnName("codItem");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TInspeccionTecnicaConclusione>(entity =>
        {
            entity.HasKey(e => e.CodItem).HasName("PK__t_inspec__ABA592C4C8BF8D0E");

            entity.ToTable("t_inspeccion_tecnica_conclusiones");

            entity.Property(e => e.CodItem)
                .ValueGeneratedNever()
                .HasColumnName("codItem");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TInspeccionTecnicaRecomendacione>(entity =>
        {
            entity.HasKey(e => e.CodItem).HasName("PK__t_inspec__ABA592C42D18BD43");

            entity.ToTable("t_inspeccion_tecnica_recomendaciones");

            entity.Property(e => e.CodItem)
                .ValueGeneratedNever()
                .HasColumnName("codItem");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TInspeccionTecnicaUi>(entity =>
        {
            entity.HasKey(e => e.CodInspUi).HasName("PK__t_inspec__FB1E2972E7E0F2DE");

            entity.ToTable("t_inspeccion_tecnica_ui");

            entity.Property(e => e.CodInspUi)
                .ValueGeneratedNever()
                .HasColumnName("codInspUI");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodInsp).HasColumnName("codInsp");
            entity.Property(e => e.CodProvAgua)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvAgua");
            entity.Property(e => e.CodProvLuz)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvLuz");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(255)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsc)
                .HasColumnType("datetime")
                .HasColumnName("fecInsc");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecReg)
                .HasColumnType("datetime")
                .HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(4)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(50)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(256)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(150)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Resultado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("resultado");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TItl>(entity =>
        {
            entity.HasKey(e => e.CodItl).HasName("PK__t_itl__9CAE3B2242F781EC");

            entity.ToTable("t_itl", tb => tb.HasTrigger("trg_t_itl"));

            entity.Property(e => e.CodItl)
                .ValueGeneratedNever()
                .HasColumnName("codITL");
            entity.Property(e => e.Adjuntos)
                .HasMaxLength(2500)
                .HasColumnName("adjuntos");
            entity.Property(e => e.AntecedentesCaso)
                .HasColumnType("text")
                .HasColumnName("antecedentesCaso");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .HasColumnName("area");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.Asunto)
                .HasMaxLength(1000)
                .HasColumnName("asunto");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodOl).HasColumnName("codOL");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodVerficacion)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("codVerficacion");
            entity.Property(e => e.Creado)
                .HasMaxLength(150)
                .HasColumnName("creado");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Derivado)
                .HasMaxLength(15)
                .HasColumnName("derivado");
            entity.Property(e => e.DerivadoNombre)
                .HasMaxLength(150)
                .HasColumnName("derivadoNombre");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(15)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioCompleto)
                .HasMaxLength(250)
                .HasColumnName("destinatarioCompleto");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.DocAprobProv)
                .HasMaxLength(150)
                .HasColumnName("docAprobProv");
            entity.Property(e => e.DocAprobProvGg)
                .HasMaxLength(150)
                .HasColumnName("docAprobProvGG");
            entity.Property(e => e.DocOpinionLegal)
                .HasMaxLength(100)
                .HasColumnName("docOpinionLegal");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.EstadoActoProv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoActoProv");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FecAprobGgprov).HasColumnName("fecAprobGGProv");
            entity.Property(e => e.FecAprobItl).HasColumnName("fecAprobITL");
            entity.Property(e => e.FecAprobacionProv).HasColumnName("fecAprobacionProv");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecItl).HasColumnName("fecITL");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("itlConclusion");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreAnio)
                .HasMaxLength(2000)
                .HasColumnName("nombreAnio");
            entity.Property(e => e.NumDocAprobProv)
                .HasMaxLength(200)
                .HasColumnName("numDocAprobProv");
            entity.Property(e => e.NumDocAprobProvGg)
                .HasMaxLength(200)
                .HasColumnName("numDocAprobProvGG");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(150)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .HasColumnName("observaciones");
            entity.Property(e => e.ObservacionesProv)
                .HasMaxLength(3000)
                .HasColumnName("observacionesProv");
            entity.Property(e => e.OpinionLegal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("opinionLegal");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Referencias)
                .HasMaxLength(2500)
                .HasColumnName("referencias");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(15)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteCompleto)
                .HasMaxLength(250)
                .HasColumnName("remitenteCompleto");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoItl)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoITL");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
        });

        modelBuilder.Entity<TItlAnalisi>(entity =>
        {
            entity.HasKey(e => e.ItemItl).HasName("PK__t_itl_an__A5B2116011E7D2A5");

            entity.ToTable("t_itl_analisis");

            entity.Property(e => e.ItemItl)
                .ValueGeneratedNever()
                .HasColumnName("itemITL");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TItlAnulacion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_itl_anulacion");

            entity.Property(e => e.Adjuntos)
                .HasMaxLength(1000)
                .HasColumnName("adjuntos");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .HasColumnName("area");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.Asunto)
                .HasMaxLength(1000)
                .HasColumnName("asunto");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.CodItlanulacion).HasColumnName("codITLAnulacion");
            entity.Property(e => e.CodOl).HasColumnName("codOL");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.Creado)
                .HasMaxLength(150)
                .HasColumnName("creado");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Derivado)
                .HasMaxLength(15)
                .HasColumnName("derivado");
            entity.Property(e => e.DerivadoNombre)
                .HasMaxLength(150)
                .HasColumnName("derivadoNombre");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(15)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioCompleto)
                .HasMaxLength(250)
                .HasColumnName("destinatarioCompleto");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.DocOpinionLegal)
                .HasMaxLength(100)
                .HasColumnName("docOpinionLegal");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FecAprobItl).HasColumnName("fecAprobITL");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecItl).HasColumnName("fecITL");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("itlConclusion");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreAnio)
                .HasMaxLength(2000)
                .HasColumnName("nombreAnio");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(150)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(3000)
                .HasColumnName("observaciones");
            entity.Property(e => e.OpinionLegal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("opinionLegal");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(15)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteCompleto)
                .HasMaxLength(250)
                .HasColumnName("remitenteCompleto");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoItl)
                .HasMaxLength(4)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoITL");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
        });

        modelBuilder.Entity<TItlConclusione>(entity =>
        {
            entity.HasKey(e => e.ItemItl).HasName("PK__t_itl_co__A5B21160634432CA");

            entity.ToTable("t_itl_conclusiones");

            entity.Property(e => e.ItemItl)
                .ValueGeneratedNever()
                .HasColumnName("itemITL");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.Descripcion)
                .HasColumnType("text")
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TMargesiReporte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_margesi_reporte");

            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AnioMargesiReporte).HasColumnName("anioMargesiReporte");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Asunto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.CodMargesiReporte).HasColumnName("codMargesiReporte");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodProvAgua)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvAgua");
            entity.Property(e => e.CodProvLuz)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvLuz");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.CodTitularReg)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codTitularReg");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estInmueble");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecIncorporacion).HasColumnName("fecIncorporacion");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecItl)
                .HasColumnType("datetime")
                .HasColumnName("fecITL");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.GeneraRenta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("generaRenta");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.IdMargesiReporte)
                .ValueGeneratedOnAdd()
                .HasColumnName("idMargesiReporte");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itlConclusion");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoProvisional)
                .HasMaxLength(6)
                .HasColumnName("motivoProvisional");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.NumMargesi).HasColumnName("numMargesi");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(15)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(150)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TMotivo>(entity =>
        {
            entity.HasKey(e => e.CodMotivo).HasName("PK__t_motivo__D97D75F954A29892");

            entity.ToTable("t_motivo");

            entity.Property(e => e.CodMotivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("codMotivo");
            entity.Property(e => e.DescMotivo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descMotivo");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.OrdenMotivo).HasColumnName("ordenMotivo");
        });

        modelBuilder.Entity<TMotivoTraslado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_motivo_traslado");

            entity.Property(e => e.CodMotivoTras)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codMotivoTras");
            entity.Property(e => e.DescMotivoTras)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("descMotivoTras");
        });

        modelBuilder.Entity<TMovimientoContable>(entity =>
        {
            entity.HasKey(e => e.CodMovCont);

            entity.ToTable("t_movimiento_contable");

            entity.Property(e => e.CodMovCont)
                .ValueGeneratedNever()
                .HasColumnName("codMovCont");
            entity.Property(e => e.CodCliProv)
                .HasMaxLength(11)
                .HasColumnName("codCliProv");
            entity.Property(e => e.CodIngreso).HasColumnName("codIngreso");
            entity.Property(e => e.Concepto)
                .HasMaxLength(250)
                .HasColumnName("concepto");
            entity.Property(e => e.CorrelativoOrigen).HasColumnName("correlativoOrigen");
            entity.Property(e => e.Credito)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("credito");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(10)
                .HasColumnName("cuenta");
            entity.Property(e => e.Debito)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("debito");
            entity.Property(e => e.Exportado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("exportado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaVenc).HasColumnName("fechaVenc");
            entity.Property(e => e.Glosa)
                .HasMaxLength(1000)
                .HasColumnName("glosa");
            entity.Property(e => e.Igv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("igv");
            entity.Property(e => e.Libro)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("libro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Moneda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(40)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.NumComprobOrigen)
                .HasMaxLength(20)
                .HasColumnName("numComprobOrigen");
            entity.Property(e => e.NumDocComprob)
                .HasMaxLength(20)
                .HasColumnName("numDocComprob");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoComprobOrigen)
                .HasMaxLength(2)
                .HasColumnName("tipoComprobOrigen");
            entity.Property(e => e.TipoDebeHaber)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDebeHaber");
            entity.Property(e => e.TipoDocComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDocComprob");
        });

        modelBuilder.Entity<TOpinionLegal>(entity =>
        {
            entity.HasKey(e => e.CodOl);

            entity.ToTable("t_opinion_legal");

            entity.Property(e => e.CodOl)
                .ValueGeneratedNever()
                .HasColumnName("codOL");
            entity.Property(e => e.Archivo)
                .HasMaxLength(150)
                .HasColumnName("archivo");
            entity.Property(e => e.Codigo).HasColumnName("codigo");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.EstOpinion)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estOpinion");
            entity.Property(e => e.FecOpinion).HasColumnName("fecOpinion");
            entity.Property(e => e.FecRecibido).HasColumnName("fecRecibido");
            entity.Property(e => e.FecSolicitado).HasColumnName("fecSolicitado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Tipo)
                .HasMaxLength(2)
                .HasColumnName("tipo");
            entity.Property(e => e.Titulo)
                .HasMaxLength(256)
                .HasColumnName("titulo");
        });

        modelBuilder.Entity<TPagoContrato>(entity =>
        {
            entity.HasKey(e => e.CodPcont).HasName("PK__t_pago_c__12A0C3DA5875B592");

            entity.ToTable("t_pago_contrato");

            entity.Property(e => e.CodPcont)
                .ValueGeneratedNever()
                .HasColumnName("codPCont");
            entity.Property(e => e.AccionBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("accionBanco");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("anticipo");
            entity.Property(e => e.AutorizaAnulado)
                .HasDefaultValue(0)
                .HasColumnName("autorizaAnulado");
            entity.Property(e => e.Canal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("canal");
            entity.Property(e => e.CancelaComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cancelaComprob");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodConcepto).HasColumnName("codConcepto");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodIngreso).HasColumnName("codIngreso");
            entity.Property(e => e.CodIngresoAnticipo).HasColumnName("codIngresoAnticipo");
            entity.Property(e => e.CodPersonaComprob)
                .HasMaxLength(15)
                .HasColumnName("codPersonaComprob");
            entity.Property(e => e.DiasAtrazados).HasColumnName("diasAtrazados");
            entity.Property(e => e.DireccionInmueble)
                .HasMaxLength(500)
                .HasColumnName("direccionInmueble");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.EnviadoBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enviadoBanco");
            entity.Property(e => e.EstPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPago");
            entity.Property(e => e.FecEnvioBanco).HasColumnName("fecEnvioBanco");
            entity.Property(e => e.FechaAnula).HasColumnName("fechaAnula");
            entity.Property(e => e.FechaAutoriza).HasColumnName("fechaAutoriza");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaValidoCanal).HasColumnName("fechaValidoCanal");
            entity.Property(e => e.ImporteAdicional).HasColumnName("importeAdicional");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotImporteAdicional)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motImporteAdicional");
            entity.Property(e => e.NomDepositante)
                .HasMaxLength(500)
                .HasColumnName("nomDepositante");
            entity.Property(e => e.NombreCompletoComprob)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoComprob");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumCuota).HasColumnName("numCuota");
            entity.Property(e => e.Pagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pagado");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RucComprob)
                .HasMaxLength(11)
                .HasColumnName("rucComprob");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.TicketAutorizado).HasColumnName("ticketAutorizado");
            entity.Property(e => e.TicketVence).HasColumnName("ticketVence");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprob");
            entity.Property(e => e.TipoDocPersComprob)
                .HasMaxLength(3)
                .HasColumnName("tipoDocPersComprob");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(6)
                .HasColumnName("ubigeo");
            entity.Property(e => e.UsuarioAnula)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuarioAnula");
            entity.Property(e => e.UsuarioAutoriza)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("usuarioAutoriza");
        });

        modelBuilder.Entity<TPagoContratoBak>(entity =>
        {
            entity.HasKey(e => e.CodPcont).HasName("PK__t_pago_c__12A0C3DAD4C581FF");

            entity.ToTable("t_pago_contrato_bak");

            entity.Property(e => e.CodPcont)
                .ValueGeneratedNever()
                .HasColumnName("codPCont");
            entity.Property(e => e.AccionBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("accionBanco");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("anticipo");
            entity.Property(e => e.Canal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("canal");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodConcepto).HasColumnName("codConcepto");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodIngreso).HasColumnName("codIngreso");
            entity.Property(e => e.CodIngresoAnticipo).HasColumnName("codIngresoAnticipo");
            entity.Property(e => e.CodPersonaComprob)
                .HasMaxLength(15)
                .HasColumnName("codPersonaComprob");
            entity.Property(e => e.DiasAtrazados).HasColumnName("diasAtrazados");
            entity.Property(e => e.DireccionInmueble)
                .HasMaxLength(500)
                .HasColumnName("direccionInmueble");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.EnviadoBanco)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("enviadoBanco");
            entity.Property(e => e.EstPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPago");
            entity.Property(e => e.FecEnvioBanco).HasColumnName("fecEnvioBanco");
            entity.Property(e => e.FechaFin).HasColumnName("fechaFin");
            entity.Property(e => e.FechaInicio).HasColumnName("fechaInicio");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaValidoCanal).HasColumnName("fechaValidoCanal");
            entity.Property(e => e.Fecletras)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fecletras");
            entity.Property(e => e.ImporteAdicional).HasColumnName("importeAdicional");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotImporteAdicional)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("motImporteAdicional");
            entity.Property(e => e.NomDepositante)
                .HasMaxLength(500)
                .HasColumnName("nomDepositante");
            entity.Property(e => e.NombreCompletoComprob)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoComprob");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumCuota).HasColumnName("numCuota");
            entity.Property(e => e.Pagado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pagado");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RucComprob)
                .HasMaxLength(11)
                .HasColumnName("rucComprob");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.Tipo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipo");
            entity.Property(e => e.TipoComprob)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoComprob");
            entity.Property(e => e.TipoDocPersComprob)
                .HasMaxLength(3)
                .HasColumnName("tipoDocPersComprob");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(6)
                .HasColumnName("ubigeo");
        });

        modelBuilder.Entity<TParametro>(entity =>
        {
            entity.HasKey(e => e.CodParam);

            entity.ToTable("t_parametro");

            entity.Property(e => e.CodParam)
                .HasMaxLength(12)
                .HasColumnName("codParam");
            entity.Property(e => e.Abrev)
                .HasMaxLength(15)
                .HasColumnName("abrev");
            entity.Property(e => e.Adm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("adm");
            entity.Property(e => e.EstParam)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estParam");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nivelmax).HasColumnName("nivelmax");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.SubListas)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("subListas");
        });

        modelBuilder.Entity<TParametroSistema>(entity =>
        {
            entity.HasKey(e => e.CodSis);

            entity.ToTable("t_parametro_sistema");

            entity.Property(e => e.CodSis)
                .ValueGeneratedNever()
                .HasColumnName("codSis");
            entity.Property(e => e.Adm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("adm");
            entity.Property(e => e.Codigo)
                .HasMaxLength(6)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoDato)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoDato");
            entity.Property(e => e.Valor)
                .HasMaxLength(80)
                .HasColumnName("valor");
        });

        modelBuilder.Entity<TParticipanteSubastum>(entity =>
        {
            entity.HasKey(e => e.CodPartSub).HasName("PK__t_partic__F8912F4A8F22F5B8");

            entity.ToTable("t_participante_subasta");

            entity.Property(e => e.CodPartSub)
                .ValueGeneratedNever()
                .HasColumnName("codPartSub");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.CodPostor).HasColumnName("codPostor");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(100)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(20)
                .HasColumnName("tipoDoc");
        });

        modelBuilder.Entity<TPerfilUsuario>(entity =>
        {
            entity.HasKey(e => e.CodPerfil);

            entity.ToTable("t_perfil_usuario");

            entity.Property(e => e.CodPerfil)
                .ValueGeneratedNever()
                .HasColumnName("codPerfil");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .HasColumnName("descripcion");
            entity.Property(e => e.EstPerfil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPerfil");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TPerfilUsuarioAcceso>(entity =>
        {
            entity.HasKey(e => e.CodPacceso);

            entity.ToTable("t_perfil_usuario_acceso");

            entity.Property(e => e.CodPacceso)
                .ValueGeneratedNever()
                .HasColumnName("codPAcceso");
            entity.Property(e => e.Acceso)
                .HasMaxLength(200)
                .HasColumnName("acceso");
            entity.Property(e => e.CodAcceso)
                .HasMaxLength(6)
                .HasColumnName("codAcceso");
            entity.Property(e => e.CodModulo)
                .HasMaxLength(6)
                .HasColumnName("codModulo");
            entity.Property(e => e.CodPerfil).HasColumnName("codPerfil");
            entity.Property(e => e.EstAcceso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estAcceso");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Modulo)
                .HasMaxLength(200)
                .HasColumnName("modulo");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TPersona>(entity =>
        {
            entity.HasKey(e => e.CodPersona).HasName("PK__t_person__17EB2D6333DE9DEB");

            entity.ToTable("t_persona");

            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.Area)
                .HasMaxLength(10)
                .HasColumnName("area");
            entity.Property(e => e.Cargo)
                .HasMaxLength(10)
                .HasColumnName("cargo");
            entity.Property(e => e.Clave)
                .HasMaxLength(20)
                .HasColumnName("clave");
            entity.Property(e => e.CodPerfil).HasColumnName("codPerfil");
            entity.Property(e => e.CodRepresentante)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("codRepresentante");
            entity.Property(e => e.Dist)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dist");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(250)
                .HasColumnName("domicilio");
            entity.Property(e => e.DomicilioCompleto)
                .HasMaxLength(250)
                .HasColumnName("domicilioCompleto");
            entity.Property(e => e.Dpto)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("dpto");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .HasColumnName("email");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Materno)
                .HasMaxLength(150)
                .HasColumnName("materno");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Movil)
                .HasMaxLength(20)
                .HasColumnName("movil");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(150)
                .HasColumnName("nombreCompleto");
            entity.Property(e => e.Nombres)
                .HasMaxLength(150)
                .HasColumnName("nombres");
            entity.Property(e => e.Organizacion)
                .HasMaxLength(10)
                .HasColumnName("organizacion");
            entity.Property(e => e.Paterno)
                .HasMaxLength(150)
                .HasColumnName("paterno");
            entity.Property(e => e.Prov)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("prov");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Ruc)
                .HasMaxLength(15)
                .HasColumnName("ruc");
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("sexo");
            entity.Property(e => e.Telefono)
                .HasMaxLength(30)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(20)
                .HasColumnName("tipoDoc");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("tipoDocumento");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPersona");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoUsuario");
            entity.Property(e => e.Titulo)
                .HasMaxLength(10)
                .HasColumnName("titulo");
            entity.Property(e => e.Ubigeo)
                .HasMaxLength(6)
                .HasColumnName("ubigeo");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<TPlanillaCobranza>(entity =>
        {
            entity.HasKey(e => e.CodPla).HasName("PK__t_planil__9ACF4A9EA82DAFFD");

            entity.ToTable("t_planilla_cobranza");

            entity.Property(e => e.CodPla)
                .ValueGeneratedNever()
                .HasColumnName("codPla");
            entity.Property(e => e.Ajuste)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ajuste");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.EstPlanilla)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPlanilla");
            entity.Property(e => e.FecPlanDepositos).HasColumnName("fecPlanDepositos");
            entity.Property(e => e.FecPlanilla).HasColumnName("fecPlanilla");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Generado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("generado");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalDeposito)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeposito");
        });

        modelBuilder.Entity<TPlanillaDeposito>(entity =>
        {
            entity.HasKey(e => e.CodDepPla).HasName("PK__t_planil__CA87AA1B996EFAA2");

            entity.ToTable("t_planilla_deposito");

            entity.Property(e => e.CodDepPla)
                .ValueGeneratedNever()
                .HasColumnName("codDepPla");
            entity.Property(e => e.Canal)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("canal");
            entity.Property(e => e.CodBanco).HasColumnName("codBanco");
            entity.Property(e => e.CodPla).HasColumnName("codPla");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.EstDeposito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estDeposito");
            entity.Property(e => e.FecDep).HasColumnName("fecDep");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumeroRel)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasComment("numero del comprobante relacionado")
                .HasColumnName("numeroRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.SerieRel)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasComment("serie del comprobante relacionado")
                .HasColumnName("serieRel");
        });

        modelBuilder.Entity<TPostorSubastum>(entity =>
        {
            entity.HasKey(e => e.CodPostor).HasName("PK__t_postor__3368C2E61DFA7EBB");

            entity.ToTable("t_postor_subasta");

            entity.Property(e => e.CodPostor)
                .ValueGeneratedNever()
                .HasColumnName("codPostor");
            entity.Property(e => e.Admitido)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("admitido");
            entity.Property(e => e.AdquirioBase)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("adquirioBase");
            entity.Property(e => e.CodComprobBase).HasColumnName("codComprobBase");
            entity.Property(e => e.CodComprobInscripcion).HasColumnName("codComprobInscripcion");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.Deposito)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("deposito");
            entity.Property(e => e.DocumentoPagoBase)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoBase");
            entity.Property(e => e.DocumentoPagoInscripcion)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoInscripcion");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ImpBasePagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impBasePagado");
            entity.Property(e => e.ImpInscripcionPagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impInscripcionPagado");
            entity.Property(e => e.ImporteBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeBase");
            entity.Property(e => e.ImporteInscripcion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeInscripcion");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoNoAdmitido)
                .HasMaxLength(250)
                .HasColumnName("motivoNoAdmitido");
            entity.Property(e => e.Oferta)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("oferta");
            entity.Property(e => e.Participantes)
                .HasMaxLength(250)
                .HasColumnName("participantes");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.SetTicketAnio).HasColumnName("setTicketAnio");
            entity.Property(e => e.SetTicketMes).HasColumnName("setTicketMes");
            entity.Property(e => e.TicketBase).HasColumnName("ticketBase");
            entity.Property(e => e.TicketInscripcion).HasColumnName("ticketInscripcion");
            entity.Property(e => e.TipoPostor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPostor");
        });

        modelBuilder.Entity<TProcesoJudicial>(entity =>
        {
            entity.HasKey(e => e.CodPj);

            entity.ToTable("t_proceso_judicial");

            entity.Property(e => e.CodPj)
                .ValueGeneratedNever()
                .HasColumnName("codPJ");
            entity.Property(e => e.CodDemandado)
                .HasMaxLength(15)
                .HasColumnName("codDemandado");
            entity.Property(e => e.CodDemandante)
                .HasMaxLength(15)
                .HasColumnName("codDemandante");
            entity.Property(e => e.CodEntidad)
                .HasMaxLength(6)
                .HasColumnName("codEntidad");
            entity.Property(e => e.CodEtapa)
                .HasMaxLength(10)
                .HasColumnName("codEtapa");
            entity.Property(e => e.CodEtapaNombre)
                .HasMaxLength(150)
                .HasColumnName("codEtapaNombre");
            entity.Property(e => e.CodJuzgado)
                .HasMaxLength(6)
                .HasColumnName("codJuzgado");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Decision)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("decision");
            entity.Property(e => e.DireccionInmueble)
                .HasMaxLength(2000)
                .HasColumnName("direccionInmueble");
            entity.Property(e => e.EstPj)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPJ");
            entity.Property(e => e.EstPjnombre)
                .HasMaxLength(150)
                .HasColumnName("estPJNombre");
            entity.Property(e => e.FecApelacion).HasColumnName("fecApelacion");
            entity.Property(e => e.FecDecision).HasColumnName("fecDecision");
            entity.Property(e => e.FecDemanda).HasColumnName("fecDemanda");
            entity.Property(e => e.FecDesestimiento).HasColumnName("fecDesestimiento");
            entity.Property(e => e.FecEmplaza).HasColumnName("fecEmplaza");
            entity.Property(e => e.FecFin).HasColumnName("fecFin");
            entity.Property(e => e.FecIniEvaluacion).HasColumnName("fecIniEvaluacion");
            entity.Property(e => e.FecInicio).HasColumnName("fecInicio");
            entity.Property(e => e.FecInstalacion).HasColumnName("fecInstalacion");
            entity.Property(e => e.FecLanzamiento).HasColumnName("fecLanzamiento");
            entity.Property(e => e.FecMontoRecuperado).HasColumnName("fecMontoRecuperado");
            entity.Property(e => e.FecProbatoria).HasColumnName("fecProbatoria");
            entity.Property(e => e.FecRecibido).HasColumnName("fecRecibido");
            entity.Property(e => e.FecSentencia).HasColumnName("fecSentencia");
            entity.Property(e => e.FecSentenciaVista).HasColumnName("fecSentenciaVista");
            entity.Property(e => e.FecSolicitado).HasColumnName("fecSolicitado");
            entity.Property(e => e.FecVistaCausa).HasColumnName("fecVistaCausa");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Instancia)
                .HasMaxLength(6)
                .HasColumnName("instancia");
            entity.Property(e => e.Juzgado)
                .HasMaxLength(2000)
                .HasColumnName("juzgado");
            entity.Property(e => e.Materia)
                .HasMaxLength(6)
                .HasColumnName("materia");
            entity.Property(e => e.MateriaDetalle)
                .HasMaxLength(500)
                .HasColumnName("materiaDetalle");
            entity.Property(e => e.MateriaNombre)
                .HasMaxLength(150)
                .HasColumnName("materiaNombre");
            entity.Property(e => e.MedidaCautelar)
                .HasMaxLength(2000)
                .HasColumnName("medidaCautelar");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Moneda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("moneda");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("monto");
            entity.Property(e => e.MontoRecuperado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("montoRecuperado");
            entity.Property(e => e.MotivosDecision)
                .HasMaxLength(2000)
                .HasColumnName("motivosDecision");
            entity.Property(e => e.NomDemandado)
                .HasMaxLength(150)
                .HasColumnName("nomDemandado");
            entity.Property(e => e.NomDemandante)
                .HasMaxLength(150)
                .HasColumnName("nomDemandante");
            entity.Property(e => e.NotiApelacion)
                .HasMaxLength(150)
                .HasColumnName("notiApelacion");
            entity.Property(e => e.NotiEmplaza)
                .HasMaxLength(150)
                .HasColumnName("notiEmplaza");
            entity.Property(e => e.NotiProbatoria)
                .HasMaxLength(150)
                .HasColumnName("notiProbatoria");
            entity.Property(e => e.NotiSentencia)
                .HasMaxLength(150)
                .HasColumnName("notiSentencia");
            entity.Property(e => e.NotiSentenciaVista)
                .HasMaxLength(150)
                .HasColumnName("notiSentenciaVista");
            entity.Property(e => e.NotiVistaCausa)
                .HasMaxLength(150)
                .HasColumnName("notiVistaCausa");
            entity.Property(e => e.NumEtapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numEtapa");
            entity.Property(e => e.NumExpediente)
                .HasMaxLength(50)
                .HasColumnName("numExpediente");
            entity.Property(e => e.Recuperado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("recuperado");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoProceso)
                .HasMaxLength(6)
                .HasColumnName("tipoProceso");
            entity.Property(e => e.TipoProcesoNombre)
                .HasMaxLength(150)
                .HasColumnName("tipoProcesoNombre");
        });

        modelBuilder.Entity<TProcesoJudicialCitum>(entity =>
        {
            entity.HasKey(e => e.CodPjcita);

            entity.ToTable("t_proceso_judicial_cita");

            entity.Property(e => e.CodPjcita)
                .ValueGeneratedNever()
                .HasColumnName("codPJCita");
            entity.Property(e => e.Asunto)
                .HasMaxLength(300)
                .HasColumnName("asunto");
            entity.Property(e => e.CodPj).HasColumnName("codPJ");
            entity.Property(e => e.FecCita)
                .HasColumnType("datetime")
                .HasColumnName("fecCita");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .HasColumnName("observaciones");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoCita)
                .HasMaxLength(6)
                .HasColumnName("tipoCita");
        });

        modelBuilder.Entity<TProcesoJudicialDoc>(entity =>
        {
            entity.HasKey(e => e.CodPjdoc);

            entity.ToTable("t_proceso_judicial_doc");

            entity.Property(e => e.CodPjdoc)
                .ValueGeneratedNever()
                .HasColumnName("codPJDoc");
            entity.Property(e => e.Archivo)
                .HasMaxLength(150)
                .HasColumnName("archivo");
            entity.Property(e => e.CodPj).HasColumnName("codPJ");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .HasColumnName("codigo");
            entity.Property(e => e.FecDoc).HasColumnName("fecDoc");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .HasColumnName("nombre");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Resumen)
                .HasMaxLength(1000)
                .HasColumnName("resumen");
        });

        modelBuilder.Entity<TProcesoJudicialEtapa>(entity =>
        {
            entity.HasKey(e => e.CodPje);

            entity.ToTable("t_proceso_judicial_etapa");

            entity.Property(e => e.CodPje)
                .ValueGeneratedNever()
                .HasColumnName("codPJE");
            entity.Property(e => e.CodEtapa)
                .HasMaxLength(10)
                .HasColumnName("codEtapa");
            entity.Property(e => e.CodPj).HasColumnName("codPJ");
            entity.Property(e => e.Documento)
                .HasMaxLength(100)
                .HasColumnName("documento");
            entity.Property(e => e.EstEtapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estEtapa");
            entity.Property(e => e.Etapa)
                .HasMaxLength(500)
                .HasColumnName("etapa");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumEtapa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("numEtapa");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TProcesoJudicialGasto>(entity =>
        {
            entity.HasKey(e => e.CodPjg);

            entity.ToTable("t_proceso_judicial_gasto");

            entity.Property(e => e.CodPjg)
                .ValueGeneratedNever()
                .HasColumnName("codPJG");
            entity.Property(e => e.CodPj).HasColumnName("codPJ");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .HasColumnName("descripcion");
            entity.Property(e => e.Documento)
                .HasMaxLength(150)
                .HasColumnName("documento");
            entity.Property(e => e.FecGasto).HasColumnName("fecGasto");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TipoGasto)
                .HasMaxLength(6)
                .HasColumnName("tipoGasto");
        });

        modelBuilder.Entity<TProcesoJudicialSeguimiento>(entity =>
        {
            entity.HasKey(e => e.CodPjseguimiento);

            entity.ToTable("t_proceso_judicial_seguimiento");

            entity.Property(e => e.CodPjseguimiento)
                .ValueGeneratedNever()
                .HasColumnName("codPJSeguimiento");
            entity.Property(e => e.CodPj).HasColumnName("codPJ");
            entity.Property(e => e.Detalle)
                .HasMaxLength(2000)
                .HasColumnName("detalle");
            entity.Property(e => e.FecSeguimiento).HasColumnName("fecSeguimiento");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TProvisional>(entity =>
        {
            entity.HasKey(e => e.CodProv).HasName("PK__t_provis__61BB113A24D5EDEC");

            entity.ToTable("t_provisional");

            entity.Property(e => e.CodProv)
                .ValueGeneratedNever()
                .HasColumnName("codProv");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Asunto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecItl)
                .HasColumnType("datetime")
                .HasColumnName("fecITL");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itlConclusion");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.MotivoProvisional)
                .HasMaxLength(6)
                .HasColumnName("motivoProvisional");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TProvisional2>(entity =>
        {
            entity.HasKey(e => e.CodProv).HasName("PK__t_provis__61BB113A88964AA9");

            entity.ToTable("t_provisional2");

            entity.Property(e => e.CodProv)
                .ValueGeneratedNever()
                .HasColumnName("codProv");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Asunto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecItl)
                .HasColumnType("datetime")
                .HasColumnName("fecITL");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itlConclusion");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TProvisionalBk>(entity =>
        {
            entity.HasKey(e => e.CodProv).HasName("PK__t_provis__61BB113A8A9B3185");

            entity.ToTable("t_provisional_bk");

            entity.Property(e => e.CodProv)
                .ValueGeneratedNever()
                .HasColumnName("codProv");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Asunto)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("asunto");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodItl).HasColumnName("codITL");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.Destinatario)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("destinatario");
            entity.Property(e => e.DestinatarioNombre)
                .HasMaxLength(150)
                .HasColumnName("destinatarioNombre");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocFotos)
                .HasMaxLength(150)
                .HasColumnName("docFotos");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(6)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecItl)
                .HasColumnType("datetime")
                .HasColumnName("fecITL");
            entity.Property(e => e.FecReg).HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.ItlConclusion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("itlConclusion");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(50)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(100)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumItl).HasColumnName("numITL");
            entity.Property(e => e.NumItldocumento)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numITLDocumento");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(1000)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(1000)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.Referencias)
                .HasMaxLength(1000)
                .HasColumnName("referencias");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Remitente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("remitente");
            entity.Property(e => e.RemitenteNombre)
                .HasMaxLength(150)
                .HasColumnName("remitenteNombre");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 5)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TReprogramaDeudaContrato>(entity =>
        {
            entity.HasKey(e => e.CodRdcont).HasName("PK__t_reprog__AD343759CA7E310D");

            entity.ToTable("t_reprograma_deuda_contrato");

            entity.Property(e => e.CodRdcont)
                .ValueGeneratedNever()
                .HasColumnName("codRDCont");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CuotasProgramadas).HasColumnName("cuotasProgramadas");
            entity.Property(e => e.CuotasRestantes).HasColumnName("cuotasRestantes");
            entity.Property(e => e.DocReprogramacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("docReprogramacion");
            entity.Property(e => e.FecReprogramacion).HasColumnName("fecReprogramacion");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ImporteCuota)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeCuota");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.InteresDiario)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesDiario");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
        });

        modelBuilder.Entity<TSubastaInmueble>(entity =>
        {
            entity.HasKey(e => e.CodSubInm).HasName("PK__t_subast__35C924F83A8976A0");

            entity.ToTable("t_subasta_inmueble");

            entity.Property(e => e.CodSubInm)
                .ValueGeneratedNever()
                .HasColumnName("codSubInm");
            entity.Property(e => e.AdjudicaDoc)
                .HasMaxLength(200)
                .HasColumnName("adjudicaDoc");
            entity.Property(e => e.Adjudicado)
                .HasMaxLength(15)
                .HasColumnName("adjudicado");
            entity.Property(e => e.Area)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("area");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodComprobAnterior).HasColumnName("codComprobAnterior");
            entity.Property(e => e.CodPostor).HasColumnName("codPostor");
            entity.Property(e => e.CodPostorAnterior).HasColumnName("codPostorAnterior");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.Distrito)
                .HasMaxLength(256)
                .HasColumnName("distrito");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.DocumentoPagoAnterior)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoAnterior");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaTecnica)
                .HasMaxLength(20)
                .HasColumnName("fichaTecnica");
            entity.Property(e => e.GarantiaBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("garantiaBase");
            entity.Property(e => e.GarantiaCalculada)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("garantiaCalculada");
            entity.Property(e => e.GarantiaCalculadaAnterior)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("garantiaCalculadaAnterior");
            entity.Property(e => e.ImporteInscripcionPostor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeInscripcionPostor");
            entity.Property(e => e.InformeJudicial)
                .HasMaxLength(200)
                .HasColumnName("informeJudicial");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.MesAnterior).HasColumnName("mesAnterior");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Numero)
                .HasMaxLength(256)
                .HasColumnName("numero");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(250)
                .HasColumnName("observaciones");
            entity.Property(e => e.Pagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagado");
            entity.Property(e => e.PagadoAnterior)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("pagadoAnterior");
            entity.Property(e => e.PartReg)
                .HasMaxLength(50)
                .HasColumnName("partReg");
            entity.Property(e => e.Participantes)
                .HasMaxLength(255)
                .HasColumnName("participantes");
            entity.Property(e => e.ParticipantesAnterior)
                .HasMaxLength(255)
                .HasColumnName("participantesAnterior");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.RentaBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("rentaBase");
            entity.Property(e => e.RentaPropuesta)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("rentaPropuesta");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.TicketAnterior).HasColumnName("ticketAnterior");
            entity.Property(e => e.TieneProcJud)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneProcJud");
            entity.Property(e => e.ValRef)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valRef");
            entity.Property(e => e.ValorAdjudicado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valorAdjudicado");
            entity.Property(e => e.ValorAdjudicadoAnterior)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valorAdjudicadoAnterior");
            entity.Property(e => e.Via)
                .HasMaxLength(256)
                .HasColumnName("via");
        });

        modelBuilder.Entity<TSubastaPostorInmueble>(entity =>
        {
            entity.HasKey(e => e.CodPostInm).HasName("PK__t_subast__EBA2EB1D45B9C145");

            entity.ToTable("t_subasta_postor_inmueble");

            entity.Property(e => e.CodPostInm)
                .ValueGeneratedNever()
                .HasColumnName("codPostInm");
            entity.Property(e => e.CodPostor).HasColumnName("codPostor");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TSubastum>(entity =>
        {
            entity.HasKey(e => e.CodSubasta).HasName("PK__t_subast__633F34109606E0AB");

            entity.ToTable("t_subasta");

            entity.Property(e => e.CodSubasta)
                .ValueGeneratedNever()
                .HasColumnName("codSubasta");
            entity.Property(e => e.ActaAdjudicacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("actaAdjudicacion");
            entity.Property(e => e.Anio)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("anio");
            entity.Property(e => e.BaseFin).HasColumnName("baseFin");
            entity.Property(e => e.BaseInicio).HasColumnName("baseInicio");
            entity.Property(e => e.BaseLugar)
                .HasMaxLength(150)
                .HasColumnName("baseLugar");
            entity.Property(e => e.Bases)
                .HasMaxLength(200)
                .HasColumnName("bases");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodEntAdmin)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codEntAdmin");
            entity.Property(e => e.CodOl).HasColumnName("codOL");
            entity.Property(e => e.Comision)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("comision");
            entity.Property(e => e.ComitePresDni)
                .HasMaxLength(15)
                .HasColumnName("comitePresDNI");
            entity.Property(e => e.ComitePresNomb)
                .HasMaxLength(100)
                .HasColumnName("comitePresNomb");
            entity.Property(e => e.ComiteSuplenteDni)
                .HasMaxLength(15)
                .HasColumnName("comiteSuplenteDNI");
            entity.Property(e => e.ComiteSuplenteNomb)
                .HasMaxLength(100)
                .HasColumnName("comiteSuplenteNomb");
            entity.Property(e => e.ComiteTitular1Dni)
                .HasMaxLength(15)
                .HasColumnName("comiteTitular1DNI");
            entity.Property(e => e.ComiteTitular1Nomb)
                .HasMaxLength(100)
                .HasColumnName("comiteTitular1Nomb");
            entity.Property(e => e.ComiteTitular2Dni)
                .HasMaxLength(15)
                .HasColumnName("comiteTitular2DNI");
            entity.Property(e => e.ComiteTitular2Nomb)
                .HasMaxLength(100)
                .HasColumnName("comiteTitular2Nomb");
            entity.Property(e => e.ConfComite)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("confComite");
            entity.Property(e => e.DocAprobComite)
                .HasMaxLength(150)
                .HasColumnName("docAprobComite");
            entity.Property(e => e.DocAprobSub)
                .HasMaxLength(150)
                .HasColumnName("docAprobSub");
            entity.Property(e => e.DocAprobacion)
                .HasMaxLength(150)
                .HasColumnName("docAprobacion");
            entity.Property(e => e.EstSustento)
                .HasMaxLength(2)
                .HasColumnName("estSustento");
            entity.Property(e => e.Estado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estado");
            entity.Property(e => e.FecAprobSub).HasColumnName("fecAprobSub");
            entity.Property(e => e.FecCancelaMontoOfertado).HasColumnName("fecCancelaMontoOfertado");
            entity.Property(e => e.FecConsultas).HasColumnName("fecConsultas");
            entity.Property(e => e.FecConsultasEscrito).HasColumnName("fecConsultasEscrito");
            entity.Property(e => e.FecContrato).HasColumnName("fecContrato");
            entity.Property(e => e.FecConvoca).HasColumnName("fecConvoca");
            entity.Property(e => e.FecSolicSub).HasColumnName("fecSolicSub");
            entity.Property(e => e.FechaActaAdjudicacion).HasColumnName("fechaActaAdjudicacion");
            entity.Property(e => e.FechaBases).HasColumnName("fechaBases");
            entity.Property(e => e.FechaInformeAdjudicacion).HasColumnName("fechaInformeAdjudicacion");
            entity.Property(e => e.FechaInformeSustento).HasColumnName("fechaInformeSustento");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaOpinionLegal).HasColumnName("fechaOpinionLegal");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FechaResolucion).HasColumnName("fechaResolucion");
            entity.Property(e => e.ImporteBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeBase");
            entity.Property(e => e.ImporteInscripcion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeInscripcion");
            entity.Property(e => e.InformeAdjudicacion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("informeAdjudicacion");
            entity.Property(e => e.InformeSustento)
                .HasMaxLength(200)
                .HasColumnName("informeSustento");
            entity.Property(e => e.InscFin).HasColumnName("inscFin");
            entity.Property(e => e.InscInicio).HasColumnName("inscInicio");
            entity.Property(e => e.InscLugar)
                .HasMaxLength(150)
                .HasColumnName("inscLugar");
            entity.Property(e => e.Modalidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("modalidad");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumConvocatoria).HasColumnName("numConvocatoria");
            entity.Property(e => e.NumDocSubasta)
                .HasMaxLength(150)
                .HasColumnName("numDocSubasta");
            entity.Property(e => e.NumSubasta).HasColumnName("numSubasta");
            entity.Property(e => e.ObservSustento)
                .HasMaxLength(2000)
                .HasColumnName("observSustento");
            entity.Property(e => e.OpinionLegal)
                .HasMaxLength(200)
                .HasColumnName("opinionLegal");
            entity.Property(e => e.PrecioBases)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precioBases");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Resolucion)
                .HasMaxLength(200)
                .HasColumnName("resolucion");
            entity.Property(e => e.ResultadoOl)
                .HasMaxLength(2)
                .HasColumnName("resultadoOL");
            entity.Property(e => e.SubaDiaHora)
                .HasColumnType("datetime")
                .HasColumnName("subaDiaHora");
            entity.Property(e => e.SubaFecha).HasColumnName("subaFecha");
            entity.Property(e => e.SubaHora).HasColumnName("subaHora");
            entity.Property(e => e.SubaLugar)
                .HasMaxLength(150)
                .HasColumnName("subaLugar");
            entity.Property(e => e.TieneComision)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneComision");
            entity.Property(e => e.TipoPuja)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPuja");
            entity.Property(e => e.TipoSubasta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoSubasta");
            entity.Property(e => e.ValorPuja)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("valorPuja");
            entity.Property(e => e.VeedorOcidni)
                .HasMaxLength(15)
                .HasColumnName("veedorOCIDNI");
            entity.Property(e => e.VeedorOcinomb)
                .HasMaxLength(100)
                .HasColumnName("veedorOCINomb");
        });

        modelBuilder.Entity<TSupervision>(entity =>
        {
            entity.HasKey(e => e.CodSup).HasName("PK__t_superv__980C74FACAAB1DC4");

            entity.ToTable("t_supervision");

            entity.Property(e => e.CodSup)
                .ValueGeneratedNever()
                .HasColumnName("codSup");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecInspVig).HasColumnName("fecInspVig");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InspAgua)
                .HasMaxLength(6)
                .HasColumnName("inspAgua");
            entity.Property(e => e.InspArea)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("inspArea");
            entity.Property(e => e.InspConformidad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inspConformidad");
            entity.Property(e => e.InspLuz)
                .HasMaxLength(6)
                .HasColumnName("inspLuz");
            entity.Property(e => e.InspObserv)
                .HasMaxLength(250)
                .HasColumnName("inspObserv");
            entity.Property(e => e.InspOcupado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("inspOcupado");
            entity.Property(e => e.InspParedes)
                .HasMaxLength(6)
                .HasColumnName("inspParedes");
            entity.Property(e => e.InspPiso)
                .HasMaxLength(6)
                .HasColumnName("inspPiso");
            entity.Property(e => e.InspPuertas)
                .HasMaxLength(6)
                .HasColumnName("inspPuertas");
            entity.Property(e => e.InspResponsable)
                .HasMaxLength(15)
                .HasColumnName("inspResponsable");
            entity.Property(e => e.InspTecho)
                .HasMaxLength(6)
                .HasColumnName("inspTecho");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.NumInspDoc)
                .HasMaxLength(150)
                .HasColumnName("numInspDoc");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TTipoDocumento>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_tipo_documento");

            entity.Property(e => e.CodTipoDocumento)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("codTipoDocumento");
            entity.Property(e => e.DescCortaTipDoc)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.DescTipoDocumento)
                .HasMaxLength(180)
                .IsUnicode(false);
            entity.Property(e => e.IdTipoDocumento)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoDocumento");
            entity.Property(e => e.LongExacta)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("tipo");
            entity.Property(e => e.TipoContribuyente)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tipoContribuyente");
        });

        modelBuilder.Entity<TTiponotum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_tiponota");

            entity.Property(e => e.IdTipoNota)
                .ValueGeneratedOnAdd()
                .HasColumnName("idTipoNota");
            entity.Property(e => e.TipoNotaCodigo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("tipoNotaCodigo");
            entity.Property(e => e.TipoNotaDc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoNotaDC");
            entity.Property(e => e.TipoNotaEstado).HasColumnName("tipoNotaEstado");
            entity.Property(e => e.TipoNotaNombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("tipoNotaNombre");
        });

        modelBuilder.Entity<TTmpRepIngresosDetallado>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_tmpRepIngresosDetallado");

            entity.Property(e => e.Abr202414)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ABR2024_1_4");
            entity.Property(e => e.Abr202424)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ABR2024_2_4");
            entity.Property(e => e.Abr202434)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ABR2024_3_4");
            entity.Property(e => e.Abr202444)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ABR2024_4_4");
            entity.Property(e => e.Abr202454).HasColumnName("ABR2024_5_4");
            entity.Property(e => e.Ago202418)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AGO2024_1_8");
            entity.Property(e => e.Ago202428)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AGO2024_2_8");
            entity.Property(e => e.Ago202438)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AGO2024_3_8");
            entity.Property(e => e.Ago202448)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("AGO2024_4_8");
            entity.Property(e => e.Ago202458).HasColumnName("AGO2024_5_8");
            entity.Property(e => e.Dic2024112)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIC2024_1_12");
            entity.Property(e => e.Dic2024212)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIC2024_2_12");
            entity.Property(e => e.Dic2024312)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIC2024_3_12");
            entity.Property(e => e.Dic2024412)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DIC2024_4_12");
            entity.Property(e => e.Dic2024512).HasColumnName("DIC2024_5_12");
            entity.Property(e => e.Ene202411)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ENE2024_1_1");
            entity.Property(e => e.Ene202421)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ENE2024_2_1");
            entity.Property(e => e.Ene202431)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ENE2024_3_1");
            entity.Property(e => e.Ene202441)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ENE2024_4_1");
            entity.Property(e => e.Ene202451).HasColumnName("ENE2024_5_1");
            entity.Property(e => e.FGarantia)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("fGarantia");
            entity.Property(e => e.Feb202412)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEB2024_1_2");
            entity.Property(e => e.Feb202422)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEB2024_2_2");
            entity.Property(e => e.Feb202432)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEB2024_3_2");
            entity.Property(e => e.Feb202442)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("FEB2024_4_2");
            entity.Property(e => e.Feb202452).HasColumnName("FEB2024_5_2");
            entity.Property(e => e.IAdenda).HasColumnName("iAdenda");
            entity.Property(e => e.ICodContrato).HasColumnName("iCodContrato");
            entity.Property(e => e.ICuim).HasColumnName("iCuim");
            entity.Property(e => e.ICum).HasColumnName("iCum");
            entity.Property(e => e.IId)
                .ValueGeneratedOnAdd()
                .HasColumnName("iId");
            entity.Property(e => e.INumContrato).HasColumnName("iNumContrato");
            entity.Property(e => e.Jul202417)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUL2024_1_7");
            entity.Property(e => e.Jul202427)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUL2024_2_7");
            entity.Property(e => e.Jul202437)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUL2024_3_7");
            entity.Property(e => e.Jul202447)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUL2024_4_7");
            entity.Property(e => e.Jul202457).HasColumnName("JUL2024_5_7");
            entity.Property(e => e.Jun202416)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUN2024_1_6");
            entity.Property(e => e.Jun202426)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUN2024_2_6");
            entity.Property(e => e.Jun202436)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUN2024_3_6");
            entity.Property(e => e.Jun202446)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("JUN2024_4_6");
            entity.Property(e => e.Jun202456).HasColumnName("JUN2024_5_6");
            entity.Property(e => e.Mar202413)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAR2024_1_3");
            entity.Property(e => e.Mar202423)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAR2024_2_3");
            entity.Property(e => e.Mar202433)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAR2024_3_3");
            entity.Property(e => e.Mar202443)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAR2024_4_3");
            entity.Property(e => e.Mar202453).HasColumnName("MAR2024_5_3");
            entity.Property(e => e.May202415)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAY2024_1_5");
            entity.Property(e => e.May202425)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAY2024_2_5");
            entity.Property(e => e.May202435)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAY2024_3_5");
            entity.Property(e => e.May202445)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MAY2024_4_5");
            entity.Property(e => e.May202455).HasColumnName("MAY2024_5_5");
            entity.Property(e => e.Nov2024111)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NOV2024_1_11");
            entity.Property(e => e.Nov2024211)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NOV2024_2_11");
            entity.Property(e => e.Nov2024311)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NOV2024_3_11");
            entity.Property(e => e.Nov2024411)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("NOV2024_4_11");
            entity.Property(e => e.Nov2024511).HasColumnName("NOV2024_5_11");
            entity.Property(e => e.Oct2024110)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OCT2024_1_10");
            entity.Property(e => e.Oct2024210)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OCT2024_2_10");
            entity.Property(e => e.Oct2024310)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OCT2024_3_10");
            entity.Property(e => e.Oct2024410)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OCT2024_4_10");
            entity.Property(e => e.Oct2024510).HasColumnName("OCT2024_5_10");
            entity.Property(e => e.Sep202419)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SEP2024_1_9");
            entity.Property(e => e.Sep202429)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SEP2024_2_9");
            entity.Property(e => e.Sep202439)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SEP2024_3_9");
            entity.Property(e => e.Sep202449)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("SEP2024_4_9");
            entity.Property(e => e.Sep202459).HasColumnName("SEP2024_5_9");
            entity.Property(e => e.VDireccion)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("vDireccion");
            entity.Property(e => e.VInquilino)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("vInquilino");
            entity.Property(e => e.VInterior)
                .HasMaxLength(800)
                .IsUnicode(false)
                .HasColumnName("vInterior");
        });

        modelBuilder.Entity<TUbigeo>(entity =>
        {
            entity.HasKey(e => e.CodUbi).HasName("PK__t_ubigeo__9B87DEA0F38F6CE5");

            entity.ToTable("t_ubigeo");

            entity.Property(e => e.CodUbi)
                .HasMaxLength(6)
                .HasColumnName("codUbi");
            entity.Property(e => e.Dist)
                .HasMaxLength(100)
                .HasColumnName("dist");
            entity.Property(e => e.Dpto)
                .HasMaxLength(100)
                .HasColumnName("dpto");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.PeriodoArbitrios).HasColumnName("periodoArbitrios");
            entity.Property(e => e.PeriodoPredial).HasColumnName("periodoPredial");
            entity.Property(e => e.Prov)
                .HasMaxLength(100)
                .HasColumnName("prov");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
        });

        modelBuilder.Entity<TUnidadInmobiliariaEdificacion>(entity =>
        {
            entity.HasKey(e => e.CodEdifUi).HasName("PK__t_unidad__33A5D39C63338C00");

            entity.ToTable("t_unidad_inmobiliaria_edificacion");

            entity.Property(e => e.CodEdifUi)
                .ValueGeneratedNever()
                .HasColumnName("codEdifUI");
            entity.Property(e => e.AreaConstVerif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConstVerif");
            entity.Property(e => e.Banio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("banio");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodUiprov).HasColumnName("codUIProv");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InstElectricas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("instElectricas");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("muro");
            entity.Property(e => e.NumPiso).HasColumnName("numPiso");
            entity.Property(e => e.Piso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("piso");
            entity.Property(e => e.Pisos)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pisos");
            entity.Property(e => e.Puertas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("puertas");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Revest)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("revest");
            entity.Property(e => e.Techo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("techo");
            entity.Property(e => e.TotalValor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalValor");
            entity.Property(e => e.ValEdifEstimado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdifEstimado");
        });

        modelBuilder.Entity<TUnidadInmobiliariaEdificacionInspeccion>(entity =>
        {
            entity.HasKey(e => e.CodEdifUi).HasName("PK__t_unidad__33A5D39CAD3C7028");

            entity.ToTable("t_unidad_inmobiliaria_edificacion_inspeccion");

            entity.Property(e => e.CodEdifUi)
                .ValueGeneratedNever()
                .HasColumnName("codEdifUI");
            entity.Property(e => e.AreaConstVerif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConstVerif");
            entity.Property(e => e.Banio)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("banio");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodUiprov).HasColumnName("codUIProv");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.InstElectricas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("instElectricas");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("muro");
            entity.Property(e => e.NumPiso).HasColumnName("numPiso");
            entity.Property(e => e.Piso)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("piso");
            entity.Property(e => e.Pisos)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("pisos");
            entity.Property(e => e.Puertas)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("puertas");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Revest)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("revest");
            entity.Property(e => e.Techo)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("techo");
            entity.Property(e => e.TotalValor)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalValor");
            entity.Property(e => e.ValEdifEstimado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdifEstimado");
        });

        modelBuilder.Entity<TUnidadInmobiliarium>(entity =>
        {
            entity.HasKey(e => e.CodUi).HasName("PK__t_unidad__921450638588AE46");

            entity.ToTable("t_unidad_inmobiliaria");

            entity.Property(e => e.CodUi)
                .ValueGeneratedNever()
                .HasColumnName("codUI");
            entity.Property(e => e.Abcisa)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("abcisa");
            entity.Property(e => e.Altitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("altitud");
            entity.Property(e => e.AnioConst).HasColumnName("anioConst");
            entity.Property(e => e.AntiguedadOcup).HasColumnName("antiguedadOcup");
            entity.Property(e => e.AreaConst)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaConst");
            entity.Property(e => e.AreaLibre)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaLibre");
            entity.Property(e => e.AreaOcup).HasColumnName("areaOcup");
            entity.Property(e => e.AreaOcupUi)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaOcupUI");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.Banio)
                .HasMaxLength(6)
                .HasColumnName("banio");
            entity.Property(e => e.CalidadOcup)
                .HasMaxLength(6)
                .HasColumnName("calidadOcup");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodCatast)
                .HasMaxLength(45)
                .HasColumnName("codCatast");
            entity.Property(e => e.CodInm).HasColumnName("codInm");
            entity.Property(e => e.CodProv).HasColumnName("codProv");
            entity.Property(e => e.CodProvAgua)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvAgua");
            entity.Property(e => e.CodProvLuz)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("codProvLuz");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.CodUiprov).HasColumnName("codUIProv");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Cumx).HasColumnName("cumx");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DerColReg)
                .HasMaxLength(255)
                .HasColumnName("derColReg");
            entity.Property(e => e.DerDistancia)
                .HasMaxLength(100)
                .HasColumnName("derDistancia");
            entity.Property(e => e.DerLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("derLindero");
            entity.Property(e => e.DerNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("derNumMunicipal");
            entity.Property(e => e.DerTramo).HasColumnName("derTramo");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(255)
                .HasColumnName("descPredio");
            entity.Property(e => e.DesdeOcup).HasColumnName("desdeOcup");
            entity.Property(e => e.DetFisLeg)
                .HasMaxLength(6)
                .HasColumnName("detFisLeg");
            entity.Property(e => e.DetTipoPredio)
                .HasMaxLength(6)
                .HasColumnName("detTipoPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.DispLeg)
                .HasMaxLength(45)
                .HasColumnName("dispLeg");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.Dpto)
                .HasMaxLength(6)
                .HasColumnName("dpto");
            entity.Property(e => e.EdifDetalle)
                .HasMaxLength(150)
                .HasColumnName("edifDetalle");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EntAdm)
                .HasMaxLength(6)
                .HasColumnName("entAdm");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstReg)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("estReg");
            entity.Property(e => e.FabInsc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fabInsc");
            entity.Property(e => e.FactServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServAgua");
            entity.Property(e => e.FactServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServDesag");
            entity.Property(e => e.FactServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("factServLuz");
            entity.Property(e => e.FecFab).HasColumnName("fecFab");
            entity.Property(e => e.FecInsc)
                .HasColumnType("datetime")
                .HasColumnName("fecInsc");
            entity.Property(e => e.FecInsp).HasColumnName("fecInsp");
            entity.Property(e => e.FecReg)
                .HasColumnType("datetime")
                .HasColumnName("fecReg");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FechaModificado).HasColumnName("fechaModificado");
            entity.Property(e => e.FechaRegistro).HasColumnName("fechaRegistro");
            entity.Property(e => e.FichaReg)
                .HasMaxLength(45)
                .HasColumnName("fichaReg");
            entity.Property(e => e.FonColReg)
                .HasMaxLength(255)
                .HasColumnName("fonColReg");
            entity.Property(e => e.FonDistancia)
                .HasMaxLength(100)
                .HasColumnName("fonDistancia");
            entity.Property(e => e.FonLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("fonLindero");
            entity.Property(e => e.FonNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("fonNumMunicipal");
            entity.Property(e => e.FonTramo).HasColumnName("fonTramo");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiDetalle)
                .HasMaxLength(255)
                .HasColumnName("formaAdquiDetalle");
            entity.Property(e => e.FreColReg)
                .HasMaxLength(255)
                .HasColumnName("freColReg");
            entity.Property(e => e.FreDistancia)
                .HasMaxLength(100)
                .HasColumnName("freDistancia");
            entity.Property(e => e.FreLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("freLindero");
            entity.Property(e => e.FreNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("freNumMunicipal");
            entity.Property(e => e.FreTramo).HasColumnName("freTramo");
            entity.Property(e => e.HastaOcup).HasColumnName("hastaOcup");
            entity.Property(e => e.Independizado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("independizado");
            entity.Property(e => e.InformeVal)
                .HasMaxLength(150)
                .HasColumnName("informeVal");
            entity.Property(e => e.InscFec).HasColumnName("inscFec");
            entity.Property(e => e.InscReg)
                .HasMaxLength(45)
                .HasColumnName("inscReg");
            entity.Property(e => e.IzqColReg)
                .HasMaxLength(255)
                .HasColumnName("izqColReg");
            entity.Property(e => e.IzqDistancia)
                .HasMaxLength(100)
                .HasColumnName("izqDistancia");
            entity.Property(e => e.IzqLindero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("izqLindero");
            entity.Property(e => e.IzqNumMunicipal)
                .HasMaxLength(150)
                .HasColumnName("izqNumMunicipal");
            entity.Property(e => e.IzqTramo).HasColumnName("izqTramo");
            entity.Property(e => e.Latitud)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("latitud");
            entity.Property(e => e.Lote)
                .HasMaxLength(256)
                .HasColumnName("lote");
            entity.Property(e => e.Manzana)
                .HasMaxLength(4)
                .HasColumnName("manzana");
            entity.Property(e => e.MatConst)
                .HasMaxLength(100)
                .HasColumnName("matConst");
            entity.Property(e => e.MesConst).HasColumnName("mesConst");
            entity.Property(e => e.Mizona)
                .HasMaxLength(6)
                .HasColumnName("mizona");
            entity.Property(e => e.ModificadoPor)
                .HasMaxLength(100)
                .HasColumnName("modificadoPor");
            entity.Property(e => e.Muro)
                .HasMaxLength(6)
                .HasColumnName("muro");
            entity.Property(e => e.NivOcup)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nivOcup");
            entity.Property(e => e.NivUso)
                .HasMaxLength(6)
                .HasColumnName("nivUso");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(50)
                .HasColumnName("nomVia");
            entity.Property(e => e.Norte)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("norte");
            entity.Property(e => e.NumDocOcup)
                .HasMaxLength(250)
                .HasColumnName("numDocOcup");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(256)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumPisos).HasColumnName("numPisos");
            entity.Property(e => e.Numero)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numero");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.ObsLegales)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("obsLegales");
            entity.Property(e => e.ObsTecnicas)
                .HasMaxLength(1000)
                .HasColumnName("obsTecnicas");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupUi)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ocupUI");
            entity.Property(e => e.Ocupante)
                .HasMaxLength(150)
                .HasColumnName("ocupante");
            entity.Property(e => e.OtraInfo)
                .HasMaxLength(250)
                .HasColumnName("otraInfo");
            entity.Property(e => e.OtraInformacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("otraInformacion");
            entity.Property(e => e.PartidaElect)
                .HasMaxLength(45)
                .HasColumnName("partidaElect");
            entity.Property(e => e.Pisos)
                .HasMaxLength(6)
                .HasColumnName("pisos");
            entity.Property(e => e.Prov)
                .HasMaxLength(6)
                .HasColumnName("prov");
            entity.Property(e => e.ProyInflu)
                .HasMaxLength(6)
                .HasColumnName("proyInflu");
            entity.Property(e => e.PuertaCalle)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("puertaCalle");
            entity.Property(e => e.Puertas)
                .HasMaxLength(6)
                .HasColumnName("puertas");
            entity.Property(e => e.RefNomVia)
                .HasMaxLength(150)
                .HasColumnName("refNomVia");
            entity.Property(e => e.RefProxEsquina)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refProxEsquina");
            entity.Property(e => e.RefProxNomVia)
                .HasMaxLength(150)
                .HasColumnName("refProxNomVia");
            entity.Property(e => e.RefProxOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refProxOrient");
            entity.Property(e => e.RefTipoVia)
                .HasMaxLength(6)
                .HasColumnName("refTipoVia");
            entity.Property(e => e.RefViaPrincDist)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("refViaPrincDist");
            entity.Property(e => e.RefViaPrincNomVia)
                .HasMaxLength(150)
                .HasColumnName("refViaPrincNomVia");
            entity.Property(e => e.RefViaPrincOrient)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("refViaPrincOrient");
            entity.Property(e => e.RegRel)
                .HasMaxLength(255)
                .HasColumnName("regRel");
            entity.Property(e => e.RegistradoPor)
                .HasMaxLength(100)
                .HasColumnName("registradoPor");
            entity.Property(e => e.Resol)
                .HasMaxLength(100)
                .HasColumnName("resol");
            entity.Property(e => e.Revest)
                .HasMaxLength(6)
                .HasColumnName("revest");
            entity.Property(e => e.ServAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servAgua");
            entity.Property(e => e.ServCable)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servCable");
            entity.Property(e => e.ServDesag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servDesag");
            entity.Property(e => e.ServInternet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servInternet");
            entity.Property(e => e.ServLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("servLuz");
            entity.Property(e => e.SitFisLeg)
                .HasMaxLength(6)
                .HasColumnName("sitFisLeg");
            entity.Property(e => e.Techo)
                .HasMaxLength(6)
                .HasColumnName("techo");
            entity.Property(e => e.TieneCarga)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tieneCarga");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipUnidad)
                .HasMaxLength(6)
                .HasColumnName("tipUnidad");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipoCambio)
                .HasColumnType("decimal(12, 3)")
                .HasColumnName("tipoCambio");
            entity.Property(e => e.TipoDocOcup)
                .HasMaxLength(6)
                .HasColumnName("tipoDocOcup");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TitularReg)
                .HasMaxLength(60)
                .HasColumnName("titularReg");
            entity.Property(e => e.TituloLeg)
                .HasMaxLength(6)
                .HasColumnName("tituloLeg");
            entity.Property(e => e.TomoFoja)
                .HasMaxLength(45)
                .HasColumnName("tomoFoja");
            entity.Property(e => e.Topografia)
                .HasMaxLength(6)
                .HasColumnName("topografia");
            entity.Property(e => e.TraDecla)
                .HasMaxLength(6)
                .HasColumnName("traDecla");
            entity.Property(e => e.UsoEsp)
                .HasMaxLength(6)
                .HasColumnName("usoEsp");
            entity.Property(e => e.UsoGen)
                .HasMaxLength(6)
                .HasColumnName("usoGen");
            entity.Property(e => e.UsoMesesGarantia).HasColumnName("usoMesesGarantia");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValEdifEstimado).HasColumnName("valEdifEstimado");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValMoneda)
                .HasMaxLength(2)
                .HasColumnName("valMoneda");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValTotDolares)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTotDolares");
            entity.Property(e => e.Zona)
                .HasColumnType("decimal(24, 18)")
                .HasColumnName("zona");
            entity.Property(e => e.Zonif)
                .HasMaxLength(45)
                .HasColumnName("zonif");
            entity.Property(e => e.ZonifDetalle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("zonifDetalle");
        });

        modelBuilder.Entity<TbChangeCod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_change_cod");

            entity.Property(e => e.Actualizado)
                .HasDefaultValue(0)
                .HasColumnName("actualizado");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.NvoCodigo).HasColumnName("nvo_codigo");
        });

        modelBuilder.Entity<TbChangeCodV2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_change_cod_v2");

            entity.Property(e => e.Actualizado).HasColumnName("actualizado");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NvoCodigo).HasColumnName("nvo_codigo");
        });

        modelBuilder.Entity<TblComprobantesSi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TblComprobantesSis");

            entity.Property(e => e.Comprobante)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("comprobante");
            entity.Property(e => e.Glosa)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("glosa");
            entity.Property(e => e.IIdTbl)
                .ValueGeneratedOnAdd()
                .HasColumnName("iIdTbl");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
        });

        modelBuilder.Entity<TblValidaArchivoBanco>(entity =>
        {
            entity.HasKey(e => e.Idtbl).HasName("PK__tblValid__2A4161FED7645F65");

            entity.ToTable("tblValidaArchivoBanco");

            entity.Property(e => e.Idtbl)
                .ValueGeneratedNever()
                .HasColumnName("idtbl");
            entity.Property(e => e.Anio).HasColumnName("anio");
            entity.Property(e => e.Mes).HasColumnName("mes");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
        });

        modelBuilder.Entity<TblVentaLibro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblVentaLibros");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("codPersona");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.NombreLibro)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreLibro");
            entity.Property(e => e.NombreRazonSocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombreRazonSocial");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<TblVentaLibros2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tblVentaLibros2");

            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("codPersona");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.NombreLibro)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("nombreLibro");
            entity.Property(e => e.NombreRazonSocial)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("nombreRazonSocial");
            entity.Property(e => e.Numero).HasColumnName("numero");
            entity.Property(e => e.Preciounit)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("preciounit");
            entity.Property(e => e.Serie)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("serie");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<VAprobacionGarantia>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_aprobacion_garantias");

            entity.Property(e => e.Adenda).HasColumnName("adenda");
            entity.Property(e => e.CodActo).HasColumnName("codActo");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodGcont).HasColumnName("codGCont");
            entity.Property(e => e.CodOl).HasColumnName("codOL");
            entity.Property(e => e.CodPcont).HasColumnName("codPCont");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.DeudaTotalRenta)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("deudaTotalRenta");
            entity.Property(e => e.DocAprobacion)
                .HasMaxLength(150)
                .HasColumnName("docAprobacion");
            entity.Property(e => e.EstGarantia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estGarantia");
            entity.Property(e => e.EstPago)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estPago");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Informe)
                .HasMaxLength(150)
                .HasColumnName("informe");
            entity.Property(e => e.Motivo)
                .HasMaxLength(256)
                .HasColumnName("motivo");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(256)
                .HasColumnName("numInterno");
            entity.Property(e => e.Ocupantes)
                .HasMaxLength(500)
                .HasColumnName("ocupantes");
            entity.Property(e => e.OpinionLegal)
                .HasMaxLength(150)
                .HasColumnName("opinionLegal");
            entity.Property(e => e.TipoArrendatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoArrendatario");
        });

        modelBuilder.Entity<VConsultum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("V_Consulta");

            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodIngreso).HasColumnName("codIngreso");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.Detalle)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("detalle");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.FechaPago).HasColumnName("fechaPago");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.NombreCompletoSunat)
                .HasMaxLength(150)
                .HasColumnName("nombreCompletoSUNAT");
            entity.Property(e => e.Numcontrato).HasColumnName("numcontrato");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(2000)
                .HasColumnName("observaciones");
            entity.Property(e => e.Ticket).HasColumnName("ticket");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("total");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
        });

        modelBuilder.Entity<VInfocorp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_infocorp");

            entity.Property(e => e.AdicionalDocCredito)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("adicionalDocCredito");
            entity.Property(e => e.CodExpIdet).HasColumnName("codExpIDet");
            entity.Property(e => e.CodPersona)
                .HasMaxLength(15)
                .HasColumnName("codPersona");
            entity.Property(e => e.CodigoEntidad)
                .HasMaxLength(80)
                .HasColumnName("codigoEntidad");
            entity.Property(e => e.CondicionDocMoroso)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("condicionDocMoroso");
            entity.Property(e => e.DepartamentoDeudor)
                .HasMaxLength(100)
                .HasColumnName("departamentoDeudor");
            entity.Property(e => e.Deuda)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("deuda");
            entity.Property(e => e.DistritoDeudor)
                .HasMaxLength(100)
                .HasColumnName("distritoDeudor");
            entity.Property(e => e.DocumentoCredito)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("documentoCredito");
            entity.Property(e => e.DomicilioDeudor)
                .HasMaxLength(250)
                .HasColumnName("domicilioDeudor");
            entity.Property(e => e.FechaReporte)
                .HasColumnType("datetime")
                .HasColumnName("fechaReporte");
            entity.Property(e => e.FechaVencimiento).HasColumnName("fechaVencimiento");
            entity.Property(e => e.Moneda)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("moneda");
            entity.Property(e => e.NombreDeudor)
                .HasMaxLength(150)
                .HasColumnName("nombreDeudor");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(15)
                .HasColumnName("numDoc");
            entity.Property(e => e.TipoDeudor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoDeudor");
            entity.Property(e => e.TipoDoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoDoc");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("tipoPersona");
        });

        modelBuilder.Entity<VMargesiAmpliado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_margesi_ampliado");

            entity.Property(e => e.Adenda).HasColumnName("adenda");
            entity.Property(e => e.AdministradoActo)
                .HasMaxLength(255)
                .HasColumnName("administradoActo");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodPostor).HasColumnName("codPostor");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.CuotasDeudaAgua).HasColumnName("cuotasDeudaAgua");
            entity.Property(e => e.CuotasDeudaArbitrios).HasColumnName("cuotasDeudaArbitrios");
            entity.Property(e => e.CuotasDeudaLuz).HasColumnName("cuotasDeudaLuz");
            entity.Property(e => e.CuotasDeudaPredial).HasColumnName("cuotasDeudaPredial");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.DocumentoPagoBase)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoBase");
            entity.Property(e => e.DocumentoPagoInscripcion)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoInscripcion");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstConservNombre)
                .HasMaxLength(150)
                .HasColumnName("estConservNombre");
            entity.Property(e => e.EstInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estInmueble");
            entity.Property(e => e.EstInmuebleNombre)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("estInmuebleNombre");
            entity.Property(e => e.EstadoActo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoActo");
            entity.Property(e => e.EstadoActoNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoActoNombre");
            entity.Property(e => e.EstadoInmuebleSubasta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoInmuebleSubasta");
            entity.Property(e => e.EstadoInmuebleSubastaNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoInmuebleSubastaNombre");
            entity.Property(e => e.EstadoItl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoITL");
            entity.Property(e => e.EstadoPostor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoPostor");
            entity.Property(e => e.EstadoSubasta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoSubasta");
            entity.Property(e => e.EstadoSubastaNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoSubastaNombre");
            entity.Property(e => e.FecAprobSub).HasColumnName("fecAprobSub");
            entity.Property(e => e.FecFinActo).HasColumnName("fecFinActo");
            entity.Property(e => e.FecFinContrato).HasColumnName("fecFinContrato");
            entity.Property(e => e.FecInicioActo).HasColumnName("fecInicioActo");
            entity.Property(e => e.FecInicioContrato).HasColumnName("fecInicioContrato");
            entity.Property(e => e.FecSolicSub).HasColumnName("fecSolicSub");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FinEspActo)
                .HasMaxLength(6)
                .HasColumnName("finEspActo");
            entity.Property(e => e.FinEspActoNombre)
                .HasMaxLength(150)
                .HasColumnName("finEspActoNombre");
            entity.Property(e => e.FinGenActo)
                .HasMaxLength(6)
                .HasColumnName("finGenActo");
            entity.Property(e => e.FinGenActoNombre)
                .HasMaxLength(150)
                .HasColumnName("finGenActoNombre");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiNombre)
                .HasMaxLength(150)
                .HasColumnName("formaAdquiNombre");
            entity.Property(e => e.GarantiaCalculada)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("garantiaCalculada");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.ImpBasePagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impBasePagado");
            entity.Property(e => e.ImpInscripcionPagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impInscripcionPagado");
            entity.Property(e => e.ImporteInscripcion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeInscripcion");
            entity.Property(e => e.MotivoProvisional)
                .HasMaxLength(6)
                .HasColumnName("motivoProvisional");
            entity.Property(e => e.MotivoProvisionalNombre)
                .HasMaxLength(150)
                .HasColumnName("motivoProvisionalNombre");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.NombreDistrito)
                .HasMaxLength(100)
                .HasColumnName("nombreDistrito");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumContratoFisico)
                .HasMaxLength(20)
                .HasColumnName("numContratoFisico");
            entity.Property(e => e.NumDocSubasta)
                .HasMaxLength(150)
                .HasColumnName("numDocSubasta");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(256)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumSubasta).HasColumnName("numSubasta");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.Ocup)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ocup");
            entity.Property(e => e.OcupNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ocupNombre");
            entity.Property(e => e.Ocupantes)
                .HasMaxLength(500)
                .HasColumnName("ocupantes");
            entity.Property(e => e.Participantes)
                .HasMaxLength(250)
                .HasColumnName("participantes");
            entity.Property(e => e.Renta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("renta");
            entity.Property(e => e.RentaBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("rentaBase");
            entity.Property(e => e.ResponsablePagoAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoAgua");
            entity.Property(e => e.ResponsablePagoArbitrios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoArbitrios");
            entity.Property(e => e.ResponsablePagoImpPredial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoImpPredial");
            entity.Property(e => e.ResponsablePagoLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoLuz");
            entity.Property(e => e.SubaDiaHora)
                .HasColumnType("datetime")
                .HasColumnName("subaDiaHora");
            entity.Property(e => e.SubaLugar)
                .HasMaxLength(150)
                .HasColumnName("subaLugar");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipBienCulNombre)
                .HasMaxLength(150)
                .HasColumnName("tipBienCulNombre");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipDomNombre)
                .HasMaxLength(150)
                .HasColumnName("tipDomNombre");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipEdifNombre)
                .HasMaxLength(150)
                .HasColumnName("tipEdifNombre");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipHabilitaNombre)
                .HasMaxLength(150)
                .HasColumnName("tipHabilitaNombre");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInmuebleNombre)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("tipInmuebleNombre");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipIntervNombre)
                .HasMaxLength(150)
                .HasColumnName("tipIntervNombre");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipViaNombre)
                .HasMaxLength(150)
                .HasColumnName("tipViaNombre");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoActoNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoActoNombre");
            entity.Property(e => e.TipoArrendatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoArrendatario");
            entity.Property(e => e.TipoBeneficiario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoBeneficiario");
            entity.Property(e => e.TipoBeneficiarioNombre)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("tipoBeneficiarioNombre");
            entity.Property(e => e.TipoPostor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPostor");
            entity.Property(e => e.TipoPredio)
                .HasMaxLength(6)
                .HasColumnName("tipoPredio");
            entity.Property(e => e.TipoPredioNombre)
                .HasMaxLength(150)
                .HasColumnName("tipoPredioNombre");
            entity.Property(e => e.TipoSuelo)
                .HasMaxLength(6)
                .HasColumnName("tipoSuelo");
            entity.Property(e => e.TipoSueloNombre)
                .HasMaxLength(150)
                .HasColumnName("tipoSueloNombre");
            entity.Property(e => e.TotalDeudaCuotas).HasColumnName("totalDeudaCuotas");
            entity.Property(e => e.TotalDeudaInsoluto)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("totalDeudaInsoluto");
            entity.Property(e => e.TotalDeudaIntereses)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("totalDeudaIntereses");
            entity.Property(e => e.TotalDeudaOtros)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("totalDeudaOtros");
            entity.Property(e => e.TotalDeudaRenta)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("totalDeudaRenta");
            entity.Property(e => e.UsoEspContrato)
                .HasMaxLength(6)
                .HasColumnName("usoEspContrato");
            entity.Property(e => e.UsoEspContratoNombre)
                .HasMaxLength(150)
                .HasColumnName("usoEspContratoNombre");
            entity.Property(e => e.UsoEspInmueble)
                .HasMaxLength(6)
                .HasColumnName("usoEspInmueble");
            entity.Property(e => e.UsoEspInmuebleNombre)
                .HasMaxLength(150)
                .HasColumnName("usoEspInmuebleNombre");
            entity.Property(e => e.UsoGenContrato)
                .HasMaxLength(6)
                .HasColumnName("usoGenContrato");
            entity.Property(e => e.UsoGenContratoNombre)
                .HasMaxLength(150)
                .HasColumnName("usoGenContratoNombre");
            entity.Property(e => e.UsoGenInmueble)
                .HasMaxLength(6)
                .HasColumnName("usoGenInmueble");
            entity.Property(e => e.UsoGenInmuebleNombre)
                .HasMaxLength(150)
                .HasColumnName("usoGenInmuebleNombre");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValorAdjudicado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valorAdjudicado");
        });

        modelBuilder.Entity<VMargesiAmpliadoDetallado>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_margesi_ampliado_detallado");

            entity.Property(e => e.Adenda).HasColumnName("adenda");
            entity.Property(e => e.AdministradoActo)
                .HasMaxLength(255)
                .HasColumnName("administradoActo");
            entity.Property(e => e.AreaReg)
                .HasMaxLength(45)
                .HasColumnName("areaReg");
            entity.Property(e => e.AreaTotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("areaTotal");
            entity.Property(e => e.CodComprob).HasColumnName("codComprob");
            entity.Property(e => e.CodContrato).HasColumnName("codContrato");
            entity.Property(e => e.CodPostor).HasColumnName("codPostor");
            entity.Property(e => e.CodSubasta).HasColumnName("codSubasta");
            entity.Property(e => e.Cuim).HasColumnName("cuim");
            entity.Property(e => e.Cum).HasColumnName("cum");
            entity.Property(e => e.CuotasDeudaAgua).HasColumnName("cuotasDeudaAgua");
            entity.Property(e => e.CuotasDeudaArbitrios).HasColumnName("cuotasDeudaArbitrios");
            entity.Property(e => e.CuotasDeudaLuz).HasColumnName("cuotasDeudaLuz");
            entity.Property(e => e.CuotasDeudaPredial).HasColumnName("cuotasDeudaPredial");
            entity.Property(e => e.Denominacion)
                .HasMaxLength(150)
                .HasColumnName("denominacion");
            entity.Property(e => e.DescPredio)
                .HasMaxLength(1000)
                .HasColumnName("descPredio");
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .HasColumnName("direccion");
            entity.Property(e => e.Dist)
                .HasMaxLength(6)
                .HasColumnName("dist");
            entity.Property(e => e.DocumentoPago)
                .HasMaxLength(50)
                .HasColumnName("documentoPago");
            entity.Property(e => e.DocumentoPagoBase)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoBase");
            entity.Property(e => e.DocumentoPagoInscripcion)
                .HasMaxLength(50)
                .HasColumnName("documentoPagoInscripcion");
            entity.Property(e => e.EmpresaAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaAgua");
            entity.Property(e => e.EmpresaLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("empresaLuz");
            entity.Property(e => e.EstConserv)
                .HasMaxLength(6)
                .HasColumnName("estConserv");
            entity.Property(e => e.EstConservNombre)
                .HasMaxLength(150)
                .HasColumnName("estConservNombre");
            entity.Property(e => e.EstadoActo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoActo");
            entity.Property(e => e.EstadoActoNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoActoNombre");
            entity.Property(e => e.EstadoInmuebleSubasta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoInmuebleSubasta");
            entity.Property(e => e.EstadoInmuebleSubastaNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoInmuebleSubastaNombre");
            entity.Property(e => e.EstadoPostor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoPostor");
            entity.Property(e => e.EstadoSubasta)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("estadoSubasta");
            entity.Property(e => e.EstadoSubastaNombre)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoSubastaNombre");
            entity.Property(e => e.FecAprobSub).HasColumnName("fecAprobSub");
            entity.Property(e => e.FecFinActo).HasColumnName("fecFinActo");
            entity.Property(e => e.FecFinContrato).HasColumnName("fecFinContrato");
            entity.Property(e => e.FecInicioActo).HasColumnName("fecInicioActo");
            entity.Property(e => e.FecInicioContrato).HasColumnName("fecInicioContrato");
            entity.Property(e => e.FecSolicSub).HasColumnName("fecSolicSub");
            entity.Property(e => e.FecValoriza).HasColumnName("fecValoriza");
            entity.Property(e => e.FinEspActo)
                .HasMaxLength(6)
                .HasColumnName("finEspActo");
            entity.Property(e => e.FinEspActoNombre)
                .HasMaxLength(150)
                .HasColumnName("finEspActoNombre");
            entity.Property(e => e.FinGenActo)
                .HasMaxLength(6)
                .HasColumnName("finGenActo");
            entity.Property(e => e.FinGenActoNombre)
                .HasMaxLength(150)
                .HasColumnName("finGenActoNombre");
            entity.Property(e => e.FormaAdqui)
                .HasMaxLength(6)
                .HasColumnName("formaAdqui");
            entity.Property(e => e.FormaAdquiNombre)
                .HasMaxLength(150)
                .HasColumnName("formaAdquiNombre");
            entity.Property(e => e.GarantiaCalculada)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("garantiaCalculada");
            entity.Property(e => e.GarantiaOblig)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaOblig");
            entity.Property(e => e.GarantiaReal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("garantiaReal");
            entity.Property(e => e.ImpBasePagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impBasePagado");
            entity.Property(e => e.ImpInscripcionPagado)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("impInscripcionPagado");
            entity.Property(e => e.ImporteInscripcion)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("importeInscripcion");
            entity.Property(e => e.Insoluto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("insoluto");
            entity.Property(e => e.InteresAcumulado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("interesAcumulado");
            entity.Property(e => e.NomHabilita)
                .HasMaxLength(50)
                .HasColumnName("nomHabilita");
            entity.Property(e => e.NomVia)
                .HasMaxLength(100)
                .HasColumnName("nomVia");
            entity.Property(e => e.NombreDistrito)
                .HasMaxLength(100)
                .HasColumnName("nombreDistrito");
            entity.Property(e => e.NumContrato).HasColumnName("numContrato");
            entity.Property(e => e.NumContratoFisico)
                .HasMaxLength(20)
                .HasColumnName("numContratoFisico");
            entity.Property(e => e.NumCuota).HasColumnName("numCuota");
            entity.Property(e => e.NumDocSubasta)
                .HasMaxLength(150)
                .HasColumnName("numDocSubasta");
            entity.Property(e => e.NumInterno)
                .HasMaxLength(256)
                .HasColumnName("numInterno");
            entity.Property(e => e.NumMuni)
                .HasMaxLength(256)
                .HasColumnName("numMuni");
            entity.Property(e => e.NumSubasta).HasColumnName("numSubasta");
            entity.Property(e => e.NumeroAgua)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroAgua");
            entity.Property(e => e.NumeroLuz)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("numeroLuz");
            entity.Property(e => e.Ocupantes)
                .HasMaxLength(500)
                .HasColumnName("ocupantes");
            entity.Property(e => e.Participantes)
                .HasMaxLength(250)
                .HasColumnName("participantes");
            entity.Property(e => e.Renta)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("renta");
            entity.Property(e => e.RentaBase)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("rentaBase");
            entity.Property(e => e.ResponsablePagoAgua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoAgua");
            entity.Property(e => e.ResponsablePagoArbitrios)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoArbitrios");
            entity.Property(e => e.ResponsablePagoImpPredial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoImpPredial");
            entity.Property(e => e.ResponsablePagoLuz)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("responsablePagoLuz");
            entity.Property(e => e.SubaDiaHora)
                .HasColumnType("datetime")
                .HasColumnName("subaDiaHora");
            entity.Property(e => e.SubaLugar)
                .HasMaxLength(150)
                .HasColumnName("subaLugar");
            entity.Property(e => e.TipBienCul)
                .HasMaxLength(255)
                .HasColumnName("tipBienCul");
            entity.Property(e => e.TipBienCulNombre)
                .HasMaxLength(150)
                .HasColumnName("tipBienCulNombre");
            entity.Property(e => e.TipDom)
                .HasMaxLength(6)
                .HasColumnName("tipDom");
            entity.Property(e => e.TipDomNombre)
                .HasMaxLength(150)
                .HasColumnName("tipDomNombre");
            entity.Property(e => e.TipEdif)
                .HasMaxLength(6)
                .HasColumnName("tipEdif");
            entity.Property(e => e.TipEdifNombre)
                .HasMaxLength(150)
                .HasColumnName("tipEdifNombre");
            entity.Property(e => e.TipHabilita)
                .HasMaxLength(6)
                .HasColumnName("tipHabilita");
            entity.Property(e => e.TipHabilitaNombre)
                .HasMaxLength(150)
                .HasColumnName("tipHabilitaNombre");
            entity.Property(e => e.TipInmueble)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipInmueble");
            entity.Property(e => e.TipInmuebleNombre)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("tipInmuebleNombre");
            entity.Property(e => e.TipInterv)
                .HasMaxLength(6)
                .HasColumnName("tipInterv");
            entity.Property(e => e.TipIntervNombre)
                .HasMaxLength(150)
                .HasColumnName("tipIntervNombre");
            entity.Property(e => e.TipVia)
                .HasMaxLength(6)
                .HasColumnName("tipVia");
            entity.Property(e => e.TipViaNombre)
                .HasMaxLength(150)
                .HasColumnName("tipViaNombre");
            entity.Property(e => e.TipoActo).HasColumnName("tipoActo");
            entity.Property(e => e.TipoActoNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoActoNombre");
            entity.Property(e => e.TipoArrendatario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoArrendatario");
            entity.Property(e => e.TipoBeneficiario)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoBeneficiario");
            entity.Property(e => e.TipoBeneficiarioNombre)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("tipoBeneficiarioNombre");
            entity.Property(e => e.TipoPostor)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoPostor");
            entity.Property(e => e.TotalDeuda)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("totalDeuda");
            entity.Property(e => e.UsoEspContrato)
                .HasMaxLength(6)
                .HasColumnName("usoEspContrato");
            entity.Property(e => e.UsoEspContratoNombre)
                .HasMaxLength(150)
                .HasColumnName("usoEspContratoNombre");
            entity.Property(e => e.UsoEspInmueble)
                .HasMaxLength(6)
                .HasColumnName("usoEspInmueble");
            entity.Property(e => e.UsoEspInmuebleNombre)
                .HasMaxLength(150)
                .HasColumnName("usoEspInmuebleNombre");
            entity.Property(e => e.UsoGenContrato)
                .HasMaxLength(6)
                .HasColumnName("usoGenContrato");
            entity.Property(e => e.UsoGenContratoNombre)
                .HasMaxLength(150)
                .HasColumnName("usoGenContratoNombre");
            entity.Property(e => e.UsoGenInmueble)
                .HasMaxLength(6)
                .HasColumnName("usoGenInmueble");
            entity.Property(e => e.UsoGenInmuebleNombre)
                .HasMaxLength(150)
                .HasColumnName("usoGenInmuebleNombre");
            entity.Property(e => e.ValArrendMes)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valArrendMes");
            entity.Property(e => e.ValEdif)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valEdif");
            entity.Property(e => e.ValM2)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valM2");
            entity.Property(e => e.ValTerr)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTerr");
            entity.Property(e => e.ValTot)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valTot");
            entity.Property(e => e.ValorAdjudicado)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("valorAdjudicado");
        });

        modelBuilder.Entity<_28092022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("28 09 2022");

            entity.Property(e => e.Anio)
                .HasMaxLength(255)
                .HasColumnName("anio");
            entity.Property(e => e.Idtbl)
                .HasMaxLength(255)
                .HasColumnName("idtbl");
            entity.Property(e => e.Mes)
                .HasMaxLength(255)
                .HasColumnName("mes");
            entity.Property(e => e.NumContrato)
                .HasMaxLength(255)
                .HasColumnName("numContrato");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
