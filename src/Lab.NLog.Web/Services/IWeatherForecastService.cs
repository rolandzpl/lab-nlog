using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lab.NLog.Web.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecast();
    }
}
