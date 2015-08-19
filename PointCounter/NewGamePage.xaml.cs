using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PointCounter
{
	public partial class NewGamePage : ContentPage
	{
		public NewGamePage ()
		{
			InitializeComponent ();
		}

		void OnCallCreateGame (object sender, EventArgs e)
		{
			var game = new Game ();
			Navigation.PushAsync (new NewGamePlayersPage ());
		}
	}
}

