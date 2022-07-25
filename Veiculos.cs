

namespace devincar
{
    class Veiculo {

    public Veiculo(string _potencia, string _name, string _placa, decimal _valor, string _dataDeFabricacao, string _cpfDoComprador, string _cor) // Contructor do Veículo.
    {

        Potencia = _potencia + "cv";
        NumeroDoChassi = RelatorioVeiculos.getNewChassi();
        Name = _name;
        Placa = _placa;
        Valor = _valor;
        DataDeFabricao = _dataDeFabricacao;
        cpfDoComprador = _cpfDoComprador;
        Cor = _cor;
    }

    public string DataDeFabricao { get; set; }
    public string Potencia { get; set; }
    public string NumeroDoChassi { get; set; }
    public string Name { get; set; }
    public string Placa { get; set; }
    public decimal Valor { get; set; }
    public string cpfDoComprador { get; private set; }
    public string Cor { get; set; }

    public virtual void Mostrar(){} // Função virtual.

    public static void SelecionarMostrarTodos() // Mostra todos os veículos, até aqueles que foram vendidos.
    {
        foreach (var veiculo in RelatorioVeiculos.veiculos)
        {
            veiculo.Mostrar();
            System.Console.WriteLine("\n");
        }
    }

    /* A função abaixo é executada quando o usuário vai registrar um veiculo vendido.
       Ela serve para filtrar o veículo que o usuário quer vender. */
    private static Veiculo VeiculoSelecionado(string placaDoVeiculo)
    {
        var veiculoSelecionado = RelatorioVeiculos.veiculos.Where(pdC => pdC.Placa.StartsWith(placaDoVeiculo)).First(); // Filtra o veículo de acordo com a placa

        System.Console.WriteLine("Você selecionou o veículo:\n");
        veiculoSelecionado.Mostrar();


        return veiculoSelecionado;
    }

    /* A função abaixo capta o CPF do comprador e retorna ela. */
    private static string setCpfDoComprador()
    {
        System.Console.WriteLine("\nDigite o CPF do comprador deste veículo.\nInsira somente os números sem pontuação.");
        System.Console.Write("\nCPF do comprador: ");
        string cpfDigitado = System.Console.ReadLine();
        return cpfDigitado;
    }

    public static void VenderVeiculo() // Método 'Vender Veículo'.
    {
        // Listar os nomes dos veiculos disniveis.
        System.Console.WriteLine("Esses são os veículos disponíveis:\n");
        SelecionarMostrarTodos();

        // Usuario escolhe o veiculo através da placa.
        System.Console.Write("Digite a placa do veículo que deseja vender: ");
        string placaDoVeiculo = System.Console.ReadLine();
        string respostaDoUsuario = placaDoVeiculo.ToUpper();
        //PlacaInvalidaException(respostaDoUsuario); // Não consegui fazer essa exceção rodar.
        System.Console.WriteLine("\n");

        // Mostrar veículo selecionado.
        var veiculoEscolhido = VeiculoSelecionado(respostaDoUsuario);

        // pedir o CPF do comprador
        var cpfDigitado = setCpfDoComprador();

        // Inserir o CPF no veículo selecionado.
        veiculoEscolhido.cpfDoComprador = cpfDigitado;
        
        System.Console.WriteLine("\n ");
    }

    private enum OpcoesRelatorio // Enum de opções para o método de relatórios.
    {
        Voltar, VeiculosDisponiveis, VeiculosVendidos, VeiculosVendidosComMenorPreco, VeiculosVendidosComMaiorPreco
    }

