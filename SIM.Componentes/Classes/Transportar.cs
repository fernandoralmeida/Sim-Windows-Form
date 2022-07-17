using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sim.Classes
{
    public static class Transportar
    {

        public static string getURL;

        public static string Url(string vurl)
        {
            getURL = vurl;
            getURL = getURL.Replace("/", @"/");
            return getURL;
        }

        public static string UrlAtiva()
        {
            return getURL;
        }
        
    }
}
