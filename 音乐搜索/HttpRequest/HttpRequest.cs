using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace 音乐搜索.HttpRequest
{
    public class HttpRequest
    {
        private const string QQmusic_api = "http://i.y.qq.com/s.music/fcgi-bin/search_for_qq_cp?g_tk=5381&uin=0&format=jsonp&inCharset=utf8&outCharset=utf-8&notice=0&platform=h5&needNewCode=1&w={0}&t=0&flag=1&ie=utf-8&sem=1&aggr=0&p=1&remoteplace=txt.mqq.all&_=1460982060643";
        public static async Task<string> QQmusicRequest(string songname)
        {
            HttpClient httpclient = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            string result = null;
            string api = QQmusic_api.Replace("{0}", songname);
            httpclient.DefaultRequestHeaders.Add("apikey", "bf94c84716d4ea324db6b45d2e28166d");
            try
            {
                response = await httpclient.GetAsync(api);
                result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch
            {
                displayNoWifiDialog();
                return null;
            }
        }
        private static async void displayNoWifiDialog()
        {
            ContentDialog noWifiDialog = new ContentDialog()
            {
                Title = "网络异常",
                Content = "请检查网络是否连接",
                PrimaryButtonText = "确定"
            };
            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }
    }
}
