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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Web;


namespace Kami.app
{
    public class Chrome

    {
        public static List<Chrome> Chromes = new List<Chrome>();
        public static int ids = 0;
        public static bool  chromeruing;
        public Form1 log;
        public IWebElement Even;
        public Random random = new Random();
        public Proxy proxy;
        public int id;
        public IWebDriver driver; 
        public Chrome(Form1 log, int profile, proxy _proxy = null, string pathprofile = null )
        {
            try
            {
                Chrome.ids++;

                //Form1 log = new Form1();
                ////log.Show();
                this.log = log;
                this.id = Chrome.ids;
                string file;
                if (profile == 0)
                {
                    file = "Default";
                }
                else
                {
                    file = $"Profile {profile}";
                }

                if (!Chrome.chromeruing)
                {
                    this.killchrome();

                }
                string userDataDir = pathprofile;
                if (pathprofile == null)
                {

                    userDataDir = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), @"AppData\Local\Google\Chrome\User Data");
                }

                print(userDataDir + file);
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--silent");
                options.AddArgument("--log-level=3");
                options.AddArgument($"user-data-dir={userDataDir}");
                options.AddArgument($"profile-directory={file}");
                options.AddArgument("--disable-blink-features=AutomationControlled");
                int port = 9222 + profile; // tạo cổng dựa trên id của profile hoặc một số duy nhất khác
                options.AddArgument($"--remote-debugging-port={port}");

                options.AddExcludedArgument("enable-automation");
                options.AddExcludedArgument("enable-logging");
                if (_proxy != null)
                {
                    if (_proxy.type == "soc")
                    {
                        print("proxy đạng socks");
                        string socks5Proxy;
                        if (_proxy.Usename == null && _proxy.password == null)
                        {
                            socks5Proxy = $"socks5://{_proxy.ip}:{_proxy.port}";
                            options.AddArgument("--proxy-server=" + socks5Proxy);



                        }
                        else
                        {







                        }



                    }
                    else
                    {
                        options.AddArgument($"--proxy-server={_proxy.ip}:{_proxy.port}");

                        if (!string.IsNullOrEmpty(_proxy.Usename) && !string.IsNullOrEmpty(_proxy.password))
                        {
                            try
                            {
                                string proxyex = _proxy.extensonproxy(this);

                                options.AddExtension(proxyex);
                            }
                            catch (Exception e)
                            {
                                print($"lỗi tại hàm {e}");
                            }
                        }
                    }

                }


                try
                {
                    if (Chrome.chromeDriverService == null)
                    {
                        Chrome.CreaterChromedriver();
                    }
                    this.driver = new ChromeDriver(Chrome.chromeDriverService, options);
                    IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                    jsExecutor.ExecuteScript("Object.defineProperty(navigator, 'webdriver', {get: () => undefined})");
                    Chrome.Chromes.Add(this);
                }
                catch (Exception ex)
                {
                    print("Lỗi Chi Tiết tại " );
                }
                print($"khởi tạo thành công rồi Chrome id {this.id}");
            }catch(Exception ex)
            {
                print($"lỗ tại {ex}");
            }
        }
        public  static  ChromeDriverService chromeDriverService;
        public  static void CreaterChromedriver()
        {
            try
            {

                if (chromeDriverService == null)
                {
                   chromeDriverService = ChromeDriverService.CreateDefaultService();
                    chromeDriverService.SuppressInitialDiagnosticInformation = true;
                    chromeDriverService.LogPath = System.IO.Path.Combine(Environment.CurrentDirectory, "chromedriver.log");
                    chromeDriverService.HideCommandPromptWindow = true;

                }

            }
            catch (Exception ex)
            {
               
            }
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
                    return;
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
            //try
            //{
                //Actions actions = new Actions(this.driver);
                //actions.MoveToElement(this.Even).Perform();
                string js_code = "arguments[0].scrollIntoView();";
                IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
                jsExecutor.ExecuteScript(js_code, this.Even);
            //}catch ( Exception ex)
            //{
            //    print($" Lỗi tại Hàm Cuộn điến Phần Tử Chi tiết Lỗi {ex}");
            //}
        }

        public void Scronll(int y = 250, int x=  0) // cuộn theo px niếu y > 0 thì cuộn xuống niếu y < 0 thì cuộn lên
        {
            string js_code = $"window.scrollBy({x},{y})";
            IJavaScriptExecutor jsExecutor = (IJavaScriptExecutor)driver;
            jsExecutor.ExecuteScript(js_code);
                            
        }
        public void find_Xpath(string xpath)
        {
            this.find(9, xpath);
        }
        public void find(int id, string text)
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
        public bool input_dilay(string data ,int clean = 0 , int  dilay = 1)
        {
            if (this.Even == null) return false;
            if (clean == 0) 
            this.Even.Clear(); 
            
            for (int i = 0; i < data.Length; i++)
            {
                this.Even.SendKeys(data[i].ToString());

                if (dilay != 0)
                {
                    Thread.Sleep(dilay * 100);
                }


            }
            return true;

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
            if (log.InvokeRequired)
            {
               
                log.Invoke((MethodInvoker)(() => log.log(text)));
            }
            else
            {
              
                log.log(text);
            }
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
        public static void KillChrome(int chromeId = -1, Chrome chromeInstance = null)
        {
            if (chromeInstance != null)
            {
               
                chromeInstance.driver.Quit();
                chromeInstance = null;
            }
            else if (chromeId >= 0)
            {
               
                for (int i = Chrome.Chromes.Count - 1; i >= 0; i--)
                {
                    var ch = Chrome.Chromes[i];
                    if (ch.id == chromeId)
                    {
                        ch.driver.Quit();

                        Chrome.Chromes.RemoveAt(i);
                        ch = null;
                        break; 
                    }
                }
            }
            else
            {
                
                for (int i = Chrome.Chromes.Count - 1; i >= 0; i--)
                {
                    var ch = Chrome.Chromes[i];
                    ch.driver.Quit();
                    Chrome.Chromes.RemoveAt(i);
                    ch = null;
                }
            }
        }

    }

}
