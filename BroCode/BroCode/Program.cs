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

            //for(int i = 0; i < 10; i++) //first condition indicates where to start, second condition indicates when to stop
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

using System;

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
                    Console.WriteLine("Guess a number between " + min + " " + max + " : ");
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

                    guess++;
                }
                Console.WriteLine("Number :" + number);
                Console.WriteLine("You win!");
                Console.WriteLine("Guesses + " + guesses);

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
}*/