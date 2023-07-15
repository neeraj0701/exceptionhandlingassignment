using System.Net;

namespace NetworkCommunicationException
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                WebClient client = new WebClient();
                string response = client.DownloadString("https://api.example.com");
                Console.WriteLine("Response: " + response);
            }
            catch (WebException e)
            {
                if (e.Status == WebExceptionStatus.Timeout)
                {
                    Console.WriteLine("Connection timeout. Retrying...");
                }
                else if (e.Status == WebExceptionStatus.NameResolutionFailure)
                {
                    Console.WriteLine("DNS resolution failure. Switching to alternative server...");
                }
                else if (e.Status == WebExceptionStatus.ConnectFailure)
                {
                    Console.WriteLine("Connection failure. Checking network connectivity...");
                }
                else
                {
                    Console.WriteLine("WebException occurred: " + e.Message);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}