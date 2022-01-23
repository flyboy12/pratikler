// See https://aka.ms/new-console-template for more information
DateTime dt = DateTime.Now ;
Console.WriteLine("Günlerden  "+dt.ToString("dddd"));
string s1 = "20";
int s2 = 21;
Console.WriteLine("String işlem : "+s1+s2);
Console.WriteLine("Matematiksel işlem : "+(int.Parse(s1)+s2));
Console.WriteLine("Şu an saat :" + dt.ToString("hh:mm"));
bool bitti = 10>8;
Console.WriteLine("İşlem Bitmiştir : (ing) "+bitti);
Console.ReadLine();