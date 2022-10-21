//lesson 1: Getting started with C#

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I like pizaa"); //prints out the text in quatation

            Console.WriteLine("It's really good");

            Console.Beep(); //console emits a beeing sound when reaches the function
            Console.Write("beep probs works");//Probably ignored by the MacOS

        }
    }
}
*/

//__________________________________
//Lesson 2: Output
/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //doesnt hit the enter key after the end.
            //whatever prints after will be printed on the same line
            Console.Write("Hey!"); 

            //hits enter at the end. wtvr prints after will
            //print on a new line
            Console.WriteLine("Hello World");

            //shortcut to create a .writeline statement
            //type cw and hit tab twice

            //Escape Sequences:
            // \a = bell(alert)
            Console.WriteLine("Hello World");

            // \b = backspace 
            Console.WriteLine("Hello World");

            // \f = form Feed
            Console.WriteLine("Hello World");

            // \n = new line
            Console.WriteLine("Hello World");

            // \r = carriage return 
            Console.WriteLine("Hello World");

            // \t = horizontal tab
            Console.WriteLine("\tHello World");

            // \v = vertical tab
            Console.WriteLine("Hello World");

            // \' = single quotation mark
            Console.WriteLine("Hello World");

            // \" = double quotation mark
            Console.WriteLine("Hello World");

            // \\ = backlash
            Console.WriteLine("Hello World");

            // \? = literal question mark
            Console.WriteLine("Hello World");

            //prevents the program from ending until hit enter
            //hides all the extra stuff from 
            Console.ReadKey(); 
        }
    }
}*/

//__________________________________
//Lesson 3: Variables

/*using System;
 * namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x; //declaration
            //x = 10; //initialization 

            char character = 'x'; //single quotes

            string word = "word";

            int wholeNum = 4;

            double decimalNum = 4.5;

            bool isAlive = true;

            //Console.WriteLine(wholeNum);

            int age = 23;
            double height = 184.5;

            Console.WriteLine("Your age is " + age);
            Console.WriteLine("Your height is " + height + "cm");

            Console.ReadKey();


        }
    }
}*/

//__________________________________
//Lesson 4: Constants

