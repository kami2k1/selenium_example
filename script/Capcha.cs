using Kami.app;
using OpenQA.Selenium.DevTools.V128.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kami.script
{
    public class Capcha
    {
        public Chrome chrome;
        public Capcha( Chrome chrome)
        {
            this.chrome = chrome;
        }
        public async Task uncapcha(string Link)
        {
            chrome.getwed(Link);
            while (true)
            {

                chrome.find_Xpath("//input[@type='checkbox']");
                chrome.click();
                await Task.Delay(400);
            }

        }
    }
}
