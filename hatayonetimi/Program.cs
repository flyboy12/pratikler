// See https://aka.ms/new-console-template for more information
try{
System.Console.WriteLine(   "Bir sayı giriniz: ");
int? sayi = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(  "Girilmiş Sayı: "+sayi!);
}
catch(Exception ex){
System.Console.WriteLine(  "Hata: "+ex.Message.ToString());
}
finally{
    System.Console.WriteLine("İşlem Tamamlandı.");
}
try
{
    int a = int.Parse(Console.ReadLine());
    
}
catch ( ArgumentNullException ex)
{
    System.Console.WriteLine( "Null değer Girdiniz");
    System.Console.WriteLine(ex);
}
catch(FormatException ex)
{
System.Console.WriteLine("Formatı uygun değil");
System.Console.WriteLine(ex);
}
catch(OverflowException ex){
    System.Console.WriteLine("Aşırı değer yüklemesi yaptınız");
    System.Console.WriteLine(ex.ToString());
}
Console.ReadLine();