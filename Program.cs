using DesafioPOO.Models;

// Implementado!
Console.WriteLine("Smartphone Nokia:");
Smartphone noki = new Nokia(numero: "123456", modelo: "Modelo 1", iMEI: "11111111", memoria: 64);
noki.Ligar();
noki.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "654321", modelo: "Modelo 2", iMEI: "222222", memoria: 120);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");