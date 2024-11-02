using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Windows.Forms;


namespace Kami.app
{
    public class Chrome
    {
        public static bool  chromeruing;
        public Form1 log;
        public IWebElement Even;
        public Random random = new Random();

        public int id;
        public IWebDriver driver; 
        public Chrome(int id , int profile )
        {
            Form1 log = new Form1();
            log.Show();
            this.log = log;
            this.id = id;
            string file;
            if (profile == 0)
            {
                file = "Default";
            } else {
                file = $"Profile {profile}";
            }

            if (!Chrome.chromeruing)
            {
                this.killchrome();
            }

            string userDataDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\Local\Google\Chrome\User Data");

            // Khởi tạo ChromeOptions
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--no-sandbox");
            //options.AddArgument("--disable-gpu");
            options.AddArgument($"user-data-dir={userDataDir}"); 
            options.AddArgument($"profile-directory={file}"); 
            options.AddArgument("--disable-blink-features=AutomationControlled");
            options.AddArgument("--remote-debugging-port=9222");
            options.AddExcludedArgument("enable-automation");
            options.AddExcludedArgument("enable-logging");
            this.driver = new ChromeDriver(options);
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript("Object.defineProperty(navigator, 'webdriver', {get: () => undefined})");
        }
        public void getwed(string link)
        {
            try
            {
                this.driver.Navigate().GoToUrl(link);
                print($"oke ->: {link}");



            }
            catch (Exception ex)
            {
                print($" có lỗi xảy ra tại hàm mở web chi tiết lỗi xem tại đây : \n {ex} ");
            }

        }
        public void find_text(string text)
        {
            this.find(0, text);
        }
        public void find_text_contains(string text)
        {
            this.find(1, text);
        }
        public void find_text_starts_with(string text)
        {
            this.find(2, text);
        }
        public string getTextEven() // trả text được trỏ vào 
        {
            if (this.Even == null) return "";
            return this.Even.Text; 
            
        }
        public void click()
        {
            try
            {
                if (this.Even == null)
                {
                    print("lỗi khồn có phần tử");
                }
                this.Even.Click();
                print("đã nhấp vào phần tử ");
            }catch (Exception e)
            {
                print($"có lỗi xảy ra chi Tiết Lỗi tại \n {e}");
            }
        }
        public void inputfie(string path)
        {
            this.clear();
             this.Even = driver.FindElement(By.CssSelector("input[type='file']"));


            this.Even.SendKeys(path);
        }
        public void find_id(string id)
        {
            this.find(3,id);
        }
        public void find_name(string name)
        {
            this.find(4,name);
        }
        public void find_clasname(string nameclass)
        {
            this.find(5,nameclass);
        }
        public void find_tagname(string name)
        {
            this.find(6,name); //Tìm phần tử qua tên thẻ HTML (ví dụ: input, div, button).

        }
        public void find_linktext(string text)
        {
            this.find(7,text); // tịm phần tử của thẻ <a> văn bản được hiển thị của thẻ a 
        }
        public void find_Css(string css)
        {
            this.find(8, css);

        }
        public string gettille()
        {
            return this.driver.Title;
        }
        public string geturlhome()
        {
            return this.driver.Url;
        }
        public void Scroll_Even() // cuộn chuột điến phần tử 
        {
            if (this.Even == null) return;
            Actions actions = new Actions(this.driver);
            actions.MoveToElement(this.Even).Perform();

        }
        public void Scronll(int y , int x=  0) // cuộn theo px niếu y > 0 thì cuộn xuống niếu y < 0 thì cuộn lên
        {
            int viewportHeight = (int)((IJavaScriptExecutor)driver).ExecuteScript("return window.innerHeight");
            int viewportWidth = (int)((IJavaScriptExecutor)driver).ExecuteScript("return window.innerWidth");
            int middleX = viewportWidth / 2;
            int middleY = viewportHeight / 2;

            Actions actions = new Actions(this.driver);
            int steps = 20;
            int stepY = y / steps;
            int stepX = x / steps;

            for (int i = 0; i < steps; i++)
            {
                actions.MoveByOffset(middleX, middleY) // Di chuyển đến giữa màn hình
                       .ScrollByAmount(stepX, stepY) // Cuộn
                       .Perform();

                int dilay = 200 + random.Next(i, 100 + i);
                Thread.Sleep(dilay);
            }
        }
        public void find_Xpath(string xpath)
        {
            this.find(9, xpath);
        }
        private void find(int id, string text)
        {
            clear();
            try
            {
                switch (id)
                {
                    case 0: // text ==
                        Even = driver.FindElement(By.XPath($"//*[text()='{text}']"));
                        break;
                    case 1: // text contains
                        Even = driver.FindElement(By.XPath($"//*[contains(text(), '{text}')]"));
                        break;
                    case 2: // text starts_with
                        Even = driver.FindElement(By.XPath($"//*[starts-with(text(), '{text}')]"));
                        break;
                    case 3: // tìm bằng id
                        Even = driver.FindElement(By.Id(text));
                        break;
                    case 4: // tìm bằng name
                        Even = driver.FindElement(By.Name(text));
                        break;
                    case 5: // tìm bằng class
                        Even = driver.FindElement(By.ClassName(text));
                        break;
                    case 6: // tìm bằng tag
                        Even = driver.FindElement(By.TagName(text));
                        break;
                    case 7: // tìm bằng link text
                        Even = driver.FindElement(By.LinkText(text));
                        break;
                    case 8: // tìm bằng CSS selector
                        Even = driver.FindElement(By.CssSelector(text));
                        break;
                    case 9: // tìm bằng XPath
                        Even = driver.FindElement(By.XPath(text));
                        break;
                }
            }
            catch (NoSuchElementException ex)
            {
                print($"Lỗi không tìm thấy phần tử: {ex.Message}");
                Even = null; 
            }
            catch (Exception ex)
            {
                print($"Lỗi: {ex.Message}");
            }

            if (Even == null)
            {
                print($"Lỗi không tìm thấy phần tử {text}");
            }
            else
            {
                print("Đã tìm thấy phần tử");
            }
        }
        public void input_dilay(string data ,int clean = 0 , int  dilay = 1)
        {
            if (clean == 0)  this.Even.Clear(); 
            
            for (int i = 0; i < data.Length; i++)
            {
                this.Even.SendKeys(data[i].ToString());

                if (dilay != 0)
                {
                    Thread.Sleep(dilay * 100);
                }


            }


        }
        public void clear()
        {
            if (this.Even != null)
            {
                this.Even = null;
            }
        }
        public void print(string text)
        {
            log.log(text);
        }
        public  void killchrome()
        {
            Process[] chromeProcesses = Process.GetProcessesByName("chrome");

            // Nếu có bất kỳ tiến trình nào, tắt chúng
            if (chromeProcesses.Length > 0)
            {
                foreach (Process process in chromeProcesses)
                {
                    process.Kill(); // Tắt tiến trình
                }
               print("Đã tắt tất cả phiên bản Chrome đang chạy.");

            }
            else
            {
                print("Không tìm thấy phiên bản Chrome nào đang chạy.");
            }
            Chrome.chromeruing = true;
        }
    }
    
}
