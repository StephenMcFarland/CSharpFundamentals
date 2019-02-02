using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Class_Example
{
    //Utilize Enum
    public enum CookieType { Chocolate, Sugar, Snickerdoodle, Gingersnap }
    //Challenge Create A Thanksgiving Dinner Object with Properties test the properties 
    public class Cookie
    {
        public string Name { get; set; }
        public CookieType Type { get; set; }
        public int BatchSize { get; set; }
        public bool GlutenFree { get; set; }
    }
}
