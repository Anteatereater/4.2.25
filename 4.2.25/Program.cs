using System;
using System.Security.Cryptography.X509Certificates;

using (StreamReader reader = new StreamReader("C:\\Users\\Student18\\Desktop\\New folder (change name)\\4.2.25"))
{
    using (StreamWriter writer = new StreamWriter("C:\\Users\\Student18\\Desktop\\New folder (change name)\\reversed.txt"))
    {
          void Print(string name)
        {
            foreach (string line in TeamsHistory.TeamLogs[name])
                writer.WriteLine(line);
        }
      
    }
}


static class TeamsHistory
{
    public static Dictionary<string, List<string>> TeamLogs = new Dictionary<string, List<string>>();
    public static void CreateTeamLog(string name,string info)
    {
        List<string> temp = new List<string>();
        temp.Add(info);
        TeamLogs.Add(name, temp);
    }
    public static void AddToLog(string name, string info)
    {
        if (TeamLogs.ContainsKey(name))
        {
            TeamLogs[name].Add(info);
        }
    }
}

namespace _4._2._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITeam> teams = new List<ITeam>();
            List<Player> players = new List<Player>();
            string input = Console.ReadLine();
            string[] str;
            while (input != "END")
            {
                str = input.Split(' ').ToArray();
                switch (str[0])
                {
                    case "create_team":
                        Team t = new Team(str[1]);
                        teams.Add(t);
                        string teaminfo = $"Team {str[1]} was created at {DateTime.Now}";
                        TeamsHistory.CreateTeamLog(str[1], teaminfo);
                        break;
                    case "create_player":
                        Player p = new Player(str[1], str[2]);
                        players.Add(p);
                        break;
                    case "add_player":
                        Player temp = new Player();
                        foreach (Player pl in players)
                        {
                            if (pl.Name == str[2])
                            {
                                temp = pl;
                            }
                        }
                        if (temp.Name == null) break;
                        foreach (Team tm in teams)
                        {
                            if (tm.Name == str[1])
                            {
                                tm.AddPlayer(temp);
                                string Playerinfo = $"Player {temp} was added to team {tm} created at {DateTime.Now}";
                               TeamsHistory.AddToLog(tm.Name, Playerinfo);
                            }
                        }
                        break;
                    case "remove_player":
                         temp = new Player();
                        foreach (Player pl in players)
                        {
                            if (pl.Name == str[2])
                            {
                                temp = pl;
                            }
                        }
                        if (temp.Name == null) break;
                        foreach (Team tm in teams)
                        {
                            if (tm.Name == str[1])
                            {
                                tm.RemovePlayer(temp);
                            }
                        }
                        break;
                    case "print_team":
                        
                        break;
                }
                input = Console.ReadLine();

            }
        }
    }
}