EXEC sp_configure filestream_access_level, 2  
RECONFIGURE  
USE master
GO
IF NOT EXISTS (
   SELECT name
   FROM sys.databases
   WHERE name = N'StudentDB'
)
-- Create the database with the default data
-- filegroup, filstream filegroup and a log file. Specify the
-- growth increment and the max size for the
-- primary data file.
CREATE DATABASE StudentDB
ON PRIMARY
  ( NAME='StudentDB_Primary',
    FILENAME=
       'c:\DataSqlStudent3Layers\StudentDB_Prm.mdf',
    SIZE=4MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
FILEGROUP StudentDB_FG1
  ( NAME = 'StudentDB_FG1_Dat1',
    FILENAME =
       'c:\DataSqlStudent3Layers\StudentDB_FG1_1.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB),
  ( NAME = 'StudentDB_FG1_Dat2',
    FILENAME =
       'c:\DataSqlStudent3Layers\StudentDB_FG1_2.ndf',
    SIZE = 1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB)
LOG ON
  ( NAME='StundetDB_log',
    FILENAME =
       'c:\DataSqlStudent3Layers\StudentDB.ldf',
    SIZE=1MB,
    MAXSIZE=10MB,
    FILEGROWTH=1MB);
GO


