namespace devincar
{
    class Carro : Veiculo
    {

        public Carro(string _potencia, string _name, string _placa, decimal _valor, string _dataDeFabricacao, string _cpfDoComprador, string _cor, int _totalDePortas, string _combustivel) : base( _potencia,  _name,  _placa,  _valor, _dataDeFabricacao,  _cpfDoComprador, _cor ) 
        {
            TotalDePortas = _totalDePortas;
            Combustivel = _combustivel;
        }

        public int TotalDePortas { get; set; }
        public string Combustivel { get; set; }
        
        public override void Mostrar()
        {
            System.Console.WriteLine($"Nome: {Name}");     
            System.Console.WriteLine($"Placa do veículo: {Placa}");
            System.Console.WriteLine($"Total de Portas: {TotalDePortas}");
            System.Console.WriteLine($"Potência: {Potencia}");    
            System.Console.WriteLine($"Valor: R$ {Valor} reais");   
        }
        
        public static void SelecionarCarros()
        {
            System.Console.WriteLine("Você digitou '2'.");
            System.Console.WriteLine("Lista de carros:\n");
            foreach (var veiculo in RelatorioVeiculos.veiculos) 
            {
                if (veiculo.GetType()==typeof(Carro))
                {
                    veiculo.Mostrar();
                    System.Console.WriteLine("\n");
                }
            }
        }
    }
}