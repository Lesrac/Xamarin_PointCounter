using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PointCounter
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

		void OnCallNewGame (object sender, EventArgs e)
		{
			Navigation.PushAsync (new NewGamePage ());
		}

		void OnCallOldGames (object sender, EventArgs e)
		{
			Navigation.PushAsync (new OldGamesPage ());
		}
	}
}

