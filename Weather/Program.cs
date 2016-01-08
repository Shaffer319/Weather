using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
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

        static void Main(string[] args)
        {
            checkOpenWeatherAPI();
        }
    }
}
