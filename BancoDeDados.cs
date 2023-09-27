namespace ListManager;

public class BancoDeDados
{
    public List<Clientes> Clientes { get; set; }
    public List<Enderecos> Enderecos { get; set; }


    //  C O N S T R U T O R
    public BancoDeDados()
    {
            Enderecos = new List<Enderecos>
        {
            new Enderecos { Id = 1, Logradouro = "Rua da Imprensa", Numero = "790", Bairro = "Monte Castelo", Cidade = "Campo Grande", Estado = "MS" },
            new Enderecos { Id = 2, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "39", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP" },
            new Enderecos { Id = 3, Logradouro = "Rua Tenente-Coronel Cardoso", Numero = "2803", Bairro = "Centro", Cidade = "Campos dos Goytacazes", Estado = "RJ" },
            new Enderecos { Id = 4, Logradouro = "Avenida Governador José Malcher", Numero = "660", Bairro = "Nazaré", Cidade = "Belém", Estado = "PA" },
            new Enderecos { Id = 5, Logradouro = "Rua Cristiano Olsen", Numero = "16", Bairro = "Jardim Sumaré", Cidade = "Araçatuba", Estado = "SP" },
            new Enderecos { Id = 6, Logradouro = "Rua Maria Luísa do Val Penteado", Numero = "396", Bairro = "Cidade São Mateus", Cidade = "São Paulo", Estado = "SP" },
            new Enderecos { Id = 7, Logradouro = "Avenida São João", Numero = "13", Bairro = "Vila Joana", Cidade = "Jundiaí", Estado = "SP" },
            new Enderecos { Id = 8, Logradouro = "Travessa Antônio Ferreira", Numero = "667", Bairro = "Igrejinha", Cidade = "Capanema", Estado = "PA" },
            new Enderecos { Id = 9, Logradouro = "Avenida Tocantins", Numero = "7580B", Bairro = "Vila Jardim Rio Claro", Cidade = "Jataí", Estado = "GO" },
            new Enderecos { Id = 10, Logradouro = "Avenida Esbertalina Barbosa Damiani", Numero = "6H", Bairro = "Centro", Cidade = "Sobral", Estado = "CE" }
        };

            Clientes = new List<Clientes>
        {
            new Clientes { Id = 1, Nome = "Sofia Romero D'ávila Sobrinho", Documento = "525.623.578-84", Profissao = "Professora", EstadoCivil = "Viúva" },
            new Clientes { Id = 2, Nome = "Tessália Beltrão Uchoa", Documento = "679.804.895-19", Profissao = "Servidora Pública", EstadoCivil = "Separada" },
            new Clientes { Id = 3, Nome = "Artur Espinoza Sepúlveda", Documento = "183.584.224-07", Profissao = "Médico Veterinário", EstadoCivil = "Solteiro" },
            new Clientes { Id = 4, Nome = "Arthur de Souza Delgado Neto", Documento = "391.699.507-33", Profissao = "Cameraman", EstadoCivil = "Casado" },
            new Clientes { Id = 5, Nome = "Poliana Hosana Lira Sobrinho", Documento = "898.993.104-50", Profissao = "Comerciante", EstadoCivil = "Casada" },
            new Clientes { Id = 6, Nome = "Sueli Balestero Neto", Documento = "340.922.834-90", Profissao = "Árbitro", EstadoCivil = "Separada" },
            new Clientes { Id = 7, Nome = "Aparecida Ferraz Maldonado", Documento = "554.917.713-76", Profissao = "Boleira", EstadoCivil = "Divorciada" },
            new Clientes { Id = 8, Nome = "Renan Valdez Sobrinho", Documento = "536.277.646-09", Profissao = "Motorista de Aplicativo", EstadoCivil = "Solteiro" },
            new Clientes { Id = 9, Nome = "Jerônimo Rezende Soto", Documento = "536.055.714-17", Profissao = "Açougueiro", EstadoCivil = "Viúvo" },
            new Clientes { Id = 10, Nome = "Pedro Carlos D'ávila Filho", Documento = "648.457.300-06", Profissao = "Cientista da Computação", EstadoCivil = "Casado" }
        };
    }
}