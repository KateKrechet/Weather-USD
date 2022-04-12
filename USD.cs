using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class USD
    {
        public string getUSD()
        {
            SiteParser siteParser = new SiteParser();
            string site = siteParser.GetHTML("https://www.cbr.ru/currency_base/daily/");
            int index = site.IndexOf("Доллар США");
            if (index != -1)
                return "Ошибка!";
            site = site.Remove(0, index);
           index = site.IndexOf("<td>");
            site = site.Remove(0, index + 4);
            index = site.IndexOf("</td>");
            site = site.Remove(index);
            return site;
            
        }
    }
}
