using System;
using System.Runtime.CompilerServices;

namespace MediatorChatApp
{
    //implementação concreta do Usuario
    public class UsuarioChat : Usuario
    {
        public UsuarioChat (IChatMediator mediador, string nome) : base (mediador, nome)
        {
            
        }

        public override void Enviar (string mensagem)
        {
            Console.WriteLine($"\n{Nome} diz: {mensagem}");
            _mediador.EnviarMensagem(mensagem, this);
        }

        public override void Receber(string mensagem)
        {
            Console.WriteLine($"[{Nome} recebeu]: {mensagem}");
        }
    }
}