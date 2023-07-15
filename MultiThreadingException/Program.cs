namespace MultiThreadingException
{
    public class Program
    {
        public static void Main()
        {
            Thread backgroundThread = new Thread(BackgroundTask);
            backgroundThread.Start();
            Console.WriteLine("Main thread is doing some work...");
            backgroundThread.Join();
        }

        public static void BackgroundTask()
        {
            Console.WriteLine("Background thread is doing some work...");

            try
            {
                string input = Console.ReadLine();
                int value = Int32.Parse(input);
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
