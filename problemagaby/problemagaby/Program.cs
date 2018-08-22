using System;
namespace InputValidation
{
    class PasswordValidator
    {
        static void Main(string[] args)
        {
            int l = 6;//CONSREAD +2
            for (int i = 0; i < l; i++)//LINIA  
            {
                for (int j = 0; j < l; j++)//coloana    
                {
                    if (i == 0 || i == l - 1)
                    {
                        if (j == 0 || j == l - 1)
                        {
                            Console.Write('+');
                        }
                        else
                        {
                            Console.Write('-');
                        }
                    }
                    else
                    {
                        if (j == 0 || j == l - 1)
                        {
                            Console.Write('|');
                        }
                        else
                        {
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
