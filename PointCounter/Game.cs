using System;
using System.Collections.Generic;

namespace PointCounter
{
	public class Game
	{
		public static int? Id{ get; set; }

		public string Name{ get; set; }

		public Dictionary<int?, string> Players{ get; set; }

		public DateTime CreationTime{ get; set; }

		public Game (string Name, int? player_count)
		{
			this.Name = Name;
			Players = new Dictionary<int?, string> ();
			for (int? i = 1; i <= player_count; i++) {
				addPlayer (i, "");
			}
		}

		public void addPlayer (int? id, string name)
		{
			if (Players.ContainsKey (id)) {
				
			} else {
				Players.Add (id, name);
			}
		}

		public void removePlayer (int? id)
		{
			Players.Remove (id);
		}

		public string toString ()
		{
			return CreationTime + ": " + Name + ", " + Players.Count + " Players";
		}
	}
}

