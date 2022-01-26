bool islemDevam = true;
int  sayac=1;

while(islemDevam)
{

Console.WriteLine(sayac+ ". işleminiz");
System.Console.WriteLine("----------------------------------");
Console.WriteLine("1. Sayıyı giriniz: ");
int s1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. Sayıyı giriniz: ");
int s2 = Convert.ToInt32(Console.ReadLine());
if(s1 < s2){
System.Console.WriteLine(s1+" sayısından "+ s2+" sayısı büyüktür");
}
else if(s1 > s2){
System.Console.WriteLine(s2+" sayısından "+ s1+" sayısı büyüktür");
}
else{
    System.Console.WriteLine(s1 +" sayısı "+ s2 +"sayısına eşittir.");
}
sayac++;
System.Console.WriteLine("İşleme devam etmek istiyor musunuz ?");

string? cevap = Console.ReadLine();
if(cevap!.ToLower() =="hayır")
      Environment.Exit(0);
 }
// See https://aka.ms/new-console-template for more information
Console.ReadLine();