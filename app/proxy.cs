using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V128.DOM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SocksSharp;


namespace Kami.app
{
    public class proxy
    {

        //public static List<SocksSharp> clients = new List<SocksSharp>();
        public string ip, Usename, password;

        public int port;
      public   string type;
        public proxy( string ip , int port ,string type , string Usename = null , string password = null)
        {
            this.ip = ip;
            this.port = port;
            this.Usename = Usename; 
            this.password = password;
this.type = type;

        }
       

        //public async string socks5_authu()
        //{
        //    var socks5Client = new Socks5Client(host, port, username, password);

        //}
        public string extensonproxy(Chrome C)
        {
            // Tạo thư mục tạm với tên "ProxyAuthExtension"
            var tempDir = Path.Combine( "ProxyAuthExtension");
            if (!Directory.Exists(tempDir))
            {
                Directory.CreateDirectory(tempDir);
            }

            // Tạo tên file ngẫu nhiên với định dạng .zip
            var zipFileName = "ProxyAuthExtension_" + Guid.NewGuid().ToString() + ".zip";
            var zipPath = Path.Combine(Path.GetTempPath(), zipFileName);

            // Tạo nội dung của manifest.json
            var manifestContent = @"{
        'manifest_version': 2,
        'name': 'Proxy Auth Extension',
        'version': '1.0',
        'permissions': ['webRequest', 'webRequestBlocking', '<all_urls>'],
        'background': {
            'scripts': ['background.js']
        }
    }".Replace("'", "\"");

            File.WriteAllText(Path.Combine(tempDir, "manifest.json"), manifestContent);

            // Tạo nội dung của background.js
            var backgroundContent = $@"
    var proxyAuth = {{
        username: '{this.Usename}',
        password: '{this.password}'
    }};

    chrome.webRequest.onAuthRequired.addListener(
        function(details) {{
            return {{
                authCredentials: {{ username: proxyAuth.username, password: proxyAuth.password }}
            }};
        }},
        {{ urls: ['<all_urls>'] }},
        ['blocking']
    );
    ";

            File.WriteAllText(Path.Combine(tempDir, "background.js"), backgroundContent);
            C.print($"path là, {tempDir}");

            // Xóa file .zip nếu đã tồn tại
            if (File.Exists(zipPath))
            {
                File.Delete(zipPath);
            }

            // Nén thư mục thành file .zip
            System.IO.Compression.ZipFile.CreateFromDirectory(tempDir, zipPath);

            return zipPath; // Trả về đường dẫn file .zip
        }

    }
}
