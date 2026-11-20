int[] t = new int[7];
int max = 0, min = 0;
double med = 0;

for (int i = 0; i < 7; i++)
{
    Console.WriteLine("inserisci la temperatura del " + (i + 1) + "o giorno della settimana");
    t[i] = int.Parse(Console.ReadLine());
    if (i == 0)
    {
        max = t[i];
        min = t[i];
    }
    else if (t[i] < min)
    {
        min = t[i];
    }
    else if (t[i] > max)
    {
        max = t[i];
    }
    med += t[i];
}
Console.WriteLine("la temperatura massima nella settimana e' " + max);
Console.WriteLine("la temperatura minima nella settimana e' " + min);
Console.WriteLine("la temperatura media della settimana e' " + (med / 7));