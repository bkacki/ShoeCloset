using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoeCloset
{
    internal class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();

        public void PrintShoe()
        {
            if (shoes.Count == 0)
                Console.WriteLine("\nSchowek na buty jest pusty.");
            else
            {
                Console.WriteLine("\nSchowek na buty zawiera:");
                int i = 1;
                foreach(Shoe shoe in shoes)
                    Console.WriteLine($"Para numer {i++}: {shoe.Description}");
            }
        }

        public void AddShoe()
        {
            Console.WriteLine("\nDodaj parę butów.");

            for (int i = 0; i < 6; i++)
                Console.WriteLine($"Wciśnij {i}, aby dodać {(Style)i}.");

            Console.Write("Podaj fason: ");

            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int style))
            {
                Console.Write("\nPodaj kolor: ");
                string color = Console.ReadLine();
                Shoe shoe = new Shoe((Style)style, color);
                shoes.Add(shoe);
            }
        }

        public void RemoveShoe()
        {
            Console.Write("\nWciśnij numer pary, którą chcesz usunąć: ");

            if(int.TryParse(Console.ReadKey().KeyChar.ToString(), out int shoeNumber) && (shoeNumber >= 1) && (shoeNumber <=shoes.Count))
            {
                Console.WriteLine($"\nUsuwanie pary {shoes[shoeNumber-1].Description}");
                shoes.RemoveAt(shoeNumber-1);
            }
        }
    }
}
