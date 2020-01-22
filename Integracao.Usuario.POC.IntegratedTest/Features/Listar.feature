Funcionalidade: ListarReservas
	Teste integrado para listar reservas de um hóspede

Contexto: Listar Reservas de um Hospede
	Dado que o host é 'http://localhost:51503/'
	E o método http é 'GET'
	E que o endpoint é 'Reservas'

Cenario: Listar as reservas ativas e inativas de um hospede
	Dado o hospedeId seja 1
	E o inativo seja true
	Quando executar a requisição
	Entao A resposta será 200

Cenario: Listar apenas as reservas ativas de um hospede
	Dado o hospedeId seja 1
	E o inativo seja false
	Quando executar a requisição
	Entao A resposta será 200

Cenario: Quando nao encontrar hospede com o hospedeId solicitado
	Dado o hospedeId seja 142231
	E o inativo seja false
	Quando executar a requisição
	Entao A resposta será 400

Cenario: Quando nao encontrar reservas do hospede informado
	Dado o hospedeId seja 142231
	E o inativo seja false
	Quando executar a requisição
	Entao A resposta será 404