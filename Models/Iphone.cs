namespace DesafioPOO.Models
{
    // IMPLEMENTADO
    public class Iphone : Smartphone
    {

        public Iphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando um aplicativo {nomeApp} no iphone");
        }
        // IMPLEMENTADO
    }
}