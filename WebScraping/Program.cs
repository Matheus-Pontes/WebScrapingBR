using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebScraping
{   
    public class Program 
    {

        private static void Main(string[] args)
        {
            string path = System.AppDomain.CurrentDomain.BaseDirectory.ToString();

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("user-data-dir=" + path + "ChromeDriver\\Cache");
            ChromeDriver driver = new ChromeDriver(path, options);

            SearchFirstFiveBRLeague(driver, "https://www.google.com/search?q=tabela+brasileir%C3%A3o+2022&oq=ta&aqs=chrome.0.69i59j69i57j35i39j0i131i433i512j46i131i199i433i465i512j69i60l3.1353j0j9&sourceid=chrome&ie=UTF-8");            
        } 

        public static void SearchFirstFiveBRLeague(ChromeDriver driver, string URL) 
        {
            BrasileiraoService brService = new BrasileiraoService();

            driver.Navigate().GoToUrl(URL);

            var posicoes = driver.FindElements(By.CssSelector(".iU5t0d")).Where(i => i.Text != "").ToList();
            var nomes = driver.FindElements(By.ClassName("hsKSJe")).ToList();
            var pontos = driver.FindElements(By.CssSelector(".e9fBA.xkW0Cc.snctkc")).ToList();
           
            brService.registrarTimes(posicoes, nomes, pontos);
            
            driver.Quit();
        }
    }
}
