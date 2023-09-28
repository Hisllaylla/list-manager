var clientes = new Cliente { Id = 3, Nome = "Artur Espinoza Sepúlveda", Documento = "183.584.224-07", Profissao = "Médico Veterinário", EstadoCivil = "Solteiro" };

clientes.CarregarDados();

clientes.Adicionar(clientes);
clientes.Listar(clientes);

clientes.Consultar(clientes.Id);
clientes.Atualizar(clientes);
clientes.Remover(clientes.Id);

var enderecos = new Endereco { Id = 10, Logradouro = "Avenida Esbertalina Barbosa Damiani", Numero = "6H", Bairro = "Centro", Cidade = "Sobral", Estado = "CE" };

enderecos.CarregarDados();

enderecos.Adicionar(enderecos);
enderecos.Listar(enderecos);
enderecos.Consultar(enderecos.Id);
enderecos.Atualizar(enderecos);
enderecos.Remover(enderecos.Id);

