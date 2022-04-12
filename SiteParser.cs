using System.Net;
using System.IO;

namespace WindowsFormsApp4
{
    class SiteParser
    {
       public string GetHTML(string URL)
        {
            // запрос серверу на показ сайта
            WebRequest webRequest = WebRequest.Create(URL);
            //Ответ от сервера приходит в WebResponse
            WebResponse webResponse = webRequest.GetResponse();
            // Ответ от сервера получаем в ввиде потока данных Stream
            Stream stream = webResponse.GetResponseStream();
            //Поток обрабатываем при помощи StreamReader
            StreamReader reader = new StreamReader(stream);
            // Читаем весь поток данных в переменную string
            string site = reader.ReadToEnd();
            return site;
        }
    }
}
