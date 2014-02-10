using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページのアイテム テンプレートについては、http://go.microsoft.com/fwlink/?LinkId=234238 を参照してください

namespace NHK.Timetable.StoreApp
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        NhkTimetable timetable;

        public MainPage()
        {
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo( NavigationEventArgs e )
        {
            base.OnNavigatedTo( e );

            timetable = new NhkTimetable( ApiKey.Token );
            var nowonair = await timetable.GetNowOnAir();
            TextTitle.Text = nowonair.nowonair_list.g1.present.title;
            TextStartTime.Text = nowonair.nowonair_list.g1.present.start_time.ToString();
            TextEndTime.Text = nowonair.nowonair_list.g1.present.end_time.ToString();
            TextArea.Text = nowonair.nowonair_list.g1.present.area.name;
        }
    }
}
