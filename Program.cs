namespace Topic_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carter Todd
            string name;
            int age;
            double salary;
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("What is your age?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("So you're " + age + ", eh? Thats not old at all!");
            Console.WriteLine("How much do you make, " + name + "?");
            double.TryParse(Console.ReadLine(), out salary);
            Console.WriteLine(salary.ToString("C")! + " I hope thats per hour and not per year!");


            string firstName, lastName, login;
            int ID, grade;
            double average;
            Console.WriteLine("hello what is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();
            Console.WriteLine("What grade are you in?");
            grade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your student ID?");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your student login?");
            login = Console.ReadLine();
            Console.WriteLine("What is your average?");
            average = Convert.ToDouble(Console.ReadLine());


  
           
            Console.WriteLine("Hello. What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hi " + name);
            Console.WriteLine("How old are you?");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine("Did you know in 5 years you will be " + (age + 5) + " Years old?");
            Console.WriteLine("And 5 years ago you were " + (age - 5) + "! Imagine that!");


            int number1;
            double number2, number3;
            Console.WriteLine("Hey give me a number");
            Int32.TryParse(Console.ReadLine(), out number1);
            Console.WriteLine("Give me another number");
            double.TryParse(Console.ReadLine(), out number2);
            Console.WriteLine("Give me one more number");
            double.TryParse(Console.ReadLine(), out number3);
            double num;
            num = number1 + number2 + number3;
            Console.WriteLine("The dumb calculator result is: " + (num / 2));


            string item1, item2;
            double totalPrice, discount, tax, subTotal, price1, price2, finalPrice; 
            Console.WriteLine("Sales Recipt"); 
            Console.WriteLine("What is item 1:");
            item1 = Console.ReadLine();
            Console.WriteLine("What is the price of " + item1); 
            double.TryParse(Console.ReadLine(), out price1);
            Console.WriteLine("What is item 2:");
            item2 = Console.ReadLine();
            Console.WriteLine("What is the price of " + item2);
            double.TryParse(Console.ReadLine(), out price2);
            totalPrice = price1 + price2;
            discount = totalPrice * 0.2;
            subTotal = totalPrice - discount;
            tax = subTotal * 0.13;
            finalPrice = subTotal + tax;
            Console.WriteLine("Total: " + totalPrice.ToString("c")); 
            Console.WriteLine("discount 20%: " + discount.ToString("c"));
            Console.WriteLine("Your new total is: " + subTotal);
            Console.WriteLine("Tax (13%): " + tax.ToString("c"));
            Console.WriteLine("Your final price is: " + finalPrice.ToString("c"));
            

        }
    }
}
