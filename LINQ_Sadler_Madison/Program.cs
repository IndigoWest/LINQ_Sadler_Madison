// See https://aka.ms/new-console-template for more information
// Lin_Sadler_Madison namespace needed to use Console class
using LINQ_Sadler_Madison;
// Creates an array of Games called games
// Initializes games with 10 games, specifying their title, esrb rating, and genre
Game[] games = new Game[]
{
    new Game("Minecraft", 'E', "Action-Adventure"),
    new Game("Undertale", 'E', "RPG"),
    new Game("Skyrim", 'M', "Fantasy RPG"),
    new Game("Kingdom Hearts III", 'E', "Action RPG"),
    new Game("Sly Cooper", 'E', "Stealth Platformer"),
    new Game("Cuphead", 'E', "Action"),
    new Game("Fran Bow", 'T', "Point and Click Adventure"),
    new Game("Little Nightmares", 'T', "Adventure Platformer"),
    new Game("Phasmophobia", 'M', "Psychological Horror"),
    new Game("Pokemon Sword and Shield", 'E', "Adventure RPG")
};

// Creates a LINQ Query that gets all games with a length that's less than 9 in its title and assigns it to a variable called shortGames
// Selects to print the game title with ToUpper called on it
var shortGames = from game in games
                 where game.Title.Length < 9
                 select $"Game Title: {game.Title.ToUpper()}";

// Creates a foreach loop to loop through shortGames and prints each game in it to Console
foreach (var game in shortGames)
{
    Console.WriteLine(game);
}

// Creates a LINQ method query to find the game Minecraft from games and assigns it to variable called mineCraft
// Selects to specify the game's title, esrb rating, and genre
var mineCraft = games.Where(game => game.Title == "Minecraft")
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

// Prints to Console the properties of mineCraft by using the FirstOrDefault method
Console.WriteLine(mineCraft.FirstOrDefault());

// Creates a variable called tRated that selects T rated titles in games
var tRated = from game in games
             where game.Esrb == 'T'
             select game.Title;

// Prints to Console "T Rated Games:"
Console.WriteLine("T Rated Games:");
// Creates a foreach loop that loops through tRated and prints each game to Console
foreach(var game in tRated)
{
    Console.WriteLine(game);
}

// Creates a variable called eRatedAction that selects E rated titles in games
var eRatedAction = from game in games
                   where game.Esrb == 'E' && game.Genre.Contains("Action")
                   select game.Title;

// Prints to Console "E Rated Action Games:"
Console.WriteLine("E Rated Action Games:");
// Creates foreach loop that loops through eRatedAction and prints each game to Console
foreach (var game in eRatedAction)
{
    Console.WriteLine(game);
}