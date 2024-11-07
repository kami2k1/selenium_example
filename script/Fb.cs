using Kami.app;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kami.script
{
    public class Fb 
    {
        public static int idz;
        public Chrome ch;
        public int id;
        public Fb(Chrome Ch) 
        {
            this.ch = Ch;
            Fb.idz++;
            this.id = Fb.idz;

        }
        public async Task Nv(int type, int dilay, int cout = 0, string tukhoa = null )
        {

                switch (type)
                {


                    case 0:
                        Getadd(cout, dilay);
                        break;

                     case 1:
                        add_bynname(tukhoa, dilay, cout);
                        break;
                case 2:
                    sory(cout , tukhoa);
                    break;

                }


                await Task.Delay(dilay * 1000);

                }
        public async void add_bynname (string Rq  ,int dilay ,  int cout  = 0 )
        {
            ch.getwed($"https://www.facebook.com/search/people/?q={Rq}");
            await Task.Delay(5000);
            //ch.find_text_contains("Xem tất cả");
            //await Task.Delay(300);
            //ch.click();
            await Task.Delay(5000);
            for (int i = 0; i < cout +1; i++)
            {

                this.ch.find_text_contains("Thêm bạn bè");
               
                ch.click();
                //ch.Scronll();
                ch.print($"KB {i} ");
                await Task.Delay(dilay * 1000);


            }
        }
        public async void  Getadd(int cout , int dilay )
        {
            ch.getwed("https://www.facebook.com/friends/suggestions");
            await Task.Delay(3000);
            for (int i = 0; i < cout + 1; i++)
            {
                this.ch.find_text_contains("Thêm bạn bè");
               
                ch.click();
                ch.Scronll();
                ch.print($"KB {i} ");
                await Task.Delay(dilay * 1000);
            }

        }
        public async void sory(int cout,string kq )
        {
            if ( cout >0)
            {
                ch.find(cout,kq);
                ch.click();
                return;
            }
            string urlhome = "https://www.facebook.com/";

            ch.getwed(urlhome);
            await Task.Delay(5000);
            ch.find_clasname("x1c4vz4f x2lah0s xeuugli x1bhewko x1emribx xnqqyb");
            ch.click();

        }
    }
}
