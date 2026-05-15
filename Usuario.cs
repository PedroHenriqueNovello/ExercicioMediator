namespace MediatorChatApp
{
    public abstract class Usuario
    {
        protected readonly IChatMediator _mediador;
        public string Nome {get; private set;}

        protected Usuario (IChatMediator mediador, string nome)
        {
            _mediador = mediador;
            Nome = nome;
        }

        public abstract void Enviar(string mensagem);
        public abstract void Receber (string mensagem);

    }
}