using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Hırka:IGiyin
    {
        public string Giyin()
        {
            return "Rüzgarlı günlerde hırka giyin.";
        }
    }
}