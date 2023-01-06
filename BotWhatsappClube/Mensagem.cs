using System;
using System.Text;

namespace BotWhatsappClube
{
    class Mensagem
    {
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Olá, Somos o Clube da Sorte estou passando aqui pra te informar do nosso novo Sorteio!");
            sb.AppendLine("*RESULTADO DIA 17/12/2022, COM APENAS UMA COTA DE 0,03 CENTAVOS VOCE PODE PARTICIPAR DO SORTEIO CONCORRENDO A R$ 1.500,00 E O RSULTADO SAIRA PELA LOTERIA FEDERAL*");
            sb.AppendLine("Segue a gente no Instagram pra ficar por dentro de todas as novidades. *E VEJA TODOS OS NOSSOS GANHADORES*");

            return sb.ToString();
        }
    }
}
