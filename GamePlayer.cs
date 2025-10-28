using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class GamePlayer
    {
        public string PlayerName;
        public int Score { get; set; }
        public static int PlayerID {get; set;} = 1;
        public static int TotalPlayers { get; set; }
        public static int HighestScore { get; set; }
        public static int NextID = 1;


        public GamePlayer(int totalPlayers, int playerId, int nextId, int highestScore)
        {
            TotalPlayers = totalPlayers;
            PlayerID = playerId;
            NextID = nextId;
            HighestScore = highestScore;

            GamePlayer gamePlayer = new GamePlayer(12, 1, 2, 20);
            TotalPlayers++;



        }


        public static string playerName(string Name, int NextId):base()
        {
            NextID = NextId;
            NextID++;



        }
        public static int PlayerId(int NextId)
        {
            NextID++;
        }
        public void UpdateScore(int newScore)
        {
            Score = newScore;

            if (HighestScore <= newScore)
            {
                HighestScore = newScore;
            }
        }
        public static void RemovePlayer(GamePlayer p)
        {
            //TotalPlayers -= TotalPlayers - p;

            //HighestScore=


        }

    }
}
