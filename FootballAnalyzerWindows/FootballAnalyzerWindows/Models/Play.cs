﻿using System;

namespace FootballAnalyzer
{
    public class Play
    {
		// TODO associated drawing to save
		// TODO thumbnail associated with play

        public string Name { get; set; }

		public TimeSpan TimeInGame { get; set; }

		public string Notes { get; set; }
			
		private GameFilm m_parent;
		public GameFilm Parent
        {
            get { return m_parent; }
        }

		public Play(GameFilm parent, TimeSpan time)
        {
            m_parent = parent;
            TimeInGame = time;
        }
    }
}