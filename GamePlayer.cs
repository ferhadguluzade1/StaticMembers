using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembers
{
    internal class GamePlayer
    {
        public static GamePlayer[] players = new GamePlayer[0];
        public int Score { get; set; }



        public static int PlayerID = 1;

        public string PlayerName { get; set; }
        public static int TotalPlayers { get; set; }
        public static int HighestScore { get; set; }
        
        public static int NextId = 0;


        public GamePlayer(string name, int score)
        {
            Score = score;
            PlayerName = name;
            NextId++;
            
            if (Score > HighestScore)
            {
                HighestScore = Score;
            }

            TotalPlayers++;
            Array.Resize(ref players, players.Length + 1);
            players[players.Length - 1] = this;



        }


       
        public void UpdateScore(int newScore)
        {
            Score = newScore;

            if (HighestScore < newScore)
            {
                HighestScore = newScore;
            }

        }
        public static void RemovePlayer(GamePlayer p)
        {
            if (TotalPlayers == 0)
            {
                Console.WriteLine("There is no player");
            }
            else
            {
                int location = -1;
                for (int i = 0; i < players.Length; i++)
                {
                    if (p == players[i])
                    {
                        location = i;
                        break;
                    }
                }

                if(location == -1)
                {
                    Console.WriteLine("There is no such a player");
                    return;
                }
                else
                {
                    for (int i = location; i < players.Length - 1; i++)
                    {
                        players[i] = players[i + 1]; 
                    }
                    Array.Resize(ref players, players.Length - 1);
                    Console.WriteLine("Deleted successfuly!");
                    Console.ReadKey();
                }
            }


        }

    }
}
