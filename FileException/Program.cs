public class Program
{
    public static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("C:\\Users\\Neeraj Potlapalli\\Documents\\Assignment-3.txt"))
            {
                reader.ReadToEnd();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File was not found check with file name");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("you doesn't have access to that file");
        }
        catch (FormatException)
        {
            Console.WriteLine("data is in invalid format");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}