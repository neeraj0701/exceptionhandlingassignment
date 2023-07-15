namespace InputException
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter an input");

            try
            {
                string userInput = Console.ReadLine();
                int value = Int32.Parse(userInput);
                Console.WriteLine(value);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter the correct input of integer type");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

