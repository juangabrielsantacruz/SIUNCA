USE [master]
GO
/****** Object:  Database [SIUNCA]    Script Date: 26/10/2021 10:39:55 ******/
CREATE DATABASE [SIUNCA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PruebaSIUNCA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PruebaSIUNCA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PruebaSIUNCA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\PruebaSIUNCA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SIUNCA] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SIUNCA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SIUNCA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SIUNCA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SIUNCA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SIUNCA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SIUNCA] SET ARITHABORT OFF 
GO
ALTER DATABASE [SIUNCA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SIUNCA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SIUNCA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SIUNCA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SIUNCA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SIUNCA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SIUNCA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SIUNCA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SIUNCA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SIUNCA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SIUNCA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SIUNCA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SIUNCA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SIUNCA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SIUNCA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SIUNCA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SIUNCA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SIUNCA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SIUNCA] SET  MULTI_USER 
GO
ALTER DATABASE [SIUNCA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SIUNCA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SIUNCA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SIUNCA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SIUNCA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SIUNCA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [SIUNCA] SET QUERY_STORE = OFF
GO
USE [SIUNCA]
GO
/****** Object:  User [BICE\juan.santacruz]    Script Date: 26/10/2021 10:39:55 ******/
CREATE USER [BICE\juan.santacruz] FOR LOGIN [BICE\juan.santacruz] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_datareader] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [BICE\juan.santacruz]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [BICE\juan.santacruz]
GO
/****** Object:  Table [dbo].[Alumno]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno](
	[LegajoAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Sexo] [varchar](50) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Alumno] PRIMARY KEY CLUSTERED 
(
	[LegajoAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alumno_MateriaCC]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alumno_MateriaCC](
	[IdAlumno_Materia] [int] IDENTITY(1,1) NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Estado] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Alumno_Curso] PRIMARY KEY CLUSTERED 
(
	[IdAlumno_Materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Asistencia]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asistencia](
	[IdAsistencia] [int] IDENTITY(1,1) NOT NULL,
	[Ausente] [varchar](50) NOT NULL,
	[Presente] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Asistencia] PRIMARY KEY CLUSTERED 
(
	[IdAsistencia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaConCorrelativas]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaConCorrelativas](
	[IdMateriaCC] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_MateriaConCorrelativas] PRIMARY KEY CLUSTERED 
(
	[IdMateriaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VistaSumaAsistencias]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VistaSumaAsistencias]
AS
SELECT        dbo.Alumno.LegajoAlumno, MIN(dbo.MateriaConCorrelativas.IdMateriaCC) AS idMateriaCC, MIN(dbo.Alumno.Nombre) AS Nombre, MIN(dbo.Alumno.Apellido) AS Apellido, SUM(CAST(dbo.Asistencia.Ausente AS int)) AS Ausentes, 
                         SUM(CAST(dbo.Asistencia.Presente AS int)) AS Presentes, MIN(dbo.Alumno_MateriaCC.Estado) AS Estado
FROM            dbo.Alumno INNER JOIN
                         dbo.Alumno_MateriaCC ON dbo.Alumno.LegajoAlumno = dbo.Alumno_MateriaCC.LegajoAlumno INNER JOIN
                         dbo.Asistencia ON dbo.Alumno.LegajoAlumno = dbo.Asistencia.LegajoAlumno INNER JOIN
                         dbo.MateriaConCorrelativas ON dbo.Alumno_MateriaCC.IdMateriaCC = dbo.MateriaConCorrelativas.IdMateriaCC AND dbo.Asistencia.IdMateriaCC = dbo.MateriaConCorrelativas.IdMateriaCC
WHERE        (dbo.MateriaConCorrelativas.IdMateriaCC = 11)
GROUP BY dbo.Alumno.LegajoAlumno
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[IdBitacora] [int] IDENTITY(1,1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdTipoBitacora] [int] NOT NULL,
	[FechaHora] [datetime] NOT NULL,
	[Mensaje] [varchar](50) NOT NULL,
	[dv] [int] NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[IdBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Carrera]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrera](
	[IdCarrera] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Carrera] PRIMARY KEY CLUSTERED 
(
	[IdCarrera] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Curso]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[IdCurso] [int] IDENTITY(1,1) NOT NULL,
	[CuposMax] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[FechaFin] [date] NOT NULL,
	[Turno] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Curso] PRIMARY KEY CLUSTERED 
(
	[IdCurso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesDetMatPlanCorrPlan]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesDetMatPlanCorrPlan](
	[IdDetallesDetMatPlanCorrPlan] [int] IDENTITY(1,1) NOT NULL,
	[IdPlanDetalles] [int] NOT NULL,
	[IdPlanDetalles2] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[IdDetallesDetMatPlanCorrPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesPlanDeEstudio]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesPlanDeEstudio](
	[IdPlanDetalles] [int] IDENTITY(1,1) NOT NULL,
	[IdPlanDeEstudio] [int] NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Obligatoriedad] [varchar](50) NOT NULL,
	[NumeroMateria] [int] NOT NULL,
	[Año] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_DetallesPlanDeEstudio] PRIMARY KEY CLUSTERED 
(
	[IdPlanDetalles] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dvv]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dvv](
	[nombreTabla] [varchar](50) NOT NULL,
	[dvv] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Evaluacion]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Evaluacion](
	[IdEvaluacion] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[LegajoProfesor] [int] NOT NULL,
	[Nota] [float] NOT NULL,
	[TipoDeNota] [varchar](50) NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Evaluacion] PRIMARY KEY CLUSTERED 
(
	[IdEvaluacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Familia]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Familia](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Familia] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaFamilia]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaFamilia](
	[IdFamilia] [int] NOT NULL,
	[IdFamiliaHijo] [int] NOT NULL,
 CONSTRAINT [PK_FamiliaFamilia] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdFamiliaHijo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FamiliaPatente]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamiliaPatente](
	[IdFamilia] [int] NOT NULL,
	[IdPatente] [int] NOT NULL,
 CONSTRAINT [PK_FamiliaPatente] PRIMARY KEY CLUSTERED 
(
	[IdFamilia] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Idioma] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MateriaCC_Profesor]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MateriaCC_Profesor](
	[IdMateriaCC_Profesor] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[Legajo] [int] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_MateriaCC_Profesor] PRIMARY KEY CLUSTERED 
(
	[IdMateriaCC_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Palabra]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Palabra](
	[IdPalabra] [int] IDENTITY(1,1) NOT NULL,
	[Palabra_Texto] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Palabra] PRIMARY KEY CLUSTERED 
(
	[IdPalabra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patente]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patente](
	[Id] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Patente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Permiso] [varchar](50) NULL,
 CONSTRAINT [PK_Permiso] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso_permiso]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_permiso](
	[Id_permiso_padre] [int] NULL,
	[Id_permiso_hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlanDeEstudio]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlanDeEstudio](
	[IdPlanDeEstudio] [int] IDENTITY(1,1) NOT NULL,
	[IdCarrera] [int] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_PlanDeEstudio_1] PRIMARY KEY CLUSTERED 
(
	[IdPlanDeEstudio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[Legajo] [int] IDENTITY(1,1) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[Edad] [int] NOT NULL,
	[Direccion] [varchar](50) NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [int] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
	[iduser] [int] NOT NULL,
 CONSTRAINT [PK_Profesor] PRIMARY KEY CLUSTERED 
(
	[Legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promedio]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promedio](
	[IdPromedio] [int] IDENTITY(1,1) NOT NULL,
	[IdMateriaCC] [int] NOT NULL,
	[LegajoAlumno] [int] NOT NULL,
	[NotaPromedio] [float] NOT NULL,
	[ChangedOn] [datetime] NULL,
	[ChangedBy] [datetime] NULL,
	[CreatedOn] [datetime] NULL,
	[CreatedBy] [int] NULL,
 CONSTRAINT [PK_Promedio] PRIMARY KEY CLUSTERED 
(
	[IdPromedio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_user]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_user](
	[iduser] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](500) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_user] PRIMARY KEY CLUSTERED 
(
	[iduser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoBitacora]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoBitacora](
	[IdTipoBitacora] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoBitacora] PRIMARY KEY CLUSTERED 
(
	[IdTipoBitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Traduccion]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Traduccion](
	[IdPalabra_Traduccion] [int] NOT NULL,
	[IdIdioma] [int] NOT NULL,
	[PalabraTraducida] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Traduccion] PRIMARY KEY CLUSTERED 
(
	[IdPalabra_Traduccion] ASC,
	[IdIdioma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioFamilia]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioFamilia](
	[IdUsuario] [int] NOT NULL,
	[IdFamilia] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioFamilia] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdFamilia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsuarioPatente]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPatente](
	[IdUsuario] [int] NOT NULL,
	[IdPatente] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioPatente] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC,
	[IdPatente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios_permisos]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios_permisos](
	[Id_usuario] [int] NOT NULL,
	[Id_permiso] [int] NOT NULL,
 CONSTRAINT [PK_Usuarios_permisos] PRIMARY KEY CLUSTERED 
(
	[Id_usuario] ASC,
	[Id_permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'aa', N'aa', N'Masculino', 1, N'aa', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [Email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Federico', N'Lopez', N'Masculino', 2, N'fed21@gmail.com', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] ON 

INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 1, 11, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 1, 12, N'Cursando', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 1, 14, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (42, 1, 33, N'Cursando', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1033, 2, 12, N'Cursando', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] OFF
GO
SET IDENTITY_INSERT [dbo].[Asistencia] ON 

INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'1', N'0', CAST(N'2019-09-17T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, N'0', N'1', CAST(N'2019-02-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (6, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, N'0', N'1', CAST(N'2019-02-02T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, N'0', N'1', CAST(N'2018-05-05T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Asistencia] OFF
GO
SET IDENTITY_INSERT [dbo].[Bitacora] ON 

INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (1, 1, 1, CAST(N'2019-10-15T11:23:57.877' AS DateTime), N'Todo ok', 12)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (2, 2, 1, CAST(N'2019-10-16T09:55:43.070' AS DateTime), N'Todo ok', 13)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (3, 1, 1, CAST(N'2019-10-16T09:56:11.257' AS DateTime), N'Todo ok', 14)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (4, 1, 1, CAST(N'2019-10-16T09:59:08.313' AS DateTime), N'Todo ok', 15)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (5, 1, 1, CAST(N'2019-10-17T09:41:04.100' AS DateTime), N'Se probó una conexion con la base', 16)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (18, 1, 1, CAST(N'2021-10-14T11:32:30.760' AS DateTime), N'Todo ok', 17)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (19, 1, 1, CAST(N'2021-10-14T12:03:08.257' AS DateTime), N'Todo ok', 18)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (20, 1, 1, CAST(N'2021-10-14T12:03:14.303' AS DateTime), N'Todo ok', 11)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (21, 1, 1, CAST(N'2021-10-14T12:03:22.590' AS DateTime), N'Todo ok', 1)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (23, 1, 1, CAST(N'2021-10-14T14:54:06.733' AS DateTime), N'Todo ok', 123)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (24, 1, 1, CAST(N'2021-10-14T15:05:04.990' AS DateTime), N'Se agrego el usuario pepe', 123)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (25, 1, 1, CAST(N'2021-10-14T21:00:33.597' AS DateTime), N'Se probó una conexion con la base', 123)
INSERT [dbo].[Bitacora] ([IdBitacora], [IdUsuario], [IdTipoBitacora], [FechaHora], [Mensaje], [dv]) VALUES (26, 1, 1, CAST(N'2021-10-18T11:29:07.307' AS DateTime), N'Se probó una conexion con la base', 123)
SET IDENTITY_INSERT [dbo].[Bitacora] OFF
GO
SET IDENTITY_INSERT [dbo].[Carrera] ON 

INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Abogacia', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Carrera] OFF
GO
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (4, 27, CAST(N'2019-06-19' AS Date), 14, 1, NULL, NULL, NULL, NULL, CAST(N'2019-06-19' AS Date), N'Noche')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (5, 20, CAST(N'2019-06-19' AS Date), 15, 1, NULL, NULL, NULL, NULL, CAST(N'2019-07-11' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (6, 26, CAST(N'2019-06-19' AS Date), 12, 1, NULL, NULL, NULL, NULL, CAST(N'2020-02-21' AS Date), N'Tarde')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (9, 32, CAST(N'2020-06-23' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2020-09-09' AS Date), N'Tarde')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (10, 13, CAST(N'2019-09-06' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (11, 40, CAST(N'2019-09-06' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (12, 49, CAST(N'2019-09-06' AS Date), 12, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
SET IDENTITY_INSERT [dbo].[Curso] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesDetMatPlanCorrPlan] ON 

INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (23, 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (24, 3, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (25, 4, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (27, 19, 20, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesDetMatPlanCorrPlan] ([IdDetallesDetMatPlanCorrPlan], [IdPlanDetalles], [IdPlanDetalles2], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (28, 22, 21, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesDetMatPlanCorrPlan] OFF
GO
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] ON 

INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, 3, 14, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, 3, 16, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 3, 15, N'Opcional', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 3, 12, N'Opcional', 4, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (5, 4, 11, N'Obligatoria', 1, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 8, 12, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 8, 14, N'Obligatoria', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 9, 11, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, 9, 12, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (18, 3, 33, N'Obligatoria', 5, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (19, 12, 14, N'Obligatoria', 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (20, 12, 16, N'Obligatoria', 2, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (21, 12, 33, N'Obligatoria', 3, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateriaCC], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (22, 12, 15, N'Obligatoria', 4, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] OFF
GO
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (1, N'Botón 1 y 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (2, N'Botón 2 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (3, N'Familia Id2 y Botón 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (4, N'Botón 7 y 9')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (5, N'Fam 3 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (6, N'Ban')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (6666, N'DescMod')
GO
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (3, 2)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 3)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 4)
GO
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 1)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 2)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 4)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (3, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 7)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 9)
GO
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (2, N'Ingles')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
GO
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] ON 

INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, N'Fisica1', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, N'Quimica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (14, N'Matematica', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (15, N'Ingles', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (16, N'Matematica2', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (29, N'Ingles3', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (31, N'Fiolosofia', NULL, NULL, NULL, NULL)
INSERT [dbo].[MateriaConCorrelativas] ([IdMateriaCC], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (33, N'Ingles2', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[MateriaConCorrelativas] OFF
GO
SET IDENTITY_INSERT [dbo].[Palabra] ON 

INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (1, N'TagLabelESP')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (2, N'TagBOTON')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (3, N'combo')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (4, N'Tagg')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (5, N'Gestion Patentes')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (6, N'Gestion Familias')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (7, N'Gestion Perfiles Usuarios')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (8, N'Secretario')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (9, N'Plan de estudio')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (10, N'Materias')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (11, N'Cursos')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (12, N'Alumnos')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (13, N'Profesor')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (14, N'Asistencias')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (15, N'Parciales')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (16, N'Recuperatorios')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (17, N'Finales')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (18, N'Seguridad')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (19, N'Usuarios')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (20, N'Perfiles')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (21, N'Bitacora')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (22, N'Salir')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (23, N'Contrasena')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (24, N'Usuario')
INSERT [dbo].[Palabra] ([IdPalabra], [Palabra_Texto]) VALUES (25, N'Backup')
SET IDENTITY_INSERT [dbo].[Palabra] OFF
GO
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (1, N'btn Usuarios')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (2, N'btn Perfiles')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (3, N'btn Bitacora')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (4, N'btn Backup')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (5, N'Botón 5')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (6, N'Botón 6')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (7, N'Botón 7')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (8, N'Botón 8')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (9, N'Botón 9')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (10, N'Botón 10')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (11, N'Botón 11')
INSERT [dbo].[Patente] ([Id], [Descripcion]) VALUES (12, N'Botón 12')
GO
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1, N'pa', N'PuedeHacerA')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (2, N'f1', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (3, N'pb', N'PuedeHacerB')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (4, N'PuedeVerForm1', N'PuedeVerFormVentas')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (2, 1)
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (2, 3)
GO
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] ON 

INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 1, N'Plan1', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 1, N'PlanMod', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, 1, N'plan 2', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, 2, N'plan3', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 1, N'PLAN4', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 1, N'PLAN551', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1, N'admin', N'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', N'a', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (2, N'b', N'3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d', N'b', N'Profesor')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1001, N'c', N'2e7d2c03a9507ae265ecf5b5356885a53393a2029d241394997265a1a25aefc6', N'c', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1002, N'c1', N'd0f631ca1ddba8db3bcfcb9e057cdc98d0379f1bee00e75a545147a27dadd982', N'asd@asd1.com', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1003, N'd', N'18ac3e7343f016890c510e93f935261169d9e3f565436429830faf0934f4f8e4', N'd', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1004, N'juan', N'ed08c290d7e22f7bb324b15cbadce35b0b348564fd2d5f95752388d86d71bcca', N'asd@asd.com', N'Profesor')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1005, N'pepe', N'7c9e7c1494b2684ab7c19d6aff737e460fa9e98d5a234da1310c97ddf5691834', N'asd@asd.com', N'Profesor')
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoBitacora] ON 

INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (1, N'Baja criticidad')
INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (2, N'Semicritico')
INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (3, N'Critico')
SET IDENTITY_INSERT [dbo].[TipoBitacora] OFF
GO
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (1, 1, N'TagLabelESP')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (1, 2, N'HomeING')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (2, 1, N'TagBOTON')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (2, 2, N'ChangeING')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (3, 1, N'combo')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (3, 2, N'comboing')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (4, 1, N'Tagg')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (4, 2, N'TaggEnIngles')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (5, 1, N'Gestion Patentes')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (5, 2, N'Patent management')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (6, 1, N'Gestion Familias')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (6, 2, N'Family management')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (7, 1, N'Gestion Perfiles Usuarios')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (7, 2, N'User Profile Management')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (8, 1, N'Secretario')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (8, 2, N'Secretary')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (9, 1, N'Plan de estudio')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (9, 2, N'
Study plan')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (10, 1, N'Materias')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (10, 2, N'Subjects')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (11, 1, N'Cursos')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (11, 2, N'Courses')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (12, 1, N'Alumnos')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (12, 2, N'Students')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (13, 1, N'Profesor')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (13, 2, N'Professor')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (14, 1, N'Asistencias')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (14, 2, N'Assists')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (15, 1, N'Parciales')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (15, 2, N'Partial')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (16, 1, N'Recuperatorios')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (16, 2, N'Recuperatory')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (17, 1, N'Finales')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (17, 2, N'Finals')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (18, 1, N'Seguridad')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (18, 2, N'Security')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (19, 1, N'Usuarios')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (19, 2, N'Users')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (20, 1, N'Perfiles')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (20, 2, N'Profiles')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (21, 1, N'Bitacora')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (21, 2, N'Binnacle')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (22, 1, N'Salir')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (22, 2, N'Exit')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (23, 1, N'Contrasena')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (23, 2, N'Password')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (24, 1, N'Usuario')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (24, 2, N'User')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (25, 1, N'Backup')
INSERT [dbo].[Traduccion] ([IdPalabra_Traduccion], [IdIdioma], [PalabraTraducida]) VALUES (25, 2, N'Backup')
GO
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (1, 1)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (1, 2)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (2, 2)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (3, 5)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (4, 5)
GO
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (2, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 12)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 7)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 10)
GO
INSERT [dbo].[Usuarios_permisos] ([Id_usuario], [Id_permiso]) VALUES (1, 2)
INSERT [dbo].[Usuarios_permisos] ([Id_usuario], [Id_permiso]) VALUES (1, 4)
GO
ALTER TABLE [dbo].[Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Alumno] CHECK CONSTRAINT [FK_Alumno_Carrera]
GO
ALTER TABLE [dbo].[Alumno_MateriaCC]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Materia_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] CHECK CONSTRAINT [FK_Alumno_Materia_Alumno]
GO
ALTER TABLE [dbo].[Alumno_MateriaCC]  WITH CHECK ADD  CONSTRAINT [FK_Alumno_Materia_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] CHECK CONSTRAINT [FK_Alumno_Materia_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_Alumno]
GO
ALTER TABLE [dbo].[Asistencia]  WITH CHECK ADD  CONSTRAINT [FK_Asistencia_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Asistencia] CHECK CONSTRAINT [FK_Asistencia_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_tbl_user] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[tbl_user] ([iduser])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_tbl_user]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_TipoBitacora] FOREIGN KEY([IdTipoBitacora])
REFERENCES [dbo].[TipoBitacora] ([IdTipoBitacora])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_TipoBitacora]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_Carrera]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Curso_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Curso_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan]  WITH CHECK ADD  CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio] FOREIGN KEY([IdPlanDetalles])
REFERENCES [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles])
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan] CHECK CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio]
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan]  WITH CHECK ADD  CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio1] FOREIGN KEY([IdPlanDetalles2])
REFERENCES [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles])
GO
ALTER TABLE [dbo].[DetallesDetMatPlanCorrPlan] CHECK CONSTRAINT [FK_DetallesDetMatPlanCorrPlan_DetallesPlanDeEstudio1]
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPlanDeEstudio_MateriaConCorrelativas1] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio] CHECK CONSTRAINT [FK_DetallesPlanDeEstudio_MateriaConCorrelativas1]
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_DetallesPlanDeEstudio_PlanDeEstudio] FOREIGN KEY([IdPlanDeEstudio])
REFERENCES [dbo].[PlanDeEstudio] ([IdPlanDeEstudio])
GO
ALTER TABLE [dbo].[DetallesPlanDeEstudio] CHECK CONSTRAINT [FK_DetallesPlanDeEstudio_PlanDeEstudio]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Alumno]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Evaluacion]  WITH CHECK ADD  CONSTRAINT [FK_Evaluacion_Profesor] FOREIGN KEY([LegajoProfesor])
REFERENCES [dbo].[Profesor] ([Legajo])
GO
ALTER TABLE [dbo].[Evaluacion] CHECK CONSTRAINT [FK_Evaluacion_Profesor]
GO
ALTER TABLE [dbo].[MateriaCC_Profesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaCC_Profesor_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[MateriaCC_Profesor] CHECK CONSTRAINT [FK_MateriaCC_Profesor_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[MateriaCC_Profesor]  WITH CHECK ADD  CONSTRAINT [FK_MateriaCC_Profesor_Profesor] FOREIGN KEY([Legajo])
REFERENCES [dbo].[Profesor] ([Legajo])
GO
ALTER TABLE [dbo].[MateriaCC_Profesor] CHECK CONSTRAINT [FK_MateriaCC_Profesor_Profesor]
GO
ALTER TABLE [dbo].[Permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_permiso_Permiso] FOREIGN KEY([Id_permiso_padre])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Permiso_permiso] CHECK CONSTRAINT [FK_Permiso_permiso_Permiso]
GO
ALTER TABLE [dbo].[Permiso_permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_permiso_Permiso1] FOREIGN KEY([Id_permiso_hijo])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Permiso_permiso] CHECK CONSTRAINT [FK_Permiso_permiso_Permiso1]
GO
ALTER TABLE [dbo].[PlanDeEstudio]  WITH CHECK ADD  CONSTRAINT [FK_PlanDeEstudio_Carrera] FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Carrera] ([IdCarrera])
GO
ALTER TABLE [dbo].[PlanDeEstudio] CHECK CONSTRAINT [FK_PlanDeEstudio_Carrera]
GO
ALTER TABLE [dbo].[Promedio]  WITH CHECK ADD  CONSTRAINT [FK_Promedio_Alumno] FOREIGN KEY([LegajoAlumno])
REFERENCES [dbo].[Alumno] ([LegajoAlumno])
GO
ALTER TABLE [dbo].[Promedio] CHECK CONSTRAINT [FK_Promedio_Alumno]
GO
ALTER TABLE [dbo].[Promedio]  WITH CHECK ADD  CONSTRAINT [FK_Promedio_MateriaConCorrelativas] FOREIGN KEY([IdMateriaCC])
REFERENCES [dbo].[MateriaConCorrelativas] ([IdMateriaCC])
GO
ALTER TABLE [dbo].[Promedio] CHECK CONSTRAINT [FK_Promedio_MateriaConCorrelativas]
GO
ALTER TABLE [dbo].[Traduccion]  WITH CHECK ADD  CONSTRAINT [FK_Traduccion_Idioma] FOREIGN KEY([IdIdioma])
REFERENCES [dbo].[Idioma] ([Id])
GO
ALTER TABLE [dbo].[Traduccion] CHECK CONSTRAINT [FK_Traduccion_Idioma]
GO
ALTER TABLE [dbo].[Usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_permisos_Permiso] FOREIGN KEY([Id_permiso])
REFERENCES [dbo].[Permiso] ([Id])
GO
ALTER TABLE [dbo].[Usuarios_permisos] CHECK CONSTRAINT [FK_Usuarios_permisos_Permiso]
GO
ALTER TABLE [dbo].[Usuarios_permisos]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_permisos_tbl_user] FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[tbl_user] ([iduser])
GO
ALTER TABLE [dbo].[Usuarios_permisos] CHECK CONSTRAINT [FK_Usuarios_permisos_tbl_user]
GO
/****** Object:  Trigger [dbo].[TG_ActualizarCupos2]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[TG_ActualizarCupos2]
   on [dbo].[Alumno_MateriaCC]
   for Insert
   as
   Update Curso set Curso.CuposMax = Curso.CuposMax-1
   from Curso inner join
   INSERTED as D on D.IdMateriaCC=Curso.IdMateriaCC
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] ENABLE TRIGGER [TG_ActualizarCupos2]
GO
/****** Object:  Trigger [dbo].[TG_ActualizarCuposAlEliminar]    Script Date: 26/10/2021 10:39:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[TG_ActualizarCuposAlEliminar]
   on [dbo].[Alumno_MateriaCC]
   for delete
   as
   Update Curso set Curso.CuposMax = Curso.CuposMax+1
   from Curso inner join
   INSERTED as D on D.IdMateriaCC=Curso.IdMateriaCC
GO
ALTER TABLE [dbo].[Alumno_MateriaCC] ENABLE TRIGGER [TG_ActualizarCuposAlEliminar]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[43] 4[23] 2[16] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Alumno"
            Begin Extent = 
               Top = 17
               Left = 7
               Bottom = 147
               Right = 177
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Alumno_MateriaCC"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 136
               Right = 433
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Asistencia"
            Begin Extent = 
               Top = 189
               Left = 240
               Bottom = 319
               Right = 410
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "MateriaConCorrelativas"
            Begin Extent = 
               Top = 6
               Left = 527
               Bottom = 136
               Right = 697
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 12
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaSumaAsistencias'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaSumaAsistencias'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VistaSumaAsistencias'
GO
USE [master]
GO
ALTER DATABASE [SIUNCA] SET  READ_WRITE 
GO
