using System;

namespace ProblemSolving
{
    class Program
    {
        static string[] houses = { "Red", "Green", "Yellow", "White", "Blue" };
        static string[] pets = { "Dog", "Cat", "Bird", "Horse", "Fish" };
        static string[] nationalities = { "Brit", "Swede", "Dane", "Norwegian", "German" };
        static string[] cigarettes = { "Blend", "Prince", "Dunhill", "BlueMaster", "PullMall" };
        static string[] drinks = { "Tea", "Coffee", "Milk", "Beer", "Water" };
        static string[] hints = new string[15];

        static void Main()
        {
            Random rand = new Random();
            Shuffle(rand);
            GenerateHints();
            Console.WriteLine("Einstein's riddle");
            Console.WriteLine("The situation: ");
            Console.WriteLine("        1. There are 5 houses in five different colors.");
            Console.WriteLine("        2. In each house lives a person with a different nationality.");
            Console.WriteLine("        3. These five owners drink a certain type of beverage, smoke a certain brand of cigar and keep a certain pet.");
            Console.WriteLine("        4. No owners have the same pet, smoke the same brand of cigar or drink the same beverage.");
            Console.WriteLine($"The question is: Who owns the {pets[3]}?");
            Console.WriteLine("HINTS: ");

            for (int i = 1; i <= hints.Length; i++)
            {
                Console.WriteLine($"{i}. {hints[i - 1]}");
            }

            Console.WriteLine("Einstein wrote this riddle this century. He said that 98% of the world could not solve it.");
            Console.WriteLine("To see the solution type solution!");

            string solution = Console.ReadLine();

            while (solution.ToLower() != "solution")
            {
                Console.WriteLine("Wrong command! Try again!");
                solution = Console.ReadLine();
            }

            PrintSolution();
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"In the {houses[i]} lives the {nationalities[i]}. He drinks {drinks[i]}, smokes {cigarettes[i]} and has {pets[i]} as a pet.");
            }
        }

        private static void GenerateHints()
        {
            //the Brit lives in the red house
            hints[0] = $"the {nationalities[2]} lives in the {houses[2]} house";

            //the Swede keeps dogs as pets
            hints[1] = $"the {nationalities[4]} keeps {pets[4]} as pets";

            //the Dane drinks tea
            hints[2] = $"the {nationalities[1]} drinks {drinks[1]}";

            //the green house is on the left of the white house
            hints[3] = $"the {houses[3]} is on the left of the {houses[4]} house";

            //the green house's owner drinks coffee
            hints[4] = $"the {houses[3]} house's owner drinks {drinks[3]}";

            //the person who smokes Pall Mall rears birds
            hints[5] = $"the person who smokes {cigarettes[2]} rears {pets[2]}";

            //the owner of the yellow house smokes Dunhill
            hints[6] = $"the owner of the {houses[0]} smokes {cigarettes[0]}";

            //the man living in the center house drinks milk
            hints[7] = $"the man living in the center house drikns {drinks[2]}";

            //the Norwegian lives in the first house
            hints[8] = $"the {nationalities[0]} lives in the first house";

            //the man who smokes blends lives next to the one who keeps cats
            hints[9] = $"the man who smokes {cigarettes[1]} lives next to the one who keeps {pets[0]}";

            //the man who keeps horses lives next to the man who smokes Dunhill
            hints[10] = $"the man who keeps {pets[1]} lives next to the man who smokes {cigarettes[0]}";

            //the owner who smokes BlueMaster drinks beer
            hints[11] = $"the owner who smokes {cigarettes[4]} drinks {drinks[4]}";

            //the German smokes Prince
            hints[12] = $"the {nationalities[3]} smokes {cigarettes[3]}";

            //the Norwegian lives next to the blue house
            hints[13] = $"the {nationalities[0]} lives next to the {houses[1]} house";

            //the man who smokes blend has a neighbor who drinks water       
            hints[14] = $"the man who smokes {cigarettes[1]} lhas a nieghbor who drinks {drinks[0]}";
        }

        private static void Shuffle(Random rand)
        {
            for (int i = 0; i < 5; i++)
            {
                //shuffling houses
                int randomHouse = i + rand.Next(0, houses.Length - i);
                Swap(i, randomHouse, houses);

                //Shuffling pets
                int randomPet = i + rand.Next(0, pets.Length - i);
                Swap(i, randomPet, pets);

                //Shuffling nationalities
                int randomNationality = i + rand.Next(0, nationalities.Length - i);
                Swap(i, randomNationality, nationalities);

                //Shuffling cigarettes
                int randomCigarettes = i + rand.Next(0, cigarettes.Length - i);
                Swap(i, randomCigarettes, cigarettes);

                //Shuffling drinks
                int randomDrinks = i + rand.Next(0, drinks.Length - i);
                Swap(i, randomDrinks, drinks);
            }
        }

        private static void Swap(int i, int random, string[] array)
        {
            string temp = array[i];
            array[i] = array[random];
            array[random] = temp;
        }
    }
}
