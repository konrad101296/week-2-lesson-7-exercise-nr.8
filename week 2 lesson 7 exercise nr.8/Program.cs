Console.WriteLine("Podaj wynik z matematyki:");
int maths = int.Parse(Console.ReadLine());
Console.WriteLine("podaj wynik z fizyki:");
int physics = int.Parse(Console.ReadLine());
Console.WriteLine("podaj wynik z chemi:");
int chemistry = int.Parse(Console.ReadLine());

int inTotal = maths + physics + chemistry;

if (maths > 70 && physics > 55 && chemistry > 45 && inTotal > 180)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else if (maths + physics > 150 || maths + chemistry > 150)
{
    Console.WriteLine("Kandydat dopuszczony do rekrutacji");
}
else
{
    Console.WriteLine("Kandydat nie dopuszczony do rekrutacji");
}
