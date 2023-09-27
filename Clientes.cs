namespace ListManager;

public class Clientes
{
    public Clientes()
    {
        BancoDeDados = new BancoDeDados();
    }
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Documento { get; set; }
    public string Profissao { get; set; }
    public string EstadoCivil { get; set; }
    public BancoDeDados BancoDeDados { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Documento: {Documento}, Profissão: {Profissao}, Estado Civil: {EstadoCivil}";
    }

    public bool Adicionar(Clientes clientes)
    {
        if (clientes != null)
        {
            BancoDeDados.Clientes.Add(clientes);
            return true; // Cliente adicionado com sucesso
        }

        return false; // Falha ao adicionar cliente
    }

    public List<Clientes> Listar()
    {
        return BancoDeDados.Clientes;
    }

    public Clientes Consultar(int id)
    {
        return BancoDeDados.Clientes.FirstOrDefault(cliente => cliente.Id == id);
    }
    public bool Atualizar(Clientes clientes)
    {
        if (clientes != null)
        {
            // Procura o cliente pelo ID
            Clientes cliente = BancoDeDados.Clientes.FirstOrDefault(clientes => clientes.Id == clientes.Id);

            if (clientes != null)
            {
                // Atualiza as propriedades do cliente
                clientes.Nome = clientes.Nome;
                clientes.Documento = clientes.Documento;
                clientes.Profissao = clientes.Profissao;
                clientes.EstadoCivil = clientes.EstadoCivil;

                return true; // Cliente atualizado com sucesso
            }
        }

        return false; // Falha ao atualizar o cliente
    }

    public bool Remover(int id)
    {
        // Procura o cliente pelo ID
        Clientes clientes = BancoDeDados.Clientes.FirstOrDefault(clientes => clientes.Id == id);

        if (clientes != null)
        {
            BancoDeDados.Clientes.Remove(clientes);
            return true; // Cliente removido com sucesso
        }

        return false; // Falha ao remover o cliente (ID não encontrado)
    }

}
