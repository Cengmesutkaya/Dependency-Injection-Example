using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Ceket : IGiyin
    {
        public string Giyin()
        {
            return "Resmi veya özel günlerde Ceket giy.";
        }
    }
}