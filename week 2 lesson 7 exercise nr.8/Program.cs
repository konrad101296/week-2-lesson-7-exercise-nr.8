Console.WriteLine("Podaj wynik z matematyki:");
int Matma = int.Parse(Console.ReadLine());
Console.WriteLine("podaj wynik z fizyki:");
int Fizyka = int.Parse(Console.ReadLine());
Console.WriteLine("podaj wynik z chemi:");
int Chemia = int.Parse(Console.ReadLine());

int Razem = Matma + Fizyka + Chemia;

if (Matma > 70 && Fizyka > 55 && Chemia > 45 && Razem > 180)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else if (Matma + Fizyka > 150 || Matma + Chemia > 150)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}