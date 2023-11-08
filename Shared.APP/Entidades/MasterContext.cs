using Microsoft.EntityFrameworkCore;

namespace Shared.APP.Entidades;

public partial class MasterContext : DbContext
{
    public MasterContext()
    {
    }

    public MasterContext(DbContextOptions<MasterContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> DetalleCompras { get; set; }

    public virtual DbSet<DetalleVentum> DetalleVenta { get; set; }

    public virtual DbSet<Negocio> Negocios { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderProduct> OrderProducts { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Ventum> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__CATEGORI__F353C1C53ED53533");

            entity.ToTable("CATEGORIA");

            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Client>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(250);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(10);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__CLIENTE__71ABD0A7F5824E4B");

            entity.ToTable("CLIENTE");

            entity.Property(e => e.ClienteId).HasColumnName("ClienteID");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NomkbreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__COMPRA__067DA725A09EA498");

            entity.ToTable("COMPRA");

            entity.Property(e => e.CompraId).HasColumnName("CompraID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MontoTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProveedorId)
                .HasConstraintName("FK__COMPRA__Proveedo__041093DD");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Compras)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__COMPRA__UsuarioI__0504B816");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.DetalleCompraId).HasName("PK__DETALLE___F7FC189AEF24B407");

            entity.ToTable("DETALLE_COMPRA");

            entity.Property(e => e.DetalleCompraId).HasColumnName("DetalleCompraID");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.CompraId).HasColumnName("CompraID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrecioCompra)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioVenta)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.Compra).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.CompraId)
                .HasConstraintName("FK__DETALLE_C__Compr__05F8DC4F");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleCompras)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__DETALLE_C__Produ__06ED0088");
        });

        modelBuilder.Entity<DetalleVentum>(entity =>
        {
            entity.HasKey(e => e.DetalleVentaId).HasName("PK__DETALLE___340EED4458346E03");

            entity.ToTable("DETALLE_VENTA");

            entity.Property(e => e.DetalleVentaId).HasColumnName("DetalleVentaID");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Subtotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.VentaId).HasColumnName("ventaID");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK__DETALLE_V__Produ__07E124C1");

            entity.HasOne(d => d.Venta).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK__DETALLE_V__venta__08D548FA");
        });

        modelBuilder.Entity<Negocio>(entity =>
        {
            entity.HasKey(e => e.NegocioId).HasName("PK__NEGOCIO__72945E4C5FF18198");

            entity.ToTable("NEGOCIO");

            entity.Property(e => e.NegocioId)
                .ValueGeneratedNever()
                .HasColumnName("NegocioID");
            entity.Property(e => e.Direccion).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Rfc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("RFC");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.DeliveryDate).HasColumnType("date");
            entity.Property(e => e.OrderDate).HasColumnType("date");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Client).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ClientId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Orders_Clients");
        });

        modelBuilder.Entity<OrderProduct>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ProductId });
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.PermisoId).HasName("PK__PERMISO__96E0C703CA036641");

            entity.ToTable("PERMISO");

            entity.Property(e => e.PermisoId).HasColumnName("PermisoID");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreMenu)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RolId).HasColumnName("RolID");

            entity.HasOne(d => d.Rol).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__PERMISO__RolID__09C96D33");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__PRODUCTO__A430AE83BD19BABE");

            entity.ToTable("PRODUCTO");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("codigo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.PrecioCompra)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioVenta)
                .HasDefaultValueSql("((0))")
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Stock).HasColumnName("stock");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__PRODUCTO__Catego__0ABD916C");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK__PROVEEDO__61266BB9799DEA67");

            entity.ToTable("PROVEEDOR");

            entity.Property(e => e.ProveedorId).HasColumnName("ProveedorID");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.RolId).HasName("PK__ROL__F92302D1FB2B7DEB");

            entity.ToTable("ROL");

            entity.Property(e => e.RolId).HasColumnName("RolID");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__USUARIO__2B3DE798335E8A71");

            entity.ToTable("USUARIO");

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Clave)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Correo)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NomkbreCompleto)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.RolId).HasColumnName("RolID");

            entity.HasOne(d => d.Rol).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.RolId)
                .HasConstraintName("FK__USUARIO__RolID__0BB1B5A5");
        });

        modelBuilder.Entity<Ventum>(entity =>
        {
            entity.HasKey(e => e.VentaId).HasName("PK__VENTA__40B8EB3491D6E44D");

            entity.ToTable("VENTA");

            entity.Property(e => e.VentaId).HasColumnName("ventaID");
            entity.Property(e => e.DocumentoCliente)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MontoCambio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MontoPago).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MontoTotal).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NumeroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Venta)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__VENTA__UsuarioID__0CA5D9DE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
