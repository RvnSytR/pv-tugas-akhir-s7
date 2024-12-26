CREATE DATABASE db_latihan;
GO

USE db_latihan;
GO

CREATE TABLE history (
    id_history INT IDENTITY(1,1) PRIMARY KEY,
    waktu_hitung DATETIME DEFAULT GETDATE(),
    tgl_lahir DATE NOT NULL,
    zodiac NVARCHAR(50) NOT NULL
);
GO