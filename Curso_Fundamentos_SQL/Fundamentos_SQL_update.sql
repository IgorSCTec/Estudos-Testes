BEGIN TRANSACTION
    UPDATE
        [Categoria]
    SET
        [Nome] = 'Backend'
    WHERE
        [Id] = 1
-- ROLLBACK