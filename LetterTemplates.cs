public static class LetterTemplates 
{
    private static IDictionary<char, string> _templates = new Dictionary<char, string>()
    {
        { 
            'a', 
            " XXX " +
            "X   X" +
            "XXXXX" +
            "X   X" +
            "X   X" 
        },
        {
            'b',
            "XXXX " +
            "XX XX" +
            "XXXX " +
            "XX XX" +
            "XXXX "
        },
        {
            'c',
            " XXXX" +
            "X    " +
            "X    " +
            "X    " +
            " XXXX"
        },
        {
            'd',
            "XXXX " +
            "X   X" +
            "X   X" +
            "X   X" +
            "XXXX "
        },
        {
            'e',
            "XXXXX" +
            "X    " +
            "XXXX " +
            "X    " +
            "XXXXX"
        },
        {
            'f',
            "XXXXX" +
            "X    " +
            "XXXX " +
            "X    " +
            "X    "
        },
        {
            'g',
            " XXX " +
            "X    " +
            "X  XX" +
            "X   X" +
            " XXX "
        },
        {
            'h',
            "X   X" +
            "X   X" +
            "XXXXX" +
            "X   X" +
            "X   X"
        },
        {
            'i',
            "  X  " +
            "  X  " +
            "  X  " +
            "  X  " +
            "  X  "
        },
        {
            'j',
            "    X" +
            "    X" +
            "    X" +
            "X   X" +
            " XXX "
        },
        {
            'k',
            "X   X" +
            "X  X " +
            "XXX  " +
            "X  X " +
            "X   X"
        },
        {
            'l',
            "X    " +
            "X    " +
            "X    " +
            "X    " +
            "XXXXX"
        },
        {
            'm',
            "XX XX" +
            "X X X" +
            "X X X" +
            "X   X" +
            "X   X"
        },
        {
            'n',
            "X   X" +
            "XX  X" +
            "X X X" +
            "X  XX" +
            "X   X"
        },
        {
            'o',
            " XXX " +
            "X   X" +
            "X   X" +
            "X   X" +
            " XXX "
        },
        {
            'p',
            "XXXX " +
            "X   X" +
            "XXXX " +
            "X    " +
            "X    "
        },
        {
            'q',
            " XXX " +
            "X   X" +
            "X   X" +
            "X  XX" +
            " XXXX"
        },
        {
            'r',
            "XXXX " +
            "X   X" +
            "XXXX " +
            "X  X " +
            "X   X"
        },
        {
            's',
            " XXXX" +
            "X    " +
            " XXX " +
            "    X" +
            "XXXX "
        },
        {
            't',
            "XXXXX" +
            "  X  " +
            "  X  " +
            "  X  " +
            "  X  "
        },
        {
            'u',
            "X   X" +
            "X   X" +
            "X   X" +
            "X   X" +
            " XXX "
        },
        {
            'v',
            "X   X" +
            "X   X" +
            " X X " +
            " X X " +
            "  X  "
        },
        {
            'w',
            "X   X" +
            "X   X" +
            "X X X" +
            "X X X" +
            "XX XX"
        },
        {
            'x',
            "X   X" +
            " X X " +
            "  X  " +
            " X X " +
            "X   X"
        },
        {
            'y',
            "X   X" +
            " X X " +
            "  X  " +
            "  X  " +
            "  X  "
        },
        {
            'z',
            "XXXXX" +
            "   X " +
            "  X  " +
            " X   " +
            "XXXXX"
        }
    };

    public static string GetLetter(char c) => _templates[Char.ToLower(c)];
}