/*using System;
 * namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // constants = immutable values which are knwon at compile time
            //             and do not change for the lide of the program

            //double pi = 3.14159;
            //pi = 3.15;
            //as is pi can be changed by anyone, but if pi data type is preceded
            //by const, making it an unchangeable value
            const double pi = 3.14159;

            Console.WriteLine(pi);

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 5: type casting

/*using System;
 * namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //type casting = converting a value to a different data type
            //               useful when we accept user input (string)
            //               different data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a); //converted double to int

            Console.WriteLine(b);

            //prints out the datatype of the variable
            //Console.WriteLine(b.GetType());

            int c = 200;
            double d = Convert.ToDouble(c) + 0.1;

            Console.WriteLine(d);

            string e = "$";
            char f = Convert.ToChar(e);
            Console.WriteLine(f);

            string g = "true";
            bool h = Convert.ToBoolean(g);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 6: user input

/*using System;
 * namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameInstructions = "Write your name";
            Console.WriteLine(nameInstructions);
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            string ageInstructions = "Write your age";
            Console.WriteLine(ageInstructions);
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are " + age + " years old");

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 7: arithmetic
/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //int friends = 10;
            //int otherFriends = 5;
            //int allFriends = friends + otherFriends;

            //Console.WriteLine(allFriends);

            //This is called incrementing 
            //friends = friends + 1;
            //is the same as
            //friends += 1; // or friends++

            //decrement = take awy from, make smaller
            //friends = friends - 1;
            //OR
            //friends -= 1;
            //OR
            //friends--;

            //multiplication
            //friends = friends * 2;
            //friends *= 2;

            //division
            //friends = friends / 2;
            //friends /= 2;

            //modular aka the remainder
            //friends = friends % 2;
            //friends %= 2;

            //Console.WriteLine(friends);

            //Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 8: Math class
/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.14;
            double y = 5;

            //double a = Math.Pow(x, 3);
            //double b = Math.Sqrt(x);
            //double c = Math.Abs(x);
            //double d = Math.Round(x);
            //double e = Math.Ceiling(x);
            //double f = Math.Floor(x);
            //double g = Math.Max(x, y);  //finds out the largest number from the ones in brackets
            //double h = Math.Min(x, y);  //finds out the smallest number

            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 9: Random numbers

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int num1 = random.Next(1, 7); //will generate a radnom number between 0 and 2 billion
                                          //alternatively can set the boundary, 1st number inclusive, 2nd exclusive
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);

            //double num2 = random.NextDouble();  //will generate a random number between 0 and 1

            Console.WriteLine(num1);
            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 10: hypotenuse calculator program 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side A: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            //alternatively can write as
            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse of the triangle is: " + c);
            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 11: string methods

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string when referring to object
            //String when referring to a class
            string fullName = "Bro Code";

            string phoneNumber = "123-456-7890";

            //fullName = fullName.ToUpper(); //makes all letters upper case 
            //fullName = fullName.ToLower(); //makes all the letter in the string lower case
            //string value need to be reasigned if want to keep the value
            //Console.WriteLine(fullName);

            //phoneNumber = phoneNumber.Replace("-", "!"); //1st old character, 2nd the character to replace with
            //Console.WriteLine(phoneNumber);

            //string userName = fullName.Insert(0, "@"); //inserts string at the given index value
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); prints out the lenght of the string

            //string firstName = fullName.Substring(0, 3); //1st = index, 2nd = # of characters to include within substring
            //string lastName = fullName.Substring(4, 4); //index at which to begin then characters to include

            //Console.WriteLine(lastName);

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 12: if statements 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statement = basic form of decision making

            /*Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("You are an adult!");
            }
            else if (age == 18)
            {
                Console.WriteLine("You are exactly of age");
            }
            else if (age < 18)
            {
                Console.WriteLine("You are a baby!");
            }

            Console.WriteLine("Enter you name: ");
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.WriteLine("Your name is: " + name);
            }
            else
            {
                Console.WriteLine("You did not enter your name!");
            }

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 13: switches 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch = an efficient alternative to many else if statements

            Console.WriteLine("What day is it today? ");
            string day = Console.ReadLine();

            switch (day) //in the brackets place the variable you would like to examine
            {
                case "Monday": //if case == day, then:
                    Console.WriteLine("Today is Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                case "Wednsday":
                    Console.WriteLine("Today is Wednsday");
                    break;
                case "Thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("Today is Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day!");
                    break;
            }

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 14: logical operators

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operators = can be used to check if more than 1 condition is true/false
            //&& == (AND)
            //|| == (OR)

            Console.WriteLine("What's the temperature outside: (C)");
            double temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 25)
            {
                Console.WriteLine("it's too damn hot!");
            }
            else if (temp < 25 && temp > 10)
            {
                Console.WriteLine("The weather is optimal");
            }
            else
            {
                Console.WriteLine("It's too damn cold!");
            }

            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 15: while loops

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop = repeats some code while some condition remains true

            //Console.WriteLine("Enter your name: "); //don't need this line with it already being in the loop
            string name = "";                         //Console.ReadLine(); //same applies

            while (name == "")
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            Console.WriteLine("Hello " + name);

            //while (1 == 1) //not good
            //{
            //    Console.WriteLine("HELP IM STUCK IN AN INFINITE LOOP!");
            //}

            //Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 16: for loops

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loop = repeats a FINITE amount of times

            //for(int i = 0; i < 10; i++) //first condition indicates where to start, second condition indicates the limitation
            //third condition indicates how much to increment or decrement by

            /*for (int i = 0; i <= 10; i++) //could also be i+=1
            {
                Console.WriteLine(i);
            }
            */

/*for (int i = 10; i > 0; i--)
{
    Console.WriteLine(i);
}

Console.ReadKey();

}
}
}
*/

//__________________________________
//Lesson 17: nested loops

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //nested loops = loops inside other loops
            //               User vary. used a lot in sorting algorithms.

            Console.WriteLine("How many rows?: ");

            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many columns?: ");

            int columns = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What symbol?: ");

            string symbol = Console.ReadLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine(); //used to move down to the next line
            }
            Console.ReadKey();
        }
    }
}*/

