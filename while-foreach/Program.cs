// See https://aka.ms/new-console-template for more information
char karakter= 'a';
while (karakter <='z')
{
    System.Console.Write( karakter);
    karakter++;
    System.Console.Write(" ");
}
System.Console.WriteLine();
string[] arabalar = {"bmw","mercedes","ford"};
foreach(var item in arabalar){
System.Console.WriteLine("Araba Markası: "+item);
}
Console.ReadLine();