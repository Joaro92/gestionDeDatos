DECLARE @sql NVARCHAR(MAX) = '';

SELECT @sql += N'
ALTER TABLE ' + QUOTENAME(OBJECT_SCHEMA_NAME(parent_object_id))
    + '.' + QUOTENAME(OBJECT_NAME(parent_object_id)) + 
    ' DROP CONSTRAINT ' + QUOTENAME(name) + ';'
FROM sys.foreign_keys;

SET @sql += N'
';

SELECT @sql += N'
DROP TABLE [' + TABLE_SCHEMA + '].['+ TABLE_NAME + ']' + ';'
FROM   INFORMATION_SCHEMA.TABLES
WHERE  TABLE_TYPE = 'BASE TABLE' and TABLE_SCHEMA = 'LOPEZ_Y_CIA';

SET @sql += N'

DROP SCHEMA [LOPEZ_Y_CIA];'

PRINT @sql;
--EXEC sp_executesql @sql;