//__________________________________
//Lesson 18: number guessing game

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool playAgain = true;

            int min = 1;
            int max = 100;

            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " and " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low!");
                    }

                    guesses++;
                }
                Console.WriteLine("Number :" + number);
                Console.WriteLine("You win!");
                Console.WriteLine("You guessed: " + guesses + " times");

                Console.WriteLine("Would you like to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                while (response != "Y" || response != "N")
                {
                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else if (response == "N")
                    {
                        playAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter a vaild answer");
                    }
                }
            }

            Console.WriteLine("Tahnks for playing");

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 19: rock-paper-scissors game

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;
            string answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                //int randomNum = random.Next(1, 4);
                //alternatively can place the random insde the case
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player :" + player);
                Console.WriteLine("Computer :" + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You win");
                        }
                        else
                        {
                            Console.WriteLine("You lose");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose");
                        }
                        else
                        {
                            Console.WriteLine("You win");
                        }
                        break;
                }
                Console.WriteLine("Would you like to play again? (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing");

            Console.ReadKey();
        }
    }
}
*/
//__________________________________
//Lesson 20: calculator program

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;
                string symbol = "";
                string separationLine = "------------------";


                Console.WriteLine(separationLine);
                Console.WriteLine("Calculator Program");
                Console.WriteLine(separationLine);

                Console.WriteLine("Enter the 1st number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the 2nd number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the operator symbol: ");
                symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                }

                Console.WriteLine("The result is: " + result);
                Console.WriteLine("Would you like to continue? (Y/N)");

                Console.ReadKey();
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
        }
    }
}
*/
//__________________________________
//Lesson 21: arrays

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //array = a variable that can store multiple values. fixed size

            string[] cars = new string[4]; //arrays have fixed sizes, if unsure about the size can make more
                                           //in case, the unused index will remain empty, can be assigned later

            //string[] cars = { "BMW", "Mustang", "Corvette" };

            cars[0] = "Tesla"; //if need to update the name of array
                               //arrays cannot be added onto, fixed size
            cars[1] = "Corvette";
            cars[2] = "BMW";
            cars[3] = "Ranger";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]); //array[i] = prints out the array values; i prints out the array indexes
            }

            //Console.WriteLine(cars[0]); //to print the value withing the array,indicate the index in the brackets

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 22: foreach loop

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loop = a simplified way to itegrate over an array, but it's less flexible

            string[] cars = { "BMW", "Mustang", "Corvette" };

            foreach (string car in cars) //for every element in array iterate forward by 1, not flexible
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 23: 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //method = performs a section of code, whenever it's called/invoked (same thing)
            //benefit = let's us reuse code without writing it multiple times

            string name = "Ed";
            int age = 23;

            HappyBirthday(name, age);

            Console.ReadKey();
        }

        static void HappyBirthday(string name, int age)
        {
            Console.WriteLine("Happy birthday to you");
            Console.WriteLine("Happy " + age + " to you");
            Console.WriteLine("Happy birthday dear" + name);
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday");
            Console.WriteLine("Happy birthday to you");
        }
    }
}
*/

//__________________________________
//Lesson 24: return keywords

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //return = returns data back to the place where the method is invoked
            int num1;
            int num2;
            int result;

            Console.WriteLine("Enter 1st number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2nd number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = Add(num1, num2);

            Console.WriteLine("The result is " + result);

            Console.ReadKey();
        }

        static int Add(int num1, int num2)
        {
            //int result = num1 + num2; 
            //return result;

            //alternatively could write
            return num1 + num2;
        }
    }
}
*/

//__________________________________
//Lesson 25: method overloading

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overloading = methods share the same name, but different parameters
            //                     name + parameters = signature
            //                     methods must have a unique signature

            double total;

            total = Multiply(1, 2, 4); //has three parameters;

            Console.WriteLine(total);

            Console.ReadKey();
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
*/

//__________________________________
//Lesson 26: params keyword

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //params keyword = a method parameter that takes a variable number of arguments
            //                 the parameter type must be a single - dimensional array

            double total = Checkout(3.99, 5.57, 15); //can add as many arameters as needed

            Console.WriteLine(total);

            Console.ReadKey();
        }

        static double Checkout(params double[] prices) //truns the return keyword into an array
        {
            double total = 0;

            foreach (double price in prices)
            {
                total += price;
            }

            return total;
        }
    }
}
*/

