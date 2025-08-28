using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone


public class Program
{
    public static void Main(string[] args)
    {
         Iphone iphone = new Iphone ("123456789", "iPhone 13", "IMEI123456", 128);
         Nokia nokia = new Nokia("987654321", "Nokia 3310", "IMEI987654", 32);
   
        while (true)
        {
         Console.WriteLine("Escolha o smartphone para teste:");
         Console.WriteLine("1 - Iphone");   
         Console.WriteLine("2 - Nokia");
         Console.WriteLine("3 - Sair");

            switch (Console.ReadLine())
            {
                case "1":
                    iphone.Ligar();
                    Console.WriteLine("Iphone iniciando");
                    iphone.ReceberLigacao();
                    Console.WriteLine("Iphone recebendo ligação");
                    iphone.InstalarAplicativo("WhatsApp");
                    Console.WriteLine("Instalando WhatsApp no Iphone");
                    break;
                case "2":
                    nokia.Ligar();
                    Console.WriteLine("Nokia iniciando");
                    nokia.ReceberLigacao();
                    Console.WriteLine("Nokia recebendo ligação");
                    nokia.InstalarAplicativo("Telegram");
                    Console.WriteLine("Instalando Telegram no Nokia");
                    break;
                case "3":
                    Console.WriteLine("Saindo...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    return;
            }
           
        }
    }
}

