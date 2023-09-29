namespace ListManager;

public class Endereco
{

    // Propriedades que representam os dados de endereço
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public BancoDeDados BancoDeDados { get; set; } // Propriedade que mantém uma referência ao BancoDeDados

    // Construtor da classe
    public void CarregarDados()
    {
        BancoDeDados = new BancoDeDados();

        BancoDeDados.Enderecos = new List<Endereco> // INICIALIZAÇÃO DE OBJETOS DA CLASSE LIST<ENDERECOS>
        {
            new Endereco { Id = 1, Logradouro = "Rua da Imprensa", Numero = "790", Bairro = "Monte Castelo", Cidade = "Campo Grande", Estado = "MS" },
            new Endereco { Id = 2, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "39", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP" },
            new Endereco { Id = 3, Logradouro = "Rua Tenente-Coronel Cardoso", Numero = "2803", Bairro = "Centro", Cidade = "Campos dos Goytacazes", Estado = "RJ" },
            new Endereco { Id = 4, Logradouro = "Avenida Governador José Malcher", Numero = "660", Bairro = "Nazaré", Cidade = "Belém", Estado = "PA" },
            new Endereco { Id = 5, Logradouro = "Rua Cristiano Olsen", Numero = "16", Bairro = "Jardim Sumaré", Cidade = "Araçatuba", Estado = "SP" },
            new Endereco { Id = 6, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "396", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP" },
            new Endereco { Id = 7, Logradouro = "Avenida São João", Numero = "13", Bairro = "Vila Joana", Cidade = "Jundiaí", Estado = "SP" },
            new Endereco { Id = 8, Logradouro = "Travessa Antônio Ferreira", Numero = "667", Bairro = "Igrejinha", Cidade = "Capanema", Estado = "PA" },
            new Endereco { Id = 9, Logradouro = "Avenida Tocantins", Numero = "7580B", Bairro = "Vila Jardim Rio Claro", Cidade = "Jataí", Estado = "GO" },
            new Endereco { Id = 10, Logradouro = "Avenida Esbertalina Barbosa Damiani", Numero = "6H", Bairro = "Centro", Cidade = "Sobral", Estado = "CE" }
        };
    }

    // Método ToString para representação de texto do objeto
    public override string ToString()
    {
        return $"ID: {Id}, Logradouro: {Logradouro}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}";
    }

    // Método Adicionar para adicionar um endereço à lista de endereços
    public bool Adicionar(Endereco enderecos)
    {
        if (enderecos != null)
        {
            BancoDeDados.Enderecos.Add(enderecos);
            Console.WriteLine("Endereço adicionado com sucesso!");
            return true; // endereço adicionado com sucesso
        }
        else
        {
            Console.WriteLine("Endereço adicionado com sucesso!");
            return false; // Falha ao adicionar endereço
        }
    }

    // Método Listar para obter a lista de endereços
    public List<Endereco> Listar(Endereco enderecos)
    {
        return BancoDeDados.Enderecos;
    }

    // Método Consultar para buscar um endereço por ID
    public Endereco Consultar(int id)
    {
        return BancoDeDados.Enderecos.Where(enderecos => enderecos.Id == id).FirstOrDefault();
    }

    // Método Atualizar para atualizar um endereço existente
    public bool Atualizar(Endereco enderecos)
    {
        // Procura o endereço pelo ID
        Endereco novoEndereco = BancoDeDados.Enderecos.Where(novoEndereco => novoEndereco.Id == enderecos.Id).FirstOrDefault();
        // Atualiza as propriedades dos endereços existentes
        enderecos.Logradouro = novoEndereco.Logradouro;
        enderecos.Numero = novoEndereco.Numero;
        enderecos.Bairro = novoEndereco.Bairro;
        enderecos.Cidade = novoEndereco.Cidade;
        enderecos.Estado = novoEndereco.Estado;

        Console.WriteLine("Endereço atualizado com sucesso!");
        return true; // Endereço atualizado com sucesso
    }

    // Método Remover para remover um endereço por ID
    public bool Remover(int id)
    {
        // Procura o endereço pelo ID
        Endereco endereco = BancoDeDados.Enderecos.FirstOrDefault(enderecos => enderecos.Id == id);

        BancoDeDados.Enderecos.Remove(endereco);
        Console.WriteLine("Endereço removido com sucesso!");

        return true; // Endereço removido com sucesso

    }
}
