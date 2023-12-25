// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//rakendus palub kasutajal sisestada tema vanuse
//    kui kasutaja vanus on vaiksem kui, siis konsoolis kuvatakse:
//    "You are too young to use Instagram"
//    muul juhul
//    "Welcome to Insagram"

Console.WriteLine("Enter your age:");

int userAge = Int32.Parse(Console.ReadLine());

if (userAge >= 13)
{ 
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");

}