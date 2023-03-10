namespace ExceptionHandling;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number is : " + number); 
        }
        catch(Exception ex)
        {
            Console.WriteLine("Exception is : " + ex.Message.ToString());
        }
        finally
        {
           Console.WriteLine("process completed");
        }

        //-------

        try
        {
            int x = int.Parse(null);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Value cannot be null.");
            Console.WriteLine(ex);            
        }

        //-------
        
        try
        {
            int x = int.Parse("test");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Input was not a correct format.");
            Console.WriteLine(ex);            
        }

        //-------

        try
        {
            int x = int.Parse("4584561548793");
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Value is too small or too large");
            Console.WriteLine(ex);            
        }

        //-------

        try
        {
            int x = 4;
            int y = 0;
            int f = x / y;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Value cannot be divided by zero");
            Console.WriteLine(ex);            
        }
    }
}