//__________________________________
//Lesson 27: exception handling 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //exceptions = errors that occur during execution

            //try = try some code that is considered dangerous
            //catch = catches and handles exceptions when they occur
            //finally = always executes regardless if exception is caught or not

            int x;
            int y;
            double result;

            try
            {
                Console.WriteLine("Enter 1st number: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter 2nd number: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result :" + result);
            }
            //catch specific exceptions first
            catch (FormatException e)
            {
                Console.WriteLine("Only write numbers you numpty.");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by 0 you silly you.");
            }
            //catchall at the end
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong");
            }
            finally
            {
                Console.WriteLine("Tahnks for visiting");
            }

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 28: conditional operator

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //conditional operator = used in a conditional assignment if a condition is true/false

            //(condition) ? x : y
            //(condition) ? = is this condition is true/false?
            //x = if true return x
            //y = if false return y

            double temperature = 25;
            string message;

            //if (temperature > 15)
            //{
            //    message = "It's warm outside";
            //}
            //else
            //{
            //    message = "It's cold outside";
            //}

            Console.WriteLine(message);
            

            message = (temperature > 15) ? "It's warm outside" : "It's cold outside";

            Console.WriteLine(message);

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 29: string interpolation

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //string interpolation = allows us to insert variables into a string literal
            //                       precede a string literal with $
            //                       {} are placeholders

            string firstName = "Ed";
            string lastName = "Boytsov";
            int age = 23;

            //Console.WriteLine("Hey my name is " + firstName + " " + lastName);
            //Console.WriteLine("I am " + age + " years old");

            Console.WriteLine($"Hey my name is {firstName} {lastName}");
            Console.WriteLine($"I am {age} years old"); //{age, 10} 10 allocates ten spaces before the first value
                                                        //{age, -10} does the opposite
            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 30: multidimensional arrays

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //multidimensional arrays = array of arrays
            string[] ford = { "Mustang", "F-150", "Explorer" };
            string[] chevy = { "Corvette", "Camaro", "Silverado" };
            string[] toyota = { "Corolla", "Camry", "Rav4" };

            string[,] parkingLot = { { "Mustang", "F-150", "Explorer" } ,
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav4" }};

            parkingLot[0, 2] = "Fusion"; //[0,2] = first number is the index of the array,
                                         //second number is the index of the element within the selected array

            //foreach (string car in parkingLot)
            //{
            //    Console.WriteLine(car);
            //}

            for (int i = 0; i < parkingLot.GetLength(0); i++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.WriteLine(parkingLot[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 31: classes

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //class = A bundle of related code.
            //        Can be used as a bluebprint to create objects (OOP)

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();

            Console.ReadKey();
        }
    }

    class Messages //usually each class is assigned a script
    {
        public static void Hello()
        {
            Console.WriteLine("Hello! Hapyy to be here");
        }

        public static void Waiting()
        {
            Console.WriteLine("I am waiting for something");
        }

        public static void Bye()
        {
            Console.WriteLine("Gotta go now. Goodbye!");
        }
    }
}
*/

//__________________________________
//Lesson 32: objects

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //object = an instance of a class
            //         a class can be used as a blueprint to create objects (OOP)
            //         objects can have fields and methods (characteristics & actions)

            Human human1 = new Human(); //human1 is defined as a new instance of Human() therefore Human human1 = new Human()
            Human human2 = new Human();

            human1.name = "Rick";
            human1.age = 65;

            human1.Eat();
            human1.Sleep();


            human2.name = "Morty";
            human2.age = 14;

            human2.Eat();
            human2.Sleep();

            Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}
*/

//__________________________________
//Lesson 33: constructors

/*
using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor = a special method in a class
            //              same name as the class name
            //              can be used to assign arguments to fields when creating an object 

            /*
            Human human1 = new Human("Rick", 65); //now parameters need to be passed
            Human human2 = new Human("Morty", 14); //works the same as in the last lesson
                                                   //no need to define the values manually

            //human1.name = "Rick"; //no need to define separately
            //human1.age = 65;

            human1.Eat();
            human1.Sleep();


            //human2.name = "Morty";
            //human2.age = 14;

            human2.Eat();
            human2.Sleep();
            

            Car car1 = new Car("Ford", "Mustang", "red",2022);
            Car car2 = new Car("Audi", "R6", "black", 2018);
            Car car3 = new Car("Mercedez", "Benz", "silver", 2020);

            car1.Drive();
            car2.Drive();
            car3.Drive();

            car1.Stop();
            car2.Stop();
            car3.Stop();

            Console.ReadKey();
        }
    }

    class Car
    {
        public string make;
        public string model;
        public string colour;
        public int year;

        public Car(string make, string model, string colour, int year)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {year} {make} {model}");
        }

        public void Stop()
        {
            Console.WriteLine($"You stop the {year} {make} {model}");
        }
    }

    /*class Human
    {
        public string name;
        public int age;

        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{name} is eating");
        }

        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}
*/

