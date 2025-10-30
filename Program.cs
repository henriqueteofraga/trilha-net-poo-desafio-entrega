using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "9876543", modelo: "Iphone 5", imei: "77777", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Discord");

Console.WriteLine("\n");

Console.WriteLine("Smarthopne Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Tijolão", imei: "111111", memoria: 8);
nokia.Ligar();
nokia.InstalarAplicativo("Jogo da Cobrinha");