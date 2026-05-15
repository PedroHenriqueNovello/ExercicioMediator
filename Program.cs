using System;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace MediatorChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator salaGeral = new SalaDeChat();

            var isabelle = new UsuarioChat (salaGeral, "Isabelle");
            var pedro = new UsuarioChat (salaGeral, "Pedro");
            var joao = new UsuarioChat (salaGeral, "João");

            salaGeral.AdicionarUsuario(isabelle);
            salaGeral.AdicionarUsuario(pedro);
            salaGeral.AdicionarUsuario(joao);

            isabelle.Enviar("Bom dia, grupo!");
            pedro.Enviar("Bom dia, Isabelle! Tudo bem?");
            joao.Enviar("Bom dia, pessoal! Como estão?");
        }
    }
}