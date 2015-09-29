using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PointCounter
{
	public class App : Application
	{
		public static List<Game> Games{ get; set; }

		public App ()
		{
			// The root page of your application
			Games = new List<Game> ();
			GameCreationViewModel gcvm = new GameCreationViewModel();
			MainPage = new NavigationPage (new PointCounter.MainPage ());
			MainPage.BindingContext = gcvm;
		}

		public static void addGame (Game game)
		{
			Games.Add (game);
		}

		public static void removeGame (Game game)
		{
			Games.Remove (game);
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

