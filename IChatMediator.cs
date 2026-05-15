namespace MediatorChatApp
{
    public interface IChatMediator
    {
        void EnviarMensagem (string mensagem, Usuario remetente);
        void AdicionarUsuario (Usuario usuario);
    }
}