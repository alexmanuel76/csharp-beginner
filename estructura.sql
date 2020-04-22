USE [master]
GO
/****** Object:  Database [Medico]    Script Date: 4/22/2020 12:00:27 AM ******/
CREATE DATABASE [Medico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Medico', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Medico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Medico_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Medico_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Medico] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Medico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Medico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Medico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Medico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Medico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Medico] SET ARITHABORT OFF 
GO
ALTER DATABASE [Medico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Medico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Medico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Medico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Medico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Medico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Medico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Medico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Medico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Medico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Medico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Medico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Medico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Medico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Medico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Medico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Medico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Medico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Medico] SET  MULTI_USER 
GO
ALTER DATABASE [Medico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Medico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Medico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Medico] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Medico] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Medico', N'ON'
GO
ALTER DATABASE [Medico] SET QUERY_STORE = OFF
GO
USE [Medico]
GO
/****** Object:  Table [dbo].[Clinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clinica](
	[IIDCLINICA] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[DIRECCION] [varchar](150) NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_Clinica] PRIMARY KEY CLUSTERED 
(
	[IIDCLINICA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Consulta]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consulta](
	[IIDCONSULTA] [int] IDENTITY(1,1) NOT NULL,
	[IIDPACIENTE] [int] NULL,
	[PESO] [decimal](18, 2) NULL,
	[ESTATURA] [decimal](18, 2) NULL,
	[EXAMENFISICO] [varchar](200) NULL,
	[EXAMENLABORATORIO] [varchar](200) NULL,
	[DIAGNOSTICO] [varchar](200) NULL,
	[FECHACITA] [datetime] NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_Consulta] PRIMARY KEY CLUSTERED 
(
	[IIDCONSULTA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConsultaMedicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsultaMedicamento](
	[IIDCONSULTA] [int] NOT NULL,
	[IIDMEDICAMENTO] [int] NOT NULL,
	[CANTIDAD] [int] NULL,
	[PRECIO] [decimal](18, 2) NULL,
	[TOTAL] [decimal](18, 2) NULL,
 CONSTRAINT [PK_ConsultaMedicamento] PRIMARY KEY CLUSTERED 
(
	[IIDCONSULTA] ASC,
	[IIDMEDICAMENTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[IIDDOCTOR] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[APPATERNO] [varchar](150) NULL,
	[APMATERNO] [varchar](150) NULL,
	[IIDCLINICA] [int] NULL,
	[IIDESPECIALIDAD] [int] NULL,
	[EMAIL] [varchar](150) NULL,
	[TELEFONOCELULAR] [varchar](10) NULL,
	[IIDSEXO] [int] NULL,
	[SUELDO] [decimal](18, 2) NULL,
	[FECHACONTRATO] [datetime] NULL,
	[BHABILITADO] [int] NULL,
	[ARCHIVO] [varbinary](max) NULL,
	[nombreArchivo] [varchar](100) NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[IIDDOCTOR] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[IIDESPECIALIDAD] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[BHABILITADO] [int] NULL,
	[DESCRIPCION] [varchar](200) NULL,
 CONSTRAINT [PK_TipoEspecialidad] PRIMARY KEY CLUSTERED 
(
	[IIDESPECIALIDAD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaFarmaceutica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaFarmaceutica](
	[IIDFORMAFARMACEUTICA] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_FormaFarmaceutica] PRIMARY KEY CLUSTERED 
(
	[IIDFORMAFARMACEUTICA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicamento](
	[IIDMEDICAMENTO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[CONCENTRACION] [varchar](100) NULL,
	[IIDFORMAFARMACEUTICA] [int] NULL,
	[PRECIO] [decimal](18, 2) NULL,
	[STOCK] [int] NULL,
	[PRESENTACION] [varchar](100) NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_Medicamento] PRIMARY KEY CLUSTERED 
(
	[IIDMEDICAMENTO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paciente](
	[IIDPACIENTE] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[APPATERNO] [varchar](150) NULL,
	[APMATERNO] [varchar](150) NULL,
	[EMAIL] [varchar](100) NULL,
	[DIRECCION] [varchar](200) NULL,
	[TELEFONOFIJO] [varchar](10) NULL,
	[TELEFONOCELULAR] [varchar](10) NULL,
	[FECHANACIMIENTO] [datetime] NULL,
	[IIDSEXO] [int] NULL,
	[IIDTIPOSANGRE] [int] NULL,
	[ALERGIAS] [varchar](200) NULL,
	[ENFERMEDADESCRONICAS] [varchar](200) NULL,
	[CUADRADOVACUNAS] [varchar](200) NULL,
	[ANTECEDENTESQUIRURGICOS] [varchar](200) NULL,
	[BHABILITADO] [int] NULL,
	[foto] [varbinary](max) NULL,
 CONSTRAINT [PK_Paciente] PRIMARY KEY CLUSTERED 
(
	[IIDPACIENTE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sexo]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sexo](
	[IIDSEXO] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[IIDSEXO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoSangre]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSangre](
	[IIDTIPOSANGRE] [int] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](100) NULL,
	[BHABILITADO] [int] NULL,
 CONSTRAINT [PK_TipoSangre] PRIMARY KEY CLUSTERED 
(
	[IIDTIPOSANGRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IIDUSUARIO] [int] IDENTITY(1,1) NOT NULL,
	[IIDDOCTOR] [int] NULL,
	[NOMBREUSUARIO] [varchar](100) NULL,
	[PASSWORD] [varchar](100) NULL,
	[BHABILITADO] [tinyint] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Usuario] ADD  DEFAULT ((0)) FOR [BHABILITADO]
GO
ALTER TABLE [dbo].[Consulta]  WITH CHECK ADD FOREIGN KEY([IIDPACIENTE])
REFERENCES [dbo].[Paciente] ([IIDPACIENTE])
GO
ALTER TABLE [dbo].[ConsultaMedicamento]  WITH CHECK ADD FOREIGN KEY([IIDCONSULTA])
REFERENCES [dbo].[Consulta] ([IIDCONSULTA])
GO
ALTER TABLE [dbo].[ConsultaMedicamento]  WITH CHECK ADD FOREIGN KEY([IIDMEDICAMENTO])
REFERENCES [dbo].[Medicamento] ([IIDMEDICAMENTO])
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD FOREIGN KEY([IIDSEXO])
REFERENCES [dbo].[Sexo] ([IIDSEXO])
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Clinica] FOREIGN KEY([IIDCLINICA])
REFERENCES [dbo].[Clinica] ([IIDCLINICA])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Clinica]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Especialidad] FOREIGN KEY([IIDESPECIALIDAD])
REFERENCES [dbo].[Especialidad] ([IIDESPECIALIDAD])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Especialidad]
GO
ALTER TABLE [dbo].[Medicamento]  WITH CHECK ADD FOREIGN KEY([IIDFORMAFARMACEUTICA])
REFERENCES [dbo].[FormaFarmaceutica] ([IIDFORMAFARMACEUTICA])
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_Sexo] FOREIGN KEY([IIDSEXO])
REFERENCES [dbo].[Sexo] ([IIDSEXO])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_Sexo]
GO
ALTER TABLE [dbo].[Paciente]  WITH CHECK ADD  CONSTRAINT [FK_Paciente_TipoSangre] FOREIGN KEY([IIDTIPOSANGRE])
REFERENCES [dbo].[TipoSangre] ([IIDTIPOSANGRE])
GO
ALTER TABLE [dbo].[Paciente] CHECK CONSTRAINT [FK_Paciente_TipoSangre]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([IIDDOCTOR])
REFERENCES [dbo].[Doctor] ([IIDDOCTOR])
GO
/****** Object:  StoredProcedure [dbo].[sp_buscarClinicaPorId]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_buscarClinicaPorId](@i_idClinica int)
as
begin
	select IIDCLINICA, NOMBRE, DIRECCION 
	  from Clinica 
	 where IIDCLINICA = @i_idClinica
	 and   BHABILITADO = 1
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listarEspecialidades]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_listarEspecialidades]
as
begin
select IIDESPECIALIDAD, NOMBRE, DESCRIPCION 
  from Especialidad
 where BHABILITADO = 1
 order by NOMBRE
end
GO
/****** Object:  StoredProcedure [dbo].[spBuscarDoctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBuscarDoctor]
@i_id_doctor int
as
begin
   select IIDDOCTOR    ,    NOMBRE      , APPATERNO    , APMATERNO      , 
          IIDCLINICA   , IIDESPECIALIDAD, EMAIL        , TELEFONOCELULAR, 
		  IIDSEXO      , SUELDO         , FECHACONTRATO, ARCHIVO        ,
		  nombreArchivo
   from Doctor
   where IIDDOCTOR = @i_id_doctor
   
   if(@@ROWCOUNT = 0)
   begin
       raiserror('El doctor no existe',0,0)
   end
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultaFormaFarmaceutica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spConsultaFormaFarmaceutica]
as
begin
   select IIDFORMAFARMACEUTICA, NOMBRE 
     from FormaFarmaceutica 
	where BHABILITADO = 1
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultarClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarClinica]
@i_id_clinica int
as
begin
   select IIDCLINICA, NOMBRE,DIRECCION
   from Clinica
   where IIDCLINICA = @i_id_clinica
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultarDoctorPorEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[spConsultarDoctorPorEspecialidad]
@i_id_especialidad int
as
begin
   select IIDDOCTOR as ID,NOMBRE,APPATERNO,APMATERNO
     from Doctor
	where BHABILITADO = 1 and IIDESPECIALIDAD = @i_id_especialidad
	order by NOMBRE
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarEspecialidad]
@i_id_especialidad int
as
begin
    select IIDESPECIALIDAD,NOMBRE,DESCRIPCION
	  from Especialidad
	 where IIDESPECIALIDAD = @i_id_especialidad
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultarMedicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spConsultarMedicamento]
@i_id_medicamento int
as
begin
   select IIDMEDICAMENTO, NOMBRE, CONCENTRACION, IIDFORMAFARMACEUTICA, PRECIO, STOCK,PRESENTACION
     from Medicamento
    where IIDMEDICAMENTO = @i_id_medicamento

	if (@@ROWCOUNT = 0)
	begin
	    raiserror('El Medicamento no Existe',0,0)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spConsultarPaciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spConsultarPaciente]
@i_id_paciente int
as
begin
   select IIDPACIENTE    , NOMBRE         , APPATERNO, APMATERNO    , EMAIL   , DIRECCION           , TELEFONOFIJO,
          TELEFONOCELULAR, FECHANACIMIENTO, IIDSEXO  , IIDTIPOSANGRE, ALERGIAS, ENFERMEDADESCRONICAS,
		  CUADRADOVACUNAS, ANTECEDENTESQUIRURGICOS   , foto
   from Paciente
   where IIDPACIENTE = @i_id_paciente

end
GO
/****** Object:  StoredProcedure [dbo].[spCrearClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spCrearClinica]
@i_nombre varchar(100),
@i_direccion varchar(150)
as
declare @w_cantidad int
begin
    select @w_cantidad = count(1)
	from Clinica
	where NOMBRE = @i_nombre

	if (isnull(@i_nombre,'') ='' or isnull(@i_direccion,'') = '')
	begin
		raiserror('Los valores no pueden estar vacios',0,0)
	end

	if (@w_cantidad = 0)
	begin
	   insert into Clinica (NOMBRE,DIRECCION,BHABILITADO) values (@i_nombre,@i_direccion,1)
	end
	else
	   return 999
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spCrearDoctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spCrearDoctor]
@i_nombre           varchar(100),
@i_apellido_paterno varchar(150),
@i_apellido_materno varchar(150),
@i_id_clinica       int,
@i_id_especialidad  int,
@i_email            varchar(150)   = null,
@i_telefono         varchar(10)    = null,
@i_id_sexo          int,
@i_sueldo           decimal(18,2)  = 0,
@i_fecha_contrato   datetime       = null,
@i_archivo          varbinary(max) = null,
@i_nombre_archivo   varchar(100)   = null
as
declare @w_cantidad int
begin
   select @w_cantidad = count(1)
     from Doctor
    where    NOMBRE = @i_nombre
      and APPATERNO = @i_apellido_paterno
	  and APMATERNO = @i_apellido_materno

   if (@w_cantidad > 0)
   begin
       raiserror('El medico ya existe',1,1)
	   return 5000
   end

   insert into Doctor (NOMBRE           , APPATERNO    , APMATERNO                , IIDCLINICA,
                       IIDESPECIALIDAD  , EMAIL        , TELEFONOCELULAR          , IIDSEXO,
					   SUELDO           , FECHACONTRATO, BHABILITADO              , ARCHIVO,
					   nombreArchivo)
			   values (@i_nombre        , @i_apellido_paterno, @i_apellido_materno, @i_id_clinica,
			          @i_id_especialidad, @i_email           , @i_telefono        , @i_id_sexo   ,
					  @i_sueldo         , @i_fecha_contrato  , 1                  , @i_archivo   ,
					  @i_nombre_archivo)
	if (@@ERROR !=0)
	begin
	   raiserror('Problemas para insertar Doctor',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spEliminarClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spEliminarClinica]
@i_id_clinica int
as
begin
   update Clinica set
   BHABILITADO = 0
    where IIDCLINICA = @i_id_clinica

	if (@@ERROR != 0 or @@ROWCOUNT=0)
	begin
	   raiserror('Problemas para Elminar la clinica o no Existe',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spEliminarDoctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEliminarDoctor]
@i_id_doctor int
as
begin
   update Doctor set
   BHABILITADO = 0
   where IIDDOCTOR = @i_id_doctor

	if (@@ERROR != 0 or @@ROWCOUNT=0)
	begin
	   raiserror('Problemas para Elminar el Doctor o no Existe',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spEliminarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEliminarEspecialidad]
@i_id_especialidad int
as
begin
   update Especialidad set
   BHABILITADO = 0
   where IIDESPECIALIDAD = @i_id_especialidad

	if (@@ERROR != 0 or @@ROWCOUNT=0)
	begin
	   raiserror('Problemas para Elminar la Especialidad o no Existe',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spEliminarMedicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEliminarMedicamento]
@i_id_medicamento int
as
begin
   update Medicamento set
   BHABILITADO = 0
   where IIDMEDICAMENTO = @i_id_medicamento

	if (@@ERROR != 0 or @@ROWCOUNT=0)
	begin
	   raiserror('Problemas para Elminar el Medicamento o no Existe',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spEliminarPaciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEliminarPaciente]
@i_id_paciente int
as
begin
   update Paciente set
   BHABILITADO = 0
   where IIDPACIENTE = @i_id_paciente

	if (@@ERROR != 0 or @@ROWCOUNT=0)
	begin
	   raiserror('Problemas para Elminar el Medicamento o no Existe',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spInsertarMedicamentos]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spInsertarMedicamentos]
@i_nombre                varchar(100),
@i_concentracion         varchar(100),
@i_id_forma_farmaceutica int,
@i_precio                decimal (18,2),
@i_stock                 int,
@i_presentacion          varchar(100)
as
declare @w_cantidad int
begin
    if ((isnull(@i_nombre,'') = '' or isnull(@i_concentracion,'') is null))
	begin
	   raiserror('Nombre ni concentracion no pueden estar en blanco',1,1)
	   return 50000
	end

    select @w_cantidad = count(1)
	  from Medicamento
	 where NOMBRE = @i_nombre

	if (@w_cantidad = 0)
	begin
	    insert into Medicamento (NOMBRE                  , CONCENTRACION,
		                         IIDFORMAFARMACEUTICA    , PRECIO, 
								 STOCK                   , PRESENTACION    , BHABILITADO)
		                 values (@i_nombre               , @i_concentracion,
						         @i_id_forma_farmaceutica, @i_precio,
								 @i_stock                , @i_presentacion ,1)
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spInsertarUsuario]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spInsertarUsuario]
@i_id_doctor      int,
@i_nombre_usuario varchar(100),
@i_password       varchar(100)
as
declare @w_cantidad_1 int,
        @w_cantidad_2 int
begin
    select @w_cantidad_1 = count(1)
	  from Usuario
  	 where IIDDOCTOR = @i_id_doctor

	select @w_cantidad_2 = count(1)
	  from Usuario
	 where NOMBREUSUARIO = @i_nombre_usuario

	 if (@w_cantidad_1 = 0 and @w_cantidad_2 = 0)
	 begin
	    insert into Usuario (IIDDOCTOR   , NOMBREUSUARIO    , PASSWORD   , BHABILITADO)
		             values (@i_id_doctor, @i_nombre_usuario, @i_password, 1          )
		if @@ERROR != 0
		   raiserror('Problemas para Ingresar el Usuario',1,1)
	 end
	 else
	     raiserror('No se puede Crear el Usuario',0,0)
end

GO
/****** Object:  StoredProcedure [dbo].[spListarCLinicas]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarCLinicas]
as
begin
   select IIDCLINICA 'ID',NOMBRE
     from Clinica
    where BHABILITADO = 1
	order by NOMBRE
end
GO
/****** Object:  StoredProcedure [dbo].[spListarDoctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarDoctor]
@i_modo tinyint = 1
as
begin
   if (@i_modo = 1)
   begin
      select IIDDOCTOR as ID,NOMBRE,APPATERNO,APMATERNO
     from Doctor
	where BHABILITADO = 1
	order by NOMBRE
   end
   if (@i_modo = 2)
   begin
      select IIDDOCTOR, concat(NOMBRE,' ',APPATERNO,' ',APMATERNO)
     from Doctor
	where BHABILITADO = 1
	order by NOMBRE
   end
end
GO
/****** Object:  StoredProcedure [dbo].[spListarDoctor2]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarDoctor2]
as
begin
   select IIDDOCTOR, concat(NOMBRE,' ',APPATERNO,' ',APMATERNO) as DOCTOR
     from Doctor
	where BHABILITADO = 1
	order by NOMBRE
end
GO
/****** Object:  StoredProcedure [dbo].[spListarDoctorPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spListarDoctorPrograma]
@i_paterno varchar(100) = null,
@i_materno varchar(100) = null
as
begin
   --Busqueda General
   if @i_paterno is null and @i_materno is null
   begin
		select
		'NOMBRE'       = d.NOMBRE,
		'APELLIDO P'   = d.APPATERNO,
		'APELLIDO M'   = d.APMATERNO,
		'ESPECIALIDAD' = e.NOMBRE,
		'CLINICA'      = c.NOMBRE,
		'ID DOCTOR'    = d.IIDDOCTOR
		from Doctor d inner join Clinica c
		  on d.IIDCLINICA = c.IIDCLINICA
		  inner join Especialidad e
		  on d.IIDESPECIALIDAD = e.IIDESPECIALIDAD
		where d.BHABILITADO = 1
		order by e.NOMBRE
   end
   -- Busqueda por Apellido Paterno
   if @i_paterno is not null
   begin
		select
		'NOMBRE'       = d.NOMBRE,
		'APELLIDO P'   = d.APPATERNO,
		'APELLIDO M'   = d.APMATERNO,
		'ESPECIALIDAD' = e.NOMBRE,
		'CLINICA'      = c.NOMBRE,
		'ID DOCTOR'    = d.IIDDOCTOR
		from Doctor d inner join Clinica c
		  on d.IIDCLINICA = c.IIDCLINICA
		  inner join Especialidad e
		  on d.IIDESPECIALIDAD = e.IIDESPECIALIDAD
		where d.BHABILITADO = 1
		  and d.APPATERNO like '%' + @i_paterno + '%'
		order by e.NOMBRE
   end
   -- Busqueda por Apellido Materno
   if @i_materno is not null
   begin
		select
		'NOMBRE'       = d.NOMBRE,
		'APELLIDO P'   = d.APPATERNO,
		'APELLIDO M'   = d.APMATERNO,
		'ESPECIALIDAD' = e.NOMBRE,
		'CLINICA'      = c.NOMBRE,
		'ID DOCTOR'    = d.IIDDOCTOR
		from Doctor d inner join Clinica c
		  on d.IIDCLINICA = c.IIDCLINICA
		  inner join Especialidad e
		  on d.IIDESPECIALIDAD = e.IIDESPECIALIDAD
		where d.BHABILITADO = 1
		  and d.APMATERNO like '%' + @i_materno + '%'
		order by e.NOMBRE
   end
end
GO
/****** Object:  StoredProcedure [dbo].[spListarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarEspecialidad]
as
begin
   select IIDESPECIALIDAD as ID,NOMBRE
     from Especialidad
	where BHABILITADO = 1
end
GO
/****** Object:  StoredProcedure [dbo].[spListarEspecialidadPorNombre]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarEspecialidadPorNombre]
@i_nombre_especialidad varchar(25)
as
begin
   select IIDESPECIALIDAD, NOMBRE, DESCRIPCION 
     from Especialidad
    where NOMBRE like '%'+isnull(@i_nombre_especialidad,'')+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[spListarMedicamentoPorFormaFarmaceutica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarMedicamentoPorFormaFarmaceutica]
@i_id_formaFarmaceutica int
as
begin
   select IIDMEDICAMENTO,NOMBRE,CONCENTRACION,PRECIO,STOCK
     from Medicamento
	where BHABILITADO = 1
	  and IIDFORMAFARMACEUTICA = @i_id_formaFarmaceutica 
end 
GO
/****** Object:  StoredProcedure [dbo].[spListarMedicamentosPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarMedicamentosPrograma]
@i_nombre varchar(100)        = null,
@i_concentracion varchar(100) = null
as
begin
   -- Consulta General
   if @i_nombre is null and @i_concentracion is null
   begin
	   select 'ID_MEDICAMENTO'     = IIDMEDICAMENTO,
	          'NOMBRE'             = m.NOMBRE, 
			  'CONCENRACION'       = m.CONCENTRACION, 
			  'FORMA_FARMACEUTICA' = f.NOMBRE , 
			  'PRECIO'             = m.PRECIO,
			  'STOCK'              = m.STOCK
		 from Medicamento m inner join FormaFarmaceutica f
		   on m.IIDFORMAFARMACEUTICA = f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO = 1
   end
   -- Consulta por Nombre
   if @i_nombre is not null
   begin
	   select 'ID_MEDICAMENTO'     = IIDMEDICAMENTO,
	          'NOMBRE'             = m.NOMBRE, 
			  'CONCENRACION'       = m.CONCENTRACION, 
			  'FORMA_FARMACEUTICA' = f.NOMBRE , 
			  'PRECIO'             = m.PRECIO,
			  'STOCK'              = m.STOCK
		 from Medicamento m inner join FormaFarmaceutica f
		   on m.IIDFORMAFARMACEUTICA = f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO = 1 and m.NOMBRE like '%' + @i_nombre + '%'
   end
   -- Cosulta por Concentracion
   if @i_concentracion is not null
   begin
	   select 'ID_MEDICAMENTO'     = IIDMEDICAMENTO,
	          'NOMBRE'             = m.NOMBRE, 
			  'CONCENRACION'       = m.CONCENTRACION, 
			  'FORMA_FARMACEUTICA' = f.NOMBRE , 
			  'PRECIO'             = m.PRECIO,
			  'STOCK'              = m.STOCK
		 from Medicamento m inner join FormaFarmaceutica f
		   on m.IIDFORMAFARMACEUTICA = f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO = 1 and m.CONCENTRACION like '%' + @i_concentracion + '%'
   end
end


/*
exec spListarMedicamentosPrograma
*/
GO
/****** Object:  StoredProcedure [dbo].[spListarPacientesPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spListarPacientesPrograma]
@i_nombre varchar(100) = null,
@i_apellido_paterno varchar(100) = null,
@i_apellido_materno varchar(100) = null
as
begin
   --Busqueda General
   if @i_nombre is null and @i_apellido_paterno is null and @i_apellido_materno is null
   begin
		select
		 'ID Paciente'      = IIDPACIENTE,
		 'Nombre'           = NOMBRE,
		 'Apellido Paterno' = APPATERNO,
		 'Apellido Materno' = APMATERNO,
		 'Fecha Nacimiento' = FECHANACIMIENTO,
		 'Email'            = EMAIL
		from Paciente
		where BHABILITADO = 1
   end
   --Busqueda Por Nombre
   if @i_nombre is not null
   begin
		select
		 'ID Paciente'      = IIDPACIENTE,
		 'Nombre'           = NOMBRE,
		 'Apellido Paterno' = APPATERNO,
		 'Apellido Materno' = APMATERNO,
		 'Fecha Nacimiento' = FECHANACIMIENTO,
		 'Email'            = EMAIL
		from Paciente
		where BHABILITADO = 1
		  and NOMBRE like '%' + @i_nombre + '%'
   end
   --Busqueda por Apellido Paterno
   if @i_apellido_paterno is not null
   begin
		select
		 'ID Paciente'      = IIDPACIENTE,
		 'Nombre'           = NOMBRE,
		 'Apellido Paterno' = APPATERNO,
		 'Apellido Materno' = APMATERNO,
		 'Fecha Nacimiento' = FECHANACIMIENTO,
		 'Email'            = EMAIL
		from Paciente
		where BHABILITADO = 1
		  and APPATERNO like '%' + @i_apellido_paterno + '%'
   end
   --Busqueda por Apellido Materno
   if @i_apellido_materno is not null
   begin
		select
		 'ID Paciente'      = IIDPACIENTE,
		 'Nombre'           = NOMBRE,
		 'Apellido Paterno' = APPATERNO,
		 'Apellido Materno' = APMATERNO,
		 'Fecha Nacimiento' = FECHANACIMIENTO,
		 'Email'            = EMAIL
		from Paciente
		where BHABILITADO = 1
		  and APMATERNO like '%' + @i_apellido_materno + '%'
   end
end
GO
/****** Object:  StoredProcedure [dbo].[spListarSexo]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spListarSexo]
as
begin
   select IIDSEXO 'ID', NOMBRE 'SEXO' from Sexo where BHABILITADO = 1
end
GO
/****** Object:  StoredProcedure [dbo].[spListarTipoSangre]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarTipoSangre]
as
begin
   select IIDTIPOSANGRE 'ID', NOMBRE 'TIPO'
     from TipoSangre
    where BHABILITADO = 1
    order by NOMBRE
end
GO
/****** Object:  StoredProcedure [dbo].[spListarUsuarios]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spListarUsuarios]
as
begin
   select U.IIDUSUARIO,U.NOMBREUSUARIO, D.NOMBRE + ' ' + D.APPATERNO + ' ' + D.APMATERNO as NOMBRE
     from Usuario U
    inner join Doctor D
       on U.IIDDOCTOR = D.IIDDOCTOR
    where U.BHABILITADO = 1
end
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spLogin]
@i_usuario  varchar(100),
@i_password varchar(100)
as
begin
    select IIDUSUARIO, IIDDOCTOR, NOMBREUSUARIO
	from Usuario
	where NOMBREUSUARIO = @i_usuario
	  and PASSWORD      = @i_password
	  and BHABILITADO   = 1

	if (@@ROWCOUNT = 0)
	   raiserror('Usuario Deshabilitado o no Existe',0,0)
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spModificarClinica]
@i_id_clinica int,
@i_nombre     varchar(100),
@i_direccion  varchar(150)
as
declare @w_cantidad int
begin
   select @w_cantidad = count(1)
     from Clinica
    where IIDCLINICA = @i_id_clinica

	if (@w_cantidad = 1)
	begin
	   update Clinica set
	   NOMBRE    =  @i_nombre,
	   DIRECCION = @i_direccion
	   where IIDCLINICA = @i_id_clinica

	   if (@@ROWCOUNT != 1)
	   begin
	      raiserror('Problemas para actualizar la Clinica',1,1)
		  return 5000
	   end
	end
	else
	begin
	   raiserror('La Clinica No Existe',0,0)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarDoctor]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spModificarDoctor]
@i_id_doctor        int,
@i_nombre           varchar(100),
@i_apellido_paterno varchar(150),
@i_apellido_materno varchar(150),
@i_id_clinica       int,
@i_id_especialidad  int,
@i_email            varchar(150)   = null,
@i_telefono         varchar(10)    = null,
@i_id_sexo          int,
@i_sueldo           decimal(18,2)  = 0,
@i_fecha_contrato   datetime       = null,
@i_archivo          varbinary(max) = null,
@i_nombre_archivo   varchar(100)   = null
as
declare @w_cantidad int
begin
   select @w_cantidad = count(1)
     from Doctor
    where IIDDOCTOR != @i_id_doctor
	  and NOMBRE    =  @i_nombre
      and APPATERNO =  @i_apellido_paterno
	  and APMATERNO =  @i_apellido_materno

   if (@w_cantidad != 0)
   begin
       raiserror('No se puede Modidicar el doctor',1,1)
	   return 5000
   end

   update Doctor set
   NOMBRE          = @i_nombre        , APPATERNO       = @i_apellido_paterno, APMATERNO     = @i_apellido_materno, 
   IIDCLINICA      = @i_id_clinica    , IIDESPECIALIDAD = @i_id_especialidad , EMAIL         = @i_email           , 
   TELEFONOCELULAR = @i_telefono      , IIDSEXO         = @i_id_sexo         , SUELDO        = @i_sueldo          ,
   FECHACONTRATO   = @i_fecha_contrato, ARCHIVO         = @i_archivo         , nombreArchivo = @i_nombre_archivo
   where IIDDOCTOR = @i_id_doctor

	if (@@ERROR !=0)
	begin
	   raiserror('Problemas para Modificar el Doctor',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spModificarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spModificarEspecialidad]
@i_id_especialidad int,
@i_nombre          varchar(100),
@i_descripcion     varchar(150)
as
declare @w_cantidad int,
        @w_error    int
begin
    select @w_cantidad = count(1)
	  from Especialidad
	 where IIDESPECIALIDAD = @i_id_especialidad

	 if (@w_cantidad = 1)
	 begin
	     update Especialidad set
		 NOMBRE      = @i_nombre,
		 DESCRIPCION = @i_descripcion
		 where IIDESPECIALIDAD = @i_id_especialidad

		 if (@@ROWCOUNT !=1 or @@ERROR !=0)
		 begin
		     raiserror('Problemas para actualizar la Especialidad',1,1)
			 return 5000
		 end
	 end
	 else
	    raiserror('La Especialidad no Existe',0,0)
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarMedicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[spModificarMedicamento]
@i_id_medicamento        int,
@i_nombre                varchar(100),
@i_concentracion         varchar(100),
@i_id_forma_farmaceutica int,
@i_precio                decimal (18,2),
@i_stock                 int,
@i_presentacion          varchar(100)
as
declare @w_cantidad int
begin
    if ((isnull(@i_nombre,'') = '' or isnull(@i_concentracion,'') is null))
	begin
	   raiserror('Nombre ni concentracion no pueden estar en blanco',1,1)
	   return 50000
	end

    select @w_cantidad = count(1)
	  from Medicamento
	 where IIDMEDICAMENTO = @i_id_medicamento

	if (@w_cantidad = 1)
	begin
	    update Medicamento set
		NOMBRE               = @i_nombre,
		CONCENTRACION        = @i_concentracion,
		IIDFORMAFARMACEUTICA = @i_id_forma_farmaceutica,
		PRECIO               = @i_precio,
		STOCK                = @i_stock,
		PRESENTACION         = @i_presentacion
		where IIDMEDICAMENTO = @i_id_medicamento

		if (@@ROWCOUNT != 1)
		begin
		   raiserror('Error al actualizar Medicamento',1,1)
		   return 5000
		end
	end
	else
		raiserror('El Medicamento no existe',0,0)
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spModificarPaciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spModificarPaciente]
@i_id_paciente              int,
@i_nombre                   varchar(100),
@i_apaterno                 varchar(150),
@i_amaterno                 varchar(150),
@i_email                    varchar(100) = null,
@i_direccion                varchar(200) = null,
@i_telefono_fijo            varchar(10)  = null,
@i_telefono_celular         varchar(10)  = null,
@i_fecha_nacimiento         datetime,
@i_id_sexo                  int,
@i_id_tipo_sangre           int,
@i_alergias                 varchar(200) = null,
@i_enfermedades             varchar(200) = null,
@i_cuadro_vacunas           varchar(200) = null,
@i_antecedentes_quirurgicos varchar(200) = null,
@i_foto                     varbinary(max) = null
as
declare @w_cantidad int
begin
   if ((isnull(@i_nombre,'') = '' or isnull(@i_apaterno,'') = '' or isnull(@i_amaterno,'') = '')) 
   begin
      raiserror ('CAMPOS OBLIGATORIOS VACIOS',1,1)
	  return 5000
   end

   select @w_cantidad = count(1)
   from Paciente
   where IIDPACIENTE != @i_id_paciente
   and NOMBRE = @i_nombre
   and APPATERNO = @i_apaterno
   and APMATERNO = @i_amaterno

   if (@w_cantidad = 0)
      update Paciente  set
	  NOMBRE          = @i_nombre          , APPATERNO               = @i_apaterno                , APMATERNO            = @i_amaterno        ,
	  EMAIL           = @i_email           , DIRECCION               = @i_direccion               , TELEFONOFIJO         = @i_telefono_celular,
	  TELEFONOCELULAR = @i_telefono_celular, FECHANACIMIENTO         = @i_fecha_nacimiento        ,	  IIDSEXO            = @i_id_sexo  ,
	  IIDTIPOSANGRE   = @i_id_tipo_sangre  , ALERGIAS                = @i_alergias                , ENFERMEDADESCRONICAS = @i_enfermedades,
	  CUADRADOVACUNAS = @i_cuadro_vacunas  , ANTECEDENTESQUIRURGICOS = @i_antecedentes_quirurgicos, foto                 = @i_foto
	  where IIDPACIENTE = @i_id_paciente

	if (@@ERROR != 0)
	begin
	   raiserror ('Problemas para hacer el INSERT',1,1)
	   return 5000
	end
end
return 0
GO
/****** Object:  StoredProcedure [dbo].[spPaciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spPaciente]
@i_nombre                   varchar(100),
@i_apaterno                 varchar(150),
@i_amaterno                 varchar(150),
@i_email                    varchar(100) = null,
@i_direccion                varchar(200) = null,
@i_telefono_fijo            varchar(10)  = null,
@i_telefono_celular         varchar(10)  = null,
@i_fecha_nacimiento         datetime,
@i_id_sexo                  int,
@i_id_tipo_sangre           int,
@i_alergias                 varchar(200) = null,
@i_enfermedades             varchar(200) = null,
@i_cuadro_vacunas           varchar(200) = null,
@i_antecedentes_quirurgicos varchar(200) = null,
@i_foto                     varbinary(max) = null
as
declare @w_cantidad int
begin
   if ((isnull(@i_nombre,'') = '' or isnull(@i_apaterno,'') = '' or isnull(@i_amaterno,'') = '')) 
   begin
      raiserror ('CAMPOS OBLIGATORIOS VACIOS',1,1)
	  return 5000
   end

   select @w_cantidad = count(1)
   from Paciente
   where NOMBRE = @i_nombre
   and APPATERNO = @i_apaterno
   and APMATERNO = @i_amaterno

   if (@w_cantidad = 0)
    insert into Paciente (NOMBRE           , APPATERNO           ,  APMATERNO         , EMAIL                       , DIRECCION,
	                      TELEFONOFIJO     , TELEFONOCELULAR     , FECHANACIMIENTO    , IIDSEXO                     , IIDTIPOSANGRE,
						  ALERGIAS         , ENFERMEDADESCRONICAS, CUADRADOVACUNAS    , ANTECEDENTESQUIRURGICOS     , foto,
						  BHABILITADO)
	              values (@i_nombre        , @i_apaterno         , @i_amaterno        , @i_email                    , @i_direccion,
				          @i_telefono_fijo , @i_telefono_celular , @i_fecha_nacimiento, @i_id_sexo                  , @i_id_tipo_sangre,
						  @i_alergias      , @i_enfermedades     , @i_cuadro_vacunas  , @i_antecedentes_quirurgicos , @i_foto,
						  1)
	if (@@ERROR != 0)
	begin
	   raiserror ('Problemas para hacer el INSERT',1,1)
	   return 5000
	end
end
GO
/****** Object:  StoredProcedure [dbo].[uspActualizarClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspActualizarClinica]
@idclinica int,
@nombre varchar(100),
@direccion varchar(150)
as
begin
   declare @cantidad int

   select @cantidad=count(*)
   from Clinica
   where IIDCLINICA!=@idclinica and  NOMBRE=@nombre
     
	 if @cantidad=0
	 begin
	   update Clinica
	   set NOMBRE=@nombre , DIRECCION=@direccion
	   where IIDCLINICA=@idclinica
	 end

end

GO
/****** Object:  StoredProcedure [dbo].[USPACTUALIZARDOCTOR]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPACTUALIZARDOCTOR]
@IDDOCTOR INT,
@NOMBRE VARCHAR(100),
@APPATERNO VARCHAR(150),
@APMATERNO VARCHAR(150),
@IIDCLINICA INT,
@IIDESPECIALIDAD INT,
@EMAIL VARCHAR(150),
@TELEFONOCELULAR VARCHAR(10),
@IIDSEXO INT,
@SUELDO DECIMAL(18,2),
@FECHACONTRATO DATETIME,
@ARCHIVO VARBINARY(MAX),
@nombreArchivo varchar(100)
AS
BEGIN
  DECLARE @CANTIDAD INT
  SELECT  @CANTIDAD=COUNT(*)
  FROM Doctor
  WHERE IIDDOCTOR!=@IDDOCTOR AND
   NOMBRE=@NOMBRE AND APPATERNO=@APPATERNO AND APMATERNO=@APMATERNO

  IF @CANTIDAD=0
  BEGIN
    UPDATE DOCTOR
	SET NOMBRE= @NOMBRE ,
	APPATERNO= @APPATERNO ,
	APMATERNO= @APMATERNO ,
IIDCLINICA=	 @IIDCLINICA ,
IIDESPECIALIDAD=  @IIDESPECIALIDAD ,
EMAIL= @EMAIL ,
TELEFONOCELULAR=	@TELEFONOCELULAR,
IIDSEXO= @IIDSEXO ,
SUELDO= @SUELDO,
FECHACONTRATO=  @FECHACONTRATO ,
 ARCHIVO= @ARCHIVO,
 nombreArchivo= @nombreArchivo 
   WHERE IIDDOCTOR=@IDDOCTOR
  END
END
GO
/****** Object:  StoredProcedure [dbo].[uspActualizarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspActualizarEspecialidad]
@idespecialidad int,
@nombre varchar(100),
@descripcion varchar(200)
as
begin
    declare @cantidad int

	select @cantidad=count(*)
	from Especialidad
	where IIDESPECIALIDAD!=@idespecialidad and    NOMBRE=@nombre

	if @cantidad=0
	begin
	  update Especialidad
	  set NOMBRE=@nombre , DESCRIPCION=@descripcion
	  where IIDESPECIALIDAD=@idespecialidad


	end

end
GO
/****** Object:  StoredProcedure [dbo].[USPACTUALIZARMEDICAMENTOS]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USPACTUALIZARMEDICAMENTOS]
@IDMEDICAMENTO INT,
@NOMBRE VARCHAR(100),
@CONCENTRACION VARCHAR(100),
@IIDFORMAFARMACEUTICA INT,
@PRECIO DECIMAL(18,2),
@STOCK INT,
@PRESENTACION VARCHAR(100)
AS
BEGIN
DECLARE @CANTIDAD INT
     SELECT @CANTIDAD=COUNT(*)
	 FROM Medicamento
	 WHERE IIDMEDICAMENTO!=@IDMEDICAMENTO AND NOMBRE=@NOMBRE

	 IF @CANTIDAD=0
	 BEGIN
	  UPDATE Medicamento
	  SET NOMBRE=@NOMBRE , CONCENTRACION=@CONCENTRACION,
	  IIDFORMAFARMACEUTICA=@IIDFORMAFARMACEUTICA ,
	  PRECIO=@PRECIO ,
	  STOCK=@STOCK,
	  PRESENTACION=@PRESENTACION
	  WHERE IIDMEDICAMENTO=@IDMEDICAMENTO
	 END

END




GO
/****** Object:  StoredProcedure [dbo].[USPACTUALIZARPACIENTE]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[USPACTUALIZARPACIENTE]
@IDPACIENTE INT,
@NOMBRE VARCHAR(100),
@APPATERNO VARCHAR(150),
@APMATERNO VARCHAR(150),
@EMAIL VARCHAR(100),
@DIRECCION VARCHAR(200),
@TELEFONOFIJO VARCHAR(10),
@TELEFONOCELULAR VARCHAR(10),
@FECHANACIMIENTO DATETIME,
@IIDSEXO INT,
@IIDTIPOSANGRE INT,
@ALERGIAS VARCHAR(200),
@ENFERMEDADESCRONICAS VARCHAR(200),
@CUADRODEVACUNAS VARCHAR(200),
@ANTECENTES VARCHAR(200),
@FOTO VARBINARY(MAX)
AS
BEGIN
DECLARE @CANTIDAD INT

SELECT @CANTIDAD=  COUNT(*)
FROM Paciente
WHERE  IIDPACIENTE!=@IDPACIENTE AND NOMBRE=@NOMBRE AND APPATERNO=@APPATERNO
AND APMATERNO=@APMATERNO

IF @CANTIDAD=0
BEGIN
  UPDATE Paciente
  SET 
  NOMBRE= @NOMBRE, APPATERNO= @APPATERNO,
  APMATERNO= @APMATERNO,EMAIL= @EMAIL,DIRECCION= @DIRECCION,
  TELEFONOFIJO= @TELEFONOFIJO,TELEFONOCELULAR= @TELEFONOCELULAR,
  FECHANACIMIENTO= @FECHANACIMIENTO,IIDSEXO= @IIDSEXO,
  IIDTIPOSANGRE= @IIDTIPOSANGRE,ALERGIAS= @ALERGIAS,
  ENFERMEDADESCRONICAS= @ENFERMEDADESCRONICAS,
  CUADRADOVACUNAS= @CUADRODEVACUNAS,
  ANTECEDENTESQUIRURGICOS= @ANTECENTES,foto= @FOTO
  WHERE IIDPACIENTE=@IDPACIENTE


END


END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaDoctorPorApMaterno]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspConsultaDoctorPorApMaterno]
@apMaterno varchar(150)
as
begin
   select d.NOMBRE,d.APPATERNO,d.APMATERNO,c.NOMBRE as NOMBRECLINICA , e.NOMBRE AS NOMBREESPECIALIDAD
   from Doctor d inner join Clinica c
   on d.IIDCLINICA=c.IIDCLINICA
   inner join Especialidad e
   on e.IIDESPECIALIDAD=d.IIDESPECIALIDAD
   where d.BHABILITADO=1 and d.APMATERNO like '%'+@apMaterno+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultaDoctorPorApPaterno]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspConsultaDoctorPorApPaterno]
@apPaterno varchar(150)
as
begin
   select d.NOMBRE,d.APPATERNO,d.APMATERNO,c.NOMBRE as NOMBRECLINICA , e.NOMBRE AS NOMBREESPECIALIDAD
   from Doctor d inner join Clinica c
   on d.IIDCLINICA=c.IIDCLINICA
   inner join Especialidad e
   on e.IIDESPECIALIDAD=d.IIDESPECIALIDAD
   where d.BHABILITADO=1 and d.APPATERNO like '%'+@apPaterno+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[USPCONSULTARDOCTORPORESPECIALIDAD]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPCONSULTARDOCTORPORESPECIALIDAD]
@IDESPECIALIDAD INT
AS
BEGIN
  SELECT IIDDOCTOR,NOMBRE,APMATERNO,APMATERNO
  FROM Doctor
  WHERE BHABILITADO=1 AND IIDESPECIALIDAD=@IDESPECIALIDAD
END
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarMedicamentoPorConcentracion]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultarMedicamentoPorConcentracion]
@concentracion varchar(100)
as
begin
        select m.IIDMEDICAMENTO,m.NOMBRE,m.CONCENTRACION,f.NOMBRE,m.PRECIO,m.STOCK
		from Medicamento m  inner join  FormaFarmaceutica f
		on m.IIDFORMAFARMACEUTICA=f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO=1 and m.CONCENTRACION like '%'+@concentracion+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarMedicamentoPorNombre]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultarMedicamentoPorNombre]
@nombre varchar(100)
as
begin
        select m.IIDMEDICAMENTO,m.NOMBRE,m.CONCENTRACION,f.NOMBRE,m.PRECIO,m.STOCK
		from Medicamento m  inner join  FormaFarmaceutica f
		on m.IIDFORMAFARMACEUTICA=f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO=1 and m.NOMBRE like '%'+@nombre+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPacientesProgramaPorApMaterno]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultarPacientesProgramaPorApMaterno]
@apMaterno varchar(150)
as
begin
      select IIDPACIENTE,NOMBRE,APPATERNO,APMATERNO,EMAIL,FECHANACIMIENTO,TELEFONOCELULAR
	  from Paciente
      where BHABILITADO=1 and APMATERNO like '%'+@apMaterno+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPacientesProgramaPorApPaterno]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultarPacientesProgramaPorApPaterno]
@apPaterno varchar(150)
as
begin
      select IIDPACIENTE,NOMBRE,APPATERNO,APMATERNO,EMAIL,FECHANACIMIENTO,TELEFONOCELULAR
	  from Paciente
      where BHABILITADO=1 and APPATERNO like '%'+@apPaterno+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[uspConsultarPacientesProgramaPorNombre]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspConsultarPacientesProgramaPorNombre]
@nombre varchar(100)
as
begin
      select IIDPACIENTE,NOMBRE,APPATERNO,APMATERNO,EMAIL,FECHANACIMIENTO,TELEFONOCELULAR
	  from Paciente
      where BHABILITADO=1 and NOMBRE like '%'+@nombre+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[USPELIMINARCLINICA]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPELIMINARCLINICA]
@IDCLINICA INT
AS
BEGIN

UPDATE CLINICA
SET BHABILITADO=0
WHERE IIDCLINICA=@IDCLINICA

END
GO
/****** Object:  StoredProcedure [dbo].[uspELiminarDoctos]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspELiminarDoctos]
@iddoctor int
as
begin
   update Doctor
   set  BHABILITADO=0
   where  IIDDOCTOR=@iddoctor

end
GO
/****** Object:  StoredProcedure [dbo].[USPELIMINARESPECIALIDAD]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USPELIMINARESPECIALIDAD]
@IDESPECIALIDAD INT
AS
BEGIN
        UPDATE Especialidad
		SET BHABILITADO=0
		WHERE IIDESPECIALIDAD=@IDESPECIALIDAD
           
END
GO
/****** Object:  StoredProcedure [dbo].[USPELIMINARMEDICAMENTO]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPELIMINARMEDICAMENTO]
@IDMEDICAMENTO INT
AS
BEGIN
       UPDATE Medicamento
	   SET  BHABILITADO=0
	   WHERE IIDMEDICAMENTO=@IDMEDICAMENTO
END
GO
/****** Object:  StoredProcedure [dbo].[USPELIMNARPACIENTE]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPELIMNARPACIENTE]
@IDPACIENTE INT
AS
BEGIN
    UPDATE Paciente
	SET  BHABILITADO=0
	WHERE IIDPACIENTE=@IDPACIENTE
END
GO
/****** Object:  StoredProcedure [dbo].[uspFiltrarClinicaPorId]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[uspFiltrarClinicaPorId]
@idclinica int
as
begin
   select IIDCLINICA,NOMBRE,DIRECCION
   from Clinica
   where IIDCLINICA=@idclinica
end
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspInsertarClinica]
@nombre varchar(100),
@direccion varchar(150)
as
begin
   declare @cantidad int
      select @cantidad=count(*)
	  from Clinica
	  where NOMBRE=@nombre

	  if @cantidad=0
	  begin
	   insert into Clinica(NOMBRE,DIRECCION,BHABILITADO)
	   values(@nombre,@direccion,1)
	  end

end

GO
/****** Object:  StoredProcedure [dbo].[USPINSERTARDOCTOR]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[USPINSERTARDOCTOR]
@NOMBRE VARCHAR(100),
@APPATERNO VARCHAR(150),
@APMATERNO VARCHAR(150),
@IIDCLINICA INT,
@IIDESPECIALIDAD INT,
@EMAIL VARCHAR(150),
@TELEFONOCELULAR VARCHAR(10),
@IIDSEXO INT,
@SUELDO DECIMAL(18,2),
@FECHACONTRATO DATETIME,
@ARCHIVO VARBINARY(MAX),
@nombreArchivo varchar(100)
AS
BEGIN
  DECLARE @CANTIDAD INT
  SELECT  @CANTIDAD=COUNT(*)
  FROM Doctor
  WHERE NOMBRE=@NOMBRE AND APPATERNO=@APPATERNO AND APMATERNO=@APMATERNO

  IF @CANTIDAD=0
  BEGIN
    INSERT INTO Doctor(NOMBRE,APPATERNO,APMATERNO,IIDCLINICA,IIDESPECIALIDAD,
	EMAIL,TELEFONOCELULAR,IIDSEXO,SUELDO,FECHACONTRATO,BHABILITADO,ARCHIVO,nombreArchivo)
	VALUES
	(@NOMBRE ,@APPATERNO ,@APMATERNO ,@IIDCLINICA ,@IIDESPECIALIDAD ,@EMAIL ,
	@TELEFONOCELULAR, @IIDSEXO ,@SUELDO, @FECHACONTRATO ,1,@ARCHIVO,@nombreArchivo )
  END
END
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspInsertarEspecialidad]
@nombre varchar(100),
@descripcion varchar(200)
as
begin
    declare @cantidad int
	select @cantidad=count(*)
	from Especialidad
	where NOMBRE=@nombre

	if @cantidad=0
	begin
	   insert into Especialidad(NOMBRE,DESCRIPCION,BHABILITADO)
	   values(@nombre,@descripcion,1)
	end

end
GO
/****** Object:  StoredProcedure [dbo].[USPINSERTARMEDICAMENTOS]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPINSERTARMEDICAMENTOS]
@NOMBRE VARCHAR(100),
@CONCENTRACION VARCHAR(100),
@IIDFORMAFARMACEUTICA INT,
@PRECIO DECIMAL(18,2),
@STOCK INT,
@PRESENTACION VARCHAR(100)
AS
BEGIN
DECLARE @CANTIDAD INT
     SELECT @CANTIDAD=COUNT(*)
	 FROM Medicamento
	 WHERE NOMBRE=@CONCENTRACION

	 IF @CANTIDAD=0
	 BEGIN
	  INSERT INTO Medicamento(NOMBRE,CONCENTRACION,IIDFORMAFARMACEUTICA,
	  PRECIO,STOCK,PRESENTACION,BHABILITADO)
	  VALUES(@NOMBRE,@CONCENTRACION,@IIDFORMAFARMACEUTICA,@PRECIO,
	  @STOCK,@PRESENTACION,1)
	 END

END
GO
/****** Object:  StoredProcedure [dbo].[USPINSERTARPACIENTE]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPINSERTARPACIENTE]
@NOMBRE VARCHAR(100),
@APPATERNO VARCHAR(150),
@APMATERNO VARCHAR(150),
@EMAIL VARCHAR(100),
@DIRECCION VARCHAR(200),
@TELEFONOFIJO VARCHAR(10),
@TELEFONOCELULAR VARCHAR(10),
@FECHANACIMIENTO DATETIME,
@IIDSEXO INT,
@IIDTIPOSANGRE INT,
@ALERGIAS VARCHAR(200),
@ENFERMEDADESCRONICAS VARCHAR(200),
@CUADRODEVACUNAS VARCHAR(200),
@ANTECENTES VARCHAR(200),
@FOTO VARBINARY(MAX)
AS
BEGIN
DECLARE @CANTIDAD INT

SELECT @CANTIDAD=  COUNT(*)
FROM Paciente
WHERE NOMBRE=@NOMBRE AND APPATERNO=@APPATERNO
AND APMATERNO=@APMATERNO

IF @CANTIDAD=0
BEGIN
  INSERT INTO Paciente (NOMBRE,APPATERNO,APMATERNO,EMAIL,DIRECCION,
  TELEFONOFIJO,TELEFONOCELULAR,FECHANACIMIENTO,IIDSEXO,IIDTIPOSANGRE,
  ALERGIAS,ENFERMEDADESCRONICAS,CUADRADOVACUNAS,ANTECEDENTESQUIRURGICOS,BHABILITADO,
  foto)
  VALUES(
  @NOMBRE,@APPATERNO,@APMATERNO,@EMAIL,@DIRECCION,@TELEFONOFIJO,@TELEFONOCELULAR,
  @FECHANACIMIENTO,@IIDSEXO,@IIDTIPOSANGRE,@ALERGIAS,@ENFERMEDADESCRONICAS,@CUADRODEVACUNAS,
  @ANTECENTES,1,@FOTO
  )
END


END
GO
/****** Object:  StoredProcedure [dbo].[USPLCONSULTARMEDICAMENTOSPORFORMAFARMACEUTICA]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLCONSULTARMEDICAMENTOSPORFORMAFARMACEUTICA]
@IIDFORMAFARMACEUTICA INT
AS
BEGIN
   SELECT IIDMEDICAMENTO,NOMBRE,CONCENTRACION,PRECIO,STOCK
   FROM Medicamento
   WHERE BHABILITADO=1 AND IIDFORMAFARMACEUTICA=@IIDFORMAFARMACEUTICA
END
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARCOMBOCLINICA]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARCOMBOCLINICA]
AS
BEGIN
      SELECT IIDCLINICA,NOMBRE
	  FROM Clinica
	  WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARCOMBOESPECIALIDAD]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARCOMBOESPECIALIDAD]
AS
BEGIN
   SELECT IIDESPECIALIDAD,NOMBRE
   FROM Especialidad
   WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARDOCTOR]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARDOCTOR]
AS
BEGIN
  SELECT IIDDOCTOR,NOMBRE,APMATERNO,APMATERNO
  FROM Doctor
  WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[uspListarDoctorPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[uspListarDoctorPrograma]
as
begin
   select d.IIDDOCTOR, d.NOMBRE,d.APMATERNO,d.APMATERNO,c.NOMBRE as NOMBRECLINICA , e.NOMBRE AS NOMBREESPECIALIDAD
   from Doctor d inner join Clinica c
   on d.IIDCLINICA=c.IIDCLINICA
   inner join Especialidad e
   on e.IIDESPECIALIDAD=d.IIDESPECIALIDAD
   where d.BHABILITADO=1
end
GO
/****** Object:  StoredProcedure [dbo].[uspListarEspecialidades]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure  [dbo].[uspListarEspecialidades]
as
begin
select IIDESPECIALIDAD,NOMBRE,DESCRIPCION
from Especialidad
where BHABILITADO=1
end
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARESPECIALIDADPORNOMBRE]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARESPECIALIDADPORNOMBRE]
@NOMBRE VARCHAR(100)
AS
BEGIN
    SELECT IIDESPECIALIDAD,NOMBRE,DESCRIPCION
	FROM Especialidad
	WHERE NOMBRE LIKE '%'+@NOMBRE+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[uspListarMedicamentoPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspListarMedicamentoPrograma]
as
begin
        select m.IIDMEDICAMENTO,m.NOMBRE,m.CONCENTRACION,f.NOMBRE,m.PRECIO,m.STOCK
		from Medicamento m  inner join  FormaFarmaceutica f
		on m.IIDFORMAFARMACEUTICA=f.IIDFORMAFARMACEUTICA
		where m.BHABILITADO=1
end
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARMEDICAMENTOS]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARMEDICAMENTOS]
AS
BEGIN
   SELECT IIDMEDICAMENTO,NOMBRE,CONCENTRACION,PRECIO,STOCK
   FROM Medicamento
   WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[USPLISTARMEDICAS]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLISTARMEDICAS]
AS
BEGIN
  SELECT IIDDOCTOR,NOMBRE,APMATERNO,APMATERNO
  FROM Doctor
  WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[uspListarPacientesPrograma]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[uspListarPacientesPrograma]
as
begin
      select IIDPACIENTE,NOMBRE,APPATERNO,APMATERNO,EMAIL,FECHANACIMIENTO,TELEFONOCELULAR
	  from Paciente
      where BHABILITADO=1
end
GO
/****** Object:  StoredProcedure [dbo].[USPLLENARCOMBOFORMAFARMACEUTICA]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROCEDURE [dbo].[USPLLENARCOMBOFORMAFARMACEUTICA]
AS
BEGIN
  SELECT IIDFORMAFARMACEUTICA as Id,NOMBRE
  FROM FormaFarmaceutica
  WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[USPLLENARCOMBOSEXO]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLLENARCOMBOSEXO]
AS 
BEGIN
  SELECT IIDSEXO,NOMBRE
  FROM Sexo
  WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[USPLLENARCOMBOTIPOSANGRE]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPLLENARCOMBOTIPOSANGRE]
AS 
BEGIN
       SELECT IIDTIPOSANGRE,NOMBRE
	   FROM TipoSangre
	   WHERE BHABILITADO=1
END
GO
/****** Object:  StoredProcedure [dbo].[uspObtenerDatosClinica]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspObtenerDatosClinica]
@idclinica int
as
begin
select IIDCLINICA,NOMBRE,DIRECCION
from Clinica
where IIDCLINICA=@idclinica

end
GO
/****** Object:  StoredProcedure [dbo].[USPOBTENERDOCTOR]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[USPOBTENERDOCTOR]
@IIDDOCTOR INT
AS
BEGIN
           SELECT IIDDOCTOR,NOMBRE,APPATERNO,APMATERNO,
		   IIDCLINICA,IIDESPECIALIDAD,EMAIL,TELEFONOCELULAR,
		   IIDSEXO,SUELDO,FECHACONTRATO,ARCHIVO,NOMBREARCHIVO
		   FROM Doctor
		   WHERE IIDDOCTOR=@IIDDOCTOR
END
GO
/****** Object:  StoredProcedure [dbo].[uspObtenerEspecialidad]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspObtenerEspecialidad]
@idespecialidad int
as
begin
  select IIDESPECIALIDAD,NOMBRE,DESCRIPCION
  from Especialidad
  where IIDESPECIALIDAD=@idespecialidad

end
GO
/****** Object:  StoredProcedure [dbo].[uspObtenerMedicamento]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[uspObtenerMedicamento]
@idmedicamento int
as
begin

select IIDMEDICAMENTO,NOMBRE,CONCENTRACION,IIDFORMAFARMACEUTICA,
PRECIO,STOCK,PRESENTACION
from Medicamento
where IIDMEDICAMENTO=@idmedicamento

end
GO
/****** Object:  StoredProcedure [dbo].[uspObtenerPaciente]    Script Date: 4/22/2020 12:00:27 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspObtenerPaciente]
@idpaciente int
as
begin
 select IIDPACIENTE,NOMBRE,APPATERNO,APMATERNO,EMAIL,DIRECCION,
 TELEFONOFIJO,TELEFONOCELULAR,FECHANACIMIENTO,IIDSEXO,IIDTIPOSANGRE,
 ALERGIAS,ENFERMEDADESCRONICAS,CUADRADOVACUNAS,ANTECEDENTESQUIRURGICOS,foto
 from Paciente
 where IIDPACIENTE=@idpaciente
end
GO
USE [master]
GO
ALTER DATABASE [Medico] SET  READ_WRITE 
GO