    public static void ListarInformacoes() // Método 'Listar Informaçoes'.
    {
        System.Console.WriteLine("Qual relatório você gostaria de ver: \n");
        System.Console.WriteLine("1 - Veículos Disponíveis");
        System.Console.WriteLine("2 - Veículos Vendidos");
        System.Console.WriteLine("3 - Veículos Vendidos com Menor Preço");
        System.Console.WriteLine("4 - Veículos Vendidos com Maior Preço\n");
        System.Console.WriteLine("0 - Voltar\n");
        System.Console.Write("Digite uma opção: "); 
        int opcaoDoUsuario = int.Parse(System.Console.ReadLine());
        OpcoesRelatorio opcaoEscolhida = (OpcoesRelatorio) opcaoDoUsuario;
        System.Console.WriteLine("\n");

        switch (opcaoEscolhida) 
        {
            case OpcoesRelatorio.VeiculosDisponiveis:
                RelatorioVeiculos.VeiculosDisponiveis();
                break;
            case OpcoesRelatorio.VeiculosVendidos:
                RelatorioVeiculos.VeiculosVendidos();
                break;
            case OpcoesRelatorio.VeiculosVendidosComMenorPreco:
                RelatorioVeiculos.VeiculosVendidosComMenorPreco();
                break;
            case OpcoesRelatorio.VeiculosVendidosComMaiorPreco:
                RelatorioVeiculos.VeiculosVendidosComMaiorPreco();
                break;
            case OpcoesRelatorio.Voltar:
                break;
            default:
               break;
        }
    }

    private enum OpcoesAlterarInformacoes // Enum de opções para o método de alterações.
    {
        Voltar, Cor, Valor
    }

    public static void AlterarInformacoes() // Método 'Alterar Informações'.
    {
        System.Console.WriteLine("Você deseja alterar: \n");
        System.Console.WriteLine("1 - Cor");
        System.Console.WriteLine("2 - Valor\n");
        System.Console.WriteLine("0 - Voltar\n");
        System.Console.Write("Digite uma opção: "); 
        int opcaoDoUsuario = int.Parse(System.Console.ReadLine());
        OpcoesAlterarInformacoes opcaoEscolhida = (OpcoesAlterarInformacoes) opcaoDoUsuario;
        System.Console.WriteLine("\n");

        switch (opcaoEscolhida)
        {
            case OpcoesAlterarInformacoes.Cor:
                MudarCor();
                break;
            case OpcoesAlterarInformacoes.Valor:
                MudarValor();
                break;
            case OpcoesAlterarInformacoes.Voltar:
                break;
            default:
                break;
        }
    }

    private static string MudarCor() // Função que muda a cor do objeto.
    {
        // Mostra os veículos disponíveis
        System.Console.WriteLine("Esses são os veículos disponíveis para mudar a cor:\n");
        MotoTriciclo.SelecionarMotos();
        Carro.SelecionarCarros();

        // Usuario escolhe o veiculo através da placa.
        System.Console.Write("Digite a placa do veículo que deseja mudar a cor: ");
        string placaDoVeiculo = System.Console.ReadLine();
        string respostaDoUsuario = placaDoVeiculo.ToUpper();
        System.Console.WriteLine("\n");

        // Mostra o veículo selecionado
        var veiculoSelecionado = VeiculoSelecionado(respostaDoUsuario);

        // Solicita ao usuário a nova cor do veículo selecionado.
        System.Console.Write("Digite a cor que deseja para este veículo: ");
        string novaCor = System.Console.ReadLine();

        veiculoSelecionado.Cor = novaCor;

        return novaCor;
    }

    public static decimal MudarValor() // Função que muda o valor do objeto.
    {

        // Mostra os veículos disponíveis
        System.Console.WriteLine("Esses são os veículos disponíveis para mudar a cor:\n");
        SelecionarMostrarTodos();

        // Usuario escolhe o veiculo através da placa.
        System.Console.Write("Digite a placa do veículo que deseja mudar o valor: ");
        string placaDoVeiculo = System.Console.ReadLine();
        string respostaDoUsuario = placaDoVeiculo.ToUpper();
        System.Console.WriteLine("\n");

        // Mostra o veículo selecionado
        var veiculoSelecionado = VeiculoSelecionado(respostaDoUsuario);

        // Solicita ao usuário o novo valor do veículo selecionado.
        System.Console.WriteLine("Digite o novo valor que deseja para este veículo: ");
        decimal novoValor = decimal.Parse(System.Console.ReadLine());

        veiculoSelecionado.Valor = novoValor;

        return novoValor;
    }

    // Exceptions
    private static void PlacaInvalidaException(string _placa) // Essa é a exceção que não consegui fazer rodar.
    {

        var obj = RelatorioVeiculos.veiculos.Where(placa => placa.Placa.Any());

        
        if(_placa != obj.ToString())
        {
            //throw new PlacaInvalidaException(_placa);
        }
    }
}
}