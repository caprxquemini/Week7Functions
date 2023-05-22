string[] songs = { "Another Brick in the Wall", "Anybody Seen My Baby", "Crazy Train", "Wicked Games" };
string[] actors = { "Keanu Reeves", "Mark Wahlberg", "Jim Carrey", "Terry Crews" };

PrintArrayElements(songs);
PrintArrayElements(actors);

static void PrintArrayElements(string[] someArray)
{
    for (int i = 0; i < someArray.Length; i++)
        Console.WriteLine($" {i+1}. {someArray[i]}");
}