namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO!
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        //IMPLEMENTADO! 
        public Nokia(string numero, string Modelo, string IMEI, int Memoria)

        : base(numero, Modelo, IMEI, Memoria)
        {
        }
        public override void InstalarAplicativo(string WhatsApp)
        {
            Console.WriteLine($"Instalando o aplicativo {WhatsApp} no Nokia");
        }
    }
}