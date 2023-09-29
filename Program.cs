var cliente1 = new Cliente { Id = 3, Nome = "Artur Espinoza Sepúlveda", Documento = "183.584.224-07", Profissao = "Médico Veterinário", EstadoCivil = "Solteiro" };

cliente1.CarregarDados();

cliente1.Adicionar(cliente1);
cliente1.Listar(cliente1);

cliente1.Consultar(cliente1.Id);
cliente1.Atualizar(cliente1);
cliente1.Remover(cliente1.Id);

var endereco1 = new Endereco { Id = 10, Logradouro = "Avenida Esbertalina Barbosa Damiani", Numero = "6H", Bairro = "Centro", Cidade = "Sobral", Estado = "CE" };

endereco1.CarregarDados();

endereco1.Adicionar(endereco1);
endereco1.Listar(endereco1);
endereco1.Consultar(endereco1.Id);
endereco1.Atualizar(endereco1);
endereco1.Remover(endereco1.Id);

