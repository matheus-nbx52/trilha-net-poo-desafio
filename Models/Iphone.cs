using System;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Construtor da classe Iphone, chamando o construtor da classe base (Smartphone)
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Apple...");
            // Mensagem simulada de instalação do aplicativo para o iPhone
        }
    }
}
