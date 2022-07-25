namespace devincar
{
    class Program
    {

        public enum OpcoesMenu
        {
            Sair, MostrarMotosTriciclo, MostrarCarros, MostrarCamionetes, MostrarTodos, VenderVeiculo, AlterarCorOuValorDeUmVeiculo, ListarInformacoes
        }

        public static void Main(string[] args)
        {

            RelatorioVeiculos.IniciarVeiculos(); // Instancia os veículos.

            bool condicao = true; // Condição para executar o loop do programa.
            
            while (condicao)
            {
                System.Console.WriteLine("\n --- MENU --- \n\n");

                /* Opções para mostrar os veículos instanciados. */
                System.Console.WriteLine("1 - Mostrar Motos e Triciclos");
                System.Console.WriteLine("2 - Mostrar Carros");
                System.Console.WriteLine("3 - Mostrar Camionetes");
                System.Console.WriteLine("4 - Mostrar Todos \n");

                /* Opções para executar os métodos. */
                System.Console.WriteLine("5 - Vender Veículo");
                System.Console.WriteLine("6 - Alterar Informações");
                System.Console.WriteLine("7 - Listar Informações\n");

                System.Console.WriteLine("0 - Sair \n\n");

                System.Console.Write("Escolha uma opção: ");
                int opcaoDoUsuario = int.Parse(Console.ReadLine()); // Capta o que o usuário digitou e tranforma no tipo 'Int'.

                ValorDigitadoInvalido(opcaoDoUsuario); // Exception 
                
                OpcoesMenu opcaoEscolhida = (OpcoesMenu) opcaoDoUsuario; // Transforma o tipo 'Int' no tipo 'OpcoesMenu'.
                System.Console.WriteLine("\n");

                /* Switch que mostra os objetos intanciados. */
                switch (opcaoEscolhida)
                {
                    case OpcoesMenu.MostrarMotosTriciclo:
                        MotoTriciclo.SelecionarMotos(); // Mostra as motos instanciadas.
                        break;
                    case OpcoesMenu.MostrarCarros:
                        Carro.SelecionarCarros(); // Mostra os carros instanciados.
                        break;
                    case OpcoesMenu.MostrarCamionetes:
                        Camionete.SelecionarCamionetes(); // Mostra as camionetes instaciadas.
                        break;
                    case OpcoesMenu.MostrarTodos:
                        Veiculo.SelecionarMostrarTodos(); // Mostra todos os veículos instanciados.
                        break;
                    case OpcoesMenu.Sair:
                        condicao = false; // Muda a condição para 'false' e encerra o programa.
                        break;
                    default:
                        break;
                }
                
                /* Switch que executa os métodos solicitado no projeto. */
                switch (opcaoEscolhida)
                {
                    case OpcoesMenu.VenderVeiculo:
                        Veiculo.VenderVeiculo();
                        break;
                    case OpcoesMenu.AlterarCorOuValorDeUmVeiculo:
                        Veiculo.AlterarInformacoes();
                        break;
                    case OpcoesMenu.ListarInformacoes:
                        Veiculo.ListarInformacoes();
                        break;
                    default:
                        break;
                }
            }
        }

        // Exception
        private static void ValorDigitadoInvalido(int opcao)
        {
            if (opcao > 7)
            {
                throw new NumeroInvalidoException(opcao);
            }
        }
    }
}  