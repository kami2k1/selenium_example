
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
        public int sartfifle, endfile;
        public yt(Chrome chrome , int sartfile , int endfile) {
            this.sartfifle = sartfile; 
            this.endfile = endfile;
            this.chrome = chrome;
        
        }
        public async Task Runing()
        {
            chrome.print($"Cb Úp Sau 5s nữa  {this.sartfifle}  cuối file {this.endfile}");
            for (int i = 0; i <=5; i++)

            {

                await Task.Delay(1000);
            }
            for (int i = this.sartfifle; i < this.endfile + 1; i++)
            {
                this.chrome.print($"Bắt Đầu Úp FIle {i}");
                upshort(i);
                this.chrome.print($"đã Úp Xong  FIle Id {i}");
                await Task.Delay(60 * 60 * 1000);
                // 1000 = 1 phút * 60s + 60 = 1 Tiếng 
            }
            chrome.print("done");
            Chrome.KillChrome(-1);

        }

        public async void upshort(int idfile )
        {
            this.chrome.getwed("https://studio.youtube.com/");
            await Task.Delay(200);
            this.chrome.find_Css("a[test-id='upload-icon-url']"); // 
            await Task.Delay(20000);
            this.chrome.click();
            this.chrome.find_text_contains("Tải video lên");
            this.chrome.click();
            string path = $@"C:\data_lam_game\zalo\YT_MMO\data\{idfile}.mp4";
            this.chrome.inputfie(path);
            await Task.Delay(10000);
            this.chrome.find_id("textbox");
            string tieudevideo = $" gái xinh host tiktok #{idfile}  #xuhuongtiktok #flowsport #dance #gir #shots #cosplay #beautiful #animefyp #beauty";
            if (tieudevideo.Length > 100)
            {
                tieudevideo = tieudevideo.Substring(0, 100);
                this.chrome.print("Chuỗi đã được cắt xuống còn 100 ký tự: " + tieudevideo);
            }
            else
            {
                this.chrome.print("Kí tự không voutwj quá 100 ký tự ");
            }
            if (!this.chrome.input_dilay(tieudevideo))
            {
                bool dev = true;
                while (dev)
                {
                    this.chrome.find_id("textbox");
                    if (this.chrome.input_dilay(tieudevideo))
                    {
                        dev = false;
                    }
                    await Task.Delay(1000);

                }
            }
            // this.chrome.Scronll(400, 0);
            this.chrome.find_Css("ytkc-made-for-kids-select");
            this.chrome.Even.FindElement(By.XPath(".//tp-yt-paper-radio-button[2]")).Click();

            this.chrome.find_id("step-badge-3");
            this.chrome.click();
            await Task.Delay(200);
            this.chrome.find_Xpath("//tp-yt-paper-radio-button[@name='PUBLIC']");
            this.chrome.click();
            await Task.Delay(3000);
            this.chrome.find_id("done-button");
            this.chrome.click();
            this.chrome.find_id("close-button");
            this.chrome.click();
            await Task.Delay(1000);
            this.chrome.getwed("https://studio.youtube.com/");
            await Task.Delay(1000);
            this.chrome.find_id("go-to-video-analytics-button");
            this.chrome.click();

        }
    }
}
