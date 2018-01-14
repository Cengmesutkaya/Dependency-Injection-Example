using DependencyInjection.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Classes
{
    public class Insan
    {
        IGiyin _giyin;

        public Insan(IGiyin giyin)
        {
            _giyin = giyin;
        }

        public string Yaz()
        {
            return _giyin.Giyin();
        }

    }
}