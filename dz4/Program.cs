namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunOne();
            RunTwo();
        }

        public static void RunOne()
        {
            IMailConstructor mailConstructor = new MailConstructor();
            SMTP smtp = new SMTP(mailConstructor);

            smtp.SendNoReplyMail();
        }

        public static void RunTwo()
        {
            LoginPageFactory factory = new ChromeLoginPageFactory();
            LoginPage loginPage = factory.CreatePage();

            WebElement loginButton = loginPage.loginButton();
            loginButton.Click();

            WebElement usernameInput = loginPage.usernameInput();
            usernameInput.Click();

            WebElement passwordInput = loginPage.passwordInput();
            passwordInput.Click();
        }
    }
}