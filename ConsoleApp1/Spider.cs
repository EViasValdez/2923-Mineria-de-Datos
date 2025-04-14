using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Spider
    {
        #region Constructor
        /// <sumary
        /// constructor vacio
        /// </sumary
        /// 

        public Spider() { }

        #endregion

        #region Metodos

        public async Task<List<Car>> start {
            var url = "";
            var httpclient = new HttpClient();
            var html = await httpclient.GetStringAsync(Url);
            var htmldocument = new HtmlDocument();
            htmldocument.LoadHtml(html);
            var cars = new List<Car>();
            var divs = htmlDocument.DocumentNode.Descendats("div").Where(node.GetAttributeValue("class", "").Equals("")).ToList();
        }
    }
}