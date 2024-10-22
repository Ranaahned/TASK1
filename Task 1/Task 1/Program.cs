using System.Xml.Linq;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
           
            string name = Console.ReadLine() ;
            Console.WriteLine(" Hello "+ name +" welcome to C# course ");

            Console.WriteLine("********************************");

            Console.WriteLine(" please Eter any two numbers");

            float num1 =float.Parse(Console.ReadLine());
            float  num2 = float.Parse(Console.ReadLine());

            float add = num1 + num2;
            float sub = num1 - num2;
            float multi = num1 * num2;
            float divi = num1 / num2;

            Console.WriteLine("sum=" + add + "\nsubstruction = " + sub + "\nmuliplication =" + multi + "\n division = " + divi + "\n");

            Console.WriteLine("********************************");

            Console.WriteLine("please Enter your birth year ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("You are " +(2024 - age)+ " years old \n");

            Console.WriteLine("********************************");

            Console.WriteLine(" please Enter temperture in celsiuse ");
            float deg = float.Parse(Console.ReadLine());

            Console.WriteLine(deg + " degrees celsius is " + (deg * (9 / 5) + 32) + " degrees fahrenheit ");


        }
    }
}
