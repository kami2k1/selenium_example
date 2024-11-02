
using Kami.app;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kami.script
{
    public class yt
    {

        public Chrome chrome;
        public yt(Chrome chrome) { 
            this.chrome = chrome;
        
        }
        public async Task upshort()
        {
            this.chrome.getwed("https://studio.youtube.com/");
            Thread.Sleep(200);
            this.chrome.find_Css("a[test-id='upload-icon-url']"); // 
           
            this.chrome.click();
            this.chrome.find_text_contains("Tải video lên");
            this.chrome.click();
            string path = @"C:\data_lam_game\zalo\YT_MMO\data\44.mp4";
            this.chrome.inputfie(path);
            Thread.Sleep(10 * 1000);
            this.chrome.find_id("textbox");
            string tieudevideo = " gái xinh #12  #xuhuongtiktok #flowsport #dance #gir #shots #cosplay #beautiful #animefyp #beauty";
                if (tieudevideo.Length > 100)
            {
                tieudevideo = tieudevideo.Substring(0, 100); 
               this.chrome.print("Chuỗi đã được cắt xuống còn 100 ký tự: " + tieudevideo);
            }
            else
            {
                this.chrome.print("Kí tự không voutwj quá 100 ký tự ");
            }
            this.chrome.input_dilay(tieudevideo);
           // this.chrome.Scronll(400, 0);
            this.chrome.find_Css("ytkc-made-for-kids-select");
            this.chrome.Even.FindElement(By.XPath(".//tp-yt-paper-radio-button[2]")).Click();

            this.chrome.find_id("step-badge-3"); 
            this.chrome.click();
            Thread.Sleep(200);
            this.chrome.find_Xpath("//tp-yt-paper-radio-button[@name='PUBLIC']");
            this.chrome.click();
            this.chrome.find_id("done-button");
            this.chrome.click();

        }
    }
}
