using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public class ChromeLoginPage : LoginPage
    {
        public WebElement loginButton()
        {
            return new WebElement("Chrome login button");
        }

        public WebElement usernameInput()
        {
            return new WebElement("Chrome username input");
        }

        public WebElement passwordInput()
        {
            return new WebElement("Chrome password input");
        }
    }
}
