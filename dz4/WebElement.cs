using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class WebElement
    {
        private string name;

        public WebElement(string name)
        {
            Console.WriteLine($"Found {name}");
            this.name = name;
        }

        public void Click()
        {
            Console.WriteLine($"Clicked {name}");
        }
    }
}
