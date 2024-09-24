using DesafioPOO.Models;

// Feito: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "11912345678", modelo: "Tijolo", imei: "1234567890", memoria: 256);
Smartphone iphone = new Iphone(numero: "11998765432", modelo: "a4", imei: "098765432", memoria: 2);

nokia.InstalarAplicativo("Spotifly");
nokia.Ligar();
nokia.ReceberLigacao();


iphone.InstalarAplicativo("Safaris");
iphone.Ligar();
iphone.ReceberLigacao();
