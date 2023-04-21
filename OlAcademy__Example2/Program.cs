
/*დავალება 2: შეყვანილი რიცხვის ორობით ფორმატში გადაყვანა*/

Console.Write("-----------------------------------------------------\n");
Console.Write("-----------------------------------------------------\n");
Console.Write("-----------------------------------------------------\n");
Console.Write("Sheiyvanet mnishvneloba :))\n");

string? input = Console.ReadLine();

try
{
    if (input != null)
    {
        Console.WriteLine($"Sheyvanili mnishvneloba --> {input}");

        int conInput = Convert.ToInt32(input);



        Console.WriteLine($"Orobit formatshi --> {Convert.ToString(conInput, 2)}");
    }
    else
    {
        Console.WriteLine("Mnishvleoba ar shegiyvania !!! ");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
