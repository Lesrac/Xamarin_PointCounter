using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PointCounter
{
    public partial class NewGamePage : ContentPage
    {

        public NewGamePage()
        {
            InitializeComponent();
        }

        void OnCallCreateGame(object sender, EventArgs e)
        {
            var page = new NewGamePlayersPage();
            page.BindingContext = this.BindingContext;
            Navigation.PushAsync(page);
        }

    }
}

