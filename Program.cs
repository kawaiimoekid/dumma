do
{
    Console.Write("Type a word (a-z, A-Z, 0 to exit): ");
    var word = Console.ReadLine();

    if (word == "0") break;

    if (!IsValidWord(word))
    {
        Console.WriteLine("Invalid word. Allowed characters: a-z, A-Z.");
        continue;
    }

    PrintWord(word!);

    Console.WriteLine("\n");
} while (true);

static bool IsValidWord(string? word)
{
    if (word is null)
        return false;

    foreach (var character in word)
    {
        var converted = (int) character;
        if (converted <= 64 || converted >= 127
            || (converted >= 91 && converted <= 96))
            return false;
    }

    return true;
}

static void PrintWord(string word)
{
    // Used to reset position of cursor
    Console.WriteLine();

    var position = Console.GetCursorPosition();

    for (var i = 0; i < word.Length; i++)
    {
        var letter = new Letter(word[i]);
        letter.Print(7 * i, position.Top);
    }
}