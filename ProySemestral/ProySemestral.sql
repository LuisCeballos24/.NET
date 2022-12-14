USE [master]
GO
/****** Object:  Database [ProySemestral]    Script Date: 24/11/2022 14:50:55 ******/
CREATE DATABASE [ProySemestral]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProySemestral', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProySemestral.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProySemestral_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ProySemestral_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProySemestral] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProySemestral].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProySemestral] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProySemestral] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProySemestral] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProySemestral] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProySemestral] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProySemestral] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ProySemestral] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProySemestral] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProySemestral] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProySemestral] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProySemestral] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProySemestral] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProySemestral] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProySemestral] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProySemestral] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ProySemestral] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProySemestral] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProySemestral] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProySemestral] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProySemestral] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProySemestral] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProySemestral] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProySemestral] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProySemestral] SET  MULTI_USER 
GO
ALTER DATABASE [ProySemestral] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProySemestral] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProySemestral] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProySemestral] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProySemestral] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProySemestral] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ProySemestral] SET QUERY_STORE = OFF
GO
USE [ProySemestral]
GO
/****** Object:  User [luis]    Script Date: 24/11/2022 14:50:55 ******/
CREATE USER [luis] FOR LOGIN [luis] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](25) NOT NULL,
	[apellido] [nvarchar](25) NOT NULL,
	[cedula] [nvarchar](25) NOT NULL,
 CONSTRAINT [Cliente_idCliente_PK] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Cliente_cedula_UK] UNIQUE NONCLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleOrden]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleOrden](
	[idProducto] [int] NOT NULL,
	[idOrden] [int] NOT NULL,
	[cantidadPedida] [int] NULL,
 CONSTRAINT [DetalleOrden_idProducto_idOrden_PK] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC,
	[idOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orden]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orden](
	[idOrden] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NULL,
	[idUsuario] [int] NULL,
 CONSTRAINT [Orden_idOrden_PK] PRIMARY KEY CLUSTERED 
(
	[idOrden] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](30) NOT NULL,
	[precio] [money] NULL,
	[cantidad] [int] NULL,
	[foto] [nvarchar](1000) NULL,
 CONSTRAINT [Producto_idProducto_PK] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](25) NOT NULL,
	[apellido] [nvarchar](25) NOT NULL,
	[cedula] [nvarchar](25) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[passTemp] [nvarchar](30) NULL,
	[passUpdateAt] [nvarchar](30) NULL,
	[tipoCuenta] [int] NOT NULL,
	[intento] [int] NULL,
	[createdAt] [date] NULL,
 CONSTRAINT [Usuario_idUsuario_PK] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Usuario_cedula_UK] UNIQUE NONCLUSTERED 
(
	[cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Usuario_email_UK] UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [Pago_Fecha_De_Pago_Df]  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[DetalleOrden]  WITH CHECK ADD  CONSTRAINT [DetalleOrden_idOrden_FK] FOREIGN KEY([idOrden])
REFERENCES [dbo].[Orden] ([idOrden])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleOrden] CHECK CONSTRAINT [DetalleOrden_idOrden_FK]
GO
ALTER TABLE [dbo].[DetalleOrden]  WITH CHECK ADD  CONSTRAINT [DetalleOrden_idProducto_FK] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleOrden] CHECK CONSTRAINT [DetalleOrden_idProducto_FK]
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [Orden_idCliente_FK] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [Orden_idCliente_FK]
GO
ALTER TABLE [dbo].[Orden]  WITH CHECK ADD  CONSTRAINT [Orden_idUsuario_FK] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Orden] CHECK CONSTRAINT [Orden_idUsuario_FK]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [Usuario_tipoCuenta_Ck] CHECK  (([tipoCuenta]>=(1) AND [tipoCuenta]<=(3)))
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [Usuario_tipoCuenta_Ck]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarCliente]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ActualizarCliente] @idCliente int, @nombreC nvarchar(25), @apellidoC nvarchar(25), @cedulaC nvarchar(25)
  As
    UPDATE Cliente
	SET nombre = @nombreC, apellido = @apellidoC, cedula = @cedulaC
	WHERE idCliente = @idCliente

GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarProducto]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ActualizarProducto] @idProducto int, @nombreP nvarchar(50), @precioP money, @cantidadP int, @fotoP nvarchar(100)
  AS
	UPDATE Producto
	SET nombre = @nombreP, precio = @precioP, cantidad = @cantidadP, foto = @fotoP
	WHERE idProducto = @idProducto

GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarUsuario]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_ActualizarUsuario] @idUsuario int, @nombreU nvarchar(25), @apellidoU nvarchar(25), @cedulaU nvarchar(25), @emailU nvarchar(50), @passwordU nvarchar(50), @tipoCuentaU int, @intentoU int
  As
    UPDATE Usuario
	SET nombre = @nombreU, apellido = @apellidoU, cedula = @cedulaU, email = @emailU, password = @passwordU, tipoCuenta = @tipoCuentaU, passTemp = NULL, passUpdateAt = NULL, intento = @intentoU
	WHERE idUsuario = @idUsuario

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarCliente]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BuscarCliente] 
  As
    Select idCliente as 'ID', nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cédula'
	From Cliente

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProductoPorNombre]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BuscarProductoPorNombre] @nombreP nvarchar(50)
  As
    Select idProducto as 'ID', nombre as 'Nombre', precio as 'Precio', cantidad as 'Cantidad'
	From producto
	Where nombre = @nombreP

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProductos]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BuscarProductos] 
  As
    Select idProducto as 'ID', nombre as 'Nombre', precio as 'Precio', cantidad as 'Cantidad', foto as 'Foto'
	From producto

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarProductoVender]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BuscarProductoVender]
  As
    Select idProducto as 'ID', nombre as 'Nombre', precio as 'Precio', cantidad as 'Cantidad'
	From producto
	Where cantidad > 0

GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarUsuario]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_BuscarUsuario]
  As
    Select idUsuario AS 'ID', nombre as 'Nombre', apellido as 'Apellido', cedula as 'Cédula', email as 'Email', password as 'Password', tipoCuenta as 'Tipo', intento as 'Intentos' 
	From Usuario

GO
/****** Object:  StoredProcedure [dbo].[SP_Comprar]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_Comprar] @idCliente int, @idUsuario int
  As 
    INSERT INTO Orden
	VALUES (@idCliente, @idUsuario)

GO
/****** Object:  StoredProcedure [dbo].[SP_DetalleOrden]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- PROC para insertar varias veces en el Visual
CREATE PROC [dbo].[SP_DetalleOrden] @idProducto int, @cantidad int
  AS
	DECLARE @idOrden int
	If Exists(Select TOP 1 idOrden from Orden ORDER BY idOrden DESC)
	Begin
		Select @idOrden = (Select TOP 1 idOrden from Orden ORDER BY idOrden DESC)
	End
	
    INSERT INTO DetalleOrden
	VALUES (@idOrden, @idProducto, @cantidad)

GO
/****** Object:  StoredProcedure [dbo].[SP_EliminarProducto]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_EliminarProducto] @idProducto int
  As
    DELETE FROM Producto WHERE idProducto = @idProducto

GO
/****** Object:  StoredProcedure [dbo].[SP_Enviar_Temp]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_Enviar_Temp] @email nvarchar(50), @random nvarchar(50), @fecha nvarchar (30)
  As
	Update Usuario
	Set passTemp = @random, passUpdateAt = @fecha
	Where email = @email

GO
/****** Object:  StoredProcedure [dbo].[SP_Login]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_Login] @email nvarchar(50), @password nvarchar(50)
  AS
	If Exists(Select * From Usuario Where email = @email AND password = @password AND intento < 3)
	Begin
		UPDATE Usuario
		SET intento = 0, passTemp = NULL, passUpdateAt = NULL 
		WHERE email = @email

		Select idUsuario, nombre, apellido, tipoCuenta
		From Usuario
		Where email = @email AND password = @password
	End
	Else If Exists(Select * From Usuario Where email = @email)
	Begin
		UPDATE Usuario
		Set intento = intento + 1
		Where email = @email
	End
	Else If Exists(Select * From Usuario Where email = @email AND passTemp = @password AND intento < 3)
	Begin
		Select idUsuario, nombre, apellido, tipoCuenta
		From Usuario
		Where email = @email AND passTemp = @password
	End

GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarCliente]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_RegistrarCliente] @nombreC nvarchar(25), @apellidoC nvarchar(25), @cedulaC nvarchar(50)
  AS
	INSERT INTO Cliente (nombre, apellido, cedula)
	VALUES (@nombreC, @apellidoC, @cedulaC)

GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarProducto]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_RegistrarProducto] @nombreP nvarchar(50), @precioP money, @cantidadP int, @byteImageP nvarchar(100)
  AS
	INSERT INTO Producto (nombre, precio, cantidad, foto)
	VALUES (@nombreP, @precioP, @cantidadP, @byteImageP)

GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarUsuario]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_RegistrarUsuario] @nombreU nvarchar(25), @apellidoU nvarchar(25), @cedulaU nvarchar(25), @emailU nvarchar(50), @passwordU nvarchar(50), @tipoCuenta int
  AS
	INSERT INTO Usuario (nombre, apellido, cedula, email, password, tipoCuenta, intento)
	VALUES (@nombreU, @apellidoU, @cedulaU, @emailU, @passwordU, @tipoCuenta, 0)
    
GO
/****** Object:  StoredProcedure [dbo].[SP_Reporte]    Script Date: 24/11/2022 14:50:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[SP_Reporte]
  As
	Select o.idOrden As 'Orden', c.nombre + ' ' + c.apellido As 'Cliente', u.nombre + ' ' + u.apellido As 'Atendido Por', p.nombre As 'Producto', do.cantidadPedida As 'Cantidad', do.cantidadPedida*p.precio As 'Precio Total' From Cliente c
			Inner Join Orden o On c.idCliente = o.idCliente
			Inner Join DetalleOrden do On o.idOrden = do.idOrden
			Inner Join Producto p On do.idProducto = p.idProducto
			Inner Join Usuario u On o.idUsuario = u.idUsuario
	Order By o.idOrden ASC, c.nombre ASC, p.nombre ASC

GO
USE [master]
GO
ALTER DATABASE [ProySemestral] SET  READ_WRITE 
GO
