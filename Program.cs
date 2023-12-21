using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia nokiaPhone = new Nokia("856458789", "Nokia Model", "12948", 51);

            nokiaPhone.Ligar();
            nokiaPhone.ReceberLigacao();
            nokiaPhone.InstalarAplicativo("Facebook");

            Console.WriteLine("\n");

            
            Iphone iphone = new Iphone("987657781", "iPhone Model", "50301", 198);

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Minecraft");

            Console.ReadLine();
        }
    }
}
