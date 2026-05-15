using System;
using System.Collections.Generic;

namespace MediatorChatApp
{
    //Mediador concreto
    public class SalaDeChat : IChatMediator
    {
        private readonly List<Usuario> _usuarios = new List<Usuario>();

        public void AdicionarUsuario(Usuario usuario)
        {
            _usuarios.Add(usuario);
            Console.WriteLine($"[SISTEMA] {usuario.Nome} entrou na sala.");
        }

        public void EnviarMensagem (string mensagem, Usuario remetente)
        {
            foreach (var usuario in _usuarios)
            {
                //não enviar a mensagem para quem a escreveu
                if (usuario != remetente)
                {
                    usuario.Receber(mensagem);
                }
            }
        }
    }
}