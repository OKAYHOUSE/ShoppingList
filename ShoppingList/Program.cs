//SHOPPING LIST
Dictionary<string, double> menuItems = new Dictionary<string, double>();

//Display at least 8 item names and prices.
menuItems.Add("Item 1", 0.99);
menuItems.Add("Item 2", 0.59);
menuItems.Add("Item 3", 1.59);
menuItems.Add("Item 4", 2.19);
menuItems.Add("Item 5", 1.79);
menuItems.Add("Item 6", 2.09);
menuItems.Add("Item 7", 1.99);
menuItems.Add("Item 8", 3.49);

List<string> shoppingList = new List<string>();
double total = 0;

Console.WriteLine("Welcome to TKO Market!");
bool runProgram = true;
while (runProgram == true)
{
    Console.WriteLine("\nItem \t \t Price");
    Console.WriteLine("======================");
    foreach (KeyValuePair<string, double> kvp in menuItems)
    {
        Console.WriteLine($"{kvp.Key}: \t ${kvp.Value}");
    }

    //Ask user to enter item
    while (true)
    {
        Console.WriteLine("\nPlease enter your item.");
        string choice = Console.ReadLine();
        if (menuItems.ContainsKey(choice))
        {
            shoppingList.Add(choice);
            break;
        }
        else { Console.WriteLine("Out of stock... please enter another item"); }
    }
    while (true)
    {
        Console.Write("Would you like to add another item? y/n: ");
        string choice2 = Console.ReadLine().ToLower().Trim();

        if (choice2 == "y")
        {
            break;
        }
        else if (choice2 == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid, enter y or n");
        }

    }
}
double maxPrice = 0;
double minPrice = 9999;
string maxName = "";
string minName = "";
Console.WriteLine();
Console.WriteLine($"Thank you for shopping with us. \nHere's your order:");
foreach (string item in shoppingList)
{
    Console.WriteLine($"{item}\t${menuItems[item]}");
    total += menuItems[item];
    if (menuItems[item] < minPrice)
    {
        minPrice = menuItems[item];
        minName = item;
    }
    if (menuItems[item] > maxPrice)
    {
        maxPrice = menuItems[item];
        maxName = item;
    }
}
Console.WriteLine($"\nYour total is: ${total}.  \n\nYour most expensive item was {maxName} and cost ${maxPrice}. \nYour least expensive item was {minName} and cost ${minPrice}. \nSee you next time!");


