using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace NHK.Timetable.Xamarin.Android
{
    [Activity( Label = "NHK.Timetable.Xamarin.Android", MainLauncher = true, Icon = "@drawable/icon" )]
    public class Activity1 : Activity
    {
        NhkTimetable timetable;

        protected override void OnCreate( Bundle bundle )
        {
            base.OnCreate( bundle );

            // Set our view from the "main" layout resource
            SetContentView( Resource.Layout.Main );

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>( Resource.Id.MyButton );

            button.Click += async delegate
            {
                var nowonair = await timetable.GetNowOnAir( NhkArea.東京, NhkService.ＮＨＫ総合１ );
                var text = FindViewById<TextView>( Resource.Id.textView );
                text.Text = string.Format( "{0}\n{1}\n{2}\n{3}",
                    nowonair.nowonair_list.g1.present.title,
                    nowonair.nowonair_list.g1.present.area.name,
                    nowonair.nowonair_list.g1.present.start_time.ToString(),
                    nowonair.nowonair_list.g1.present.end_time.ToString());
            };

            timetable = new NhkTimetable( ApiKey.Token );
        }
    }
}

