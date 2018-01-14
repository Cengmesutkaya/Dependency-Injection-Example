using DependencyInjection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            Insan insan = new Insan(new Ceket());
            Insan insan1 = new Insan(new Hırka());
            Insan insan2 = new Insan(new Mont());

            StringBuilder sb = new StringBuilder();
            sb.Append("Ceket Sınıfı Çağrılınca: " + insan.Yaz());
            sb.Append("<br>");
            sb.Append("Hırka Sınıfı Çağrılınca: " + insan1.Yaz());
            sb.Append("<br>");
            sb.Append("Mont Sınıfı Çağrılınca: " + insan2.Yaz());
            var result = sb.ToString();
            return result;
        }
    }
}