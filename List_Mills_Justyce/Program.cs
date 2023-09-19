internal class Program
{
    static void Main(string[] args)
    {
        List<string> games = new List<string>//string list called games and initialize with some game titles
        {
            "Warframe",
            "Elsword",
            "Dauntless",
            "Zomcube"
        };

        string[] otherGames = new string[]//array of strings, called otherGames, initialize with a couple more game titles
        {
            "Battlefield 1",
            "Titanfall 2"
        };

        foreach(string game in games)//foreach loop to print each game in the games list
        {
            Console.WriteLine(game);
        }

        Console.WriteLine($"\nGames in list: { games.Count}");//Print to console the number of items in the list

        games.AddRange(otherGames);//Add a range to the list using the array 

        Console.WriteLine($"\nGames in list: {games.Count}");//Print to console the number of items in the list

        if (games.Contains("Halo"))//If the list contains "Halo", then print to console, "MASTER CHIEF is in the house"
        {
            Console.WriteLine("\nMASTER CHIEF IS IN THE HOUSE");
        }
        else//Else, add "Halo" to the games list
        {
            games.Add("Halo");
        }

        int myInt = 6;//Int with the value of 6

        if(myInt<games.Count)//If the int value is less than the number of games in the games list, then remove the game at index 6 of the games list
        {
            games.RemoveAt(myInt);
        }
        else//Else, print out, "Game not found"
        {
            Console.WriteLine("\nGame not found");
        }

        Console.WriteLine("\nAll games in the list:");//Print to console, "All games in the list:"
        foreach(string game in games)//Loop through the games list and print each game to console again
        {
            Console.WriteLine(game);
        }

        games.Sort();//Sort the games list

        Console.WriteLine("\nSorted games list:");//Print to console, "Sorted Games List:"
        foreach (string game in games)//Print each game to console again
        {
            Console.WriteLine(game);
        }

        string[] newList = new string[games.Count];//string array called newList and initialize to the same size as the games list

        games.CopyTo(newList);//Copy the games list to the string array newList

        games.Clear();//Clear the games list

        Console.WriteLine("\nNew list");//Print each of the strings in the new list
        foreach(string game in newList)
        {
            Console.WriteLine(game);
        }
    }
}