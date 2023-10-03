namespace ListManager;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public BancoDeDados BancoDeDados { get; set; } // Propriedade que mantém uma referência ao BancoDeDados

    // Construtor da classe
    public void CarregarDados()
    {
        BancoDeDados = new BancoDeDados();

        BancoDeDados.Clientes = new List<Cliente> // INICIALIZAÇÃO DE OBJETOS DA CLASSE LIST<CLIENTES>
        {
            new Cliente { Id = 1, Nome = "Sofia Romero D'ávila Sobrinho", Documento = "525.623.578-84", Profissao = "Professora", EstadoCivil = "Viúva" },
            new Cliente { Id = 7, Nome = "Tessália Beltrão Uchoa", Documento = "679.804.895-19", Profissao = "Servidora Pública", EstadoCivil = "Separada" },
            new Cliente { Id = 3, Nome = "Artur Espinoza Sepúlveda", Documento = "183.584.224-07", Profissao = "Médico Veterinário", EstadoCivil = "Solteiro" },
            new Cliente { Id = 4, Nome = "Arthur de Souza Delgado Neto", Documento = "391.699.507-33", Profissao = "Cameraman", EstadoCivil = "Casado" },
            new Cliente { Id = 5, Nome = "Poliana Hosana Lira Sobrinho", Documento = "898.993.104-50", Profissao = "Comerciante", EstadoCivil = "Casada" },
            new Cliente { Id = 6, Nome = "Sueli Balestero Neto", Documento = "340.922.834-90", Profissao = "Árbitro", EstadoCivil = "Separada" },
            new Cliente { Id = 7, Nome = "Aparecida Ferraz Maldonado", Documento = "554.917.713-76", Profissao = "Boleira", EstadoCivil = "Divorciada" },
            new Cliente { Id = 8, Nome = "Renan Valdez Sobrinho", Documento = "536.277.646-09", Profissao = "Motorista de Aplicativo", EstadoCivil = "Solteiro" },
            new Cliente { Id = 9, Nome = "Jerônimo Rezende Soto", Documento = "536.055.714-17", Profissao = "Açougueiro", EstadoCivil = "Viúvo" },
            new Cliente { Id = 7, Nome = "Pedro Carlos D'ávila Filho", Documento = "648.457.300-06", Profissao = "Cientista da Computação", EstadoCivil = "Casado" }
        };
    }

    public override string ToString() // personalização do retorno
    {
        return $"ID: {Id}, Nome: {Nome}, Documento: {Documento}, Profissão: {Profissao}, Estado Civil: {EstadoCivil}";
    }

    public bool Adicionar(Cliente clientes)
    {
        if (clientes != null)
        {
            BancoDeDados.Clientes.Add(clientes);
            Console.WriteLine("Cliente adicionado com sucesso!");
            return true; // Cliente adicionado com sucesso
        }
        else
        {
            Console.WriteLine("Falha ao adicionar cliente.");
            return false; // Falha ao adicionar cliente
        }

    }

    public List<Cliente> Listar(Cliente clientes)
    {
        return BancoDeDados.Clientes;
    }

    public Cliente Consultar(int id)
    {
        return BancoDeDados.Clientes.FirstOrDefault(x => x.Id == id);
    }

    public bool Atualizar(Cliente clientes)
    {
        // Procura o cliente pelo ID
        Cliente novoCliente = BancoDeDados.Clientes.FirstOrDefault(x => x.Id == clientes.Id);

        // Atualiza as informação do cliente com novas
        clientes.Nome = novoCliente.Nome;
        clientes.Documento = novoCliente.Documento;
        clientes.Profissao = novoCliente.Profissao;
        clientes.EstadoCivil = novoCliente.EstadoCivil;

        Console.WriteLine("Cliente atualizado com sucesso!"); // mensagem de sucesso da operação
        return true;
    }

    public bool Remover(int id)
    {
        // Procura o cliente pelo ID pelo First
        Cliente removerCliente = BancoDeDados.Clientes.FirstOrDefault(x => x.Id == id);

        BancoDeDados.Clientes.Remove(removerCliente); // remover

        Console.WriteLine("Cliente removido com sucesso!"); // mensagem de sucesso da operação
        return true;
    }

}
