using HtmlAgilityPack;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SpiderDemo.Models
{
    public class Spider
    {
        public Spider() { } 
        public  async Task<List<Car>> Start()
        {

            //the url of the page we want to test
            var url = "https://listado.mercadolibre.com.mx/consolas#D[A:consolas]";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            // a list to add all the list of cars and the various prices 
            var cars = new List<Car>();
            var divs =
            htmlDocument.DocumentNode.Descendants("div")
                .Where(node => node.GetAttributeValue("class", "").Equals("ui-search-price__second-line shops__price-second-line")).ToList();

            foreach (var div in divs)
            {

                var car = new Car
                {

                    Price = div.Descendants("span").FirstOrDefault().InnerText,
                    //Model = div.Descendants("h2").FirstOrDefault().InnerText,
                    //Link = div.Descendants("a").FirstOrDefault().ChildAttributes("href").FirstOrDefault().Value,
                    //ImageUrl = div.Descendants("img").FirstOrDefault().ChildAttributes("src").FirstOrDefault().Value
                };

                cars.Add(car);
            }      
            return cars;
        }
    }
}