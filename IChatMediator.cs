namespace MediatorChatApp
{
    public interface IChatMediator
    {
        void EnviaMensagem (string mensagem, Usuario remetente);
        void AdicionarUsuario (Usuario usuario);
    }
}