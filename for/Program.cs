// See https://aka.ms/new-console-template for more information
System.Console.WriteLine("Lütfen bir sayı giriniz");
int? sayac = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayac; i++)
{
    if(i%2==1)
    {
     System.Console.WriteLine(i);
    }
}
int tekToplam =0, ciftToplam=0;
for (int i = 1; i <= sayac; i++)
{
    if(i%2==1)
    {
      tekToplam +=i;
    }
    else
      ciftToplam+=i;
}

System.Console.WriteLine("Tek Toplam : "+ tekToplam +"\nÇift Toplam : "+ciftToplam);
//contineue sadece o işleme uğramamasını devam etmesini tembihler
// break ise döngüyü durdurur
Console.ReadLine();