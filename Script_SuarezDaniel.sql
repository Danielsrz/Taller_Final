USE [Taller]
GO
/****** Object:  StoredProcedure [dbo].[UpdateUsuario]    Script Date: 13/05/2020 12:24:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[UpdateUsuario]
	@usuario nvarchar(50),
	@nlogin int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE usuarios SET ultimo_login = CURRENT_TIMESTAMP WHERE usuario = @usuario;
	UPDATE usuarios SET n_logins = @nlogin WHERE usuario = @usuario;
END