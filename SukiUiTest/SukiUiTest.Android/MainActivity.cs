using Android.App;
using Android.Content.PM;
using Avalonia.Android;
using Avalonia;

namespace SukiUiTest.Android
{
    [Activity(Label = "SukiUiTest.Android", Theme = "@style/MyTheme.NoActionBar", Icon = "@drawable/icon",
        LaunchMode = LaunchMode.SingleInstance,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class MainActivity : AvaloniaMainActivity
    {
    }
}