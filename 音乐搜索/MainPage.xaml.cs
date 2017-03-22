using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace 音乐搜索
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        
        public class songName
        {
            public string Name { get; set; }
        }
        public ObservableCollection<songName> list = new ObservableCollection<songName>();

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string json = await HttpRequest.HttpRequest.QQmusicRequest(SongName.Text);
            Regex reg =new Regex("songname\":\"(?<namelist>\\S+?)\"");
            int i;
            if (!System.String.IsNullOrWhiteSpace(json))
            {
                try
                {
                    MatchCollection match =reg.Matches(json);
                    for (i = 0; i < match.Count - 1; i++)
                    {
                        GroupCollection group = match[i].Groups;
                        list.Add(new songName { Name = group["namelist"].Value });
                    }
                    listView.ItemsSource = list;
                }
                catch
                {
                    displayerrorDialog();
                }
            }
        }

        private async void displayerrorDialog()
        {
            ContentDialog errorDialog = new ContentDialog()
            {
                Title = "错误",
                Content = "请重试",
                PrimaryButtonText = "确定"
            };

            ContentDialogResult result = await errorDialog.ShowAsync();
        }
    }
}
