namespace Juletræet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //I define the star and spaces that i need for the first line
            string stars = "*";
            string spaces = "       ";

            //a for loop for the 8 lines
            for (int i = 0; i < 8; i++)
            {
                //a if to check what line its on
                if (i %2 == 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{spaces}{stars}{spaces}");
                }
                else
                {
                    //a foreach loop to color every other star red
                    Console.Write($"{spaces}");
                    int starvalue = 0;
                    foreach (char star in stars)
                    {
                        if (starvalue %2 == 0)
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
                        starvalue++;
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