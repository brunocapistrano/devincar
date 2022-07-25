namespace devincar
{
    public class PlacaInvalidaException : Exception
    {
        private const string Mensagem = "Você digitou {0}, essa placa é invalida. Tente novamente.";

        public PlacaInvalidaException(int respostaDoUsuario) : base(
            message:string.Format(Mensagem, respostaDoUsuario)
        )
        {
            
        }
    }
}