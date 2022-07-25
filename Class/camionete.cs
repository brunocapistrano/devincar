namespace devincar
{
    class Camionete : Veiculo
    {
        public Camionete(string _potencia, string _name, string _placa, decimal _valor, string _dataDeFabricacao, string _cpfDoComprador, string _cor, int _totalDePortas, decimal _capacidadeDeCarregamento, string _combustivel) : base(_potencia, _name, _placa, _valor, _dataDeFabricacao, _cpfDoComprador, _cor)
        {
            TotalDePortas = _totalDePortas;
            CapacidadeDeCarregamento = _capacidadeDeCarregamento;
            Combustivel = _combustivel;
        }

        public int TotalDePortas { get; set; }
        public decimal CapacidadeDeCarregamento { get; set; }
        public string Combustivel { get; set; }

        public override void Mostrar()
        {       
            System.Console.WriteLine($"Nome: {Name}");     
            System.Console.WriteLine($"Placa do veículo: {Placa}");
            System.Console.WriteLine($"Total de Portas: {TotalDePortas}");
            System.Console.WriteLine($"Potência: {Potencia}");    
            System.Console.WriteLine($"Capacidade de Carregamento: {CapacidadeDeCarregamento}kg"); 
            System.Console.WriteLine($"Valor: R$ {Valor} reais");    

        }

        public static void SelecionarCamionetes()
        {
            System.Console.WriteLine("Você digitou '3'.");
            System.Console.WriteLine("Lista de camionetes:\n");
            foreach (var veiculo in RelatorioVeiculos.veiculos) 
            {
                if (veiculo.GetType()==typeof(Camionete))
                {
                    veiculo.Mostrar();
                    System.Console.WriteLine("\n");
                }
            }
        }
    }
}