//__________________________________
//Lesson 34: static

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //static = modifier to declare a static member, which belongs to the class itself
            //         rather than to any object
            //         can be applied to a field, method or class itself

            Car car1 = new Car("Ford", "Mustang", "red", 2022);
            Car car2 = new Car("Audi", "R6", "black", 2018);
            Car car3 = new Car("Mercedez", "Benz", "silver", 2020);

            car1.Drive();
            car2.Drive();
            car3.Drive();

            car1.Stop();
            car2.Stop();
            car3.Stop();

            Car.StartRace(); //applies to all instances of the car, rather than idividually

            Console.ReadKey();
        }
    }

    class Car
    {
        public string make;
        public string model;
        public string colour;
        public int year;
        public static int numberOfCars; //to keep track of the number of cars 

        public Car(string make, string model, string colour, int year)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;

            numberOfCars++; //increment number of cars each time new Car is instantiated
                            //as opposed to counting instances of specific car models
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {year} {make} {model}");
        }

        public void Stop()
        {
            Console.WriteLine($"You stop the {year} {make} {model}");
        }

        public static void StartRace()
        {
            Console.WriteLine("The race has began");
        }
    }
}
*/

//__________________________________
//Lesson 35: overloaded constructors

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //overloaded constructors = technique to create multiple constructors,
            //                          with a different set of parameters
            //                          name + parameters = signature

            Pizza pizza1 = new Pizza("White", "Mayo", "American");



            Console.ReadKey();
        }
    }

    class Pizza
    {
        string bread;
        string sauce;
        string cheese;
        string topping;

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
        }

        public Pizza(string bread, string sauce, string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
        }
    }
}
*/

//__________________________________
//Lesson 36: inheritance 

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //inheritence = 1 or more child classes receiving fields, methods, etc. from a common parent 
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            boat.Go(); //inheriting has access to methods of the other class
            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle //Car class inherits its features from Vehicle class
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;

    }
}
*/

//__________________________________
//Lesson 37: abstract classes

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classes = modifier that indicates missing components or incomplete implementation


            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            //Vehicle vehicle = new Vehicle(); //unfinished class, incomplete implementation

            Console.ReadKey();
        }
    }

    abstract class Vehicle //precede the class with abstract
    {
        public int speed = 0;

        public void Go()
        {
            Console.WriteLine("This vehicle is moving");
        }
    }

    class Car : Vehicle //Car class inherits its features from Vehicle class
    {
        public int wheels = 4;
    }

    class Bicycle : Vehicle
    {
        public int wheels = 2;
    }

    class Boat : Vehicle
    {
        public int wheels = 0;

    }
}
*/

//__________________________________
//Lesson 38: array of objects

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //instead of this:
            //Car[] garage = new Car[3];

            //Car car1 = new Car("Mustang");
            //Car car2 = new Car("Ferrari");
            //Car car3 = new Car("Porche");

            //garage[0] = car1;
            //garage[1] = car2;
            //garage[2] = car3;

            //can write this
            Car[] garage = { new Car("Mustang"), new Car("Ferrari"), new Car("Porche") }; //does the same but less steps

            //Console.WriteLine(garage[0].model);
            //Console.WriteLine(garage[1].model);
            //Console.WriteLine(garage[2].model);

            //alternatively can write this
            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }

            Console.ReadKey();
        }
    }
    class Car 
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }
    }
}
*/

//__________________________________
//Lesson 39: objects as arguments

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mustang", "Red");

            Car car2 = Copy(car1);

            ChangeColour(car1, "silver");

            Console.WriteLine($"{car2.colour} {car2.model}");

            Console.ReadKey();
        }

        public static void ChangeColour(Car car, string colour)
        {
            car.colour = colour;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.model, car.colour);
        }
    }

    class Car
    {
        public string model;
        public string colour;

        public Car(string model, string colour)
        {
            this.model = model;
            this.colour = colour;
        }
    }
}
*/

