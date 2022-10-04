using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cant divide by zero");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Arithmetic exception");
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error");
            }
        }
    }
}