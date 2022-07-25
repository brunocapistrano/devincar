namespace devincar
{
    public class NumeroInvalidoException : Exception
    {
        private const string Mensagem = "Opção {0} escolhida não existe.";

        public NumeroInvalidoException(int opcaoDoUsuario) : base(
            message:string.Format(Mensagem, opcaoDoUsuario)
        )
        {
            
        }
    }
}