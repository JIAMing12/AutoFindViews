﻿namespace AutoFindViews.Sample
{
	using Android.App;
	using Android.OS;

	[Activity(Label = "AutoFindViews", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		public MainLayoutHolder Layout { get; private set; }

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
		
			this.Layout = this.SetContentView<MainLayoutHolder>();
			var r = this.Layout.root5;

			this.Layout.myButton.Click += delegate { this.Layout.myButton.Text = $"{count++} clicks!"; };
		}
	}
}

