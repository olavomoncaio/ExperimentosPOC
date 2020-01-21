use Hotelaria

if not exists (select * from sysobjects where name='Usuario' and xtype='U')
    create table Usuario (
		UsuarioId int not null identity(1,1) primary key,
        Usuario varchar(255) not null,
		Senha varchar(30) not null,
    )
go

