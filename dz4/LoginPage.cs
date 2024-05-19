using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    public interface LoginPage
    {
        WebElement loginButton();
        WebElement usernameInput();
        WebElement passwordInput();
    }
}
