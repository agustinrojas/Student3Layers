CREATE PROCEDURE [dbo].[selectonAlumnos]
        @UUID uniqueidentifier = NULL, 
        @Nombre NVARCHAR(15)  = NULL, 
        @Apellido NVARCHAR(50)  = NULL,
        @Dni NVARCHAR(25)  = NULL,  
        @DateRegistry NVARCHAR(20)  = NULL,
		@DateBorn NVARCHAR(20)  = NULL,  
        @Edad int = NULL
AS 
BEGIN
    SET NOCOUNT ON

    SELECT * FROM dbo.Alumnos

END

GO