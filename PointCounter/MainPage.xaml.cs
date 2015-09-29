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
            var page = new NewGamePage();
            page.BindingContext = this.BindingContext;
			Navigation.PushAsync (page);
		}

		void OnCallOldGames (object sender, EventArgs e)
		{
            var page = new OldGamesPage();
            page.BindingContext = this.BindingContext;
            Navigation.PushAsync(page);
        }
	}
}

