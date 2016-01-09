using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static String API_KEY = "";
        static void checkOpenWeatherAPI()
        {
            String query = "http://api.openweathermap.org/data/2.5/weather?q=London";
            WebClient socket = new WebClient();

            try
            {
                String ret;
                ret = socket.DownloadString(query);
                //ret = socket.(query);
                System.Console.WriteLine(ret);
            }
            catch (Exception e)
            {
                System.Console.Error.WriteLine(e);
            }

            System.Console.ReadKey();

        }

        static bool b_running = true;

        static void cancelHandler(object sender, ConsoleCancelEventArgs args)
        {
            args.Cancel = false;
            b_running = false;
        }

        static bool getAPIKey()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader("API_KEY.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    API_KEY = sr.ReadToEnd();
                   
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return false;
        }

        static void Main(string[] args)
        {
            System.Console.CancelKeyPress += cancelHandler;

            checkOpenWeatherAPI();
        }
    }
}
