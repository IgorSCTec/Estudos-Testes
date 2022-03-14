SELECT TOP 100
    [Id], [Nome], [CategoriaId]
FROM
    [Curso]
--WHERE
--    [CategoriaId] = 1
Order BY
    [Nome]


SELECT TOP 100
    MAX([Id])
FROM
    [Curso]

SELECT TOP 100
    MIN([Id])
FROM
    [Curso]

SELECT TOP 100
    COUNT([Id])
FROM
    [CursO]

SELECT TOP 100
    AVG([Id])
FROM
    [Curso]

SELECT TOP 100
    SUM([Id])
FROM
    [Curso]

