using Commander.Model;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAppCommand()
        {
            var Commands=new List<Command> {
            new Command {Id=1,HowTo="Boil eggs",Line="Boil Water",Platform="Cattle & Pan" },
            new Command {Id=2,HowTo="cut Bread",Line="Get A Knife",Platform="Knife & Chopping Board" },
            new Command {Id=3,HowTo="Make Cup of Tea ",Line="Place Teabag in Cup",Platform="Cattle & Cup" },
             };
            return Commands;
        }

        public Command GetCommandById(int Id)
        {
            return new Command {Id=1,HowTo="Boil eggs",Line="Boil Water",Platform="Cattle & Pan" };
        }
    }
}
