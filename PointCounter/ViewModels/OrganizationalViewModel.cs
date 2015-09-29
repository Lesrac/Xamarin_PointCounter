using System;
using System.ComponentModel;
using System.Windows.Input;

namespace PointCounter
{
	public class OrganizationalViewModel : ViewModelBase
	{
		public OrganizationalViewModel ()
		{
			CallNewGame = new Command (
				execute: () => {
					Navigation.PushAsync (new NewGamePage ());
				});
		}

		public ICommand CallNewGame {
			get;
			private set;
		}

		public ICommand CallOldGame {
			get;
			private set;
		}
	}
}

