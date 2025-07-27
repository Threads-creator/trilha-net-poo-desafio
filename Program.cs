using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia(numero: "12345668", modelo: "xyz", imei: "11122233", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Calculadora");
nokia.ExigirInformacoes();

Console.WriteLine();

var iphone = new Iphone(numero: "35445689", modelo: "zzz", imei: "55555777", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Calculadora");
iphone.ExigirInformacoes();