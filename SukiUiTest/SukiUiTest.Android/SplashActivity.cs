﻿using Android.App;
using Android.Content;
using Android.OS;
using Avalonia.Android;
using Avalonia.ReactiveUI;
using Application = Android.App.Application;

namespace SukiUiTest.Android
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : AvaloniaSplashActivity<App>
    {
        protected override Avalonia.AppBuilder CustomizeAppBuilder(Avalonia.AppBuilder builder)
        {
            return base.CustomizeAppBuilder(builder).UseReactiveUI();

        }

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        protected override void OnResume()
        {
            base.OnResume();

            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}