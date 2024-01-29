using System;
using System.ComponentModel.Design;
bool runProgram = true;
while (runProgram)
{
    string[] Names = { "Rod Mastria", "Elijah Reid", "Logan Reeves", "Dominic Nutaitis", "Ethan Thomas", "Justin Jones" };
    string[] Foods = { "Anything Italian", "Spaghetti", "Wings", "Sushi", "Jambalaya", "Baja Blast" };
    string[] Homes = { "Detroit/SaoPaulo", "Whitehall", "Mansfield", "New Baltimore", "Rolla", "Grand rapids" };
    int userinput = 0;
    bool restart1 = true;
    while (restart1)
    {
        Console.WriteLine($"Please pick a number 1 - {Names.Length} ?");
        userinput = int.Parse(Console.ReadLine().ToLower().Trim()) - 1;

        if (userinput < 1 || userinput > 6)
        {
            Console.WriteLine("Invalid input! Please try again.");
            restart1 = true;
        }
        else
        {
            Console.WriteLine(Names[userinput]);
            break;
        }
    }
    
    bool restart2 = true;
    while (restart2)
    {
        Console.WriteLine("Pick a category? Hometown/Favorite Food");
        string category = Console.ReadLine().ToLower().Trim();
        if (category == "hometown" ||category == "home")
        {
            Console.WriteLine(Homes[userinput]);
            break;
        }
        else if (category == "favorite food" || category == "food")
        {
            Console.WriteLine(Foods[userinput]);
            break;
        }
        else
        {
            Console.WriteLine("Invalid Entry! Please Enter Hometown or Favorite Food.");
            restart2 = true;
        }
        
    }
    Console.WriteLine("Would you like to learn about another student? Yes or No");
    string answer = Console.ReadLine().ToLower().Trim();
    if (answer != "yes")
    {
        runProgram = false;
    }
}