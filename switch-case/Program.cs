// See https://aka.ms/new-console-template for more information
int month = DateTime.Now.Month;
switch (month)
{
    case 1:
    case 2:
    case 11:
    case 12:
    System.Console.WriteLine("Mevsim Kış! Dikkatli olun :)");
    break;
    case 3:
    case 4:
    case 5:
    System.Console.WriteLine("İlkbahardasınız");
    break;
    case 6:
    case 7:
    case 8:
    System.Console.WriteLine("Yazdasınız, keyfini çıkarın!");
    break;
    case 9:
    case 10:
    System.Console.WriteLine("Sonbahardasınız, kahve tonları üzerinize çok yakışabilir.");
      break;
    default:
    System.Console.WriteLine("Böyle bir mevsim yok");
    break;
}
    Console.ReadLine();
