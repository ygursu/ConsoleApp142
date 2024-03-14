double sayi1 = 0, sayi2 = 0;
string islem;
Console.Write("Birinci sayıyı giriniz:");
sayi1 = Convert.ToDouble(Console.ReadLine());
Console.Write("İkinci sayıyı giriniz:");
sayi2 = Convert.ToDouble(Console.ReadLine());

OkuOperator:
Console.Write("Operatörlerinden(+,-,*,/) birini giriniz:");
islem = Console.ReadLine();

switch (islem)
{
    case "+":
        Console.WriteLine("Toplam= {0}", (sayi1 + sayi2).ToString());
        break;
    case "-":
        Console.WriteLine("Fark= {0}", (sayi1 - sayi2).ToString());
        break;
    case "*":
        Console.WriteLine("Çarpım= {0}", (sayi1 * sayi2).ToString());
        break;
    case "/":
        Console.WriteLine("Bölüm= {0}", (sayi1 / sayi2).ToString());
        break;
    default:
        Console.WriteLine("Yanlış bir operatör girdiniz. Tekrar deneyin.");
        goto OkuOperator;
}

Console.ReadKey();