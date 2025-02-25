Console.WriteLine("Bem vindo!");
Console.WriteLine("Wellington");
Console.WriteLine("Boa noite");
Console.Clear();

string firstName = "Wellington";
string lastName = "Ferreira";
string surname = "Araujo";


Console.WriteLine("Digite sua idade: ");
int age = int.Parse(Console.ReadLine());
//teste git
Console.WriteLine($"Nome Completo: {firstName} {surname} {lastName} \nIdade é: {age}");

Console.ReadKey();