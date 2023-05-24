string name = "Rysio";
char sex = 'M'; //M = Male
                //F = Female
int age = 33;

if (sex == 'F' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && sex == 'M')
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("To tylko Rysio");
}