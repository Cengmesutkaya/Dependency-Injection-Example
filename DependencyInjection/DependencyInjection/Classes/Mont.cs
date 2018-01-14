using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Mont:IGiyin
    {
        public string Giyin()
        {
            return "Yağmurlu ve soğuk günlerde hırka giyin.";
        }
    }
}