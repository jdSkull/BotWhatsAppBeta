using System;

namespace BotWhatsappClube
{
    class Lista
    {
        public List<string> NumeroDeContatos { get; set; } = new List<string>();

        public void AdicionarAlgoLista(string message)
        {
            NumeroDeContatos.Add(message);
        }

    }
}
