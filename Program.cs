using DesafioPOO.Models;

Console.WriteLine("NOKIA >");
Smartphone nokia = new Nokia(numero: "123123", modelo: "Modelo XYZ", imei: "111111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");
nokia.ReceberLigacao();

Console.WriteLine("\n\n");

Console.WriteLine("IPHONE >");
Smartphone iphone = new Iphone(numero: "321321", modelo: "Modelo 123", imei: "2222222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Subway surfers");
iphone.ReceberLigacao();