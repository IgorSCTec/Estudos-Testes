DECLARE @teste NVARCHAR(80)
SET @teste = '%Gustavo%';
SELECT [Nome], [Phone], [Email] FROM [Cliente] WHERE [Nome] LIKE @teste
