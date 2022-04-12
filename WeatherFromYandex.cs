using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class WeatherFromYandex
    {
        public string GetWeather()
        {
            SiteParser parser = new SiteParser();
            string site = parser.GetHTML("https://yandex.ru");
            int index = site.IndexOf("weather__content");
            if (index == -1)
                return "Ошибка чтения!";
            site = site.Remove(0, index + 18);
            index = site.IndexOf("aria-label");
            site = site.Remove(0, index + 12);
            index = site.IndexOf("\"");
            site = site.Remove(index);
            return site;

        }
    }
}
