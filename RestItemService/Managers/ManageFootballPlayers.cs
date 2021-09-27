using Csharp_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestItemService.Managers
{
    public class ManageFootballPlayers : IManageFootballPlayers
    {
        private static List<FootballPlayer> footballPlayers = new List<FootballPlayer>()
        {
            new FootballPlayer("Donald",900,33),
            new FootballPlayer("Ronaldinio",5600,83),
            new FootballPlayer("Mezi",34534.5,47),
            new FootballPlayer("Mickey",10,19)
        };

        public static int GlobalId = 3;  // we start with a list of 4 footballPlayers so the globadDd is 3 already, taking th globalId from the class itself leads to errors

        public IEnumerable<FootballPlayer> Get()
        {
            return new List<FootballPlayer>(footballPlayers);
        }

        public FootballPlayer Get(int id)
        {
            return footballPlayers.Find(i => i.Id == id);
        }

        public bool Create(FootballPlayer value)
        {
            footballPlayers.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value)
        {
            FootballPlayer item = Get(id);
            if (item != null)
            {
                item.Id = value.Id;
                item.Name = value.Name;
                item.Price = value.Price;
                item.ShirtNumber= value.ShirtNumber;

                return true;
            }
            return false;
        }

        public FootballPlayer Delete(int id)
        {
            FootballPlayer item = Get(id);
            footballPlayers.Remove(item);
            return item;
        }

        public int GenerateID()
        {
          //  return ++FootballPlayer.GlobalId; // for some reason this id starts at 4
            return ++GlobalId; // first we increase the id then we read the value
        }
    }
}
