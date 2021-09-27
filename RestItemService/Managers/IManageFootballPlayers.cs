using Csharp_UnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestItemService.Managers
{
    public interface IManageFootballPlayers
    {
        IEnumerable<FootballPlayer> Get();
        FootballPlayer Get(int id);
        bool Create(FootballPlayer value);
        bool Update(int id, FootballPlayer value);
        FootballPlayer Delete(int id);

        int GenerateID();
    }
}
