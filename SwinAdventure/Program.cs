namespace SwinAdventure;

class Program
{
    static void Main(string[] args)
    {
        IdentifiableObject test = new IdentifiableObject(new string[] {});

        Console.WriteLine(test.FirstId);
    }
}

