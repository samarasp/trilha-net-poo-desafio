namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO!
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO!
        public Iphone(string numero, string Modelo, string IMEI, int Memoria)
        : base(numero, Modelo, IMEI, Memoria)
        {
        }
        public override void InstalarAplicativo(string Telegram)
        {
            Console.WriteLine($"Instalando o aplicativo {Telegram} no Iphone");
        }
    }
}