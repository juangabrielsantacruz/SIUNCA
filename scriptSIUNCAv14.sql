USE [SIUNCA]
GO
SET IDENTITY_INSERT [dbo].[Materia] ON 

INSERT [dbo].[Materia] ([IdMateria], [Nombre]) VALUES (1, N'Matematicas')
INSERT [dbo].[Materia] ([IdMateria], [Nombre]) VALUES (2, N'Ingles')
INSERT [dbo].[Materia] ([IdMateria], [Nombre]) VALUES (3, N'Fisica')
SET IDENTITY_INSERT [dbo].[Materia] OFF
SET IDENTITY_INSERT [dbo].[Carrera] ON 

INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'Sistemas', NULL, NULL, NULL, NULL)
INSERT [dbo].[Carrera] ([IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Abogacia', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Carrera] OFF
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] ON 

INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, 1, N'Plan1', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, 1, N'PlanMod', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, 1, N'plan 2', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, 2, N'plan3', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (9, 1, N'PLAN4', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (12, 1, N'PLAN551', NULL, NULL, NULL, NULL)
INSERT [dbo].[PlanDeEstudio] ([IdPlanDeEstudio], [IdCarrera], [Nombre], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (19, 1, N'plan9090', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[PlanDeEstudio] OFF
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] ON 

INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateria], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (24, 19, 1, NULL, 1, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[DetallesPlanDeEstudio] ([IdPlanDetalles], [IdPlanDeEstudio], [IdMateria], [Obligatoriedad], [NumeroMateria], [Año], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (25, 19, 2, NULL, 2, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[DetallesPlanDeEstudio] OFF
SET IDENTITY_INSERT [dbo].[Alumno] ON 

INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'aa', N'aa', N'Masculino', 1, N'aa', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno] ([LegajoAlumno], [Nombre], [Apellido], [Sexo], [IdCarrera], [email], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'Federico', N'Lopez', N'Masculino', 2, N'fed21@gmail.com', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno] OFF
SET IDENTITY_INSERT [dbo].[tbl_user] ON 

INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1, N'admin', N'ca978112ca1bbdcafac231b39a23dc4da786eff8147c4e72b9807785afee48bb', N'a', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (2, N'b', N'3e23e8160039594a33894f6564e1b1348bbd7a0088d42c4acb73eeaed59c009d', N'b', N'Profesor')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1001, N'c', N'2e7d2c03a9507ae265ecf5b5356885a53393a2029d241394997265a1a25aefc6', N'c', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1002, N'c1', N'd0f631ca1ddba8db3bcfcb9e057cdc98d0379f1bee00e75a545147a27dadd982', N'asd@asd1.com', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1003, N'd', N'18ac3e7343f016890c510e93f935261169d9e3f565436429830faf0934f4f8e4', N'd', N'Administrador')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1004, N'juan', N'ed08c290d7e22f7bb324b15cbadce35b0b348564fd2d5f95752388d86d71bcca', N'asd@asd.com', N'Profesor')
INSERT [dbo].[tbl_user] ([iduser], [username], [password], [email], [rol]) VALUES (1005, N'pepe', N'7c9e7c1494b2684ab7c19d6aff737e460fa9e98d5a234da1310c97ddf5691834', N'asd@asd.com', N'Profesor')
SET IDENTITY_INSERT [dbo].[tbl_user] OFF
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
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] ON 

INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (10, 1, 11, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (11, 1, 12, N'Cursando', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (13, 1, 14, N'Aprobado', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (42, 1, 33, N'Cursando', NULL, NULL, NULL, NULL)
INSERT [dbo].[Alumno_MateriaCC] ([IdAlumno_Materia], [LegajoAlumno], [IdMateriaCC], [Estado], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1033, 2, 12, N'Cursando', NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Alumno_MateriaCC] OFF
SET IDENTITY_INSERT [dbo].[Asistencia] ON 

INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (1, N'1', N'0', CAST(N'2019-09-17T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (2, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (3, N'0', N'1', CAST(N'2019-02-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (4, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 12, 2, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (6, N'1', N'0', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (7, N'0', N'1', CAST(N'2019-02-02T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
INSERT [dbo].[Asistencia] ([IdAsistencia], [Ausente], [Presente], [Fecha], [IdMateriaCC], [LegajoAlumno], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy]) VALUES (8, N'0', N'1', CAST(N'2018-05-05T00:00:00.000' AS DateTime), 11, 1, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Asistencia] OFF
SET IDENTITY_INSERT [dbo].[Curso] ON 

INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (4, 27, CAST(N'2019-06-19' AS Date), 14, 1, NULL, NULL, NULL, NULL, CAST(N'2019-06-19' AS Date), N'Noche')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (5, 20, CAST(N'2019-06-19' AS Date), 15, 1, NULL, NULL, NULL, NULL, CAST(N'2019-07-11' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (6, 26, CAST(N'2019-06-19' AS Date), 12, 1, NULL, NULL, NULL, NULL, CAST(N'2020-02-21' AS Date), N'Tarde')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (9, 32, CAST(N'2020-06-23' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2020-09-09' AS Date), N'Tarde')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (10, 13, CAST(N'2019-09-06' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (11, 40, CAST(N'2019-09-06' AS Date), 33, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
INSERT [dbo].[Curso] ([IdCurso], [CuposMax], [FechaInicio], [IdMateriaCC], [IdCarrera], [ChangedOn], [ChangedBy], [CreatedOn], [CreatedBy], [FechaFin], [Turno]) VALUES (12, 49, CAST(N'2019-09-06' AS Date), 12, 1, NULL, NULL, NULL, NULL, CAST(N'2019-09-07' AS Date), N'Mañana')
SET IDENTITY_INSERT [dbo].[Curso] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (1, N'Español')
INSERT [dbo].[Idioma] ([Id], [Nombre]) VALUES (2, N'Ingles')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
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
SET IDENTITY_INSERT [dbo].[Permiso] ON 

INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (1, N'pa', N'PuedeHacerA')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (2, N'f1', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (3, N'pb', N'PuedeHacerB')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (4, N'PuedeVerForm1', N'PuedeVerFormVentas')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (5, N'Ano2', NULL)
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (6, N'Matematica3', N'PuedeHacerA')
INSERT [dbo].[Permiso] ([Id], [Nombre], [Permiso]) VALUES (7, N'Matematica4', N'PuedeHacerA')
SET IDENTITY_INSERT [dbo].[Permiso] OFF
INSERT [dbo].[Usuarios_permisos] ([Id_usuario], [Id_permiso]) VALUES (1, 2)
INSERT [dbo].[Usuarios_permisos] ([Id_usuario], [Id_permiso]) VALUES (1, 4)
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (2, 1)
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (2, 3)
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (5, 6)
INSERT [dbo].[Permiso_permiso] ([Id_permiso_padre], [Id_permiso_hijo]) VALUES (5, 7)
SET IDENTITY_INSERT [dbo].[TipoBitacora] ON 

INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (1, N'Baja criticidad')
INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (2, N'Semicritico')
INSERT [dbo].[TipoBitacora] ([IdTipoBitacora], [Descripcion]) VALUES (3, N'Critico')
SET IDENTITY_INSERT [dbo].[TipoBitacora] OFF
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
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (1, N'Botón 1 y 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (2, N'Botón 2 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (3, N'Familia Id2 y Botón 3')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (4, N'Botón 7 y 9')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (5, N'Fam 3 y 4')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (6, N'Ban')
INSERT [dbo].[Familia] ([Id], [Descripcion]) VALUES (6666, N'DescMod')
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (3, 2)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 3)
INSERT [dbo].[FamiliaFamilia] ([IdFamilia], [IdFamiliaHijo]) VALUES (5, 4)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 1)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (1, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 2)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (2, 4)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (3, 3)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 7)
INSERT [dbo].[FamiliaPatente] ([IdFamilia], [IdPatente]) VALUES (4, 9)
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
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (1, 1)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (1, 2)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (2, 2)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (3, 5)
INSERT [dbo].[UsuarioFamilia] ([IdUsuario], [IdFamilia]) VALUES (4, 5)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (2, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 1)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (3, 12)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 7)
INSERT [dbo].[UsuarioPatente] ([IdUsuario], [IdPatente]) VALUES (5, 10)
