// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");

//rakendus palub kasutajal valida tema sugu (m/f)
//    rakendus palub kasutajal sisestada tema perekonnanime
//    lähtudes kasutaja valikust, rakeskus tervitab kasutajat järgmiselt:
//    "Welcome, Mr. [kasutaja perekonnanimi]/Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine ($"Welcome, Mr.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
