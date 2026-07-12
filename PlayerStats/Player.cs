using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name {get;}

        public Player(string name)
        {
            Name = name;
            highScore = 0f;
            playedGames = 0;
            wonGames = 0;
        }
        
        public float HighScore
        {
            get
            {
                return highScore;
            }
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
        public float WinRate
        {
            get
            {
                float wonGamesPercent = 0f;

                if (playedGames > 0)
                {
                    float wonGamesf = wonGames;
                    float playedGamesf = playedGames;
                    wonGamesPercent = wonGamesf / playedGamesf;
                }

                return wonGamesPercent;
            } 
        }
        public void PlayGame(bool win)
        {
            playedGames++;
            if (win)
                wonGames++;
        }
    }
}