using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone iphone = new Iphone(numero: "123456", modelo: "Iphone1", imei: "11111", memoria: 256);

Console.WriteLine();
Console.WriteLine("Smartphone Iphone:");
iphone.Ligar();
iphone.InstalarAplicativo("Teste");

Smartphone nokia = new Nokia(numero: "654321", modelo: "Nokia1", imei: "222222", memoria: 32);

Console.WriteLine();
Console.WriteLine($"Smartphone Nokia:");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine();