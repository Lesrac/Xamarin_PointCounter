using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PointCounter
{
	public partial class NewGamePlayersPage : ContentPage
	{
		private String testVar;

		public NewGamePlayersPage ()
		{
			InitializeComponent ();
			testVar = Intent.GetStringExtra ("MyData") ?? "Data not available";
		}

		public String TestVar {
			get {
				return testVar;
			}
			set {
				testVar = value;
			}
		}
	}

}

