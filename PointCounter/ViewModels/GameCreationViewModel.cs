using System;
using System.ComponentModel;

namespace PointCounter
{
	public class GameCreationViewModel : INotifyPropertyChanged
	{

		public event PropertyChangedEventHandler PropertyChanged;

		private String gameName = "";
		private int? players = 0;

		public GameCreationViewModel ()
		{
		}

		public String GameName {
			get {
				return gameName;
			}
			set {
				if (!gameName.Equals (value))
				{
					gameName = value;

					OnPropertyChanged ("GameName");

				}
			}
		}

		public int? Players {
			get {
				return players;
			}
			set {
				if (players != value)
				{
					players = value;

					OnPropertyChanged ("Players");

				}
			}
		}

		protected void OnPropertyChanged (string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;

			if (handler != null)
			{
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}

