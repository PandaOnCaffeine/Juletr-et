namespace Juletræet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I define the star and spaces that i need for the first line
            string stars = "*";
            string spaces = "       ";
            
            //I make a int sequence for later use, to get the right order of color
            int sequence = 0;

            //a for loop for the 8 lines
            for (int i = 0; i < 8; i++)
            {
                //a if to check what line its on
                if (i == 0 || i == 2 || i == 4 | i == 6 | i == 8) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{spaces}{stars}{spaces}");
                }
                else
                {
                    //a foreach loop to color every other start red
                    sequence = 0;
                    Console.Write($"{spaces}");
                    foreach (char star in stars)
                    {
                        if (sequence == 0 | sequence == 2 | sequence == 4 | sequence == 6 | sequence == 8 | sequence == 10 | sequence == 12| sequence == 14)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("*");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("*");
                            Console.ResetColor();
                        }
                        sequence++;
                    }
                    Console.Write($"{spaces}\r\n");
                }
                //some ifs and if else to remove spaces to match what each line has. stars too
                stars += "**";
                if (spaces == "       ")
                {
                    spaces = "      ";
                }
                else if (spaces == "      ")
                {
                    spaces = "     ";
                }
                else if (spaces == "     ")
                {
                    spaces = "    ";
                }
                else if (spaces == "    ")
                {
                    spaces = "   ";
                }
                else if (spaces == "   ")
                {
                    spaces = "  ";
                }
                else if (spaces == "  ")
                {
                    spaces = " ";
                }
                else
                {
                    spaces = "";
                }
            }
            Console.Read();
        }
    }
}