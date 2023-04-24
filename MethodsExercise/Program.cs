using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MethodsExercise
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string userFavoriteColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userFavoriteAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userFavoriteBand = Console.ReadLine();

            Console.WriteLine($"There was an odd person named {userName}.");
            Console.WriteLine($"They would jam to {userFavoriteBand} while petting {userFavoriteColor} {userFavoriteAnimal}.");
            Console.WriteLine($"Luckily the {userFavoriteAnimal} thought that the attention was worth listening to {userFavoriteBand}");


            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first one");
            num2 = int.Parse(Console.ReadLine());

            int sub = Subtract(num1, num2);
            Console.WriteLine($"The difference is: {sub}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide by");
            num2 = int.Parse(Console.ReadLine());

            int div = Divide(num1, num2);
            Console.WriteLine($"The answer is: {div}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide by");
           num2 = int.Parse(Console.ReadLine());

            int mod = Modulus(num1, num2);
            Console.WriteLine($"The answer is: {mod}");
        }

        //Challenge Mode- Creating a loop
        //public static int Sum(params int[] list)
        //{
        //    int sum= 0;

        //    for (int i = 0; i < list.Length; i++)
        //    {
        //        sum= sum+ list[i];
        //    }
        //    return sum;
        //}

        public static int Sum(int num1, int num2) 
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2) 
        {
            return num1 - num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Divide(int x, int y) 
        {
        return x / y;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }



}
