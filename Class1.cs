using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
//change THREE
namespace GameProject
{
    public class Game
    {
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Team1Score { get; set; }
        public int Team2Score { get; set; }

        public Game (){} //default constructor

        public Game (string team1, string team2, int team1Score, int team2Score)
        {
            this.Team1 = team1;
            this.Team2 = team2;
            this.Team1Score = team1Score;
            this.Team2Score = team2Score;
        } //method Game constructor

        public override string ToString()
        {
            return Team1 + " (" + Team1Score + ") - " + Team2 + " (" + Team2Score + ")";
        } //method ToString


    } //class Game

    public class GameFactory
    {
 
        public List<Game> GameList;
        public Game game;
        public String FilePath = @"..\..\Games.xml";

        public GameFactory() {}
        public void CreateGameList()
        {
            GameList = new List<Game>() ;
            game = new Game("Arizona Cardinals", "Atlanta Falcons", 30, 27);
            GameList.Add(game);
            game = new Game("Baltimore Ravens", "Buffalo Bills", 7, 100);
            GameList.Add(game);
            game = new Game("Carolina Panthers", "Chicago Bears", 0, 200);
            GameList.Add(game);
            game = new Game("Cincinnati Bengals", "Cleveland Browns", 38, 32);
            GameList.Add(game);
            game = new Game("Dallas Cowboys", "Denver Broncos", 53, 12);
            GameList.Add(game);
            game = new Game("Detroit Lions", "Green Bay Packers", 70, 55);
            GameList.Add(game);

        } //method CreateGameList



        public Boolean SerializeGameList()
        {
            StreamWriter sw = new StreamWriter(FilePath);
            XmlSerializer serial = new XmlSerializer(GameList.GetType());
            serial.Serialize(sw, GameList);
            sw.Close();
            return true;
        }


    } //class GameFactory
}
