namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
            public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
    }
    public override void InstalarAplicativo(string nome)
    {
      Console.WriteLine($"Instalando o aplicativo {nome} no Iphone");
    }
    }
}