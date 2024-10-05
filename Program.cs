using DesafioPOO.Models;

Iphone iphone = new(numero: "9999-9999", modelo: "XI", imei: "123", memoria: 100);
Nokia nokia = new(numero: "9999-9991", modelo: "N96", imei: "456", memoria: 10);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("RadarBot");

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake Game");
