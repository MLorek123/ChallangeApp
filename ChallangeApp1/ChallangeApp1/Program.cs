

string Name = "Marcin";
char Sex = 'M';
var Age = 26;

if (Sex == 'K' && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Name == "Ewa" && Age == 30)
{
    Console.WriteLine("Ewa,lat 30");
}
else if (Age < 18 && Sex == 'M')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
