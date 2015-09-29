using System;
using System.ComponentModel;

namespace PointCounter
{
    public class GameCreationViewModel : ViewModelBase
    {

        private String gameName = "";
        private int? players = 0;

        public GameCreationViewModel()
        {
        }

        public String GameName
        {
            get { return gameName; }
            set { SetProperty(ref gameName, value); }
        }

        public int? Players
        {
            get
            { return players; }
            set
            { SetProperty(ref players, value); }
        }
    }
}

