using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Telefone Iphone");
Smartphone iphone = new Iphone(numero: "98745-6123", modelo: "15 Pro", imei: "1234567898745632", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();

Console.WriteLine("Telefone Nokia");
Smartphone nokia = new Nokia(numero: "96385-2147", modelo: "C21", imei: "3269857412365489", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Google Translator");
iphone.ReceberLigacao();