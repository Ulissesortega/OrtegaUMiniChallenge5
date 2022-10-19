//Name: Ulises Ortega
//Date: 10.19.22
/*Description: 
the program will ask the user to input answer depending on the question
all the answers will be stored in variable
all the variable will concatenate with the text of the questions
the program will output the story and the answers at the end
once the program is executed It will ask the user to run the program again Yes or no
*/
//Reviewer Name:
//Reviwer Comments:


string userChoice = "";
do{
string place, name, aTime, noun1, noun2, adj2, adj3, noun3, number, favFood;
Console.Clear();
Console.Write("Enter a state name: ");
place = Console.ReadLine();
Console.Clear();
Console.Write("Enter persons name: ");
name = Console.ReadLine();
Console.Clear();
Console.Write("Enter cool or awful: ");
aTime = Console.ReadLine();
Console.Clear();
Console.Write("Structure: ");
noun1 = Console.ReadLine();
Console.Clear();
Console.Write("Enter noun: ");
noun2 = Console.ReadLine();
Console.Clear();
Console.Write("Enter adjective: ");
adj2 = Console.ReadLine();
Console.Clear();
Console.Write("Enter adjective: ");
adj3 = Console.ReadLine();
Console.Clear();
Console.Write("sunscreen or moonscreen: ");
noun3 = Console.ReadLine();
Console.Clear();
Console.Write("Enter a number: ");
number = Console.ReadLine();
Console.Clear();
Console.Write("Enter fav' Type of food: ");
favFood = Console.ReadLine();
Console.Clear();

Console.WriteLine("I went to the beach in " + place + " today with " + name + "\nWe had a " + noun2 + " time.");
Console.WriteLine("We built a sand " + noun1 + " and then we ran around in the " + noun2 + "\nfor a little while");
Console.WriteLine("The water was a bit " + adj2 + ". The sun was very "+ adj3 + " \nSo we make sure to wear a lot of " + noun3);
Console.WriteLine("We spent " + number + " hours there. At the end of the day, we went for " + favFood + " Food");
Console.WriteLine();

do
{
Console.WriteLine("Do you want to Run the program again Yes or No?");
    userChoice = Console.ReadLine().ToUpper();
    if(userChoice != "YES" && userChoice != "NO")
    {
        Console.WriteLine("Invalid Choice, pLease say Yes or No");
    }
}while (userChoice !="YES" && userChoice != "NO");
}while(userChoice == "YES");