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

/*namespace MyCsProgram
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

/*namespace MyCsProgram
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

/*namespace MyCsProgram
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

// __________________________________
//Lesson 6: user input

namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            Console.ReadKey();
        }
    }
}

// __________________________________
//Lesson

/*namespace MyCsProgram
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}*/