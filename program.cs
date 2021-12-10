class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, result = 0;
            string sign;
            Console.WriteLine("Enter the first number:");
            number1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            number2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sign of operation:");
            sign = Console.ReadLine();
            if (sign != "+" && sign != "-" && sign != "*" && sign != "/")
            {
                Console.WriteLine("Error");
            }
            else
            {
                if (sign == "+")
                {
                    result = number1 + number2;
                    Console.WriteLine("Your result is:");
                    Console.WriteLine("{0} {1} {2} = {3}", number1, sign, number2, result);
                }
                else if (sign == "-")
                {
                    result = number1 - number2;
                    Console.WriteLine("Your result is:");
                    Console.WriteLine("{0} {1} {2} = {3}", number1, sign, number2, result);
                }
                else if (sign == "*")
                {
                    result = number1 * number2;
                    Console.WriteLine("Your result is:");
                    Console.WriteLine("{0} {1} {2} = {3}", number1, sign, number2, result);
                }
                else if (sign == "/")
                {
                    if (number2 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        result = number1 / number2;
                        Console.WriteLine("Your result is:");
                        Console.WriteLine("{0} {1} {2} = {3}", number1, sign, number2, result);
                    }
                    
                }
                
            }
            
        }
    }
