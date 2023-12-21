using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Nokia
            Nokia nokiaPhone = new Nokia("856458789", "Nokia Model", "12948", 51);

            // Testando métodos do Nokia
            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("WhatsApp");

            // Criando uma instância de Iphone
            Iphone iphone = new Iphone("987657781", "iPhone Model", "50301", 198);

            // Testando métodos do iPhone
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");

            Console.ReadLine();
        }
    }
}
