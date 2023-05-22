string hello = "Hello, world!";

PrintStringFiveTimes(hello);
PrintStringFiveTimes("Stefania");


static void PrintStringFiveTimes (string someString)
    {
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(someString);
    }
}