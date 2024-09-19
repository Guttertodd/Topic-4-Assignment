namespace Topic_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carter Todd
            string name;
            int age;
            double salery; 
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("What is your age?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? Thats not old at all!" );
            Console.WriteLine("How much do you make, " + name + "?");
            double.TryParse(Console.ReadLine(), out salery);
            Console.WriteLine("13.50! I hope thats per hour and not per year!");

        }
    }
}
