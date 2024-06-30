namespace ShoeCloset
{
    internal class Program
    {
        static ShoeCloset shoeCloset = new ShoeCloset();
        static void Main(string[] args)
        {
            while (true)
            {
                shoeCloset.PrintShoe();
                Console.Write("\n[D]odaj but, [U]suń but: ");
                char keyChar = Console.ReadKey().KeyChar;

                switch (keyChar)
                {
                    case 'd':
                    case 'D':
                        shoeCloset.AddShoe();
                        break;
                    case 'u':
                    case 'U':
                        shoeCloset.RemoveShoe();
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
