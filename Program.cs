using DesafioPOO.Models;

Iphone iphone = new Iphone(numero: "132", modelo: "iphone 11", imei: "111111", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine("---------------");

Nokia nokia = new Nokia(numero: "231", modelo: "adamantium", imei: "2222222", memoria: 100);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("jogo da cobrinha");