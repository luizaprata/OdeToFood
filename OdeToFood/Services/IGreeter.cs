using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Greeter : IGreeter
    {
        private IConfiguration _configuration;

        public Greeter(IConfiguration conf)
        {
            _configuration = conf;
        }
        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}