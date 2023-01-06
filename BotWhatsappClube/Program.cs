using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BotWhatsappClube
{
    class Program
    {
        public static void Main(string[] args)
        {
            Mensagem mensagem = new Mensagem();

            string url = "https://web.whatsapp.com";
            string urlInstagram = "https://www.instagram.com/clubee_da_sorte/";

            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            Console.Clear();
            Console.WriteLine("Quando entrar em sua conta do WhatsApp clique na tecla 'Enter'...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Digite quantos numero o robo vai entrar em contato: ");
            Console.Write("Quantidades de numeros: ");
            int nmrDeContatos = int.Parse(Console.ReadLine());
            Console.WriteLine("Iniciando....");
            Thread.Sleep(5000);
            Console.Clear();

            Lista lista = new Lista();

            Console.WriteLine("Agora digite o numero dos contatos, como por exemplo '82992424567' o numero ja vem com numero do país ex: '55'.:");
            for (int i = 1; i <= nmrDeContatos; i++)
            {
                Console.Write($"Contato {i}: ");
                string nmrDeContato = Console.ReadLine();
                lista.AdicionarAlgoLista(nmrDeContato);
            }

            foreach (string lista1 in lista.NumeroDeContatos)
            {
                string urlZapContato = "https://wa.me/";

                urlZapContato += "55" + lista1;
                driver.Navigate().GoToUrl(urlZapContato);
                try
                {
                    Thread.Sleep(4000);
                    var selIniciarConversar = driver.FindElement(By.XPath("//*[@id=\"action-button\"]/span"));
                    selIniciarConversar.Click();
                    Thread.Sleep(3000);

                    var clickIniciar = driver.FindElement(By.XPath("//*[@id=\"fallback_block\"]/div/div/h4[2]/a/span"));
                    clickIniciar.Click();
                    Thread.Sleep(10000);

                    var menssagemDig = driver.FindElement(By.XPath("//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]"));
                    menssagemDig.SendKeys(mensagem.ToString());
                    Thread.Sleep(1000);

                    /* menssagemDig = driver.FindElement(By.XPath("//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]"));
                     menssagemDig.Click();
                     Thread.Sleep(1000);*/

                    menssagemDig = driver.FindElement(By.XPath("//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]"));
                    menssagemDig.SendKeys(urlInstagram);
                    Thread.Sleep(3000);

                    var cliqueEnviarMen = driver.FindElement(By.XPath("//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[2]/button/span"));
                    cliqueEnviarMen.Click();
                    Thread.Sleep(1000);

                    /*var selecionarConversa = driver.FindElement(By.XPath("//*[@id=\"pane-side\"]/div[2]/div/div/div[10]/div/div/div/div[2]/div[1]/div[1]/span"));
                    selecionarConversa.Click();
                    Thread.Sleep(1500);

                    var botaoDeOpConversas = driver.FindElement(By.XPath("//*[@id=\"pane-side\"]/div[2]/div/div/div[10]/div/div/div/div[2]/div[2]/div[2]"));
                    botaoDeOpConversas.Click();
                    Thread.Sleep(1000);

                    var arquivarConversa = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/span[4]/div/ul/div/li[1]"));
                    arquivarConversa.Click();
                    Thread.Sleep(500);

                    driver.Navigate().Refresh();
                    Thread.Sleep(10000);*/
                }
                catch (Exception e)
                {
                    Console.WriteLine("Numero inexistente ou digitado incorretamente");
                }
            }


        }
    }
}