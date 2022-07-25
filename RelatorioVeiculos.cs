namespace devincar 
{
    class RelatorioVeiculos
    {

        public static List<Veiculo> veiculos = new List<Veiculo>();
        public static void IniciarVeiculos()
        {
            veiculos.Add(new MotoTriciclo("152","BMW K 1200 s", "LXZ8621", 36679, "12/04/2000", "", "Azul", 2 ));
            veiculos.Add(new MotoTriciclo("203","Kawasaki Ninja Zx 10", "MBK2191", 115990, "12/04/2004", "", "Verde", 2 ));

            veiculos.Add(new Carro("118","C4 Cactus", "MHR1368", 96490, "12/09/2004", "10523254342", "Branco", 4, "Flex" ));
            veiculos.Add(new Carro("116","Onix", "LYO0655", 63430, "12/04/2004", "", "Azul", 4, "Flex" ));
            veiculos.Add(new Carro("340","BMW X6", "MGP9235", 691950, "12/04/2004", "", "Preto", 4, "Gasolina" ));

            veiculos.Add(new Camionete("170","Fiat Toro", "LZS5346", 137990, "12/04/2004", "02512354312", "Roxa", 4, 650, "Gasolina" ));
            veiculos.Add(new Camionete("163","Toyota Hilux", "MAR1373", 216990, "12/04/2004", "", "Roxa", 4, 1010, "Diesel" ));
        }

        public static string getNewChassi() // Cria um número de Chassi e adiciona.
        {
            Random numAleatorio = new Random();

            int valorChassi = numAleatorio.Next(0,1000000000);

            string chassi = valorChassi.ToString();

            return chassi;
        }

        public static void VeiculosVendidos() // Mostra os veículos com CPF.
        {

            var vendidos = veiculos.Where(veiculos => veiculos.cpfDoComprador.Any());
            

            foreach (var vendido in vendidos)
            {       
                System.Console.WriteLine("\n");
                System.Console.WriteLine(vendido.Name);
                System.Console.WriteLine(vendido.Placa);
                System.Console.WriteLine(vendido.Potencia);
                System.Console.WriteLine(vendido.NumeroDoChassi);
                System.Console.WriteLine(vendido.cpfDoComprador);
            }
        }

        public static void VeiculosDisponiveis() // Mostra os veículos sem CPF, ou seja, que não foram vendidos.
        {
            var disponiveis = veiculos.Where(veiculo => String.IsNullOrEmpty(veiculo.cpfDoComprador));

            foreach (var disponivel in disponiveis)
            {       
                System.Console.WriteLine("\n");
                System.Console.WriteLine(disponivel.Name);
                System.Console.WriteLine(disponivel.Placa);
                System.Console.WriteLine(disponivel.Potencia);
                System.Console.WriteLine(disponivel.NumeroDoChassi);
                System.Console.WriteLine(disponivel.cpfDoComprador);
            }
            
        }

        public static void VeiculosVendidosComMaiorPreco() // Mostra o valor do veículo vendido com maior preço entre todos que foram vendidos.
        {
            var vendidos = veiculos.Where(veiculos => veiculos.cpfDoComprador.Any()).Max(vendido => vendido.Valor);
            
            System.Console.WriteLine($"O carro com o maior valor vendido foi de: R$ {vendidos},00 reais.\n");

        }

        public static void VeiculosVendidosComMenorPreco() // Mostra o valor do veículo vendido com menor preço entre todos que foram vendidos.
        {
            var vendidos = veiculos.Where(veiculos => veiculos.cpfDoComprador.Any()).Min(vendido => vendido.Valor);
            
            System.Console.WriteLine($"O carro com menor valor vendido foi de: R$ {vendidos},00 reais.\n");

        }
    }   
}