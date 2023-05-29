namespace Assignment
{
    static class Program
    {
        /// <summary>
        /// The entry point of the program.
        /// </summary>
        static void Main()
        {
            System.Console.WriteLine("Hello World");
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            Console.WriteLine(chest);
        }
    }
}
