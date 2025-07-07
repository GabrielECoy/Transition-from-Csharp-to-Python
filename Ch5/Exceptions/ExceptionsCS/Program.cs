// Code example file for Python for the C# Developer LinkedIn Learning Course by Joe Marini

using System;

namespace ExceptionsCS
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            //object c = null;

            try
            {
                if (a > 20)
                    throw new ArgumentOutOfRangeException(paramName: "a", message: "The numerator can't be larger than 20!");
                int x = a / b;
                //int y = (int)c;

                Console.WriteLine("Result is {0}", x);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Tried to divide by zero!");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("This code always runs");
            }
        }
    }
}
