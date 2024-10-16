// See https://aka.ms/new-console-template for more information
Console.WriteLine("Toplamını ve çarpımını istediğiniz 4 sayı giriniz");
Console.WriteLine("1. sayı: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayı: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("3. sayı: ");
int number3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("4. sayı: ");
int number4 = Convert.ToInt32(Console.ReadLine());
int result1 = number1 + number2 + number3 + number4;
int result2 = number1 * number2 * number3 * number4;
Console.WriteLine("Toplamları:" + result1);
Console.WriteLine("Çarpımları:" + result2);
Console.ReadKey();