use Hotelaria

if not exists (select * from sysobjects where name='Cliente' and xtype='U')
    create table Cliente (
		ClienteId int not null identity(1,1) primary key,
        UsuarioId int not null FOREIGN KEY REFERENCES Usuario(UsuarioId),
		Documento varchar(11) not null,
		Nome varchar(55) not null,
		Sobrenome varchar(55),
		DataNascimento date not null,
		Logradouro varchar(255) not null,
		Numero varchar(12) not null,
		Complemento varchar(55),
		Cidade varchar(55) not null,
		Estado char(2) not null,
		Telefone varchar(24),
		Celular varchar(24),
		DataDeCadastro datetime
    )
go
