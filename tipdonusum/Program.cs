//Bilinçsiz Dönüşüm (implicit conversion)
//Düşük kapasiteli bir değikeni yüksek kapasiteli değişkene atamak
System.Console.WriteLine("***********Bilinçsiz Dönüşüm***********");
byte a = 5;
sbyte b = 12;
int c= a+b;
string d = "asdasd";
object e= d+c;
System.Console.WriteLine("c: "+c);
System.Console.WriteLine("e: "+e);
//Bilinçli Dönüşüm(Explicit Conversion)
//Kendi kendine yapamayacağı dönüşümler olarak düşünülmeli
System.Console.WriteLine("-------Bilinçli Dönüşüm------");
int x = 4;
byte y = (byte) x ;
System.Console.WriteLine("y: "+y);
float w = 18.3f;
y = (byte) w;
System.Console.WriteLine("y : "+w);//veri kaybı olur

