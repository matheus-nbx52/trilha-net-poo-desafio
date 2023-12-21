namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria) {
            // Construtor da classe Nokia, chamando o construtor da classe base (Smartphone)
        }

        public override void InstalarAplicativo(string nomeApp) {
            Console.WriteLine($"Instalando {nomeApp} na loja de aplicativos da Nokia...");
            // Lógica para instalar um aplicativo específico do Nokia
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}