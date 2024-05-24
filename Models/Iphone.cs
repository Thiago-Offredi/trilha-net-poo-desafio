namespace DesafioPOO.Models
{
    // Assumindo que a classe "Smartphone" está definida em outro lugar no projeto
    public class Iphone : Smartphone
    {
        // Construtor da classe Iphone que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método "InstalarAplicativo" da classe base (Smartphone)
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}
