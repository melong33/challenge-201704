﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MyRandomUser
{
	public partial class App : Application
	{
        /// <summary>
        /// 테스트
        /// </summary>
		public App ()
		{
			InitializeComponent();

			MainPage = new MyRandomUser.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
