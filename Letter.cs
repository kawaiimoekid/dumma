public class Letter
{
    private char _letter;

    public Letter(char letter) => _letter = letter;

    public void Print(int offsetX, int offsetY)
    {
        var template = LetterTemplates.GetLetter(_letter);

        for (var y = 0; y < 5; y++)
        {
            Console.SetCursorPosition(offsetX, offsetY + y);

            for (var x = 0; x < 5; x++)
            {
                Console.Write(template[y * 5 + x]);
            }
        }
    }
}