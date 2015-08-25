using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PointCounter
{
	public partial class NewGamePage : ContentPage
	{
		private String gameName = "Hello";
		private int? players;

		public NewGamePage ()
		{
			InitializeComponent ();
			createGameButton.Click += delegate {
				var activity = new Intent (this, typeof(NewGamePlayersPage));
				activity.PutExtra ("MyData", gameName);
				StartActivity (activity);
			};
		}

		void OnCallCreateGame (object sender, EventArgs e)
		{
			var game = new Game (gameName, players);
			Navigation.PushAsync (new NewGamePlayersPage ());
		}

		public String GameName {
			get {
				return gameName;
			}
			set {
				gameName = value;
			}
		}

		public int? Players {
			get {
				return players;
			}
			set {
				players = value + 2;
			}
		}
       
	}
}

