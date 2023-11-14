using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero : "1234565", modelo:"modelo1",imei:"1111111111", memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero : "1234565", modelo:"modelo1",imei:"1111111111", memoria: 65);
nokia.Ligar();
nokia.InstalarAplicativo("telegram");











