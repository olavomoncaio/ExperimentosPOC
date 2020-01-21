use Hotelaria

if not exists (select * from sysobjects where name='Reserva' and xtype='U')
    create table Reserva (
		ReservaId int not null identity(1,1) primary key,
        ClienteId int not null FOREIGN KEY REFERENCES Cliente(ClienteId),
		DataEntrada datetime,
		DataSaida datetime,
		Ativa bit not null,
    )
go