//__________________________________
//Lesson 40: method overriding

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overriding = rovides a new version of a method inherited from a parent class
            //                    inherited methods must be: abstract, virtual, or already overriden
            //                    Used with ToString(), polymorphism

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Run();
            cat.Run();

            Console.ReadKey();
        }
    }

    class Animal
    {

        public virtual void Run() //for a method to be overriden needs to be virtual
        {
            Console.WriteLine($"The animal is running");
        }

        public void Stop()
        {
            Console.WriteLine($"The animal has stopped");
        }
    }

    class Dog : Animal
    {
 
    }

    class Cat : Animal
    {
        public override void Run() //to verride a method must put virtual before method type
        {
            Console.WriteLine("The cat looks at you, looks away and lies down to sleep");
        }
    }
}
*/

//__________________________________
//Lesson 41: ToString method

/*
namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToString = converts an object to its string representation so that its suitable to display 

            Console.ReadKey();
        }
    }

    class Car
    {
        string make;
        string model;
        string colour;
        int year;

        public Car(string make, string model, string colour, int year)
        {
            this.make = make;
            this.model = model;
            this.colour = colour;
            this.year = year;
        }

        public override string ToString()
        {
            //string message = $"This is a {make} {model}";
            //return base.ToString();

            //alternatively can simply
            return $"This is a {make} {model}";
        }
    }
}
*/

//__________________________________
//Lesson 42: polymorphism

/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism = Greek word that means to "have many forms"
            //               Objects can be identified by more than one type
            //               E.g. A Dog is also: Canine, Animal, Organism

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Vehicle[] vehicles = { car, bicycle, boat };

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }

    class Vehicle
    {
        public virtual void Go()
        {
            Console.WriteLine("The vehicle is going!");
        }
    }

    class Car : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!");
        }
    }

    class Bicycle : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!");
        }
    }

    class Boat : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The boat is moving!");
        }
    }
}
*/

//__________________________________
//Lesson 43: interfaces
/*
using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //interface = defines a contract that all the lasses inheriting from should follow
            //            An interface declares what class should have
            //            An inheriting class defines how it should do it

            //            Benefit = security + multiple inheritence + "plug and play"

            Rabbit rabbit = new Rabbit();
            Hawk hawk = new Hawk();
            Fish fish = new Fish();

            rabbit.Flee();
            hawk.Hunt();
            fish.Flee();
            fish.Hunt();

            Console.ReadKey();
        }
    }

    interface IPrey
    {
        void Flee();
    }

    interface IPredator
    {
        void Hunt();
    }

    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit is fleeing");
        }
    }

    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is preying");
        }
    }

    class Fish : IPrey, IPredator //can iinherit from multiple interfaces, separated with a coma
    {
        public void Flee()
        {
            Console.WriteLine("The fish is fleeing");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is preying");
        }
    }
}
*/

//__________________________________
//Lesson 44: lists
/*using System;
using System.Collections.Generic;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists = data structure that represents a list of objects that can be accessed by index.
            //        similar to array, but can dynamically increase/decrease in size BUT waste more memory
            //        sing.Systems.Collections.Generic;

            List<string> food = new List<string>(); //main difference with array
                                                    //can be changed once defined

            food.Add("Pizza"); //adds to the list 
            food.Add("Hamburger");
            food.Add("HotDog");
            food.Add("Pizza");

            //food.Remove("HotDog"); //removes from the list
            //food.Insert(0, "Sushi"); //adds object at a stated index
            //Console.WriteLine(food.Count()); //counts the list size
            //Console.WriteLine(food.IndexOf("Pizza")); //finds the index of object in list
            //Console.WriteLine(food.LastIndexOf("Pizza")); //finds the last index of object, useful of two objects
            //with the same name
            //Console.WriteLine(food.Contains("Pizza")); //will return a boolean to answer whether object is/isn't present
            //food.Sort(); //will sort the list in alphabetical order
            //food.Reverse(); //sorts food in the reverse order
            //food.Clear(); //clears the list

            //foreach (string snacks in food)
            //{
            //    Console.WriteLine(snacks);
            //}

            string[] foodArray = food.ToArray(); //converts list to Array

            foreach (string items in foodArray)
            {
                Console.WriteLine(items);
            }

            Console.ReadKey();
        }
    }
}
*/

//__________________________________
//Lesson 45: List of objects
using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            Player player1 = new Player("Chad");
            Player player2 = new Player("Jake");
            Player player3 = new Player("Tyler");

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);

            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            }

            Console.ReadKey();
        }
    }

    class Player
    {
        public string username;

        public Player(string username)
        {
            this.username = username;
        }
    }
}


//__________________________________
//Lesson
/*using System;

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.ReadKey();
        }
    }
}
*/