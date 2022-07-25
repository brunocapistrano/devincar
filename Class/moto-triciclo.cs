namespace devincar
{
    class MotoTriciclo : Veiculo
    {

        public MotoTriciclo(string _potencia, string _name, string _placa, decimal _valor, string _dataDeFabricacao, string _cpfDoComprador, string _cor, int _totalDeRodas) : base( _potencia,  _name,  _placa,  _valor,  _dataDeFabricacao, _cpfDoComprador, _cor)
        {
            TotalDeRodas = _totalDeRodas;
        }

        public int TotalDeRodas { get; set; }

        
        public override void Mostrar()
        {
            System.Console.WriteLine($"Nome: {Name}");     
            System.Console.WriteLine($"Placa do veículo: {Placa}");
            System.Console.WriteLine($"Total de Rodas: {TotalDeRodas}");
            System.Console.WriteLine($"Potência: {Potencia}");  
            System.Console.WriteLine($"Valor: R$ {Valor} reais");     
        }

        public static void SelecionarMotos()
        {
            System.Console.WriteLine("Você digitou '1'.");
            System.Console.WriteLine("Lista de motos:\n");
            foreach (var veiculo in RelatorioVeiculos.veiculos)
            {
                if (veiculo.GetType()==typeof(MotoTriciclo))
                {
                    veiculo.Mostrar();
                    System.Console.WriteLine("\n");
                }
            }
        }

    }
}