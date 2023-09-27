namespace ListManager;

public class Enderecos
{
    public Enderecos()
    {
        BancoDeDados = new BancoDeDados();
    }

    public int Id { get; set; }
    public string Logradouro { get; set; }
    public string Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public BancoDeDados BancoDeDados { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Logradouro: {Logradouro}, Número: {Numero}, Bairro: {Bairro}, Cidade: {Cidade}, Estado: {Estado}";
    }

    public bool Adicionar(Enderecos enderecos)
    {
        if (enderecos != null)
        {
            BancoDeDados.Enderecos.Add(enderecos);
            return true; // endereço adicionado com sucesso
        }

        return false; // Falha ao adicionar endereço
    }

    public List<Enderecos> Listar()
    {
        return BancoDeDados.Enderecos;
    }
    public Enderecos Consultar(int id)
    {
        return BancoDeDados.Enderecos.FirstOrDefault(enderecos => enderecos.Id == id);
    }
    public bool Atualizar(Enderecos enderecos)
    {
        if (enderecos != null)
        {
            // Procura o endereço pelo ID
            Enderecos endereco = BancoDeDados.Enderecos.FirstOrDefault(enderecos => enderecos.Id == enderecos.Id);

            if (enderecos != null)
            {
                // Atualiza as propriedades dos endereços existentes
                enderecos.Logradouro = enderecos.Logradouro;
                enderecos.Numero = enderecos.Numero;
                enderecos.Bairro = enderecos.Bairro;
                enderecos.Cidade = enderecos.Cidade;
                enderecos.Estado = enderecos.Estado;

                return true; // Endereço atualizado com sucesso
            }
        }

        return false; // Falha ao atualizar o endereço
    }

    public bool Remover(int id)
    {
        // Procura o endereço pelo ID
        Enderecos enderecos = BancoDeDados.Enderecos.FirstOrDefault(enderecos => enderecos.Id == id);

        if (enderecos != null)
        {
            BancoDeDados.Enderecos.Remove(enderecos);
            return true; // Endereço removido com sucesso
        }

        return false; // Falha ao remover o endereço (ID não encontrado)
    }

}